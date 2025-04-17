using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.ObjectScripts.Soil;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerTasks.Tasks
{
	// Token: 0x02000213 RID: 531
	public class PourSoilTask : PourIntoPotTask
	{
		// Token: 0x06002C35 RID: 11317 RVA: 0x000FC758 File Offset: 0x000FA958
		// Note: this type is marked as 'beforefieldinit'.
		static PourSoilTask()
		{
			Il2CppClassPointerStore<PourSoilTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks.Tasks", "PourSoilTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourSoilTask>.NativeClassPtr);
			PourSoilTask.NativeFieldInfoPtr_soil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourSoilTask>.NativeClassPtr, "soil");
			PourSoilTask.NativeFieldInfoPtr_HoveredTopCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourSoilTask>.NativeClassPtr, "HoveredTopCollider");
			PourSoilTask.NativeMethodInfoPtr__ctor_Public_Void_Pot_ItemInstance_Pourable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourSoilTask>.NativeClassPtr, 100668267);
			PourSoilTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourSoilTask>.NativeClassPtr, 100668268);
			PourSoilTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourSoilTask>.NativeClassPtr, 100668269);
			PourSoilTask.NativeMethodInfoPtr_UpdateCursor_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourSoilTask>.NativeClassPtr, 100668270);
			PourSoilTask.NativeMethodInfoPtr_UpdateHover_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourSoilTask>.NativeClassPtr, 100668271);
			PourSoilTask.NativeMethodInfoPtr_GetHoveredTopCollider_Private_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourSoilTask>.NativeClassPtr, 100668272);
		}

		// Token: 0x06002C36 RID: 11318 RVA: 0x000FC828 File Offset: 0x000FAA28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123482, RefRangeEnd = 123483, XrefRangeStart = 123463, XrefRangeEnd = 123482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PourSoilTask(Pot _pot, ItemInstance _itemInstance, Pourable _pourablePrefab) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourSoilTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_pot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_itemInstance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_pourablePrefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourSoilTask.NativeMethodInfoPtr__ctor_Public_Void_Pot_ItemInstance_Pourable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C37 RID: 11319 RVA: 0x000FC898 File Offset: 0x000FAA98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123483, XrefRangeEnd = 123509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourSoilTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C38 RID: 11320 RVA: 0x000FC8D4 File Offset: 0x000FAAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123509, XrefRangeEnd = 123512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourSoilTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C39 RID: 11321 RVA: 0x000FC910 File Offset: 0x000FAB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123512, XrefRangeEnd = 123529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateCursor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourSoilTask.NativeMethodInfoPtr_UpdateCursor_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C3A RID: 11322 RVA: 0x000FC94C File Offset: 0x000FAB4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 123544, RefRangeEnd = 123545, XrefRangeStart = 123529, XrefRangeEnd = 123544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHover()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourSoilTask.NativeMethodInfoPtr_UpdateHover_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x000FC980 File Offset: 0x000FAB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123545, XrefRangeEnd = 123559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Collider GetHoveredTopCollider()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourSoilTask.NativeMethodInfoPtr_GetHoveredTopCollider_Private_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr3) : null;
		}

		// Token: 0x06002C3C RID: 11324 RVA: 0x00017E59 File Offset: 0x00016059
		public PourSoilTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EB5 RID: 3765
		// (get) Token: 0x06002C3D RID: 11325 RVA: 0x000FC9C0 File Offset: 0x000FABC0
		// (set) Token: 0x06002C3E RID: 11326 RVA: 0x00017E62 File Offset: 0x00016062
		public unsafe PourableSoil soil
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourSoilTask.NativeFieldInfoPtr_soil);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PourableSoil>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourSoilTask.NativeFieldInfoPtr_soil), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EB6 RID: 3766
		// (get) Token: 0x06002C3F RID: 11327 RVA: 0x000FC9F0 File Offset: 0x000FABF0
		// (set) Token: 0x06002C40 RID: 11328 RVA: 0x00017E81 File Offset: 0x00016081
		public unsafe Collider HoveredTopCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourSoilTask.NativeFieldInfoPtr_HoveredTopCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourSoilTask.NativeFieldInfoPtr_HoveredTopCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D51 RID: 7505
		private static readonly IntPtr NativeFieldInfoPtr_soil;

		// Token: 0x04001D52 RID: 7506
		private static readonly IntPtr NativeFieldInfoPtr_HoveredTopCollider;

		// Token: 0x04001D53 RID: 7507
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Pot_ItemInstance_Pourable_0;

		// Token: 0x04001D54 RID: 7508
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001D55 RID: 7509
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001D56 RID: 7510
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCursor_Protected_Virtual_Void_0;

		// Token: 0x04001D57 RID: 7511
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHover_Private_Void_0;

		// Token: 0x04001D58 RID: 7512
		private static readonly IntPtr NativeMethodInfoPtr_GetHoveredTopCollider_Private_Collider_0;
	}
}
