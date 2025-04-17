using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppVLB
{
	// Token: 0x0200009D RID: 157
	public class VolumetricLightBeamHD2D : VolumetricLightBeamHD
	{
		// Token: 0x06000AAC RID: 2732 RVA: 0x00091F84 File Offset: 0x00090184
		// Note: this type is marked as 'beforefieldinit'.
		static VolumetricLightBeamHD2D()
		{
			Il2CppClassPointerStore<VolumetricLightBeamHD2D>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "VolumetricLightBeamHD2D");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricLightBeamHD2D>.NativeClassPtr);
			VolumetricLightBeamHD2D.NativeFieldInfoPtr_m_SortingLayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD2D>.NativeClassPtr, "m_SortingLayerID");
			VolumetricLightBeamHD2D.NativeFieldInfoPtr_m_SortingOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightBeamHD2D>.NativeClassPtr, "m_SortingOrder");
			VolumetricLightBeamHD2D.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD2D>.NativeClassPtr, 100664500);
			VolumetricLightBeamHD2D.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD2D>.NativeClassPtr, 100664501);
			VolumetricLightBeamHD2D.NativeMethodInfoPtr_get_sortingLayerName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD2D>.NativeClassPtr, 100664502);
			VolumetricLightBeamHD2D.NativeMethodInfoPtr_set_sortingLayerName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD2D>.NativeClassPtr, 100664503);
			VolumetricLightBeamHD2D.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD2D>.NativeClassPtr, 100664504);
			VolumetricLightBeamHD2D.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD2D>.NativeClassPtr, 100664505);
			VolumetricLightBeamHD2D.NativeMethodInfoPtr_GetDimensions_Public_Virtual_Dimensions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD2D>.NativeClassPtr, 100664506);
			VolumetricLightBeamHD2D.NativeMethodInfoPtr_DoesSupportSorting2D_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD2D>.NativeClassPtr, 100664507);
			VolumetricLightBeamHD2D.NativeMethodInfoPtr_GetSortingLayerID_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD2D>.NativeClassPtr, 100664508);
			VolumetricLightBeamHD2D.NativeMethodInfoPtr_GetSortingOrder_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD2D>.NativeClassPtr, 100664509);
			VolumetricLightBeamHD2D.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightBeamHD2D>.NativeClassPtr, 100664510);
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x000920B8 File Offset: 0x000902B8
		// (set) Token: 0x06000AAE RID: 2734 RVA: 0x000920F4 File Offset: 0x000902F4
		public unsafe int sortingLayerID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD2D.NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81324, XrefRangeEnd = 81329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD2D.NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x00092134 File Offset: 0x00090334
		// (set) Token: 0x06000AB0 RID: 2736 RVA: 0x0009216C File Offset: 0x0009036C
		public unsafe string sortingLayerName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81329, XrefRangeEnd = 81330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD2D.NativeMethodInfoPtr_get_sortingLayerName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81330, XrefRangeEnd = 81336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD2D.NativeMethodInfoPtr_set_sortingLayerName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06000AB1 RID: 2737 RVA: 0x000921B0 File Offset: 0x000903B0
		// (set) Token: 0x06000AB2 RID: 2738 RVA: 0x000921EC File Offset: 0x000903EC
		public unsafe int sortingOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD2D.NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81336, XrefRangeEnd = 81341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD2D.NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x0009222C File Offset: 0x0009042C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 76499, RefRangeEnd = 76503, XrefRangeStart = 76499, XrefRangeEnd = 76503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Dimensions GetDimensions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamHD2D.NativeMethodInfoPtr_GetDimensions_Public_Virtual_Dimensions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00092274 File Offset: 0x00090474
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DoesSupportSorting2D()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamHD2D.NativeMethodInfoPtr_DoesSupportSorting2D_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x000922BC File Offset: 0x000904BC
		[CallerCount(0)]
		public unsafe override int GetSortingLayerID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamHD2D.NativeMethodInfoPtr_GetSortingLayerID_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x00092304 File Offset: 0x00090504
		[CallerCount(0)]
		public unsafe override int GetSortingOrder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VolumetricLightBeamHD2D.NativeMethodInfoPtr_GetSortingOrder_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x0009234C File Offset: 0x0009054C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumetricLightBeamHD2D() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricLightBeamHD2D>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightBeamHD2D.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x0000787A File Offset: 0x00005A7A
		public VolumetricLightBeamHD2D(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x00092388 File Offset: 0x00090588
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x00007883 File Offset: 0x00005A83
		public unsafe int m_SortingLayerID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD2D.NativeFieldInfoPtr_m_SortingLayerID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD2D.NativeFieldInfoPtr_m_SortingLayerID)) = value;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000ABB RID: 2747 RVA: 0x000923B0 File Offset: 0x000905B0
		// (set) Token: 0x06000ABC RID: 2748 RVA: 0x0000789E File Offset: 0x00005A9E
		public unsafe int m_SortingOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD2D.NativeFieldInfoPtr_m_SortingOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightBeamHD2D.NativeFieldInfoPtr_m_SortingOrder)) = value;
			}
		}

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeFieldInfoPtr_m_SortingLayerID;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeFieldInfoPtr_m_SortingOrder;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingLayerID_Public_get_Int32_0;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingLayerID_Public_set_Void_Int32_0;

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingLayerName_Public_get_String_0;

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingLayerName_Public_set_Void_String_0;

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeMethodInfoPtr_get_sortingOrder_Public_get_Int32_0;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeMethodInfoPtr_set_sortingOrder_Public_set_Void_Int32_0;

		// Token: 0x04000719 RID: 1817
		private static readonly IntPtr NativeMethodInfoPtr_GetDimensions_Public_Virtual_Dimensions_0;

		// Token: 0x0400071A RID: 1818
		private static readonly IntPtr NativeMethodInfoPtr_DoesSupportSorting2D_Public_Virtual_Boolean_0;

		// Token: 0x0400071B RID: 1819
		private static readonly IntPtr NativeMethodInfoPtr_GetSortingLayerID_Public_Virtual_Int32_0;

		// Token: 0x0400071C RID: 1820
		private static readonly IntPtr NativeMethodInfoPtr_GetSortingOrder_Public_Virtual_Int32_0;

		// Token: 0x0400071D RID: 1821
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
