using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Building;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200072D RID: 1837
	public class FloorRack : GridItem
	{
		// Token: 0x0600A6AE RID: 42670 RVA: 0x0029AD38 File Offset: 0x00298F38
		// Note: this type is marked as 'beforefieldinit'.
		static FloorRack()
		{
			Il2CppClassPointerStore<FloorRack>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "FloorRack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloorRack>.NativeClassPtr);
			FloorRack.NativeFieldInfoPtr_leg_BottomLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "leg_BottomLeft");
			FloorRack.NativeFieldInfoPtr_leg_BottomRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "leg_BottomRight");
			FloorRack.NativeFieldInfoPtr_leg_TopLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "leg_TopLeft");
			FloorRack.NativeFieldInfoPtr_leg_TopRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "leg_TopRight");
			FloorRack.NativeFieldInfoPtr_obs_BottomLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "obs_BottomLeft");
			FloorRack.NativeFieldInfoPtr_obs_BottomRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "obs_BottomRight");
			FloorRack.NativeFieldInfoPtr_obs_TopLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "obs_TopLeft");
			FloorRack.NativeFieldInfoPtr_obs_TopRight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "obs_TopRight");
			FloorRack.NativeFieldInfoPtr_procTiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "procTiles");
			FloorRack.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.FloorRackAssembly-CSharp.dll_Excuted");
			FloorRack.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.FloorRackAssembly-CSharp.dll_Excuted");
			FloorRack.NativeMethodInfoPtr_get_ProceduralTiles_Public_Virtual_Final_New_get_List_1_ProceduralTile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100683701);
			FloorRack.NativeMethodInfoPtr_UpdateLegVisibility_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100683702);
			FloorRack.NativeMethodInfoPtr_CockAndBalls_Protected_Void_GameObject_CornerObstacle_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100683703);
			FloorRack.NativeMethodInfoPtr_GetFloorRackFromOccupants_Private_FloorRack_List_1_GridItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100683704);
			FloorRack.NativeMethodInfoPtr_GetSurroundingRacks_Public_List_1_FloorRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100683705);
			FloorRack.NativeMethodInfoPtr_CanShareTileWith_Public_Virtual_Boolean_List_1_GridItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100683706);
			FloorRack.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100683707);
			FloorRack.NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100683708);
			FloorRack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100683709);
			FloorRack.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100683710);
			FloorRack.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100683711);
			FloorRack.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100683712);
			FloorRack.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloorRack>.NativeClassPtr, 100683713);
		}

		// Token: 0x17003377 RID: 13175
		// (get) Token: 0x0600A6AF RID: 42671 RVA: 0x0029AF48 File Offset: 0x00299148
		public unsafe virtual List<ProceduralTile> ProceduralTiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloorRack.NativeMethodInfoPtr_get_ProceduralTiles_Public_Virtual_Final_New_get_List_1_ProceduralTile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ProceduralTile>>(intPtr3) : null;
			}
		}

		// Token: 0x0600A6B0 RID: 42672 RVA: 0x0029AF88 File Offset: 0x00299188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290620, XrefRangeEnd = 290628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateLegVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_UpdateLegVisibility_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6B1 RID: 42673 RVA: 0x0029AFC4 File Offset: 0x002991C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 290711, RefRangeEnd = 290715, XrefRangeStart = 290628, XrefRangeEnd = 290711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CockAndBalls(GameObject leg, CornerObstacle obs, int xOffset, int yOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(leg);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xOffset;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloorRack.NativeMethodInfoPtr_CockAndBalls_Protected_Void_GameObject_CornerObstacle_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6B2 RID: 42674 RVA: 0x0029B034 File Offset: 0x00299234
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 290726, RefRangeEnd = 290734, XrefRangeStart = 290715, XrefRangeEnd = 290726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FloorRack GetFloorRackFromOccupants(List<GridItem> occs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(occs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloorRack.NativeMethodInfoPtr_GetFloorRackFromOccupants_Private_FloorRack_List_1_GridItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FloorRack>(intPtr3) : null;
		}

		// Token: 0x0600A6B3 RID: 42675 RVA: 0x0029B084 File Offset: 0x00299284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290734, XrefRangeEnd = 290764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<FloorRack> GetSurroundingRacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloorRack.NativeMethodInfoPtr_GetSurroundingRacks_Public_List_1_FloorRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<FloorRack>>(intPtr3) : null;
		}

		// Token: 0x0600A6B4 RID: 42676 RVA: 0x0029B0C4 File Offset: 0x002992C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290764, XrefRangeEnd = 290771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanShareTileWith(List<GridItem> obstacles)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obstacles);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_CanShareTileWith_Public_Virtual_Boolean_List_1_GridItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A6B5 RID: 42677 RVA: 0x0029B11C File Offset: 0x0029931C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290771, XrefRangeEnd = 290791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanBeDestroyed(out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600A6B6 RID: 42678 RVA: 0x0029B180 File Offset: 0x00299380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290791, XrefRangeEnd = 290803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DestroyItem(bool callOnServer = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref callOnServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6B7 RID: 42679 RVA: 0x0029B1CC File Offset: 0x002993CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290803, XrefRangeEnd = 290804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FloorRack() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloorRack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FloorRack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6B8 RID: 42680 RVA: 0x0029B208 File Offset: 0x00299408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290804, XrefRangeEnd = 290805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6B9 RID: 42681 RVA: 0x0029B244 File Offset: 0x00299444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 290805, XrefRangeEnd = 290806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6BA RID: 42682 RVA: 0x0029B280 File Offset: 0x00299480
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6BB RID: 42683 RVA: 0x0029B2BC File Offset: 0x002994BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290619, RefRangeEnd = 290620, XrefRangeStart = 290619, XrefRangeEnd = 290620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FloorRack.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A6BC RID: 42684 RVA: 0x000521D1 File Offset: 0x000503D1
		public FloorRack(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700336C RID: 13164
		// (get) Token: 0x0600A6BD RID: 42685 RVA: 0x0029B2F8 File Offset: 0x002994F8
		// (set) Token: 0x0600A6BE RID: 42686 RVA: 0x000521DA File Offset: 0x000503DA
		public unsafe Transform leg_BottomLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_BottomLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_BottomLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700336D RID: 13165
		// (get) Token: 0x0600A6BF RID: 42687 RVA: 0x0029B328 File Offset: 0x00299528
		// (set) Token: 0x0600A6C0 RID: 42688 RVA: 0x000521F9 File Offset: 0x000503F9
		public unsafe Transform leg_BottomRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_BottomRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_BottomRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700336E RID: 13166
		// (get) Token: 0x0600A6C1 RID: 42689 RVA: 0x0029B358 File Offset: 0x00299558
		// (set) Token: 0x0600A6C2 RID: 42690 RVA: 0x00052218 File Offset: 0x00050418
		public unsafe Transform leg_TopLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_TopLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_TopLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700336F RID: 13167
		// (get) Token: 0x0600A6C3 RID: 42691 RVA: 0x0029B388 File Offset: 0x00299588
		// (set) Token: 0x0600A6C4 RID: 42692 RVA: 0x00052237 File Offset: 0x00050437
		public unsafe Transform leg_TopRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_TopRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_leg_TopRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003370 RID: 13168
		// (get) Token: 0x0600A6C5 RID: 42693 RVA: 0x0029B3B8 File Offset: 0x002995B8
		// (set) Token: 0x0600A6C6 RID: 42694 RVA: 0x00052256 File Offset: 0x00050456
		public unsafe CornerObstacle obs_BottomLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_BottomLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CornerObstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_BottomLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003371 RID: 13169
		// (get) Token: 0x0600A6C7 RID: 42695 RVA: 0x0029B3E8 File Offset: 0x002995E8
		// (set) Token: 0x0600A6C8 RID: 42696 RVA: 0x00052275 File Offset: 0x00050475
		public unsafe CornerObstacle obs_BottomRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_BottomRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CornerObstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_BottomRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003372 RID: 13170
		// (get) Token: 0x0600A6C9 RID: 42697 RVA: 0x0029B418 File Offset: 0x00299618
		// (set) Token: 0x0600A6CA RID: 42698 RVA: 0x00052294 File Offset: 0x00050494
		public unsafe CornerObstacle obs_TopLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_TopLeft);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CornerObstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_TopLeft), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003373 RID: 13171
		// (get) Token: 0x0600A6CB RID: 42699 RVA: 0x0029B448 File Offset: 0x00299648
		// (set) Token: 0x0600A6CC RID: 42700 RVA: 0x000522B3 File Offset: 0x000504B3
		public unsafe CornerObstacle obs_TopRight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_TopRight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CornerObstacle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_obs_TopRight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003374 RID: 13172
		// (get) Token: 0x0600A6CD RID: 42701 RVA: 0x0029B478 File Offset: 0x00299678
		// (set) Token: 0x0600A6CE RID: 42702 RVA: 0x000522D2 File Offset: 0x000504D2
		public unsafe List<ProceduralTile> procTiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_procTiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProceduralTile>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_procTiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003375 RID: 13173
		// (get) Token: 0x0600A6CF RID: 42703 RVA: 0x0029B4A8 File Offset: 0x002996A8
		// (set) Token: 0x0600A6D0 RID: 42704 RVA: 0x000522F1 File Offset: 0x000504F1
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003376 RID: 13174
		// (get) Token: 0x0600A6D1 RID: 42705 RVA: 0x0029B4D0 File Offset: 0x002996D0
		// (set) Token: 0x0600A6D2 RID: 42706 RVA: 0x0005230C File Offset: 0x0005050C
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FloorRack.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006FCC RID: 28620
		private static readonly IntPtr NativeFieldInfoPtr_leg_BottomLeft;

		// Token: 0x04006FCD RID: 28621
		private static readonly IntPtr NativeFieldInfoPtr_leg_BottomRight;

		// Token: 0x04006FCE RID: 28622
		private static readonly IntPtr NativeFieldInfoPtr_leg_TopLeft;

		// Token: 0x04006FCF RID: 28623
		private static readonly IntPtr NativeFieldInfoPtr_leg_TopRight;

		// Token: 0x04006FD0 RID: 28624
		private static readonly IntPtr NativeFieldInfoPtr_obs_BottomLeft;

		// Token: 0x04006FD1 RID: 28625
		private static readonly IntPtr NativeFieldInfoPtr_obs_BottomRight;

		// Token: 0x04006FD2 RID: 28626
		private static readonly IntPtr NativeFieldInfoPtr_obs_TopLeft;

		// Token: 0x04006FD3 RID: 28627
		private static readonly IntPtr NativeFieldInfoPtr_obs_TopRight;

		// Token: 0x04006FD4 RID: 28628
		private static readonly IntPtr NativeFieldInfoPtr_procTiles;

		// Token: 0x04006FD5 RID: 28629
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006FD6 RID: 28630
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006FD7 RID: 28631
		private static readonly IntPtr NativeMethodInfoPtr_get_ProceduralTiles_Public_Virtual_Final_New_get_List_1_ProceduralTile_0;

		// Token: 0x04006FD8 RID: 28632
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLegVisibility_Public_Virtual_New_Void_0;

		// Token: 0x04006FD9 RID: 28633
		private static readonly IntPtr NativeMethodInfoPtr_CockAndBalls_Protected_Void_GameObject_CornerObstacle_Int32_Int32_0;

		// Token: 0x04006FDA RID: 28634
		private static readonly IntPtr NativeMethodInfoPtr_GetFloorRackFromOccupants_Private_FloorRack_List_1_GridItem_0;

		// Token: 0x04006FDB RID: 28635
		private static readonly IntPtr NativeMethodInfoPtr_GetSurroundingRacks_Public_List_1_FloorRack_0;

		// Token: 0x04006FDC RID: 28636
		private static readonly IntPtr NativeMethodInfoPtr_CanShareTileWith_Public_Virtual_Boolean_List_1_GridItem_0;

		// Token: 0x04006FDD RID: 28637
		private static readonly IntPtr NativeMethodInfoPtr_CanBeDestroyed_Public_Virtual_Boolean_byref_String_0;

		// Token: 0x04006FDE RID: 28638
		private static readonly IntPtr NativeMethodInfoPtr_DestroyItem_Public_Virtual_Void_Boolean_0;

		// Token: 0x04006FDF RID: 28639
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006FE0 RID: 28640
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006FE1 RID: 28641
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006FE2 RID: 28642
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006FE3 RID: 28643
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
