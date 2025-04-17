using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Police;
using Il2CppScheduleOne.Vehicles;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000787 RID: 1927
	public class PoliceStation : NPCEnterableBuilding
	{
		// Token: 0x0600B668 RID: 46696 RVA: 0x002D4A3C File Offset: 0x002D2C3C
		// Note: this type is marked as 'beforefieldinit'.
		static PoliceStation()
		{
			Il2CppClassPointerStore<PoliceStation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "PoliceStation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr);
			PoliceStation.NativeFieldInfoPtr_PoliceStations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "PoliceStations");
			PoliceStation.NativeFieldInfoPtr_VehicleLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "VehicleLimit");
			PoliceStation.NativeFieldInfoPtr_SpawnPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "SpawnPoint");
			PoliceStation.NativeFieldInfoPtr_VehicleSpawnPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "VehicleSpawnPoints");
			PoliceStation.NativeFieldInfoPtr_PossessedVehicleSpawnPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "PossessedVehicleSpawnPoints");
			PoliceStation.NativeFieldInfoPtr_PoliceVehiclePrefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "PoliceVehiclePrefabs");
			PoliceStation.NativeFieldInfoPtr_OfficerPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "OfficerPool");
			PoliceStation.NativeFieldInfoPtr__TimeSinceLastDispatch_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "<TimeSinceLastDispatch>k__BackingField");
			PoliceStation.NativeFieldInfoPtr_deployedVehicles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "deployedVehicles");
			PoliceStation.NativeMethodInfoPtr_get_TimeSinceLastDispatch_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100685716);
			PoliceStation.NativeMethodInfoPtr_set_TimeSinceLastDispatch_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100685717);
			PoliceStation.NativeMethodInfoPtr_get_deployedVehicleCount_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100685718);
			PoliceStation.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100685719);
			PoliceStation.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100685720);
			PoliceStation.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100685721);
			PoliceStation.NativeMethodInfoPtr_CleanVehicleList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100685722);
			PoliceStation.NativeMethodInfoPtr_Dispatch_Public_Void_Int32_Player_EDispatchType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100685723);
			PoliceStation.NativeMethodInfoPtr_PullOfficer_Public_PoliceOfficer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100685724);
			PoliceStation.NativeMethodInfoPtr_CreateVehicle_Public_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100685725);
			PoliceStation.NativeMethodInfoPtr_NPCEnteredBuilding_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100685726);
			PoliceStation.NativeMethodInfoPtr_NPCExitedBuilding_Public_Virtual_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100685727);
			PoliceStation.NativeMethodInfoPtr_GetClosestPoliceStation_Public_Static_PoliceStation_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100685728);
			PoliceStation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100685729);
			PoliceStation.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Transform_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, 100685731);
		}

		// Token: 0x17003899 RID: 14489
		// (get) Token: 0x0600B669 RID: 46697 RVA: 0x002D4C4C File Offset: 0x002D2E4C
		// (set) Token: 0x0600B66A RID: 46698 RVA: 0x002D4C88 File Offset: 0x002D2E88
		public unsafe float TimeSinceLastDispatch
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_get_TimeSinceLastDispatch_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_set_TimeSinceLastDispatch_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700389A RID: 14490
		// (get) Token: 0x0600B66B RID: 46699 RVA: 0x002D4CC8 File Offset: 0x002D2EC8
		public unsafe int deployedVehicleCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311002, XrefRangeEnd = 311023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_get_deployedVehicleCount_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600B66C RID: 46700 RVA: 0x002D4D04 File Offset: 0x002D2F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311023, XrefRangeEnd = 311042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceStation.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B66D RID: 46701 RVA: 0x002D4D40 File Offset: 0x002D2F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311042, XrefRangeEnd = 311055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B66E RID: 46702 RVA: 0x002D4D74 File Offset: 0x002D2F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311055, XrefRangeEnd = 311056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B66F RID: 46703 RVA: 0x002D4DA8 File Offset: 0x002D2FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311056, XrefRangeEnd = 311068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanVehicleList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_CleanVehicleList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B670 RID: 46704 RVA: 0x002D4DDC File Offset: 0x002D2FDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 311134, RefRangeEnd = 311136, XrefRangeStart = 311068, XrefRangeEnd = 311134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispatch(int requestedOfficerCount, Player targetPlayer, PoliceStation.EDispatchType type = PoliceStation.EDispatchType.Auto, bool beginAsSighted = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref requestedOfficerCount;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetPlayer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beginAsSighted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_Dispatch_Public_Void_Int32_Player_EDispatchType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B671 RID: 46705 RVA: 0x002D4E48 File Offset: 0x002D3048
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 311147, RefRangeEnd = 311152, XrefRangeStart = 311136, XrefRangeEnd = 311147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoliceOfficer PullOfficer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_PullOfficer_Public_PoliceOfficer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr3) : null;
		}

		// Token: 0x0600B672 RID: 46706 RVA: 0x002D4E88 File Offset: 0x002D3088
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 311184, RefRangeEnd = 311187, XrefRangeStart = 311152, XrefRangeEnd = 311184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LandVehicle CreateVehicle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_CreateVehicle_Public_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr3) : null;
		}

		// Token: 0x0600B673 RID: 46707 RVA: 0x002D4EC8 File Offset: 0x002D30C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311187, XrefRangeEnd = 311198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NPCEnteredBuilding(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceStation.NativeMethodInfoPtr_NPCEnteredBuilding_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B674 RID: 46708 RVA: 0x002D4F18 File Offset: 0x002D3118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311198, XrefRangeEnd = 311204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NPCExitedBuilding(NPC npc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PoliceStation.NativeMethodInfoPtr_NPCExitedBuilding_Public_Virtual_Void_NPC_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B675 RID: 46709 RVA: 0x002D4F68 File Offset: 0x002D3168
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 311212, RefRangeEnd = 311223, XrefRangeStart = 311204, XrefRangeEnd = 311212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PoliceStation GetClosestPoliceStation(Vector3 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_GetClosestPoliceStation_Public_Static_PoliceStation_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PoliceStation>(intPtr3) : null;
		}

		// Token: 0x0600B676 RID: 46710 RVA: 0x002D4FA8 File Offset: 0x002D31A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311223, XrefRangeEnd = 311238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoliceStation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B677 RID: 46711 RVA: 0x002D4FE4 File Offset: 0x002D31E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311238, XrefRangeEnd = 311254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Method_Internal_Static_Boolean_Transform_PDM_0(Transform spawnPoint)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spawnPoint);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Transform_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B678 RID: 46712 RVA: 0x00059920 File Offset: 0x00057B20
		public PoliceStation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003890 RID: 14480
		// (get) Token: 0x0600B679 RID: 46713 RVA: 0x002D5028 File Offset: 0x002D3228
		// (set) Token: 0x0600B67A RID: 46714 RVA: 0x00059929 File Offset: 0x00057B29
		public unsafe static List<PoliceStation> PoliceStations
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PoliceStation.NativeFieldInfoPtr_PoliceStations, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PoliceStation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PoliceStation.NativeFieldInfoPtr_PoliceStations, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003891 RID: 14481
		// (get) Token: 0x0600B67B RID: 46715 RVA: 0x002D5050 File Offset: 0x002D3250
		// (set) Token: 0x0600B67C RID: 46716 RVA: 0x0005993B File Offset: 0x00057B3B
		public unsafe int VehicleLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_VehicleLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_VehicleLimit)) = value;
			}
		}

		// Token: 0x17003892 RID: 14482
		// (get) Token: 0x0600B67D RID: 46717 RVA: 0x002D5078 File Offset: 0x002D3278
		// (set) Token: 0x0600B67E RID: 46718 RVA: 0x00059956 File Offset: 0x00057B56
		public unsafe Transform SpawnPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_SpawnPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_SpawnPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003893 RID: 14483
		// (get) Token: 0x0600B67F RID: 46719 RVA: 0x002D50A8 File Offset: 0x002D32A8
		// (set) Token: 0x0600B680 RID: 46720 RVA: 0x00059975 File Offset: 0x00057B75
		public unsafe Il2CppReferenceArray<Transform> VehicleSpawnPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_VehicleSpawnPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_VehicleSpawnPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003894 RID: 14484
		// (get) Token: 0x0600B681 RID: 46721 RVA: 0x002D50D8 File Offset: 0x002D32D8
		// (set) Token: 0x0600B682 RID: 46722 RVA: 0x00059994 File Offset: 0x00057B94
		public unsafe Il2CppReferenceArray<Transform> PossessedVehicleSpawnPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_PossessedVehicleSpawnPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_PossessedVehicleSpawnPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003895 RID: 14485
		// (get) Token: 0x0600B683 RID: 46723 RVA: 0x002D5108 File Offset: 0x002D3308
		// (set) Token: 0x0600B684 RID: 46724 RVA: 0x000599B3 File Offset: 0x00057BB3
		public unsafe Il2CppReferenceArray<LandVehicle> PoliceVehiclePrefabs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_PoliceVehiclePrefabs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_PoliceVehiclePrefabs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003896 RID: 14486
		// (get) Token: 0x0600B685 RID: 46725 RVA: 0x002D5138 File Offset: 0x002D3338
		// (set) Token: 0x0600B686 RID: 46726 RVA: 0x000599D2 File Offset: 0x00057BD2
		public unsafe List<PoliceOfficer> OfficerPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_OfficerPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PoliceOfficer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_OfficerPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003897 RID: 14487
		// (get) Token: 0x0600B687 RID: 46727 RVA: 0x002D5168 File Offset: 0x002D3368
		// (set) Token: 0x0600B688 RID: 46728 RVA: 0x000599F1 File Offset: 0x00057BF1
		public unsafe float _TimeSinceLastDispatch_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr__TimeSinceLastDispatch_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr__TimeSinceLastDispatch_k__BackingField)) = value;
			}
		}

		// Token: 0x17003898 RID: 14488
		// (get) Token: 0x0600B689 RID: 46729 RVA: 0x002D5190 File Offset: 0x002D3390
		// (set) Token: 0x0600B68A RID: 46730 RVA: 0x00059A0C File Offset: 0x00057C0C
		public unsafe List<LandVehicle> deployedVehicles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_deployedVehicles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceStation.NativeFieldInfoPtr_deployedVehicles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007ADF RID: 31455
		private static readonly IntPtr NativeFieldInfoPtr_PoliceStations;

		// Token: 0x04007AE0 RID: 31456
		private static readonly IntPtr NativeFieldInfoPtr_VehicleLimit;

		// Token: 0x04007AE1 RID: 31457
		private static readonly IntPtr NativeFieldInfoPtr_SpawnPoint;

		// Token: 0x04007AE2 RID: 31458
		private static readonly IntPtr NativeFieldInfoPtr_VehicleSpawnPoints;

		// Token: 0x04007AE3 RID: 31459
		private static readonly IntPtr NativeFieldInfoPtr_PossessedVehicleSpawnPoints;

		// Token: 0x04007AE4 RID: 31460
		private static readonly IntPtr NativeFieldInfoPtr_PoliceVehiclePrefabs;

		// Token: 0x04007AE5 RID: 31461
		private static readonly IntPtr NativeFieldInfoPtr_OfficerPool;

		// Token: 0x04007AE6 RID: 31462
		private static readonly IntPtr NativeFieldInfoPtr__TimeSinceLastDispatch_k__BackingField;

		// Token: 0x04007AE7 RID: 31463
		private static readonly IntPtr NativeFieldInfoPtr_deployedVehicles;

		// Token: 0x04007AE8 RID: 31464
		private static readonly IntPtr NativeMethodInfoPtr_get_TimeSinceLastDispatch_Public_get_Single_0;

		// Token: 0x04007AE9 RID: 31465
		private static readonly IntPtr NativeMethodInfoPtr_set_TimeSinceLastDispatch_Private_set_Void_Single_0;

		// Token: 0x04007AEA RID: 31466
		private static readonly IntPtr NativeMethodInfoPtr_get_deployedVehicleCount_Private_get_Int32_0;

		// Token: 0x04007AEB RID: 31467
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007AEC RID: 31468
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04007AED RID: 31469
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04007AEE RID: 31470
		private static readonly IntPtr NativeMethodInfoPtr_CleanVehicleList_Private_Void_0;

		// Token: 0x04007AEF RID: 31471
		private static readonly IntPtr NativeMethodInfoPtr_Dispatch_Public_Void_Int32_Player_EDispatchType_Boolean_0;

		// Token: 0x04007AF0 RID: 31472
		private static readonly IntPtr NativeMethodInfoPtr_PullOfficer_Public_PoliceOfficer_0;

		// Token: 0x04007AF1 RID: 31473
		private static readonly IntPtr NativeMethodInfoPtr_CreateVehicle_Public_LandVehicle_0;

		// Token: 0x04007AF2 RID: 31474
		private static readonly IntPtr NativeMethodInfoPtr_NPCEnteredBuilding_Public_Virtual_Void_NPC_0;

		// Token: 0x04007AF3 RID: 31475
		private static readonly IntPtr NativeMethodInfoPtr_NPCExitedBuilding_Public_Virtual_Void_NPC_0;

		// Token: 0x04007AF4 RID: 31476
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestPoliceStation_Public_Static_PoliceStation_Vector3_0;

		// Token: 0x04007AF5 RID: 31477
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007AF6 RID: 31478
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_Transform_PDM_0;

		// Token: 0x02000C06 RID: 3078
		[OriginalName("Assembly-CSharp.dll", "", "EDispatchType")]
		public enum EDispatchType
		{
			// Token: 0x0400961C RID: 38428
			Auto,
			// Token: 0x0400961D RID: 38429
			UseVehicle,
			// Token: 0x0400961E RID: 38430
			OnFoot
		}

		// Token: 0x02000C07 RID: 3079
		[ObfuscatedName("ScheduleOne.Map.PoliceStation+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E023 RID: 57379 RVA: 0x0034C6FC File Offset: 0x0034A8FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PoliceStation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PoliceStation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoliceStation.__c>.NativeClassPtr);
				PoliceStation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation.__c>.NativeClassPtr, "<>9");
				PoliceStation.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceStation.__c>.NativeClassPtr, "<>9__14_0");
				PoliceStation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation.__c>.NativeClassPtr, 100685733);
				PoliceStation.__c.NativeMethodInfoPtr__get_deployedVehicleCount_b__14_0_Internal_Boolean_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceStation.__c>.NativeClassPtr, 100685734);
			}

			// Token: 0x0600E024 RID: 57380 RVA: 0x0034C778 File Offset: 0x0034A978
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoliceStation.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E025 RID: 57381 RVA: 0x0034C7B4 File Offset: 0x0034A9B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 310998, XrefRangeEnd = 311002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_deployedVehicleCount_b__14_0(LandVehicle v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(v);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceStation.__c.NativeMethodInfoPtr__get_deployedVehicleCount_b__14_0_Internal_Boolean_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E026 RID: 57382 RVA: 0x0006D463 File Offset: 0x0006B663
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004574 RID: 17780
			// (get) Token: 0x0600E027 RID: 57383 RVA: 0x0034C804 File Offset: 0x0034AA04
			// (set) Token: 0x0600E028 RID: 57384 RVA: 0x0006D46C File Offset: 0x0006B66C
			public unsafe static PoliceStation.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PoliceStation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceStation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PoliceStation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004575 RID: 17781
			// (get) Token: 0x0600E029 RID: 57385 RVA: 0x0034C82C File Offset: 0x0034AA2C
			// (set) Token: 0x0600E02A RID: 57386 RVA: 0x0006D47E File Offset: 0x0006B67E
			public unsafe static Func<LandVehicle, bool> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PoliceStation.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<LandVehicle, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PoliceStation.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400961F RID: 38431
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009620 RID: 38432
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04009621 RID: 38433
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009622 RID: 38434
			private static readonly IntPtr NativeMethodInfoPtr__get_deployedVehicleCount_b__14_0_Internal_Boolean_LandVehicle_0;
		}
	}
}
