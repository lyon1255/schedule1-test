using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Doors;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x0200077E RID: 1918
	public class NPCEnterableBuilding : MonoBehaviour
	{
		// Token: 0x0600B5A0 RID: 46496 RVA: 0x002D2480 File Offset: 0x002D0680
		// Note: this type is marked as 'beforefieldinit'.
		static NPCEnterableBuilding()
		{
			Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "NPCEnterableBuilding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr);
			NPCEnterableBuilding.NativeFieldInfoPtr_DOOR_SOUND_DISTANCE_LIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "DOOR_SOUND_DISTANCE_LIMIT");
			NPCEnterableBuilding.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "<GUID>k__BackingField");
			NPCEnterableBuilding.NativeFieldInfoPtr_BuildingName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "BuildingName");
			NPCEnterableBuilding.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "BakedGUID");
			NPCEnterableBuilding.NativeFieldInfoPtr_Doors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "Doors");
			NPCEnterableBuilding.NativeFieldInfoPtr_Occupants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "Occupants");
			NPCEnterableBuilding.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100685618);
			NPCEnterableBuilding.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100685619);
			NPCEnterableBuilding.NativeMethodInfoPtr_get_OccupantCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100685620);
			NPCEnterableBuilding.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100685621);
			NPCEnterableBuilding.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100685622);
			NPCEnterableBuilding.NativeMethodInfoPtr_NPCEnteredBuilding_Public_Virtual_New_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100685623);
			NPCEnterableBuilding.NativeMethodInfoPtr_NPCExitedBuilding_Public_Virtual_New_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100685624);
			NPCEnterableBuilding.NativeMethodInfoPtr_GetDoors_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100685625);
			NPCEnterableBuilding.NativeMethodInfoPtr_GetSummonableNPCs_Public_List_1_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100685626);
			NPCEnterableBuilding.NativeMethodInfoPtr_GetClosestDoor_Public_StaticDoor_Vector3_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100685627);
			NPCEnterableBuilding.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, 100685628);
		}

		// Token: 0x17003854 RID: 14420
		// (get) Token: 0x0600B5A1 RID: 46497 RVA: 0x002D2604 File Offset: 0x002D0804
		// (set) Token: 0x0600B5A2 RID: 46498 RVA: 0x002D2640 File Offset: 0x002D0840
		public unsafe virtual Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003855 RID: 14421
		// (get) Token: 0x0600B5A3 RID: 46499 RVA: 0x002D2680 File Offset: 0x002D0880
		public unsafe int OccupantCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 310138, RefRangeEnd = 310139, XrefRangeStart = 310137, XrefRangeEnd = 310138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr_get_OccupantCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600B5A4 RID: 46500 RVA: 0x002D26BC File Offset: 0x002D08BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310166, RefRangeEnd = 310167, XrefRangeStart = 310139, XrefRangeEnd = 310166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEnterableBuilding.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5A5 RID: 46501 RVA: 0x002D26F8 File Offset: 0x002D08F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310167, XrefRangeEnd = 310171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5A6 RID: 46502 RVA: 0x002D2738 File Offset: 0x002D0938
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310215, RefRangeEnd = 310216, XrefRangeStart = 310171, XrefRangeEnd = 310215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NPCEnteredBuilding(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEnterableBuilding.NativeMethodInfoPtr_NPCEnteredBuilding_Public_Virtual_New_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5A7 RID: 46503 RVA: 0x002D2788 File Offset: 0x002D0988
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 310258, RefRangeEnd = 310259, XrefRangeStart = 310216, XrefRangeEnd = 310258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NPCExitedBuilding(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCEnterableBuilding.NativeMethodInfoPtr_NPCExitedBuilding_Public_Virtual_New_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5A8 RID: 46504 RVA: 0x002D27D8 File Offset: 0x002D09D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310259, XrefRangeEnd = 310263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetDoors()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr_GetDoors_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5A9 RID: 46505 RVA: 0x002D280C File Offset: 0x002D0A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310263, XrefRangeEnd = 310284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<NPC> GetSummonableNPCs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr_GetSummonableNPCs_Public_List_1_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr3) : null;
		}

		// Token: 0x0600B5AA RID: 46506 RVA: 0x002D284C File Offset: 0x002D0A4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 310310, RefRangeEnd = 310312, XrefRangeStart = 310284, XrefRangeEnd = 310310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StaticDoor GetClosestDoor(Vector3 pos, bool useableOnly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useableOnly;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr_GetClosestDoor_Public_StaticDoor_Vector3_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<StaticDoor>(intPtr3) : null;
		}

		// Token: 0x0600B5AB RID: 46507 RVA: 0x002D28A8 File Offset: 0x002D0AA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 310323, RefRangeEnd = 310325, XrefRangeStart = 310312, XrefRangeEnd = 310323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCEnterableBuilding() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B5AC RID: 46508 RVA: 0x0005926A File Offset: 0x0005746A
		public NPCEnterableBuilding(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700384E RID: 14414
		// (get) Token: 0x0600B5AD RID: 46509 RVA: 0x002D28E4 File Offset: 0x002D0AE4
		// (set) Token: 0x0600B5AE RID: 46510 RVA: 0x00059273 File Offset: 0x00057473
		public unsafe static float DOOR_SOUND_DISTANCE_LIMIT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCEnterableBuilding.NativeFieldInfoPtr_DOOR_SOUND_DISTANCE_LIMIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCEnterableBuilding.NativeFieldInfoPtr_DOOR_SOUND_DISTANCE_LIMIT, (void*)(&value));
			}
		}

		// Token: 0x1700384F RID: 14415
		// (get) Token: 0x0600B5AF RID: 46511 RVA: 0x002D2900 File Offset: 0x002D0B00
		// (set) Token: 0x0600B5B0 RID: 46512 RVA: 0x00059281 File Offset: 0x00057481
		public unsafe Guid _GUID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17003850 RID: 14416
		// (get) Token: 0x0600B5B1 RID: 46513 RVA: 0x002D2928 File Offset: 0x002D0B28
		// (set) Token: 0x0600B5B2 RID: 46514 RVA: 0x0005929C File Offset: 0x0005749C
		public unsafe string BuildingName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_BuildingName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_BuildingName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003851 RID: 14417
		// (get) Token: 0x0600B5B3 RID: 46515 RVA: 0x002D2950 File Offset: 0x002D0B50
		// (set) Token: 0x0600B5B4 RID: 46516 RVA: 0x000592BB File Offset: 0x000574BB
		public unsafe string BakedGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003852 RID: 14418
		// (get) Token: 0x0600B5B5 RID: 46517 RVA: 0x002D2978 File Offset: 0x002D0B78
		// (set) Token: 0x0600B5B6 RID: 46518 RVA: 0x000592DA File Offset: 0x000574DA
		public unsafe Il2CppReferenceArray<StaticDoor> Doors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_Doors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<StaticDoor>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_Doors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003853 RID: 14419
		// (get) Token: 0x0600B5B7 RID: 46519 RVA: 0x002D29A8 File Offset: 0x002D0BA8
		// (set) Token: 0x0600B5B8 RID: 46520 RVA: 0x000592F9 File Offset: 0x000574F9
		public unsafe List<NPC> Occupants
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_Occupants);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NPC>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.NativeFieldInfoPtr_Occupants), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007A62 RID: 31330
		private static readonly IntPtr NativeFieldInfoPtr_DOOR_SOUND_DISTANCE_LIMIT;

		// Token: 0x04007A63 RID: 31331
		private static readonly IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04007A64 RID: 31332
		private static readonly IntPtr NativeFieldInfoPtr_BuildingName;

		// Token: 0x04007A65 RID: 31333
		private static readonly IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x04007A66 RID: 31334
		private static readonly IntPtr NativeFieldInfoPtr_Doors;

		// Token: 0x04007A67 RID: 31335
		private static readonly IntPtr NativeFieldInfoPtr_Occupants;

		// Token: 0x04007A68 RID: 31336
		private static readonly IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x04007A69 RID: 31337
		private static readonly IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x04007A6A RID: 31338
		private static readonly IntPtr NativeMethodInfoPtr_get_OccupantCount_Public_get_Int32_0;

		// Token: 0x04007A6B RID: 31339
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04007A6C RID: 31340
		private static readonly IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x04007A6D RID: 31341
		private static readonly IntPtr NativeMethodInfoPtr_NPCEnteredBuilding_Public_Virtual_New_Void_NPC_0;

		// Token: 0x04007A6E RID: 31342
		private static readonly IntPtr NativeMethodInfoPtr_NPCExitedBuilding_Public_Virtual_New_Void_NPC_0;

		// Token: 0x04007A6F RID: 31343
		private static readonly IntPtr NativeMethodInfoPtr_GetDoors_Public_Void_0;

		// Token: 0x04007A70 RID: 31344
		private static readonly IntPtr NativeMethodInfoPtr_GetSummonableNPCs_Public_List_1_NPC_0;

		// Token: 0x04007A71 RID: 31345
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestDoor_Public_StaticDoor_Vector3_Boolean_0;

		// Token: 0x04007A72 RID: 31346
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BFD RID: 3069
		[ObfuscatedName("ScheduleOne.Map.NPCEnterableBuilding+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DFD4 RID: 57300 RVA: 0x0034B850 File Offset: 0x00349A50
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NPCEnterableBuilding.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCEnterableBuilding.__c>.NativeClassPtr);
				NPCEnterableBuilding.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding.__c>.NativeClassPtr, "<>9");
				NPCEnterableBuilding.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding.__c>.NativeClassPtr, "<>9__16_0");
				NPCEnterableBuilding.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding.__c>.NativeClassPtr, 100685630);
				NPCEnterableBuilding.__c.NativeMethodInfoPtr__GetSummonableNPCs_b__16_0_Internal_Boolean_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding.__c>.NativeClassPtr, 100685631);
			}

			// Token: 0x0600DFD5 RID: 57301 RVA: 0x0034B8CC File Offset: 0x00349ACC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCEnterableBuilding.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFD6 RID: 57302 RVA: 0x0034B908 File Offset: 0x00349B08
			[CallerCount(0)]
			public unsafe bool _GetSummonableNPCs_b__16_0(NPC npc)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.__c.NativeMethodInfoPtr__GetSummonableNPCs_b__16_0_Internal_Boolean_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DFD7 RID: 57303 RVA: 0x0006D23D File Offset: 0x0006B43D
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700455B RID: 17755
			// (get) Token: 0x0600DFD8 RID: 57304 RVA: 0x0034B958 File Offset: 0x00349B58
			// (set) Token: 0x0600DFD9 RID: 57305 RVA: 0x0006D246 File Offset: 0x0006B446
			public unsafe static NPCEnterableBuilding.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCEnterableBuilding.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCEnterableBuilding.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCEnterableBuilding.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700455C RID: 17756
			// (get) Token: 0x0600DFDA RID: 57306 RVA: 0x0034B980 File Offset: 0x00349B80
			// (set) Token: 0x0600DFDB RID: 57307 RVA: 0x0006D258 File Offset: 0x0006B458
			public unsafe static Func<NPC, bool> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NPCEnterableBuilding.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NPC, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NPCEnterableBuilding.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040095E5 RID: 38373
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040095E6 RID: 38374
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x040095E7 RID: 38375
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095E8 RID: 38376
			private static readonly IntPtr NativeMethodInfoPtr__GetSummonableNPCs_b__16_0_Internal_Boolean_NPC_0;
		}

		// Token: 0x02000BFE RID: 3070
		[ObfuscatedName("ScheduleOne.Map.NPCEnterableBuilding+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DFDC RID: 57308 RVA: 0x0034B9A8 File Offset: 0x00349BA8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NPCEnterableBuilding>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr);
				NPCEnterableBuilding.__c__DisplayClass17_0.NativeFieldInfoPtr_useableOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr, "useableOnly");
				NPCEnterableBuilding.__c__DisplayClass17_0.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr, "pos");
				NPCEnterableBuilding.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr, 100685632);
				NPCEnterableBuilding.__c__DisplayClass17_0.NativeMethodInfoPtr__GetClosestDoor_b__0_Internal_Boolean_StaticDoor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr, 100685633);
				NPCEnterableBuilding.__c__DisplayClass17_0.NativeMethodInfoPtr__GetClosestDoor_b__1_Internal_Single_StaticDoor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr, 100685634);
			}

			// Token: 0x0600DFDD RID: 57309 RVA: 0x0034BA38 File Offset: 0x00349C38
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCEnterableBuilding.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFDE RID: 57310 RVA: 0x0034BA74 File Offset: 0x00349C74
			[CallerCount(0)]
			public unsafe bool _GetClosestDoor_b__0(StaticDoor door)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(door);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.__c__DisplayClass17_0.NativeMethodInfoPtr__GetClosestDoor_b__0_Internal_Boolean_StaticDoor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DFDF RID: 57311 RVA: 0x0034BAC4 File Offset: 0x00349CC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310132, XrefRangeEnd = 310137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetClosestDoor_b__1(StaticDoor door)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(door);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCEnterableBuilding.__c__DisplayClass17_0.NativeMethodInfoPtr__GetClosestDoor_b__1_Internal_Single_StaticDoor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DFE0 RID: 57312 RVA: 0x0006D26A File Offset: 0x0006B46A
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700455D RID: 17757
			// (get) Token: 0x0600DFE1 RID: 57313 RVA: 0x0034BB14 File Offset: 0x00349D14
			// (set) Token: 0x0600DFE2 RID: 57314 RVA: 0x0006D273 File Offset: 0x0006B473
			public unsafe bool useableOnly
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.__c__DisplayClass17_0.NativeFieldInfoPtr_useableOnly);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.__c__DisplayClass17_0.NativeFieldInfoPtr_useableOnly)) = value;
				}
			}

			// Token: 0x1700455E RID: 17758
			// (get) Token: 0x0600DFE3 RID: 57315 RVA: 0x0034BB3C File Offset: 0x00349D3C
			// (set) Token: 0x0600DFE4 RID: 57316 RVA: 0x0006D28E File Offset: 0x0006B48E
			public unsafe Vector3 pos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.__c__DisplayClass17_0.NativeFieldInfoPtr_pos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCEnterableBuilding.__c__DisplayClass17_0.NativeFieldInfoPtr_pos)) = value;
				}
			}

			// Token: 0x040095E9 RID: 38377
			private static readonly IntPtr NativeFieldInfoPtr_useableOnly;

			// Token: 0x040095EA RID: 38378
			private static readonly IntPtr NativeFieldInfoPtr_pos;

			// Token: 0x040095EB RID: 38379
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095EC RID: 38380
			private static readonly IntPtr NativeMethodInfoPtr__GetClosestDoor_b__0_Internal_Boolean_StaticDoor_0;

			// Token: 0x040095ED RID: 38381
			private static readonly IntPtr NativeMethodInfoPtr__GetClosestDoor_b__1_Internal_Single_StaticDoor_0;
		}
	}
}
