using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x02000380 RID: 896
	public class AdvancedTransitRoute : TransitRoute
	{
		// Token: 0x060045FC RID: 17916 RVA: 0x001580D4 File Offset: 0x001562D4
		// Note: this type is marked as 'beforefieldinit'.
		static AdvancedTransitRoute()
		{
			Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "AdvancedTransitRoute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr);
			AdvancedTransitRoute.NativeFieldInfoPtr__Filter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr, "<Filter>k__BackingField");
			AdvancedTransitRoute.NativeMethodInfoPtr_get_Filter_Public_get_ManagementItemFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr, 100671898);
			AdvancedTransitRoute.NativeMethodInfoPtr_set_Filter_Private_set_Void_ManagementItemFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr, 100671899);
			AdvancedTransitRoute.NativeMethodInfoPtr__ctor_Public_Void_ITransitEntity_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr, 100671900);
			AdvancedTransitRoute.NativeMethodInfoPtr__ctor_Public_Void_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr, 100671901);
			AdvancedTransitRoute.NativeMethodInfoPtr_GetItemReadyToMove_Public_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr, 100671902);
			AdvancedTransitRoute.NativeMethodInfoPtr_GetData_Public_AdvancedTransitRouteData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr, 100671903);
		}

		// Token: 0x1700151B RID: 5403
		// (get) Token: 0x060045FD RID: 17917 RVA: 0x00158190 File Offset: 0x00156390
		// (set) Token: 0x060045FE RID: 17918 RVA: 0x001581D0 File Offset: 0x001563D0
		public unsafe ManagementItemFilter Filter
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 19662, RefRangeEnd = 19669, XrefRangeStart = 19662, XrefRangeEnd = 19669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRoute.NativeMethodInfoPtr_get_Filter_Public_get_ManagementItemFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ManagementItemFilter>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRoute.NativeMethodInfoPtr_set_Filter_Private_set_Void_ManagementItemFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060045FF RID: 17919 RVA: 0x00158214 File Offset: 0x00156414
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 157781, RefRangeEnd = 157783, XrefRangeStart = 157775, XrefRangeEnd = 157781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvancedTransitRoute(ITransitEntity source, ITransitEntity destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRoute.NativeMethodInfoPtr__ctor_Public_Void_ITransitEntity_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004600 RID: 17920 RVA: 0x00158274 File Offset: 0x00156474
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157817, RefRangeEnd = 157818, XrefRangeStart = 157783, XrefRangeEnd = 157817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvancedTransitRoute(AdvancedTransitRouteData data) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdvancedTransitRoute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRoute.NativeMethodInfoPtr__ctor_Public_Void_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004601 RID: 17921 RVA: 0x001582C0 File Offset: 0x001564C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157841, RefRangeEnd = 157842, XrefRangeStart = 157818, XrefRangeEnd = 157841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInstance GetItemReadyToMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRoute.NativeMethodInfoPtr_GetItemReadyToMove_Public_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x06004602 RID: 17922 RVA: 0x00158300 File Offset: 0x00156500
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 157880, RefRangeEnd = 157883, XrefRangeStart = 157842, XrefRangeEnd = 157880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdvancedTransitRouteData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdvancedTransitRoute.NativeMethodInfoPtr_GetData_Public_AdvancedTransitRouteData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AdvancedTransitRouteData>(intPtr3) : null;
		}

		// Token: 0x06004603 RID: 17923 RVA: 0x0002217D File Offset: 0x0002037D
		public AdvancedTransitRoute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700151A RID: 5402
		// (get) Token: 0x06004604 RID: 17924 RVA: 0x00158340 File Offset: 0x00156540
		// (set) Token: 0x06004605 RID: 17925 RVA: 0x00022186 File Offset: 0x00020386
		public unsafe ManagementItemFilter _Filter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRoute.NativeFieldInfoPtr__Filter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManagementItemFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdvancedTransitRoute.NativeFieldInfoPtr__Filter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002EF8 RID: 12024
		private static readonly IntPtr NativeFieldInfoPtr__Filter_k__BackingField;

		// Token: 0x04002EF9 RID: 12025
		private static readonly IntPtr NativeMethodInfoPtr_get_Filter_Public_get_ManagementItemFilter_0;

		// Token: 0x04002EFA RID: 12026
		private static readonly IntPtr NativeMethodInfoPtr_set_Filter_Private_set_Void_ManagementItemFilter_0;

		// Token: 0x04002EFB RID: 12027
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ITransitEntity_ITransitEntity_0;

		// Token: 0x04002EFC RID: 12028
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AdvancedTransitRouteData_0;

		// Token: 0x04002EFD RID: 12029
		private static readonly IntPtr NativeMethodInfoPtr_GetItemReadyToMove_Public_ItemInstance_0;

		// Token: 0x04002EFE RID: 12030
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_AdvancedTransitRouteData_0;
	}
}
