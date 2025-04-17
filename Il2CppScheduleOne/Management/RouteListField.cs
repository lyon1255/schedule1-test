using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x02000398 RID: 920
	public class RouteListField : ConfigField
	{
		// Token: 0x06004831 RID: 18481 RVA: 0x001612E8 File Offset: 0x0015F4E8
		// Note: this type is marked as 'beforefieldinit'.
		static RouteListField()
		{
			Il2CppClassPointerStore<RouteListField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "RouteListField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RouteListField>.NativeClassPtr);
			RouteListField.NativeFieldInfoPtr_Routes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, "Routes");
			RouteListField.NativeFieldInfoPtr_MaxRoutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, "MaxRoutes");
			RouteListField.NativeFieldInfoPtr_onListChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, "onListChanged");
			RouteListField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100672221);
			RouteListField.NativeMethodInfoPtr_SetList_Public_Void_List_1_AdvancedTransitRoute_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100672222);
			RouteListField.NativeMethodInfoPtr_Replicate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100672223);
			RouteListField.NativeMethodInfoPtr_AddItem_Public_Void_AdvancedTransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100672224);
			RouteListField.NativeMethodInfoPtr_RemoveItem_Public_Void_AdvancedTransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100672225);
			RouteListField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100672226);
			RouteListField.NativeMethodInfoPtr_GetData_Public_RouteListData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100672227);
			RouteListField.NativeMethodInfoPtr_Load_Public_Void_RouteListData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RouteListField>.NativeClassPtr, 100672228);
		}

		// Token: 0x06004832 RID: 18482 RVA: 0x001613F4 File Offset: 0x0015F5F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161800, XrefRangeEnd = 161815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RouteListField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RouteListField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004833 RID: 18483 RVA: 0x00161440 File Offset: 0x0015F640
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 161832, RefRangeEnd = 161837, XrefRangeStart = 161815, XrefRangeEnd = 161832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetList(List<AdvancedTransitRoute> list, bool network, bool bypassSequenceCheck = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bypassSequenceCheck;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListField.NativeMethodInfoPtr_SetList_Public_Void_List_1_AdvancedTransitRoute_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004834 RID: 18484 RVA: 0x001614A0 File Offset: 0x0015F6A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 161844, RefRangeEnd = 161845, XrefRangeStart = 161837, XrefRangeEnd = 161844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Replicate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListField.NativeMethodInfoPtr_Replicate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004835 RID: 18485 RVA: 0x001614D4 File Offset: 0x0015F6D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 161862, RefRangeEnd = 161863, XrefRangeStart = 161845, XrefRangeEnd = 161862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItem(AdvancedTransitRoute item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListField.NativeMethodInfoPtr_AddItem_Public_Void_AdvancedTransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004836 RID: 18486 RVA: 0x00161518 File Offset: 0x0015F718
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 161876, RefRangeEnd = 161878, XrefRangeStart = 161863, XrefRangeEnd = 161876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveItem(AdvancedTransitRoute item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListField.NativeMethodInfoPtr_RemoveItem_Public_Void_AdvancedTransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004837 RID: 18487 RVA: 0x0016155C File Offset: 0x0015F75C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161878, XrefRangeEnd = 161879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RouteListField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004838 RID: 18488 RVA: 0x001615A4 File Offset: 0x0015F7A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161879, XrefRangeEnd = 161900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RouteListData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListField.NativeMethodInfoPtr_GetData_Public_RouteListData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RouteListData>(intPtr3) : null;
		}

		// Token: 0x06004839 RID: 18489 RVA: 0x001615E4 File Offset: 0x0015F7E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 161986, RefRangeEnd = 161987, XrefRangeStart = 161900, XrefRangeEnd = 161986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(RouteListData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RouteListField.NativeMethodInfoPtr_Load_Public_Void_RouteListData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600483A RID: 18490 RVA: 0x00022E75 File Offset: 0x00021075
		public RouteListField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015A5 RID: 5541
		// (get) Token: 0x0600483B RID: 18491 RVA: 0x00161628 File Offset: 0x0015F828
		// (set) Token: 0x0600483C RID: 18492 RVA: 0x00022E7E File Offset: 0x0002107E
		public unsafe List<AdvancedTransitRoute> Routes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListField.NativeFieldInfoPtr_Routes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AdvancedTransitRoute>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListField.NativeFieldInfoPtr_Routes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015A6 RID: 5542
		// (get) Token: 0x0600483D RID: 18493 RVA: 0x00161658 File Offset: 0x0015F858
		// (set) Token: 0x0600483E RID: 18494 RVA: 0x00022E9D File Offset: 0x0002109D
		public unsafe int MaxRoutes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListField.NativeFieldInfoPtr_MaxRoutes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListField.NativeFieldInfoPtr_MaxRoutes)) = value;
			}
		}

		// Token: 0x170015A7 RID: 5543
		// (get) Token: 0x0600483F RID: 18495 RVA: 0x00161680 File Offset: 0x0015F880
		// (set) Token: 0x06004840 RID: 18496 RVA: 0x00022EB8 File Offset: 0x000210B8
		public unsafe UnityEvent<List<AdvancedTransitRoute>> onListChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListField.NativeFieldInfoPtr_onListChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<List<AdvancedTransitRoute>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RouteListField.NativeFieldInfoPtr_onListChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040030A8 RID: 12456
		private static readonly IntPtr NativeFieldInfoPtr_Routes;

		// Token: 0x040030A9 RID: 12457
		private static readonly IntPtr NativeFieldInfoPtr_MaxRoutes;

		// Token: 0x040030AA RID: 12458
		private static readonly IntPtr NativeFieldInfoPtr_onListChanged;

		// Token: 0x040030AB RID: 12459
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x040030AC RID: 12460
		private static readonly IntPtr NativeMethodInfoPtr_SetList_Public_Void_List_1_AdvancedTransitRoute_Boolean_Boolean_0;

		// Token: 0x040030AD RID: 12461
		private static readonly IntPtr NativeMethodInfoPtr_Replicate_Public_Void_0;

		// Token: 0x040030AE RID: 12462
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Void_AdvancedTransitRoute_0;

		// Token: 0x040030AF RID: 12463
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItem_Public_Void_AdvancedTransitRoute_0;

		// Token: 0x040030B0 RID: 12464
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x040030B1 RID: 12465
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_RouteListData_0;

		// Token: 0x040030B2 RID: 12466
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_RouteListData_0;
	}
}
