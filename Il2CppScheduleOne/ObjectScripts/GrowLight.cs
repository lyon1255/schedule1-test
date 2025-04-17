using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Lighting;
using Il2CppScheduleOne.Misc;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000731 RID: 1841
	public class GrowLight : ProceduralGridItem
	{
		// Token: 0x0600A759 RID: 42841 RVA: 0x0029D0B0 File Offset: 0x0029B2B0
		// Note: this type is marked as 'beforefieldinit'.
		static GrowLight()
		{
			Il2CppClassPointerStore<GrowLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "GrowLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrowLight>.NativeClassPtr);
			GrowLight.NativeFieldInfoPtr_Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowLight>.NativeClassPtr, "Light");
			GrowLight.NativeFieldInfoPtr_usableLightSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowLight>.NativeClassPtr, "usableLightSource");
			GrowLight.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowLight>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.GrowLightAssembly-CSharp.dll_Excuted");
			GrowLight.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrowLight>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.GrowLightAssembly-CSharp.dll_Excuted");
			GrowLight.NativeMethodInfoPtr_InitializeProceduralGridItem_Public_Virtual_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowLight>.NativeClassPtr, 100683768);
			GrowLight.NativeMethodInfoPtr_SetIsOn_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowLight>.NativeClassPtr, 100683769);
			GrowLight.NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowLight>.NativeClassPtr, 100683770);
			GrowLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowLight>.NativeClassPtr, 100683771);
			GrowLight.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowLight>.NativeClassPtr, 100683772);
			GrowLight.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowLight>.NativeClassPtr, 100683773);
			GrowLight.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowLight>.NativeClassPtr, 100683774);
			GrowLight.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrowLight>.NativeClassPtr, 100683775);
		}

		// Token: 0x0600A75A RID: 42842 RVA: 0x0029D1D0 File Offset: 0x0029B3D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291267, XrefRangeEnd = 291289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeProceduralGridItem(ItemInstance instance, int _rotation, List<CoordinateProceduralTilePair> _footprintTileMatches, string GUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_footprintTileMatches);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowLight.NativeMethodInfoPtr_InitializeProceduralGridItem_Public_Virtual_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A75B RID: 42843 RVA: 0x0029D250 File Offset: 0x0029B450
		[CallerCount(0)]
		public unsafe void SetIsOn(bool isOn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowLight.NativeMethodInfoPtr_SetIsOn_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A75C RID: 42844 RVA: 0x0029D290 File Offset: 0x0029B490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291289, XrefRangeEnd = 291311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyItem(bool callOnServer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref callOnServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowLight.NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A75D RID: 42845 RVA: 0x0029D2DC File Offset: 0x0029B4DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291311, XrefRangeEnd = 291312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GrowLight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrowLight>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrowLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A75E RID: 42846 RVA: 0x0029D318 File Offset: 0x0029B518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291312, XrefRangeEnd = 291313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowLight.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A75F RID: 42847 RVA: 0x0029D354 File Offset: 0x0029B554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291313, XrefRangeEnd = 291314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowLight.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A760 RID: 42848 RVA: 0x0029D390 File Offset: 0x0029B590
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowLight.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A761 RID: 42849 RVA: 0x0029D3CC File Offset: 0x0029B5CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 291314, XrefRangeEnd = 291315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GrowLight.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A762 RID: 42850 RVA: 0x00052762 File Offset: 0x00050962
		public GrowLight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170033A5 RID: 13221
		// (get) Token: 0x0600A763 RID: 42851 RVA: 0x0029D408 File Offset: 0x0029B608
		// (set) Token: 0x0600A764 RID: 42852 RVA: 0x0005276B File Offset: 0x0005096B
		public unsafe ToggleableLight Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowLight.NativeFieldInfoPtr_Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleableLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowLight.NativeFieldInfoPtr_Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033A6 RID: 13222
		// (get) Token: 0x0600A765 RID: 42853 RVA: 0x0029D438 File Offset: 0x0029B638
		// (set) Token: 0x0600A766 RID: 42854 RVA: 0x0005278A File Offset: 0x0005098A
		public unsafe UsableLightSource usableLightSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowLight.NativeFieldInfoPtr_usableLightSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UsableLightSource>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowLight.NativeFieldInfoPtr_usableLightSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170033A7 RID: 13223
		// (get) Token: 0x0600A767 RID: 42855 RVA: 0x0029D468 File Offset: 0x0029B668
		// (set) Token: 0x0600A768 RID: 42856 RVA: 0x000527A9 File Offset: 0x000509A9
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowLight.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowLight.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170033A8 RID: 13224
		// (get) Token: 0x0600A769 RID: 42857 RVA: 0x0029D490 File Offset: 0x0029B690
		// (set) Token: 0x0600A76A RID: 42858 RVA: 0x000527C4 File Offset: 0x000509C4
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowLight.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrowLight.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400703F RID: 28735
		private static readonly IntPtr NativeFieldInfoPtr_Light;

		// Token: 0x04007040 RID: 28736
		private static readonly IntPtr NativeFieldInfoPtr_usableLightSource;

		// Token: 0x04007041 RID: 28737
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04007042 RID: 28738
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04007043 RID: 28739
		private static readonly IntPtr NativeMethodInfoPtr_InitializeProceduralGridItem_Public_Virtual_Void_ItemInstance_Int32_List_1_CoordinateProceduralTilePair_String_0;

		// Token: 0x04007044 RID: 28740
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOn_Public_Void_Boolean_0;

		// Token: 0x04007045 RID: 28741
		private static readonly IntPtr NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0;

		// Token: 0x04007046 RID: 28742
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007047 RID: 28743
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04007048 RID: 28744
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04007049 RID: 28745
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400704A RID: 28746
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
