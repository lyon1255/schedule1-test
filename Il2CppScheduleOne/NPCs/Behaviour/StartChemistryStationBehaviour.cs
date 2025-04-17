using System;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000351 RID: 849
	public class StartChemistryStationBehaviour : Behaviour
	{
		// Token: 0x060040A8 RID: 16552 RVA: 0x00145144 File Offset: 0x00143344
		// Note: this type is marked as 'beforefieldinit'.
		static StartChemistryStationBehaviour()
		{
			Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "StartChemistryStationBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr);
			StartChemistryStationBehaviour.NativeFieldInfoPtr_PLACE_INGREDIENTS_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, "PLACE_INGREDIENTS_TIME");
			StartChemistryStationBehaviour.NativeFieldInfoPtr_STIR_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, "STIR_TIME");
			StartChemistryStationBehaviour.NativeFieldInfoPtr_BURNER_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, "BURNER_TIME");
			StartChemistryStationBehaviour.NativeFieldInfoPtr__targetStation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, "<targetStation>k__BackingField");
			StartChemistryStationBehaviour.NativeFieldInfoPtr_chemist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, "chemist");
			StartChemistryStationBehaviour.NativeFieldInfoPtr_cookRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, "cookRoutine");
			StartChemistryStationBehaviour.NativeFieldInfoPtr_beaker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, "beaker");
			StartChemistryStationBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StartChemistryStationBehaviourAssembly-CSharp.dll_Excuted");
			StartChemistryStationBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StartChemistryStationBehaviourAssembly-CSharp.dll_Excuted");
			StartChemistryStationBehaviour.NativeMethodInfoPtr_get_targetStation_Public_get_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100671104);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_set_targetStation_Private_set_Void_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100671105);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100671106);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_SetTargetStation_Public_Void_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100671107);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100671108);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100671109);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100671110);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_StartCook_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100671111);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_SetupBeaker_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100671112);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_FillBeaker_Private_Void_StationRecipe_Beaker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100671113);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_CanCookStart_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100671114);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_StopCook_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100671115);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_GetStationAccessPoint_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100671116);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_IsAtStation_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100671117);
			StartChemistryStationBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100671118);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100671119);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100671120);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100671121);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100671122);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_StartCook_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100671123);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_RpcLogic___StartCook_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100671124);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_RpcReader___Observers_StartCook_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100671125);
			StartChemistryStationBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, 100671126);
		}

		// Token: 0x170013C2 RID: 5058
		// (get) Token: 0x060040A9 RID: 16553 RVA: 0x001453F4 File Offset: 0x001435F4
		// (set) Token: 0x060040AA RID: 16554 RVA: 0x00145434 File Offset: 0x00143634
		public unsafe ChemistryStation targetStation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.NativeMethodInfoPtr_get_targetStation_Public_get_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChemistryStation>(intPtr3) : null;
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 115138, RefRangeEnd = 115149, XrefRangeStart = 115138, XrefRangeEnd = 115149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.NativeMethodInfoPtr_set_targetStation_Private_set_Void_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060040AB RID: 16555 RVA: 0x00145478 File Offset: 0x00143678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150136, XrefRangeEnd = 150145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartChemistryStationBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040AC RID: 16556 RVA: 0x001454B4 File Offset: 0x001436B4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 115138, RefRangeEnd = 115149, XrefRangeStart = 115138, XrefRangeEnd = 115149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetStation(ChemistryStation station)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.NativeMethodInfoPtr_SetTargetStation_Public_Void_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040AD RID: 16557 RVA: 0x001454F8 File Offset: 0x001436F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150145, XrefRangeEnd = 150159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartChemistryStationBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040AE RID: 16558 RVA: 0x00145534 File Offset: 0x00143734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150159, XrefRangeEnd = 150196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartChemistryStationBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040AF RID: 16559 RVA: 0x00145570 File Offset: 0x00143770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150196, XrefRangeEnd = 150200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartChemistryStationBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040B0 RID: 16560 RVA: 0x001455AC File Offset: 0x001437AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150200, XrefRangeEnd = 150221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartCook()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.NativeMethodInfoPtr_StartCook_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040B1 RID: 16561 RVA: 0x001455E0 File Offset: 0x001437E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150221, XrefRangeEnd = 150236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupBeaker()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.NativeMethodInfoPtr_SetupBeaker_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040B2 RID: 16562 RVA: 0x00145614 File Offset: 0x00143814
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 150289, RefRangeEnd = 150290, XrefRangeStart = 150236, XrefRangeEnd = 150289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FillBeaker(StationRecipe recipe, Beaker beaker)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beaker);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.NativeMethodInfoPtr_FillBeaker_Private_Void_StationRecipe_Beaker_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040B3 RID: 16563 RVA: 0x00145668 File Offset: 0x00143868
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 150311, RefRangeEnd = 150312, XrefRangeStart = 150290, XrefRangeEnd = 150311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanCookStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.NativeMethodInfoPtr_CanCookStart_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060040B4 RID: 16564 RVA: 0x001456A4 File Offset: 0x001438A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150319, RefRangeEnd = 150321, XrefRangeStart = 150312, XrefRangeEnd = 150319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCook()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.NativeMethodInfoPtr_StopCook_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040B5 RID: 16565 RVA: 0x001456D8 File Offset: 0x001438D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150329, RefRangeEnd = 150331, XrefRangeStart = 150321, XrefRangeEnd = 150329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetStationAccessPoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.NativeMethodInfoPtr_GetStationAccessPoint_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060040B6 RID: 16566 RVA: 0x00145714 File Offset: 0x00143914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150331, XrefRangeEnd = 150344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtStation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.NativeMethodInfoPtr_IsAtStation_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060040B7 RID: 16567 RVA: 0x00145750 File Offset: 0x00143950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StartChemistryStationBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040B8 RID: 16568 RVA: 0x0014578C File Offset: 0x0014398C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150344, XrefRangeEnd = 150349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060040B9 RID: 16569 RVA: 0x001457CC File Offset: 0x001439CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150349, XrefRangeEnd = 150357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartChemistryStationBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040BA RID: 16570 RVA: 0x00145808 File Offset: 0x00143A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartChemistryStationBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040BB RID: 16571 RVA: 0x00145844 File Offset: 0x00143A44
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartChemistryStationBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040BC RID: 16572 RVA: 0x00145880 File Offset: 0x00143A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150357, XrefRangeEnd = 150375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartCook_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_StartCook_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040BD RID: 16573 RVA: 0x001458B4 File Offset: 0x00143AB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 150386, RefRangeEnd = 150389, XrefRangeStart = 150375, XrefRangeEnd = 150386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartCook_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.NativeMethodInfoPtr_RpcLogic___StartCook_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040BE RID: 16574 RVA: 0x001458E8 File Offset: 0x00143AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150389, XrefRangeEnd = 150392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartCook_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.NativeMethodInfoPtr_RpcReader___Observers_StartCook_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040BF RID: 16575 RVA: 0x00145938 File Offset: 0x00143B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150392, XrefRangeEnd = 150401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartChemistryStationBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040C0 RID: 16576 RVA: 0x0001FFE0 File Offset: 0x0001E1E0
		public StartChemistryStationBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170013B9 RID: 5049
		// (get) Token: 0x060040C1 RID: 16577 RVA: 0x00145974 File Offset: 0x00143B74
		// (set) Token: 0x060040C2 RID: 16578 RVA: 0x0001FFE9 File Offset: 0x0001E1E9
		public unsafe static float PLACE_INGREDIENTS_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StartChemistryStationBehaviour.NativeFieldInfoPtr_PLACE_INGREDIENTS_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StartChemistryStationBehaviour.NativeFieldInfoPtr_PLACE_INGREDIENTS_TIME, (void*)(&value));
			}
		}

		// Token: 0x170013BA RID: 5050
		// (get) Token: 0x060040C3 RID: 16579 RVA: 0x00145990 File Offset: 0x00143B90
		// (set) Token: 0x060040C4 RID: 16580 RVA: 0x0001FFF7 File Offset: 0x0001E1F7
		public unsafe static float STIR_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StartChemistryStationBehaviour.NativeFieldInfoPtr_STIR_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StartChemistryStationBehaviour.NativeFieldInfoPtr_STIR_TIME, (void*)(&value));
			}
		}

		// Token: 0x170013BB RID: 5051
		// (get) Token: 0x060040C5 RID: 16581 RVA: 0x001459AC File Offset: 0x00143BAC
		// (set) Token: 0x060040C6 RID: 16582 RVA: 0x00020005 File Offset: 0x0001E205
		public unsafe static float BURNER_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StartChemistryStationBehaviour.NativeFieldInfoPtr_BURNER_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StartChemistryStationBehaviour.NativeFieldInfoPtr_BURNER_TIME, (void*)(&value));
			}
		}

		// Token: 0x170013BC RID: 5052
		// (get) Token: 0x060040C7 RID: 16583 RVA: 0x001459C8 File Offset: 0x00143BC8
		// (set) Token: 0x060040C8 RID: 16584 RVA: 0x00020013 File Offset: 0x0001E213
		public unsafe ChemistryStation _targetStation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.NativeFieldInfoPtr__targetStation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistryStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.NativeFieldInfoPtr__targetStation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013BD RID: 5053
		// (get) Token: 0x060040C9 RID: 16585 RVA: 0x001459F8 File Offset: 0x00143BF8
		// (set) Token: 0x060040CA RID: 16586 RVA: 0x00020032 File Offset: 0x0001E232
		public unsafe Chemist chemist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.NativeFieldInfoPtr_chemist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Chemist>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.NativeFieldInfoPtr_chemist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013BE RID: 5054
		// (get) Token: 0x060040CB RID: 16587 RVA: 0x00145A28 File Offset: 0x00143C28
		// (set) Token: 0x060040CC RID: 16588 RVA: 0x00020051 File Offset: 0x0001E251
		public unsafe Coroutine cookRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.NativeFieldInfoPtr_cookRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.NativeFieldInfoPtr_cookRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013BF RID: 5055
		// (get) Token: 0x060040CD RID: 16589 RVA: 0x00145A58 File Offset: 0x00143C58
		// (set) Token: 0x060040CE RID: 16590 RVA: 0x00020070 File Offset: 0x0001E270
		public unsafe Beaker beaker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.NativeFieldInfoPtr_beaker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Beaker>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.NativeFieldInfoPtr_beaker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013C0 RID: 5056
		// (get) Token: 0x060040CF RID: 16591 RVA: 0x00145A88 File Offset: 0x00143C88
		// (set) Token: 0x060040D0 RID: 16592 RVA: 0x0002008F File Offset: 0x0001E28F
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170013C1 RID: 5057
		// (get) Token: 0x060040D1 RID: 16593 RVA: 0x00145AB0 File Offset: 0x00143CB0
		// (set) Token: 0x060040D2 RID: 16594 RVA: 0x000200AA File Offset: 0x0001E2AA
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002B18 RID: 11032
		private static readonly IntPtr NativeFieldInfoPtr_PLACE_INGREDIENTS_TIME;

		// Token: 0x04002B19 RID: 11033
		private static readonly IntPtr NativeFieldInfoPtr_STIR_TIME;

		// Token: 0x04002B1A RID: 11034
		private static readonly IntPtr NativeFieldInfoPtr_BURNER_TIME;

		// Token: 0x04002B1B RID: 11035
		private static readonly IntPtr NativeFieldInfoPtr__targetStation_k__BackingField;

		// Token: 0x04002B1C RID: 11036
		private static readonly IntPtr NativeFieldInfoPtr_chemist;

		// Token: 0x04002B1D RID: 11037
		private static readonly IntPtr NativeFieldInfoPtr_cookRoutine;

		// Token: 0x04002B1E RID: 11038
		private static readonly IntPtr NativeFieldInfoPtr_beaker;

		// Token: 0x04002B1F RID: 11039
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002B20 RID: 11040
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002B21 RID: 11041
		private static readonly IntPtr NativeMethodInfoPtr_get_targetStation_Public_get_ChemistryStation_0;

		// Token: 0x04002B22 RID: 11042
		private static readonly IntPtr NativeMethodInfoPtr_set_targetStation_Private_set_Void_ChemistryStation_0;

		// Token: 0x04002B23 RID: 11043
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04002B24 RID: 11044
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetStation_Public_Void_ChemistryStation_0;

		// Token: 0x04002B25 RID: 11045
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_1;

		// Token: 0x04002B26 RID: 11046
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002B27 RID: 11047
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x04002B28 RID: 11048
		private static readonly IntPtr NativeMethodInfoPtr_StartCook_Private_Void_0;

		// Token: 0x04002B29 RID: 11049
		private static readonly IntPtr NativeMethodInfoPtr_SetupBeaker_Private_Void_0;

		// Token: 0x04002B2A RID: 11050
		private static readonly IntPtr NativeMethodInfoPtr_FillBeaker_Private_Void_StationRecipe_Beaker_0;

		// Token: 0x04002B2B RID: 11051
		private static readonly IntPtr NativeMethodInfoPtr_CanCookStart_Private_Boolean_0;

		// Token: 0x04002B2C RID: 11052
		private static readonly IntPtr NativeMethodInfoPtr_StopCook_Private_Void_0;

		// Token: 0x04002B2D RID: 11053
		private static readonly IntPtr NativeMethodInfoPtr_GetStationAccessPoint_Private_Vector3_0;

		// Token: 0x04002B2E RID: 11054
		private static readonly IntPtr NativeMethodInfoPtr_IsAtStation_Private_Boolean_0;

		// Token: 0x04002B2F RID: 11055
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002B30 RID: 11056
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04002B31 RID: 11057
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002B32 RID: 11058
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002B33 RID: 11059
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002B34 RID: 11060
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartCook_2166136261_Private_Void_0;

		// Token: 0x04002B35 RID: 11061
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartCook_2166136261_Private_Void_0;

		// Token: 0x04002B36 RID: 11062
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartCook_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002B37 RID: 11063
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000957 RID: 2391
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.StartChemistryStationBehaviour+<<StartCook>g__CookRoutine|15_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C891 RID: 51345 RVA: 0x00309990 File Offset: 0x00307B90
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique()
			{
				Il2CppClassPointerStore<StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StartChemistryStationBehaviour>.NativeClassPtr, "<<StartCook>g__CookRoutine|15_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique>.NativeClassPtr);
				StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique>.NativeClassPtr, "<>1__state");
				StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique>.NativeClassPtr, "<>2__current");
				StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique>.NativeClassPtr, "<>4__this");
				StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique.NativeFieldInfoPtr__recipe_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique>.NativeClassPtr, "<recipe>5__2");
				StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique>.NativeClassPtr, 100671127);
				StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique>.NativeClassPtr, 100671128);
				StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique>.NativeClassPtr, 100671129);
				StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique>.NativeClassPtr, 100671130);
				StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique>.NativeClassPtr, 100671131);
				StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique>.NativeClassPtr, 100671132);
			}

			// Token: 0x0600C892 RID: 51346 RVA: 0x00309A84 File Offset: 0x00307C84
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C893 RID: 51347 RVA: 0x00309ACC File Offset: 0x00307CCC
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C894 RID: 51348 RVA: 0x00309B00 File Offset: 0x00307D00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150023, XrefRangeEnd = 150131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003E92 RID: 16018
			// (get) Token: 0x0600C895 RID: 51349 RVA: 0x00309B3C File Offset: 0x00307D3C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C896 RID: 51350 RVA: 0x00309B7C File Offset: 0x00307D7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150131, XrefRangeEnd = 150136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003E93 RID: 16019
			// (get) Token: 0x0600C897 RID: 51351 RVA: 0x00309BB0 File Offset: 0x00307DB0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C898 RID: 51352 RVA: 0x000618ED File Offset: 0x0005FAED
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E8E RID: 16014
			// (get) Token: 0x0600C899 RID: 51353 RVA: 0x00309BF0 File Offset: 0x00307DF0
			// (set) Token: 0x0600C89A RID: 51354 RVA: 0x000618F6 File Offset: 0x0005FAF6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E8F RID: 16015
			// (get) Token: 0x0600C89B RID: 51355 RVA: 0x00309C18 File Offset: 0x00307E18
			// (set) Token: 0x0600C89C RID: 51356 RVA: 0x00061911 File Offset: 0x0005FB11
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E90 RID: 16016
			// (get) Token: 0x0600C89D RID: 51357 RVA: 0x00309C48 File Offset: 0x00307E48
			// (set) Token: 0x0600C89E RID: 51358 RVA: 0x00061930 File Offset: 0x0005FB30
			public unsafe StartChemistryStationBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StartChemistryStationBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E91 RID: 16017
			// (get) Token: 0x0600C89F RID: 51359 RVA: 0x00309C78 File Offset: 0x00307E78
			// (set) Token: 0x0600C8A0 RID: 51360 RVA: 0x0006194F File Offset: 0x0005FB4F
			public unsafe StationRecipe _recipe_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique.NativeFieldInfoPtr__recipe_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartChemistryStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStStObObUnique.NativeFieldInfoPtr__recipe_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040087C5 RID: 34757
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040087C6 RID: 34758
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040087C7 RID: 34759
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040087C8 RID: 34760
			private static readonly IntPtr NativeFieldInfoPtr__recipe_5__2;

			// Token: 0x040087C9 RID: 34761
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040087CA RID: 34762
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087CB RID: 34763
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040087CC RID: 34764
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040087CD RID: 34765
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087CE RID: 34766
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
