using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Equipping;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Growing;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200034F RID: 847
	public class PotActionBehaviour : Behaviour
	{
		// Token: 0x06004024 RID: 16420 RVA: 0x00142FA0 File Offset: 0x001411A0
		// Note: this type is marked as 'beforefieldinit'.
		static PotActionBehaviour()
		{
			Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "PotActionBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr);
			PotActionBehaviour.NativeFieldInfoPtr__Initialized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "<Initialized>k__BackingField");
			PotActionBehaviour.NativeFieldInfoPtr__AssignedPot_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "<AssignedPot>k__BackingField");
			PotActionBehaviour.NativeFieldInfoPtr__CurrentActionType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "<CurrentActionType>k__BackingField");
			PotActionBehaviour.NativeFieldInfoPtr__CurrentState_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "<CurrentState>k__BackingField");
			PotActionBehaviour.NativeFieldInfoPtr_AdditiveNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "AdditiveNumber");
			PotActionBehaviour.NativeFieldInfoPtr_WateringCanEquippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "WateringCanEquippable");
			PotActionBehaviour.NativeFieldInfoPtr_TrimmersEquippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "TrimmersEquippable");
			PotActionBehaviour.NativeFieldInfoPtr_botanist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "botanist");
			PotActionBehaviour.NativeFieldInfoPtr_walkToSuppliesRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "walkToSuppliesRoutine");
			PotActionBehaviour.NativeFieldInfoPtr_grabRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "grabRoutine");
			PotActionBehaviour.NativeFieldInfoPtr_walkToPotRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "walkToPotRoutine");
			PotActionBehaviour.NativeFieldInfoPtr_performActionRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "performActionRoutine");
			PotActionBehaviour.NativeFieldInfoPtr_currentActionAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "currentActionAnimation");
			PotActionBehaviour.NativeFieldInfoPtr_currentActionEquippable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "currentActionEquippable");
			PotActionBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.PotActionBehaviourAssembly-CSharp.dll_Excuted");
			PotActionBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.PotActionBehaviourAssembly-CSharp.dll_Excuted");
			PotActionBehaviour.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100670987);
			PotActionBehaviour.NativeMethodInfoPtr_set_Initialized_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100670988);
			PotActionBehaviour.NativeMethodInfoPtr_get_AssignedPot_Public_get_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100670989);
			PotActionBehaviour.NativeMethodInfoPtr_set_AssignedPot_Protected_set_Void_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100670990);
			PotActionBehaviour.NativeMethodInfoPtr_get_CurrentActionType_Public_get_EActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100670991);
			PotActionBehaviour.NativeMethodInfoPtr_set_CurrentActionType_Protected_set_Void_EActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100670992);
			PotActionBehaviour.NativeMethodInfoPtr_get_CurrentState_Public_get_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100670993);
			PotActionBehaviour.NativeMethodInfoPtr_set_CurrentState_Protected_set_Void_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100670994);
			PotActionBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100670995);
			PotActionBehaviour.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Pot_EActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100670996);
			PotActionBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100670997);
			PotActionBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100670998);
			PotActionBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100670999);
			PotActionBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671000);
			PotActionBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671001);
			PotActionBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671002);
			PotActionBehaviour.NativeMethodInfoPtr_StartAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671003);
			PotActionBehaviour.NativeMethodInfoPtr_StopAllActions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671004);
			PotActionBehaviour.NativeMethodInfoPtr_WalkToSupplies_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671005);
			PotActionBehaviour.NativeMethodInfoPtr_GrabItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671006);
			PotActionBehaviour.NativeMethodInfoPtr_WalkToPot_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671007);
			PotActionBehaviour.NativeMethodInfoPtr_PerformAction_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671008);
			PotActionBehaviour.NativeMethodInfoPtr_CompleteAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671009);
			PotActionBehaviour.NativeMethodInfoPtr_StopPerformAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671010);
			PotActionBehaviour.NativeMethodInfoPtr_GetActionAnimation_Private_String_EActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671011);
			PotActionBehaviour.NativeMethodInfoPtr_GetActionEquippable_Private_AvatarEquippable_EActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671012);
			PotActionBehaviour.NativeMethodInfoPtr_GetWaitTime_Public_Single_EActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671013);
			PotActionBehaviour.NativeMethodInfoPtr_CanGetToSupplies_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671014);
			PotActionBehaviour.NativeMethodInfoPtr_IsAtSupplies_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671015);
			PotActionBehaviour.NativeMethodInfoPtr_GetSuppliesAsTransitEntity_Private_ITransitEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671016);
			PotActionBehaviour.NativeMethodInfoPtr_CanGetToPot_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671017);
			PotActionBehaviour.NativeMethodInfoPtr_GetPotAccessPoint_Private_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671018);
			PotActionBehaviour.NativeMethodInfoPtr_IsAtPot_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671019);
			PotActionBehaviour.NativeMethodInfoPtr_GetRequiredItemIDs_Private_Il2CppStringArray_EActionType_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671020);
			PotActionBehaviour.NativeMethodInfoPtr_GetRequiredItemIDs_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671021);
			PotActionBehaviour.NativeMethodInfoPtr_AreActionConditionsMet_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671022);
			PotActionBehaviour.NativeMethodInfoPtr_DoesTaskTypeRequireSupplies_Public_Boolean_EActionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671023);
			PotActionBehaviour.NativeMethodInfoPtr_DoesBotanistHaveMaterialsForTask_Public_Boolean_Botanist_Pot_EActionType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671024);
			PotActionBehaviour.NativeMethodInfoPtr_GetSoilInSupplies_Private_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671025);
			PotActionBehaviour.NativeMethodInfoPtr_GetSeedInSupplies_Private_ItemInstance_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671026);
			PotActionBehaviour.NativeMethodInfoPtr_GetAdditiveInSupplies_Private_ItemInstance_Pot_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671027);
			PotActionBehaviour.NativeMethodInfoPtr_CanPotBeWatered_Public_Boolean_Pot_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671028);
			PotActionBehaviour.NativeMethodInfoPtr_CanPotHaveSoilPour_Public_Boolean_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671029);
			PotActionBehaviour.NativeMethodInfoPtr_CanPotHaveSeedSown_Public_Boolean_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671030);
			PotActionBehaviour.NativeMethodInfoPtr_CanPotHaveAdditiveApplied_Public_Boolean_Pot_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671031);
			PotActionBehaviour.NativeMethodInfoPtr_CanPotBeHarvested_Public_Boolean_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671032);
			PotActionBehaviour.NativeMethodInfoPtr_DoesPotHaveValidDestination_Public_Boolean_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671033);
			PotActionBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671034);
			PotActionBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671035);
			PotActionBehaviour.NativeMethodInfoPtr__WalkToSupplies_b__38_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671036);
			PotActionBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671037);
			PotActionBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671038);
			PotActionBehaviour.NativeMethodInfoPtr__WalkToPot_b__40_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671039);
			PotActionBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671040);
			PotActionBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671041);
			PotActionBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671042);
			PotActionBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671043);
			PotActionBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, 100671044);
		}

		// Token: 0x170013AD RID: 5037
		// (get) Token: 0x06004025 RID: 16421 RVA: 0x00143598 File Offset: 0x00141798
		// (set) Token: 0x06004026 RID: 16422 RVA: 0x001435D4 File Offset: 0x001417D4
		public unsafe bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_set_Initialized_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170013AE RID: 5038
		// (get) Token: 0x06004027 RID: 16423 RVA: 0x00143614 File Offset: 0x00141814
		// (set) Token: 0x06004028 RID: 16424 RVA: 0x00143654 File Offset: 0x00141854
		public unsafe Pot AssignedPot
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_get_AssignedPot_Public_get_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 115150, RefRangeEnd = 115151, XrefRangeStart = 115150, XrefRangeEnd = 115151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_set_AssignedPot_Protected_set_Void_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170013AF RID: 5039
		// (get) Token: 0x06004029 RID: 16425 RVA: 0x00143698 File Offset: 0x00141898
		// (set) Token: 0x0600402A RID: 16426 RVA: 0x001436D4 File Offset: 0x001418D4
		public unsafe PotActionBehaviour.EActionType CurrentActionType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_get_CurrentActionType_Public_get_EActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_set_CurrentActionType_Protected_set_Void_EActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170013B0 RID: 5040
		// (get) Token: 0x0600402B RID: 16427 RVA: 0x00143714 File Offset: 0x00141914
		// (set) Token: 0x0600402C RID: 16428 RVA: 0x00143750 File Offset: 0x00141950
		public unsafe PotActionBehaviour.EState CurrentState
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_get_CurrentState_Public_get_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_set_CurrentState_Protected_set_Void_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600402D RID: 16429 RVA: 0x00143790 File Offset: 0x00141990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149153, XrefRangeEnd = 149162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotActionBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600402E RID: 16430 RVA: 0x001437CC File Offset: 0x001419CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149162, XrefRangeEnd = 149176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(Pot pot, PotActionBehaviour.EActionType actionType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotActionBehaviour.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Pot_EActionType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600402F RID: 16431 RVA: 0x00143828 File Offset: 0x00141A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149176, XrefRangeEnd = 149178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotActionBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004030 RID: 16432 RVA: 0x00143864 File Offset: 0x00141A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149178, XrefRangeEnd = 149180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotActionBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004031 RID: 16433 RVA: 0x001438A0 File Offset: 0x00141AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149180, XrefRangeEnd = 149182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotActionBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004032 RID: 16434 RVA: 0x001438DC File Offset: 0x00141ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotActionBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004033 RID: 16435 RVA: 0x00143918 File Offset: 0x00141B18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149182, XrefRangeEnd = 149184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotActionBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004034 RID: 16436 RVA: 0x00143954 File Offset: 0x00141B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149184, XrefRangeEnd = 149247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotActionBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004035 RID: 16437 RVA: 0x00143990 File Offset: 0x00141B90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 149284, RefRangeEnd = 149286, XrefRangeStart = 149247, XrefRangeEnd = 149284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_StartAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004036 RID: 16438 RVA: 0x001439C4 File Offset: 0x00141BC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 149293, RefRangeEnd = 149295, XrefRangeStart = 149286, XrefRangeEnd = 149293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopAllActions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_StopAllActions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004037 RID: 16439 RVA: 0x001439F8 File Offset: 0x00141BF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149327, RefRangeEnd = 149328, XrefRangeStart = 149295, XrefRangeEnd = 149327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WalkToSupplies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_WalkToSupplies_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004038 RID: 16440 RVA: 0x00143A2C File Offset: 0x00141C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149328, XrefRangeEnd = 149349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GrabItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_GrabItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004039 RID: 16441 RVA: 0x00143A60 File Offset: 0x00141C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149349, XrefRangeEnd = 149378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WalkToPot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_WalkToPot_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600403A RID: 16442 RVA: 0x00143A94 File Offset: 0x00141C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149378, XrefRangeEnd = 149399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_PerformAction_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600403B RID: 16443 RVA: 0x00143AC8 File Offset: 0x00141CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149399, XrefRangeEnd = 149508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_CompleteAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600403C RID: 16444 RVA: 0x00143AFC File Offset: 0x00141CFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 149536, RefRangeEnd = 149538, XrefRangeStart = 149508, XrefRangeEnd = 149536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopPerformAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_StopPerformAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600403D RID: 16445 RVA: 0x00143B30 File Offset: 0x00141D30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149543, RefRangeEnd = 149544, XrefRangeStart = 149538, XrefRangeEnd = 149543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetActionAnimation(PotActionBehaviour.EActionType actionType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref actionType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_GetActionAnimation_Private_String_EActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600403E RID: 16446 RVA: 0x00143B74 File Offset: 0x00141D74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149553, RefRangeEnd = 149554, XrefRangeStart = 149544, XrefRangeEnd = 149553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AvatarEquippable GetActionEquippable(PotActionBehaviour.EActionType actionType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref actionType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_GetActionEquippable_Private_AvatarEquippable_EActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr3) : null;
		}

		// Token: 0x0600403F RID: 16447 RVA: 0x00143BC0 File Offset: 0x00141DC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149564, RefRangeEnd = 149565, XrefRangeStart = 149554, XrefRangeEnd = 149564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetWaitTime(PotActionBehaviour.EActionType actionType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref actionType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_GetWaitTime_Public_Single_EActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004040 RID: 16448 RVA: 0x00143C0C File Offset: 0x00141E0C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 149574, RefRangeEnd = 149577, XrefRangeStart = 149565, XrefRangeEnd = 149574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanGetToSupplies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_CanGetToSupplies_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004041 RID: 16449 RVA: 0x00143C48 File Offset: 0x00141E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149577, XrefRangeEnd = 149583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtSupplies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_IsAtSupplies_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004042 RID: 16450 RVA: 0x00143C84 File Offset: 0x00141E84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 149602, RefRangeEnd = 149604, XrefRangeStart = 149583, XrefRangeEnd = 149602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ITransitEntity GetSuppliesAsTransitEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_GetSuppliesAsTransitEntity_Private_ITransitEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITransitEntity>(intPtr3) : null;
		}

		// Token: 0x06004043 RID: 16451 RVA: 0x00143CC4 File Offset: 0x00141EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149604, XrefRangeEnd = 149609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanGetToPot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_CanGetToPot_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004044 RID: 16452 RVA: 0x00143D00 File Offset: 0x00141F00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 149624, RefRangeEnd = 149626, XrefRangeStart = 149609, XrefRangeEnd = 149624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Transform GetPotAccessPoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_GetPotAccessPoint_Private_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x06004045 RID: 16453 RVA: 0x00143D40 File Offset: 0x00141F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149626, XrefRangeEnd = 149643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtPot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_IsAtPot_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004046 RID: 16454 RVA: 0x00143D7C File Offset: 0x00141F7C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 149676, RefRangeEnd = 149680, XrefRangeStart = 149643, XrefRangeEnd = 149676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetRequiredItemIDs(PotActionBehaviour.EActionType actionType, Pot pot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref actionType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_GetRequiredItemIDs_Private_Il2CppStringArray_EActionType_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06004047 RID: 16455 RVA: 0x00143DDC File Offset: 0x00141FDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149681, RefRangeEnd = 149682, XrefRangeStart = 149680, XrefRangeEnd = 149681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetRequiredItemIDs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_GetRequiredItemIDs_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x06004048 RID: 16456 RVA: 0x00143E1C File Offset: 0x0014201C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 149691, RefRangeEnd = 149693, XrefRangeStart = 149682, XrefRangeEnd = 149691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool AreActionConditionsMet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_AreActionConditionsMet_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004049 RID: 16457 RVA: 0x00143E58 File Offset: 0x00142058
		[CallerCount(0)]
		public unsafe bool DoesTaskTypeRequireSupplies(PotActionBehaviour.EActionType actionType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref actionType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_DoesTaskTypeRequireSupplies_Public_Boolean_EActionType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600404A RID: 16458 RVA: 0x00143EA4 File Offset: 0x001420A4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 149694, RefRangeEnd = 149699, XrefRangeStart = 149693, XrefRangeEnd = 149694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesBotanistHaveMaterialsForTask(Botanist botanist, Pot pot, PotActionBehaviour.EActionType actionType, int additiveNumber = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(botanist);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pot);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref actionType;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additiveNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_DoesBotanistHaveMaterialsForTask_Public_Boolean_Botanist_Pot_EActionType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600404B RID: 16459 RVA: 0x00143F20 File Offset: 0x00142120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149699, XrefRangeEnd = 149708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInstance GetSoilInSupplies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_GetSoilInSupplies_Private_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600404C RID: 16460 RVA: 0x00143F60 File Offset: 0x00142160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149708, XrefRangeEnd = 149719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInstance GetSeedInSupplies(Pot pot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_GetSeedInSupplies_Private_ItemInstance_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600404D RID: 16461 RVA: 0x00143FB0 File Offset: 0x001421B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149732, RefRangeEnd = 149733, XrefRangeStart = 149719, XrefRangeEnd = 149732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemInstance GetAdditiveInSupplies(Pot pot, int additiveNumber)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref additiveNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_GetAdditiveInSupplies_Private_ItemInstance_Pot_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600404E RID: 16462 RVA: 0x00144010 File Offset: 0x00142210
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149742, RefRangeEnd = 149743, XrefRangeStart = 149733, XrefRangeEnd = 149742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanPotBeWatered(Pot pot, float threshold)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref threshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_CanPotBeWatered_Public_Boolean_Pot_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600404F RID: 16463 RVA: 0x0014406C File Offset: 0x0014226C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149747, RefRangeEnd = 149748, XrefRangeStart = 149743, XrefRangeEnd = 149747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanPotHaveSoilPour(Pot pot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_CanPotHaveSoilPour_Public_Boolean_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004050 RID: 16464 RVA: 0x001440BC File Offset: 0x001422BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149756, RefRangeEnd = 149757, XrefRangeStart = 149748, XrefRangeEnd = 149756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanPotHaveSeedSown(Pot pot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_CanPotHaveSeedSown_Public_Boolean_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004051 RID: 16465 RVA: 0x0014410C File Offset: 0x0014230C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149779, RefRangeEnd = 149780, XrefRangeStart = 149757, XrefRangeEnd = 149779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanPotHaveAdditiveApplied(Pot pot, out int additiveNumber)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &additiveNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_CanPotHaveAdditiveApplied_Public_Boolean_Pot_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004052 RID: 16466 RVA: 0x00144168 File Offset: 0x00142368
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 149789, RefRangeEnd = 149790, XrefRangeStart = 149780, XrefRangeEnd = 149789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanPotBeHarvested(Pot pot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_CanPotBeHarvested_Public_Boolean_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004053 RID: 16467 RVA: 0x001441B8 File Offset: 0x001423B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149790, XrefRangeEnd = 149806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoesPotHaveValidDestination(Pot pot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(pot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_DoesPotHaveValidDestination_Public_Boolean_Pot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004054 RID: 16468 RVA: 0x00144208 File Offset: 0x00142408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149806, XrefRangeEnd = 149810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotActionBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004055 RID: 16469 RVA: 0x00144244 File Offset: 0x00142444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149810, XrefRangeEnd = 149815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004056 RID: 16470 RVA: 0x00144284 File Offset: 0x00142484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _WalkToSupplies_b__38_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr__WalkToSupplies_b__38_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004057 RID: 16471 RVA: 0x001442C0 File Offset: 0x001424C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149815, XrefRangeEnd = 149820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004058 RID: 16472 RVA: 0x00144300 File Offset: 0x00142500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149820, XrefRangeEnd = 149825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004059 RID: 16473 RVA: 0x00144340 File Offset: 0x00142540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _WalkToPot_b__40_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr__WalkToPot_b__40_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600405A RID: 16474 RVA: 0x0014437C File Offset: 0x0014257C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149825, XrefRangeEnd = 149830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_3, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600405B RID: 16475 RVA: 0x001443BC File Offset: 0x001425BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149830, XrefRangeEnd = 149831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotActionBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600405C RID: 16476 RVA: 0x001443F8 File Offset: 0x001425F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149831, XrefRangeEnd = 149832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotActionBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600405D RID: 16477 RVA: 0x00144434 File Offset: 0x00142634
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotActionBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600405E RID: 16478 RVA: 0x00144470 File Offset: 0x00142670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149832, XrefRangeEnd = 149841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotActionBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600405F RID: 16479 RVA: 0x0001FD59 File Offset: 0x0001DF59
		public PotActionBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700139D RID: 5021
		// (get) Token: 0x06004060 RID: 16480 RVA: 0x001444AC File Offset: 0x001426AC
		// (set) Token: 0x06004061 RID: 16481 RVA: 0x0001FD62 File Offset: 0x0001DF62
		public unsafe bool _Initialized_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr__Initialized_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr__Initialized_k__BackingField)) = value;
			}
		}

		// Token: 0x1700139E RID: 5022
		// (get) Token: 0x06004062 RID: 16482 RVA: 0x001444D4 File Offset: 0x001426D4
		// (set) Token: 0x06004063 RID: 16483 RVA: 0x0001FD7D File Offset: 0x0001DF7D
		public unsafe Pot _AssignedPot_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr__AssignedPot_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr__AssignedPot_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700139F RID: 5023
		// (get) Token: 0x06004064 RID: 16484 RVA: 0x00144504 File Offset: 0x00142704
		// (set) Token: 0x06004065 RID: 16485 RVA: 0x0001FD9C File Offset: 0x0001DF9C
		public unsafe PotActionBehaviour.EActionType _CurrentActionType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr__CurrentActionType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr__CurrentActionType_k__BackingField)) = value;
			}
		}

		// Token: 0x170013A0 RID: 5024
		// (get) Token: 0x06004066 RID: 16486 RVA: 0x0014452C File Offset: 0x0014272C
		// (set) Token: 0x06004067 RID: 16487 RVA: 0x0001FDB7 File Offset: 0x0001DFB7
		public unsafe PotActionBehaviour.EState _CurrentState_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr__CurrentState_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr__CurrentState_k__BackingField)) = value;
			}
		}

		// Token: 0x170013A1 RID: 5025
		// (get) Token: 0x06004068 RID: 16488 RVA: 0x00144554 File Offset: 0x00142754
		// (set) Token: 0x06004069 RID: 16489 RVA: 0x0001FDD2 File Offset: 0x0001DFD2
		public unsafe int AdditiveNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_AdditiveNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_AdditiveNumber)) = value;
			}
		}

		// Token: 0x170013A2 RID: 5026
		// (get) Token: 0x0600406A RID: 16490 RVA: 0x0014457C File Offset: 0x0014277C
		// (set) Token: 0x0600406B RID: 16491 RVA: 0x0001FDED File Offset: 0x0001DFED
		public unsafe AvatarEquippable WateringCanEquippable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_WateringCanEquippable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_WateringCanEquippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013A3 RID: 5027
		// (get) Token: 0x0600406C RID: 16492 RVA: 0x001445AC File Offset: 0x001427AC
		// (set) Token: 0x0600406D RID: 16493 RVA: 0x0001FE0C File Offset: 0x0001E00C
		public unsafe AvatarEquippable TrimmersEquippable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_TrimmersEquippable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_TrimmersEquippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013A4 RID: 5028
		// (get) Token: 0x0600406E RID: 16494 RVA: 0x001445DC File Offset: 0x001427DC
		// (set) Token: 0x0600406F RID: 16495 RVA: 0x0001FE2B File Offset: 0x0001E02B
		public unsafe Botanist botanist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_botanist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Botanist>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_botanist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013A5 RID: 5029
		// (get) Token: 0x06004070 RID: 16496 RVA: 0x0014460C File Offset: 0x0014280C
		// (set) Token: 0x06004071 RID: 16497 RVA: 0x0001FE4A File Offset: 0x0001E04A
		public unsafe Coroutine walkToSuppliesRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_walkToSuppliesRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_walkToSuppliesRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013A6 RID: 5030
		// (get) Token: 0x06004072 RID: 16498 RVA: 0x0014463C File Offset: 0x0014283C
		// (set) Token: 0x06004073 RID: 16499 RVA: 0x0001FE69 File Offset: 0x0001E069
		public unsafe Coroutine grabRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_grabRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_grabRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013A7 RID: 5031
		// (get) Token: 0x06004074 RID: 16500 RVA: 0x0014466C File Offset: 0x0014286C
		// (set) Token: 0x06004075 RID: 16501 RVA: 0x0001FE88 File Offset: 0x0001E088
		public unsafe Coroutine walkToPotRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_walkToPotRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_walkToPotRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013A8 RID: 5032
		// (get) Token: 0x06004076 RID: 16502 RVA: 0x0014469C File Offset: 0x0014289C
		// (set) Token: 0x06004077 RID: 16503 RVA: 0x0001FEA7 File Offset: 0x0001E0A7
		public unsafe Coroutine performActionRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_performActionRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_performActionRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013A9 RID: 5033
		// (get) Token: 0x06004078 RID: 16504 RVA: 0x001446CC File Offset: 0x001428CC
		// (set) Token: 0x06004079 RID: 16505 RVA: 0x0001FEC6 File Offset: 0x0001E0C6
		public unsafe string currentActionAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_currentActionAnimation);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_currentActionAnimation), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170013AA RID: 5034
		// (get) Token: 0x0600407A RID: 16506 RVA: 0x001446F4 File Offset: 0x001428F4
		// (set) Token: 0x0600407B RID: 16507 RVA: 0x0001FEE5 File Offset: 0x0001E0E5
		public unsafe AvatarEquippable currentActionEquippable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_currentActionEquippable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarEquippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_currentActionEquippable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013AB RID: 5035
		// (get) Token: 0x0600407C RID: 16508 RVA: 0x00144724 File Offset: 0x00142924
		// (set) Token: 0x0600407D RID: 16509 RVA: 0x0001FF04 File Offset: 0x0001E104
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170013AC RID: 5036
		// (get) Token: 0x0600407E RID: 16510 RVA: 0x0014474C File Offset: 0x0014294C
		// (set) Token: 0x0600407F RID: 16511 RVA: 0x0001FF1F File Offset: 0x0001E11F
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002AAE RID: 10926
		private static readonly IntPtr NativeFieldInfoPtr__Initialized_k__BackingField;

		// Token: 0x04002AAF RID: 10927
		private static readonly IntPtr NativeFieldInfoPtr__AssignedPot_k__BackingField;

		// Token: 0x04002AB0 RID: 10928
		private static readonly IntPtr NativeFieldInfoPtr__CurrentActionType_k__BackingField;

		// Token: 0x04002AB1 RID: 10929
		private static readonly IntPtr NativeFieldInfoPtr__CurrentState_k__BackingField;

		// Token: 0x04002AB2 RID: 10930
		private static readonly IntPtr NativeFieldInfoPtr_AdditiveNumber;

		// Token: 0x04002AB3 RID: 10931
		private static readonly IntPtr NativeFieldInfoPtr_WateringCanEquippable;

		// Token: 0x04002AB4 RID: 10932
		private static readonly IntPtr NativeFieldInfoPtr_TrimmersEquippable;

		// Token: 0x04002AB5 RID: 10933
		private static readonly IntPtr NativeFieldInfoPtr_botanist;

		// Token: 0x04002AB6 RID: 10934
		private static readonly IntPtr NativeFieldInfoPtr_walkToSuppliesRoutine;

		// Token: 0x04002AB7 RID: 10935
		private static readonly IntPtr NativeFieldInfoPtr_grabRoutine;

		// Token: 0x04002AB8 RID: 10936
		private static readonly IntPtr NativeFieldInfoPtr_walkToPotRoutine;

		// Token: 0x04002AB9 RID: 10937
		private static readonly IntPtr NativeFieldInfoPtr_performActionRoutine;

		// Token: 0x04002ABA RID: 10938
		private static readonly IntPtr NativeFieldInfoPtr_currentActionAnimation;

		// Token: 0x04002ABB RID: 10939
		private static readonly IntPtr NativeFieldInfoPtr_currentActionEquippable;

		// Token: 0x04002ABC RID: 10940
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002ABD RID: 10941
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002ABE RID: 10942
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_get_Boolean_0;

		// Token: 0x04002ABF RID: 10943
		private static readonly IntPtr NativeMethodInfoPtr_set_Initialized_Protected_set_Void_Boolean_0;

		// Token: 0x04002AC0 RID: 10944
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedPot_Public_get_Pot_0;

		// Token: 0x04002AC1 RID: 10945
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedPot_Protected_set_Void_Pot_0;

		// Token: 0x04002AC2 RID: 10946
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentActionType_Public_get_EActionType_0;

		// Token: 0x04002AC3 RID: 10947
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentActionType_Protected_set_Void_EActionType_0;

		// Token: 0x04002AC4 RID: 10948
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentState_Public_get_EState_0;

		// Token: 0x04002AC5 RID: 10949
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentState_Protected_set_Void_EState_0;

		// Token: 0x04002AC6 RID: 10950
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04002AC7 RID: 10951
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_Pot_EActionType_0;

		// Token: 0x04002AC8 RID: 10952
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1;

		// Token: 0x04002AC9 RID: 10953
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1;

		// Token: 0x04002ACA RID: 10954
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1;

		// Token: 0x04002ACB RID: 10955
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04002ACC RID: 10956
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_1;

		// Token: 0x04002ACD RID: 10957
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002ACE RID: 10958
		private static readonly IntPtr NativeMethodInfoPtr_StartAction_Private_Void_0;

		// Token: 0x04002ACF RID: 10959
		private static readonly IntPtr NativeMethodInfoPtr_StopAllActions_Private_Void_0;

		// Token: 0x04002AD0 RID: 10960
		private static readonly IntPtr NativeMethodInfoPtr_WalkToSupplies_Public_Void_0;

		// Token: 0x04002AD1 RID: 10961
		private static readonly IntPtr NativeMethodInfoPtr_GrabItem_Public_Void_0;

		// Token: 0x04002AD2 RID: 10962
		private static readonly IntPtr NativeMethodInfoPtr_WalkToPot_Public_Void_0;

		// Token: 0x04002AD3 RID: 10963
		private static readonly IntPtr NativeMethodInfoPtr_PerformAction_Public_Void_0;

		// Token: 0x04002AD4 RID: 10964
		private static readonly IntPtr NativeMethodInfoPtr_CompleteAction_Private_Void_0;

		// Token: 0x04002AD5 RID: 10965
		private static readonly IntPtr NativeMethodInfoPtr_StopPerformAction_Private_Void_0;

		// Token: 0x04002AD6 RID: 10966
		private static readonly IntPtr NativeMethodInfoPtr_GetActionAnimation_Private_String_EActionType_0;

		// Token: 0x04002AD7 RID: 10967
		private static readonly IntPtr NativeMethodInfoPtr_GetActionEquippable_Private_AvatarEquippable_EActionType_0;

		// Token: 0x04002AD8 RID: 10968
		private static readonly IntPtr NativeMethodInfoPtr_GetWaitTime_Public_Single_EActionType_0;

		// Token: 0x04002AD9 RID: 10969
		private static readonly IntPtr NativeMethodInfoPtr_CanGetToSupplies_Public_Boolean_0;

		// Token: 0x04002ADA RID: 10970
		private static readonly IntPtr NativeMethodInfoPtr_IsAtSupplies_Private_Boolean_0;

		// Token: 0x04002ADB RID: 10971
		private static readonly IntPtr NativeMethodInfoPtr_GetSuppliesAsTransitEntity_Private_ITransitEntity_0;

		// Token: 0x04002ADC RID: 10972
		private static readonly IntPtr NativeMethodInfoPtr_CanGetToPot_Public_Boolean_0;

		// Token: 0x04002ADD RID: 10973
		private static readonly IntPtr NativeMethodInfoPtr_GetPotAccessPoint_Private_Transform_0;

		// Token: 0x04002ADE RID: 10974
		private static readonly IntPtr NativeMethodInfoPtr_IsAtPot_Private_Boolean_0;

		// Token: 0x04002ADF RID: 10975
		private static readonly IntPtr NativeMethodInfoPtr_GetRequiredItemIDs_Private_Il2CppStringArray_EActionType_Pot_0;

		// Token: 0x04002AE0 RID: 10976
		private static readonly IntPtr NativeMethodInfoPtr_GetRequiredItemIDs_Private_Il2CppStringArray_0;

		// Token: 0x04002AE1 RID: 10977
		private static readonly IntPtr NativeMethodInfoPtr_AreActionConditionsMet_Private_Boolean_0;

		// Token: 0x04002AE2 RID: 10978
		private static readonly IntPtr NativeMethodInfoPtr_DoesTaskTypeRequireSupplies_Public_Boolean_EActionType_0;

		// Token: 0x04002AE3 RID: 10979
		private static readonly IntPtr NativeMethodInfoPtr_DoesBotanistHaveMaterialsForTask_Public_Boolean_Botanist_Pot_EActionType_Int32_0;

		// Token: 0x04002AE4 RID: 10980
		private static readonly IntPtr NativeMethodInfoPtr_GetSoilInSupplies_Private_ItemInstance_0;

		// Token: 0x04002AE5 RID: 10981
		private static readonly IntPtr NativeMethodInfoPtr_GetSeedInSupplies_Private_ItemInstance_Pot_0;

		// Token: 0x04002AE6 RID: 10982
		private static readonly IntPtr NativeMethodInfoPtr_GetAdditiveInSupplies_Private_ItemInstance_Pot_Int32_0;

		// Token: 0x04002AE7 RID: 10983
		private static readonly IntPtr NativeMethodInfoPtr_CanPotBeWatered_Public_Boolean_Pot_Single_0;

		// Token: 0x04002AE8 RID: 10984
		private static readonly IntPtr NativeMethodInfoPtr_CanPotHaveSoilPour_Public_Boolean_Pot_0;

		// Token: 0x04002AE9 RID: 10985
		private static readonly IntPtr NativeMethodInfoPtr_CanPotHaveSeedSown_Public_Boolean_Pot_0;

		// Token: 0x04002AEA RID: 10986
		private static readonly IntPtr NativeMethodInfoPtr_CanPotHaveAdditiveApplied_Public_Boolean_Pot_byref_Int32_0;

		// Token: 0x04002AEB RID: 10987
		private static readonly IntPtr NativeMethodInfoPtr_CanPotBeHarvested_Public_Boolean_Pot_0;

		// Token: 0x04002AEC RID: 10988
		private static readonly IntPtr NativeMethodInfoPtr_DoesPotHaveValidDestination_Public_Boolean_Pot_0;

		// Token: 0x04002AED RID: 10989
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002AEE RID: 10990
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04002AEF RID: 10991
		private static readonly IntPtr NativeMethodInfoPtr__WalkToSupplies_b__38_1_Private_Boolean_0;

		// Token: 0x04002AF0 RID: 10992
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x04002AF1 RID: 10993
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_2;

		// Token: 0x04002AF2 RID: 10994
		private static readonly IntPtr NativeMethodInfoPtr__WalkToPot_b__40_1_Private_Boolean_0;

		// Token: 0x04002AF3 RID: 10995
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_3;

		// Token: 0x04002AF4 RID: 10996
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002AF5 RID: 10997
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002AF6 RID: 10998
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002AF7 RID: 10999
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x0200094F RID: 2383
		[OriginalName("Assembly-CSharp.dll", "", "EActionType")]
		public enum EActionType
		{
			// Token: 0x04008783 RID: 34691
			None,
			// Token: 0x04008784 RID: 34692
			PourSoil,
			// Token: 0x04008785 RID: 34693
			SowSeed,
			// Token: 0x04008786 RID: 34694
			Water,
			// Token: 0x04008787 RID: 34695
			ApplyAdditive,
			// Token: 0x04008788 RID: 34696
			Harvest
		}

		// Token: 0x02000950 RID: 2384
		[OriginalName("Assembly-CSharp.dll", "", "EState")]
		public enum EState
		{
			// Token: 0x0400878A RID: 34698
			Idle,
			// Token: 0x0400878B RID: 34699
			WalkingToSupplies,
			// Token: 0x0400878C RID: 34700
			GrabbingSupplies,
			// Token: 0x0400878D RID: 34701
			WalkingToPot,
			// Token: 0x0400878E RID: 34702
			PerformingAction,
			// Token: 0x0400878F RID: 34703
			WalkingToDestination
		}

		// Token: 0x02000951 RID: 2385
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.PotActionBehaviour+<<GrabItem>g__Routine|39_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0 : Il2CppSystem.Object
		{
			// Token: 0x0600C83B RID: 51259 RVA: 0x0030892C File Offset: 0x00306B2C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0()
			{
				Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "<<GrabItem>g__Routine|39_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0>.NativeClassPtr);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0>.NativeClassPtr, "<>1__state");
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0>.NativeClassPtr, "<>2__current");
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0>.NativeClassPtr, "<>4__this");
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0>.NativeClassPtr, 100671045);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0>.NativeClassPtr, 100671046);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0>.NativeClassPtr, 100671047);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0>.NativeClassPtr, 100671048);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0>.NativeClassPtr, 100671049);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0>.NativeClassPtr, 100671050);
			}

			// Token: 0x0600C83C RID: 51260 RVA: 0x00308A0C File Offset: 0x00306C0C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C83D RID: 51261 RVA: 0x00308A54 File Offset: 0x00306C54
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C83E RID: 51262 RVA: 0x00308A88 File Offset: 0x00306C88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149057, XrefRangeEnd = 149088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003E72 RID: 15986
			// (get) Token: 0x0600C83F RID: 51263 RVA: 0x00308AC4 File Offset: 0x00306CC4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C840 RID: 51264 RVA: 0x00308B04 File Offset: 0x00306D04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149088, XrefRangeEnd = 149093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003E73 RID: 15987
			// (get) Token: 0x0600C841 RID: 51265 RVA: 0x00308B38 File Offset: 0x00306D38
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C842 RID: 51266 RVA: 0x0006166A File Offset: 0x0005F86A
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E6F RID: 15983
			// (get) Token: 0x0600C843 RID: 51267 RVA: 0x00308B78 File Offset: 0x00306D78
			// (set) Token: 0x0600C844 RID: 51268 RVA: 0x00061673 File Offset: 0x0005F873
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E70 RID: 15984
			// (get) Token: 0x0600C845 RID: 51269 RVA: 0x00308BA0 File Offset: 0x00306DA0
			// (set) Token: 0x0600C846 RID: 51270 RVA: 0x0006168E File Offset: 0x0005F88E
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E71 RID: 15985
			// (get) Token: 0x0600C847 RID: 51271 RVA: 0x00308BD0 File Offset: 0x00306DD0
			// (set) Token: 0x0600C848 RID: 51272 RVA: 0x000616AD File Offset: 0x0005F8AD
			public unsafe PotActionBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotActionBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008790 RID: 34704
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008791 RID: 34705
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008792 RID: 34706
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008793 RID: 34707
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008794 RID: 34708
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008795 RID: 34709
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008796 RID: 34710
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008797 RID: 34711
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008798 RID: 34712
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000952 RID: 2386
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.PotActionBehaviour+<<PerformAction>g__Routine|41_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C849 RID: 51273 RVA: 0x00308C00 File Offset: 0x00306E00
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique()
			{
				Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "<<PerformAction>g__Routine|41_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique>.NativeClassPtr);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique>.NativeClassPtr, "<>1__state");
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique>.NativeClassPtr, "<>2__current");
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique>.NativeClassPtr, "<>4__this");
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeFieldInfoPtr__waitTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique>.NativeClassPtr, "<waitTime>5__2");
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique>.NativeClassPtr, "<i>5__3");
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique>.NativeClassPtr, 100671051);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique>.NativeClassPtr, 100671052);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique>.NativeClassPtr, 100671053);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique>.NativeClassPtr, 100671054);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique>.NativeClassPtr, 100671055);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique>.NativeClassPtr, 100671056);
			}

			// Token: 0x0600C84A RID: 51274 RVA: 0x00308D08 File Offset: 0x00306F08
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C84B RID: 51275 RVA: 0x00308D50 File Offset: 0x00306F50
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C84C RID: 51276 RVA: 0x00308D84 File Offset: 0x00306F84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149093, XrefRangeEnd = 149128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003E79 RID: 15993
			// (get) Token: 0x0600C84D RID: 51277 RVA: 0x00308DC0 File Offset: 0x00306FC0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C84E RID: 51278 RVA: 0x00308E00 File Offset: 0x00307000
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149128, XrefRangeEnd = 149133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003E7A RID: 15994
			// (get) Token: 0x0600C84F RID: 51279 RVA: 0x00308E34 File Offset: 0x00307034
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C850 RID: 51280 RVA: 0x000616CC File Offset: 0x0005F8CC
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E74 RID: 15988
			// (get) Token: 0x0600C851 RID: 51281 RVA: 0x00308E74 File Offset: 0x00307074
			// (set) Token: 0x0600C852 RID: 51282 RVA: 0x000616D5 File Offset: 0x0005F8D5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E75 RID: 15989
			// (get) Token: 0x0600C853 RID: 51283 RVA: 0x00308E9C File Offset: 0x0030709C
			// (set) Token: 0x0600C854 RID: 51284 RVA: 0x000616F0 File Offset: 0x0005F8F0
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E76 RID: 15990
			// (get) Token: 0x0600C855 RID: 51285 RVA: 0x00308ECC File Offset: 0x003070CC
			// (set) Token: 0x0600C856 RID: 51286 RVA: 0x0006170F File Offset: 0x0005F90F
			public unsafe PotActionBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotActionBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E77 RID: 15991
			// (get) Token: 0x0600C857 RID: 51287 RVA: 0x00308EFC File Offset: 0x003070FC
			// (set) Token: 0x0600C858 RID: 51288 RVA: 0x0006172E File Offset: 0x0005F92E
			public unsafe float _waitTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeFieldInfoPtr__waitTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeFieldInfoPtr__waitTime_5__2)) = value;
				}
			}

			// Token: 0x17003E78 RID: 15992
			// (get) Token: 0x0600C859 RID: 51289 RVA: 0x00308F24 File Offset: 0x00307124
			// (set) Token: 0x0600C85A RID: 51290 RVA: 0x00061749 File Offset: 0x0005F949
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04008799 RID: 34713
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400879A RID: 34714
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400879B RID: 34715
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400879C RID: 34716
			private static readonly IntPtr NativeFieldInfoPtr__waitTime_5__2;

			// Token: 0x0400879D RID: 34717
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x0400879E RID: 34718
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400879F RID: 34719
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087A0 RID: 34720
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040087A1 RID: 34721
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040087A2 RID: 34722
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087A3 RID: 34723
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000953 RID: 2387
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.PotActionBehaviour+<<WalkToPot>g__Routine|40_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1 : Il2CppSystem.Object
		{
			// Token: 0x0600C85B RID: 51291 RVA: 0x00308F4C File Offset: 0x0030714C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1()
			{
				Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "<<WalkToPot>g__Routine|40_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1>.NativeClassPtr);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1>.NativeClassPtr, "<>1__state");
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1>.NativeClassPtr, "<>2__current");
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1>.NativeClassPtr, "<>4__this");
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1>.NativeClassPtr, 100671057);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1>.NativeClassPtr, 100671058);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1>.NativeClassPtr, 100671059);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1>.NativeClassPtr, 100671060);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1>.NativeClassPtr, 100671061);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1>.NativeClassPtr, 100671062);
			}

			// Token: 0x0600C85C RID: 51292 RVA: 0x0030902C File Offset: 0x0030722C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C85D RID: 51293 RVA: 0x00309074 File Offset: 0x00307274
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C85E RID: 51294 RVA: 0x003090A8 File Offset: 0x003072A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149133, XrefRangeEnd = 149138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003E7E RID: 15998
			// (get) Token: 0x0600C85F RID: 51295 RVA: 0x003090E4 File Offset: 0x003072E4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C860 RID: 51296 RVA: 0x00309124 File Offset: 0x00307324
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149138, XrefRangeEnd = 149143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003E7F RID: 15999
			// (get) Token: 0x0600C861 RID: 51297 RVA: 0x00309158 File Offset: 0x00307358
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C862 RID: 51298 RVA: 0x00061764 File Offset: 0x0005F964
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E7B RID: 15995
			// (get) Token: 0x0600C863 RID: 51299 RVA: 0x00309198 File Offset: 0x00307398
			// (set) Token: 0x0600C864 RID: 51300 RVA: 0x0006176D File Offset: 0x0005F96D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E7C RID: 15996
			// (get) Token: 0x0600C865 RID: 51301 RVA: 0x003091C0 File Offset: 0x003073C0
			// (set) Token: 0x0600C866 RID: 51302 RVA: 0x00061788 File Offset: 0x0005F988
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E7D RID: 15997
			// (get) Token: 0x0600C867 RID: 51303 RVA: 0x003091F0 File Offset: 0x003073F0
			// (set) Token: 0x0600C868 RID: 51304 RVA: 0x000617A7 File Offset: 0x0005F9A7
			public unsafe PotActionBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotActionBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040087A4 RID: 34724
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040087A5 RID: 34725
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040087A6 RID: 34726
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040087A7 RID: 34727
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040087A8 RID: 34728
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087A9 RID: 34729
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040087AA RID: 34730
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040087AB RID: 34731
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087AC RID: 34732
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000954 RID: 2388
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.PotActionBehaviour+<<WalkToSupplies>g__Routine|38_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2 : Il2CppSystem.Object
		{
			// Token: 0x0600C869 RID: 51305 RVA: 0x00309220 File Offset: 0x00307420
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2()
			{
				Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "<<WalkToSupplies>g__Routine|38_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2>.NativeClassPtr);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2>.NativeClassPtr, "<>1__state");
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2>.NativeClassPtr, "<>2__current");
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2>.NativeClassPtr, "<>4__this");
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2>.NativeClassPtr, 100671063);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2>.NativeClassPtr, 100671064);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2>.NativeClassPtr, 100671065);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2>.NativeClassPtr, 100671066);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2>.NativeClassPtr, 100671067);
				PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2>.NativeClassPtr, 100671068);
			}

			// Token: 0x0600C86A RID: 51306 RVA: 0x00309300 File Offset: 0x00307500
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C86B RID: 51307 RVA: 0x00309348 File Offset: 0x00307548
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C86C RID: 51308 RVA: 0x0030937C File Offset: 0x0030757C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149143, XrefRangeEnd = 149148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003E83 RID: 16003
			// (get) Token: 0x0600C86D RID: 51309 RVA: 0x003093B8 File Offset: 0x003075B8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C86E RID: 51310 RVA: 0x003093F8 File Offset: 0x003075F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 149148, XrefRangeEnd = 149153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003E84 RID: 16004
			// (get) Token: 0x0600C86F RID: 51311 RVA: 0x0030942C File Offset: 0x0030762C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C870 RID: 51312 RVA: 0x000617C6 File Offset: 0x0005F9C6
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E80 RID: 16000
			// (get) Token: 0x0600C871 RID: 51313 RVA: 0x0030946C File Offset: 0x0030766C
			// (set) Token: 0x0600C872 RID: 51314 RVA: 0x000617CF File Offset: 0x0005F9CF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E81 RID: 16001
			// (get) Token: 0x0600C873 RID: 51315 RVA: 0x00309494 File Offset: 0x00307694
			// (set) Token: 0x0600C874 RID: 51316 RVA: 0x000617EA File Offset: 0x0005F9EA
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E82 RID: 16002
			// (get) Token: 0x0600C875 RID: 51317 RVA: 0x003094C4 File Offset: 0x003076C4
			// (set) Token: 0x0600C876 RID: 51318 RVA: 0x00061809 File Offset: 0x0005FA09
			public unsafe PotActionBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotActionBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotActionBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPoVoObMoInVoBoOb2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040087AD RID: 34733
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040087AE RID: 34734
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040087AF RID: 34735
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040087B0 RID: 34736
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040087B1 RID: 34737
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087B2 RID: 34738
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040087B3 RID: 34739
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040087B4 RID: 34740
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087B5 RID: 34741
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000955 RID: 2389
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.PotActionBehaviour+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C877 RID: 51319 RVA: 0x003094F4 File Offset: 0x003076F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PotActionBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PotActionBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotActionBehaviour.__c>.NativeClassPtr);
				PotActionBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.__c>.NativeClassPtr, "<>9");
				PotActionBehaviour.__c.NativeFieldInfoPtr___9__53_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotActionBehaviour.__c>.NativeClassPtr, "<>9__53_0");
				PotActionBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.__c>.NativeClassPtr, 100671070);
				PotActionBehaviour.__c.NativeMethodInfoPtr__GetRequiredItemIDs_b__53_0_Internal_String_SeedDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotActionBehaviour.__c>.NativeClassPtr, 100671071);
			}

			// Token: 0x0600C878 RID: 51320 RVA: 0x00309570 File Offset: 0x00307770
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotActionBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C879 RID: 51321 RVA: 0x003095AC File Offset: 0x003077AC
			[CallerCount(0)]
			public unsafe string _GetRequiredItemIDs_b__53_0(SeedDefinition x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotActionBehaviour.__c.NativeMethodInfoPtr__GetRequiredItemIDs_b__53_0_Internal_String_SeedDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600C87A RID: 51322 RVA: 0x00061828 File Offset: 0x0005FA28
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E85 RID: 16005
			// (get) Token: 0x0600C87B RID: 51323 RVA: 0x003095F4 File Offset: 0x003077F4
			// (set) Token: 0x0600C87C RID: 51324 RVA: 0x00061831 File Offset: 0x0005FA31
			public unsafe static PotActionBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PotActionBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotActionBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PotActionBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E86 RID: 16006
			// (get) Token: 0x0600C87D RID: 51325 RVA: 0x0030961C File Offset: 0x0030781C
			// (set) Token: 0x0600C87E RID: 51326 RVA: 0x00061843 File Offset: 0x0005FA43
			public unsafe static Converter<SeedDefinition, string> __9__53_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PotActionBehaviour.__c.NativeFieldInfoPtr___9__53_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Converter<SeedDefinition, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PotActionBehaviour.__c.NativeFieldInfoPtr___9__53_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040087B6 RID: 34742
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040087B7 RID: 34743
			private static readonly IntPtr NativeFieldInfoPtr___9__53_0;

			// Token: 0x040087B8 RID: 34744
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040087B9 RID: 34745
			private static readonly IntPtr NativeMethodInfoPtr__GetRequiredItemIDs_b__53_0_Internal_String_SeedDefinition_0;
		}
	}
}
