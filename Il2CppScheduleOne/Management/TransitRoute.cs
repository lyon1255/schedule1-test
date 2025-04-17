using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003A6 RID: 934
	public class TransitRoute : Object
	{
		// Token: 0x06004925 RID: 18725 RVA: 0x00164E0C File Offset: 0x0016300C
		// Note: this type is marked as 'beforefieldinit'.
		static TransitRoute()
		{
			Il2CppClassPointerStore<TransitRoute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "TransitRoute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr);
			TransitRoute.NativeFieldInfoPtr__Source_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, "<Source>k__BackingField");
			TransitRoute.NativeFieldInfoPtr__Destination_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, "<Destination>k__BackingField");
			TransitRoute.NativeFieldInfoPtr_visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, "visuals");
			TransitRoute.NativeFieldInfoPtr_onSourceChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, "onSourceChange");
			TransitRoute.NativeFieldInfoPtr_onDestinationChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, "onDestinationChange");
			TransitRoute.NativeMethodInfoPtr_get_Source_Public_get_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672368);
			TransitRoute.NativeMethodInfoPtr_set_Source_Protected_set_Void_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672369);
			TransitRoute.NativeMethodInfoPtr_get_Destination_Public_get_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672370);
			TransitRoute.NativeMethodInfoPtr_set_Destination_Protected_set_Void_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672371);
			TransitRoute.NativeMethodInfoPtr__ctor_Public_Void_ITransitEntity_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672372);
			TransitRoute.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672373);
			TransitRoute.NativeMethodInfoPtr_SetVisualsActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672374);
			TransitRoute.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672375);
			TransitRoute.NativeMethodInfoPtr_SetSource_Public_Virtual_New_Void_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672376);
			TransitRoute.NativeMethodInfoPtr_AreEntitiesNonNull_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672377);
			TransitRoute.NativeMethodInfoPtr_SetDestination_Public_Virtual_New_Void_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672378);
			TransitRoute.NativeMethodInfoPtr_ValidateEntities_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr, 100672379);
		}

		// Token: 0x170015F7 RID: 5623
		// (get) Token: 0x06004926 RID: 18726 RVA: 0x00164F90 File Offset: 0x00163190
		// (set) Token: 0x06004927 RID: 18727 RVA: 0x00164FD0 File Offset: 0x001631D0
		public unsafe ITransitEntity Source
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 17383, RefRangeEnd = 17393, XrefRangeStart = 17383, XrefRangeEnd = 17393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_get_Source_Public_get_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITransitEntity>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29994, RefRangeEnd = 29996, XrefRangeStart = 29994, XrefRangeEnd = 29996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_set_Source_Protected_set_Void_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015F8 RID: 5624
		// (get) Token: 0x06004928 RID: 18728 RVA: 0x00165014 File Offset: 0x00163214
		// (set) Token: 0x06004929 RID: 18729 RVA: 0x00165054 File Offset: 0x00163254
		public unsafe ITransitEntity Destination
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_get_Destination_Public_get_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITransitEntity>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_set_Destination_Protected_set_Void_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600492A RID: 18730 RVA: 0x00165098 File Offset: 0x00163298
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 162960, RefRangeEnd = 162964, XrefRangeStart = 162939, XrefRangeEnd = 162960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransitRoute(ITransitEntity source, ITransitEntity destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransitRoute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr__ctor_Public_Void_ITransitEntity_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600492B RID: 18731 RVA: 0x001650F8 File Offset: 0x001632F8
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 162987, RefRangeEnd = 163003, XrefRangeStart = 162964, XrefRangeEnd = 162987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600492C RID: 18732 RVA: 0x0016512C File Offset: 0x0016332C
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 163028, RefRangeEnd = 163044, XrefRangeStart = 163003, XrefRangeEnd = 163028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisualsActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_SetVisualsActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600492D RID: 18733 RVA: 0x0016516C File Offset: 0x0016336C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163069, RefRangeEnd = 163070, XrefRangeStart = 163044, XrefRangeEnd = 163069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600492E RID: 18734 RVA: 0x001651A0 File Offset: 0x001633A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163070, XrefRangeEnd = 163071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSource(ITransitEntity source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransitRoute.NativeMethodInfoPtr_SetSource_Public_Virtual_New_Void_ITransitEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600492F RID: 18735 RVA: 0x001651F0 File Offset: 0x001633F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 163072, RefRangeEnd = 163075, XrefRangeStart = 163071, XrefRangeEnd = 163072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreEntitiesNonNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_AreEntitiesNonNull_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004930 RID: 18736 RVA: 0x0016522C File Offset: 0x0016342C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163075, XrefRangeEnd = 163076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetDestination(ITransitEntity destination)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransitRoute.NativeMethodInfoPtr_SetDestination_Public_Virtual_New_Void_ITransitEntity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004931 RID: 18737 RVA: 0x0016527C File Offset: 0x0016347C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 163081, RefRangeEnd = 163083, XrefRangeStart = 163076, XrefRangeEnd = 163081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidateEntities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransitRoute.NativeMethodInfoPtr_ValidateEntities_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004932 RID: 18738 RVA: 0x0002341D File Offset: 0x0002161D
		public TransitRoute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015F2 RID: 5618
		// (get) Token: 0x06004933 RID: 18739 RVA: 0x001652B0 File Offset: 0x001634B0
		// (set) Token: 0x06004934 RID: 18740 RVA: 0x00023426 File Offset: 0x00021626
		public unsafe ITransitEntity _Source_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr__Source_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITransitEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr__Source_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015F3 RID: 5619
		// (get) Token: 0x06004935 RID: 18741 RVA: 0x001652E0 File Offset: 0x001634E0
		// (set) Token: 0x06004936 RID: 18742 RVA: 0x00023445 File Offset: 0x00021645
		public unsafe ITransitEntity _Destination_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr__Destination_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITransitEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr__Destination_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015F4 RID: 5620
		// (get) Token: 0x06004937 RID: 18743 RVA: 0x00165310 File Offset: 0x00163510
		// (set) Token: 0x06004938 RID: 18744 RVA: 0x00023464 File Offset: 0x00021664
		public unsafe TransitLineVisuals visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr_visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitLineVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr_visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015F5 RID: 5621
		// (get) Token: 0x06004939 RID: 18745 RVA: 0x00165340 File Offset: 0x00163540
		// (set) Token: 0x0600493A RID: 18746 RVA: 0x00023483 File Offset: 0x00021683
		public unsafe Action<ITransitEntity> onSourceChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr_onSourceChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ITransitEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr_onSourceChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015F6 RID: 5622
		// (get) Token: 0x0600493B RID: 18747 RVA: 0x00165370 File Offset: 0x00163570
		// (set) Token: 0x0600493C RID: 18748 RVA: 0x000234A2 File Offset: 0x000216A2
		public unsafe Action<ITransitEntity> onDestinationChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr_onDestinationChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ITransitEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransitRoute.NativeFieldInfoPtr_onDestinationChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003158 RID: 12632
		private static readonly IntPtr NativeFieldInfoPtr__Source_k__BackingField;

		// Token: 0x04003159 RID: 12633
		private static readonly IntPtr NativeFieldInfoPtr__Destination_k__BackingField;

		// Token: 0x0400315A RID: 12634
		private static readonly IntPtr NativeFieldInfoPtr_visuals;

		// Token: 0x0400315B RID: 12635
		private static readonly IntPtr NativeFieldInfoPtr_onSourceChange;

		// Token: 0x0400315C RID: 12636
		private static readonly IntPtr NativeFieldInfoPtr_onDestinationChange;

		// Token: 0x0400315D RID: 12637
		private static readonly IntPtr NativeMethodInfoPtr_get_Source_Public_get_ITransitEntity_0;

		// Token: 0x0400315E RID: 12638
		private static readonly IntPtr NativeMethodInfoPtr_set_Source_Protected_set_Void_ITransitEntity_0;

		// Token: 0x0400315F RID: 12639
		private static readonly IntPtr NativeMethodInfoPtr_get_Destination_Public_get_ITransitEntity_0;

		// Token: 0x04003160 RID: 12640
		private static readonly IntPtr NativeMethodInfoPtr_set_Destination_Protected_set_Void_ITransitEntity_0;

		// Token: 0x04003161 RID: 12641
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ITransitEntity_ITransitEntity_0;

		// Token: 0x04003162 RID: 12642
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x04003163 RID: 12643
		private static readonly IntPtr NativeMethodInfoPtr_SetVisualsActive_Public_Void_Boolean_0;

		// Token: 0x04003164 RID: 12644
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04003165 RID: 12645
		private static readonly IntPtr NativeMethodInfoPtr_SetSource_Public_Virtual_New_Void_ITransitEntity_0;

		// Token: 0x04003166 RID: 12646
		private static readonly IntPtr NativeMethodInfoPtr_AreEntitiesNonNull_Public_Boolean_0;

		// Token: 0x04003167 RID: 12647
		private static readonly IntPtr NativeMethodInfoPtr_SetDestination_Public_Virtual_New_Void_ITransitEntity_0;

		// Token: 0x04003168 RID: 12648
		private static readonly IntPtr NativeMethodInfoPtr_ValidateEntities_Private_Void_0;
	}
}
