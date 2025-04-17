using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Misc;
using Il2CppScheduleOne.Trash;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200072A RID: 1834
	public class Recycler : NetworkBehaviour
	{
		// Token: 0x0600A590 RID: 42384 RVA: 0x002970E8 File Offset: 0x002952E8
		// Note: this type is marked as 'beforefieldinit'.
		static Recycler()
		{
			Il2CppClassPointerStore<Recycler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Recycler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Recycler>.NativeClassPtr);
			Recycler.NativeFieldInfoPtr__State_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "<State>k__BackingField");
			Recycler.NativeFieldInfoPtr__IsHatchOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "<IsHatchOpen>k__BackingField");
			Recycler.NativeFieldInfoPtr_DetectionMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "DetectionMask");
			Recycler.NativeFieldInfoPtr_HandleIntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "HandleIntObj");
			Recycler.NativeFieldInfoPtr_ButtonIntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "ButtonIntObj");
			Recycler.NativeFieldInfoPtr_CashIntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "CashIntObj");
			Recycler.NativeFieldInfoPtr_ButtonLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "ButtonLight");
			Recycler.NativeFieldInfoPtr_ButtonAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "ButtonAnim");
			Recycler.NativeFieldInfoPtr_HatchAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "HatchAnim");
			Recycler.NativeFieldInfoPtr_CashAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "CashAnim");
			Recycler.NativeFieldInfoPtr_OpenHatchInstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "OpenHatchInstruction");
			Recycler.NativeFieldInfoPtr_InsertTrashInstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "InsertTrashInstruction");
			Recycler.NativeFieldInfoPtr_PressBeginInstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "PressBeginInstruction");
			Recycler.NativeFieldInfoPtr_ProcessingScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "ProcessingScreen");
			Recycler.NativeFieldInfoPtr_ProcessingLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "ProcessingLabel");
			Recycler.NativeFieldInfoPtr_ValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "ValueLabel");
			Recycler.NativeFieldInfoPtr_CheckCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "CheckCollider");
			Recycler.NativeFieldInfoPtr_Cash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "Cash");
			Recycler.NativeFieldInfoPtr_BankNote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "BankNote");
			Recycler.NativeFieldInfoPtr_OpenSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "OpenSound");
			Recycler.NativeFieldInfoPtr_CloseSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "CloseSound");
			Recycler.NativeFieldInfoPtr_PressSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "PressSound");
			Recycler.NativeFieldInfoPtr_DoneSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "DoneSound");
			Recycler.NativeFieldInfoPtr_CashEjectSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "CashEjectSound");
			Recycler.NativeFieldInfoPtr_cashValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "cashValue");
			Recycler.NativeFieldInfoPtr_onStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "onStart");
			Recycler.NativeFieldInfoPtr_onStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "onStop");
			Recycler.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.RecyclerAssembly-CSharp.dll_Excuted");
			Recycler.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.RecyclerAssembly-CSharp.dll_Excuted");
			Recycler.NativeMethodInfoPtr_get_State_Public_get_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683546);
			Recycler.NativeMethodInfoPtr_set_State_Protected_set_Void_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683547);
			Recycler.NativeMethodInfoPtr_get_IsHatchOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683548);
			Recycler.NativeMethodInfoPtr_set_IsHatchOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683549);
			Recycler.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683550);
			Recycler.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683551);
			Recycler.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683552);
			Recycler.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683553);
			Recycler.NativeMethodInfoPtr_HandleInteracted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683554);
			Recycler.NativeMethodInfoPtr_ButtonInteracted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683555);
			Recycler.NativeMethodInfoPtr_CashInteracted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683556);
			Recycler.NativeMethodInfoPtr_SendCashCollected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683557);
			Recycler.NativeMethodInfoPtr_CashCollected_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683558);
			Recycler.NativeMethodInfoPtr_EnableCash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683559);
			Recycler.NativeMethodInfoPtr_SetCashValue_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683560);
			Recycler.NativeMethodInfoPtr_Process_Private_IEnumerator_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683561);
			Recycler.NativeMethodInfoPtr_SendState_Public_Void_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683562);
			Recycler.NativeMethodInfoPtr_SetState_Private_Void_NetworkConnection_EState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683563);
			Recycler.NativeMethodInfoPtr_SetHatchOpen_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683564);
			Recycler.NativeMethodInfoPtr_GetTrash_Private_Il2CppReferenceArray_1_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683565);
			Recycler.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683566);
			Recycler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683567);
			Recycler.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683568);
			Recycler.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683569);
			Recycler.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683570);
			Recycler.NativeMethodInfoPtr_RpcWriter___Server_SendCashCollected_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683571);
			Recycler.NativeMethodInfoPtr_RpcLogic___SendCashCollected_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683572);
			Recycler.NativeMethodInfoPtr_RpcReader___Server_SendCashCollected_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683573);
			Recycler.NativeMethodInfoPtr_RpcWriter___Observers_CashCollected_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683574);
			Recycler.NativeMethodInfoPtr_RpcLogic___CashCollected_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683575);
			Recycler.NativeMethodInfoPtr_RpcReader___Observers_CashCollected_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683576);
			Recycler.NativeMethodInfoPtr_RpcWriter___Observers_EnableCash_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683577);
			Recycler.NativeMethodInfoPtr_RpcLogic___EnableCash_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683578);
			Recycler.NativeMethodInfoPtr_RpcReader___Observers_EnableCash_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683579);
			Recycler.NativeMethodInfoPtr_RpcWriter___Observers_SetCashValue_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683580);
			Recycler.NativeMethodInfoPtr_RpcLogic___SetCashValue_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683581);
			Recycler.NativeMethodInfoPtr_RpcReader___Observers_SetCashValue_431000436_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683582);
			Recycler.NativeMethodInfoPtr_RpcWriter___Server_SendState_3569965459_Private_Void_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683583);
			Recycler.NativeMethodInfoPtr_RpcLogic___SendState_3569965459_Public_Void_EState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683584);
			Recycler.NativeMethodInfoPtr_RpcReader___Server_SendState_3569965459_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683585);
			Recycler.NativeMethodInfoPtr_RpcWriter___Observers_SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683586);
			Recycler.NativeMethodInfoPtr_RpcLogic___SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683587);
			Recycler.NativeMethodInfoPtr_RpcReader___Observers_SetState_3790170803_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683588);
			Recycler.NativeMethodInfoPtr_RpcWriter___Target_SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683589);
			Recycler.NativeMethodInfoPtr_RpcReader___Target_SetState_3790170803_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683590);
			Recycler.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler>.NativeClassPtr, 100683591);
		}

		// Token: 0x17003335 RID: 13109
		// (get) Token: 0x0600A591 RID: 42385 RVA: 0x002976F4 File Offset: 0x002958F4
		// (set) Token: 0x0600A592 RID: 42386 RVA: 0x00297730 File Offset: 0x00295930
		public unsafe Recycler.EState State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_get_State_Public_get_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_set_State_Protected_set_Void_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003336 RID: 13110
		// (get) Token: 0x0600A593 RID: 42387 RVA: 0x00297770 File Offset: 0x00295970
		// (set) Token: 0x0600A594 RID: 42388 RVA: 0x002977AC File Offset: 0x002959AC
		public unsafe bool IsHatchOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_get_IsHatchOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_set_IsHatchOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600A595 RID: 42389 RVA: 0x002977EC File Offset: 0x002959EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289199, XrefRangeEnd = 289236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A596 RID: 42390 RVA: 0x00297820 File Offset: 0x00295A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289236, XrefRangeEnd = 289238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Recycler.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A597 RID: 42391 RVA: 0x00297870 File Offset: 0x00295A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289238, XrefRangeEnd = 289256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A598 RID: 42392 RVA: 0x002978A4 File Offset: 0x00295AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289256, XrefRangeEnd = 289267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A599 RID: 42393 RVA: 0x002978D8 File Offset: 0x00295AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289267, XrefRangeEnd = 289268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_HandleInteracted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A59A RID: 42394 RVA: 0x0029790C File Offset: 0x00295B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289268, XrefRangeEnd = 289295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ButtonInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_ButtonInteracted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A59B RID: 42395 RVA: 0x00297940 File Offset: 0x00295B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289295, XrefRangeEnd = 289335, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CashInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_CashInteracted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A59C RID: 42396 RVA: 0x00297974 File Offset: 0x00295B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289335, XrefRangeEnd = 289353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendCashCollected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_SendCashCollected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A59D RID: 42397 RVA: 0x002979A8 File Offset: 0x00295BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289353, XrefRangeEnd = 289375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CashCollected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_CashCollected_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A59E RID: 42398 RVA: 0x002979DC File Offset: 0x00295BDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289394, RefRangeEnd = 289395, XrefRangeStart = 289375, XrefRangeEnd = 289394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableCash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_EnableCash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A59F RID: 42399 RVA: 0x00297A10 File Offset: 0x00295C10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 289415, RefRangeEnd = 289416, XrefRangeStart = 289395, XrefRangeEnd = 289415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCashValue(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_SetCashValue_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5A0 RID: 42400 RVA: 0x00297A50 File Offset: 0x00295C50
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 289421, RefRangeEnd = 289423, XrefRangeStart = 289416, XrefRangeEnd = 289421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Process(bool startedByLocalPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startedByLocalPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_Process_Private_IEnumerator_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A5A1 RID: 42401 RVA: 0x00297A9C File Offset: 0x00295C9C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 289444, RefRangeEnd = 289452, XrefRangeStart = 289423, XrefRangeEnd = 289444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendState(Recycler.EState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_SendState_Public_Void_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5A2 RID: 42402 RVA: 0x00297ADC File Offset: 0x00295CDC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 289496, RefRangeEnd = 289500, XrefRangeStart = 289452, XrefRangeEnd = 289496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetState(NetworkConnection conn, Recycler.EState state, bool force = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_SetState_Private_Void_NetworkConnection_EState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5A3 RID: 42403 RVA: 0x00297B3C File Offset: 0x00295D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289500, XrefRangeEnd = 289504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHatchOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_SetHatchOpen_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5A4 RID: 42404 RVA: 0x00297B7C File Offset: 0x00295D7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 289542, RefRangeEnd = 289544, XrefRangeStart = 289504, XrefRangeEnd = 289542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<TrashItem> GetTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_GetTrash_Private_Il2CppReferenceArray_1_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrashItem>>(intPtr3) : null;
		}

		// Token: 0x0600A5A5 RID: 42405 RVA: 0x00297BBC File Offset: 0x00295DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289544, XrefRangeEnd = 289552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5A6 RID: 42406 RVA: 0x00297BF0 File Offset: 0x00295DF0
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 134800, RefRangeEnd = 134822, XrefRangeStart = 134800, XrefRangeEnd = 134822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Recycler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Recycler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5A7 RID: 42407 RVA: 0x00297C2C File Offset: 0x00295E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289552, XrefRangeEnd = 289596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Recycler.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5A8 RID: 42408 RVA: 0x00297C68 File Offset: 0x00295E68
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Recycler.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5A9 RID: 42409 RVA: 0x00297CA4 File Offset: 0x00295EA4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Recycler.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5AA RID: 42410 RVA: 0x00297CE0 File Offset: 0x00295EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendCashCollected_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcWriter___Server_SendCashCollected_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5AB RID: 42411 RVA: 0x00297D14 File Offset: 0x00295F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendCashCollected_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcLogic___SendCashCollected_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5AC RID: 42412 RVA: 0x00297D48 File Offset: 0x00295F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289596, XrefRangeEnd = 289619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendCashCollected_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcReader___Server_SendCashCollected_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5AD RID: 42413 RVA: 0x00297DAC File Offset: 0x00295FAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289619, XrefRangeEnd = 289637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_CashCollected_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcWriter___Observers_CashCollected_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5AE RID: 42414 RVA: 0x00297DE0 File Offset: 0x00295FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289637, XrefRangeEnd = 289640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___CashCollected_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcLogic___CashCollected_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5AF RID: 42415 RVA: 0x00297E14 File Offset: 0x00296014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289640, XrefRangeEnd = 289645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_CashCollected_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcReader___Observers_CashCollected_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5B0 RID: 42416 RVA: 0x00297E64 File Offset: 0x00296064
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289645, XrefRangeEnd = 289663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_EnableCash_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcWriter___Observers_EnableCash_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5B1 RID: 42417 RVA: 0x00297E98 File Offset: 0x00296098
		[CallerCount(0)]
		public unsafe void RpcLogic___EnableCash_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcLogic___EnableCash_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5B2 RID: 42418 RVA: 0x00297ECC File Offset: 0x002960CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289663, XrefRangeEnd = 289665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_EnableCash_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcReader___Observers_EnableCash_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5B3 RID: 42419 RVA: 0x00297F1C File Offset: 0x0029611C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289665, XrefRangeEnd = 289684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetCashValue_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcWriter___Observers_SetCashValue_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5B4 RID: 42420 RVA: 0x00297F5C File Offset: 0x0029615C
		[CallerCount(0)]
		public unsafe void RpcLogic___SetCashValue_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcLogic___SetCashValue_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5B5 RID: 42421 RVA: 0x00297F9C File Offset: 0x0029619C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289684, XrefRangeEnd = 289687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetCashValue_431000436(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcReader___Observers_SetCashValue_431000436_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5B6 RID: 42422 RVA: 0x00297FEC File Offset: 0x002961EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289687, XrefRangeEnd = 289706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendState_3569965459(Recycler.EState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcWriter___Server_SendState_3569965459_Private_Void_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5B7 RID: 42423 RVA: 0x0029802C File Offset: 0x0029622C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289706, XrefRangeEnd = 289707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendState_3569965459(Recycler.EState state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcLogic___SendState_3569965459_Public_Void_EState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5B8 RID: 42424 RVA: 0x0029806C File Offset: 0x0029626C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289707, XrefRangeEnd = 289711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendState_3569965459(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcReader___Server_SendState_3569965459_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5B9 RID: 42425 RVA: 0x002980D0 File Offset: 0x002962D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289711, XrefRangeEnd = 289731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetState_3790170803(NetworkConnection conn, Recycler.EState state, bool force = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcWriter___Observers_SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5BA RID: 42426 RVA: 0x00298130 File Offset: 0x00296330
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 289750, RefRangeEnd = 289753, XrefRangeStart = 289731, XrefRangeEnd = 289750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetState_3790170803(NetworkConnection conn, Recycler.EState state, bool force = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcLogic___SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5BB RID: 42427 RVA: 0x00298190 File Offset: 0x00296390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289753, XrefRangeEnd = 289757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetState_3790170803(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcReader___Observers_SetState_3790170803_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5BC RID: 42428 RVA: 0x002981E0 File Offset: 0x002963E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289757, XrefRangeEnd = 289768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetState_3790170803(NetworkConnection conn, Recycler.EState state, bool force = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref force;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcWriter___Target_SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5BD RID: 42429 RVA: 0x00298240 File Offset: 0x00296440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289768, XrefRangeEnd = 289772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetState_3790170803(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler.NativeMethodInfoPtr_RpcReader___Target_SetState_3790170803_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5BE RID: 42430 RVA: 0x00298290 File Offset: 0x00296490
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Recycler.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A5BF RID: 42431 RVA: 0x00051920 File Offset: 0x0004FB20
		public Recycler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003318 RID: 13080
		// (get) Token: 0x0600A5C0 RID: 42432 RVA: 0x002982CC File Offset: 0x002964CC
		// (set) Token: 0x0600A5C1 RID: 42433 RVA: 0x00051929 File Offset: 0x0004FB29
		public unsafe Recycler.EState _State_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr__State_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr__State_k__BackingField)) = value;
			}
		}

		// Token: 0x17003319 RID: 13081
		// (get) Token: 0x0600A5C2 RID: 42434 RVA: 0x002982F4 File Offset: 0x002964F4
		// (set) Token: 0x0600A5C3 RID: 42435 RVA: 0x00051944 File Offset: 0x0004FB44
		public unsafe bool _IsHatchOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr__IsHatchOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr__IsHatchOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x1700331A RID: 13082
		// (get) Token: 0x0600A5C4 RID: 42436 RVA: 0x0029831C File Offset: 0x0029651C
		// (set) Token: 0x0600A5C5 RID: 42437 RVA: 0x0005195F File Offset: 0x0004FB5F
		public unsafe LayerMask DetectionMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_DetectionMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_DetectionMask)) = value;
			}
		}

		// Token: 0x1700331B RID: 13083
		// (get) Token: 0x0600A5C6 RID: 42438 RVA: 0x00298344 File Offset: 0x00296544
		// (set) Token: 0x0600A5C7 RID: 42439 RVA: 0x0005197A File Offset: 0x0004FB7A
		public unsafe InteractableObject HandleIntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_HandleIntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_HandleIntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700331C RID: 13084
		// (get) Token: 0x0600A5C8 RID: 42440 RVA: 0x00298374 File Offset: 0x00296574
		// (set) Token: 0x0600A5C9 RID: 42441 RVA: 0x00051999 File Offset: 0x0004FB99
		public unsafe InteractableObject ButtonIntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ButtonIntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ButtonIntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700331D RID: 13085
		// (get) Token: 0x0600A5CA RID: 42442 RVA: 0x002983A4 File Offset: 0x002965A4
		// (set) Token: 0x0600A5CB RID: 42443 RVA: 0x000519B8 File Offset: 0x0004FBB8
		public unsafe InteractableObject CashIntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CashIntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CashIntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700331E RID: 13086
		// (get) Token: 0x0600A5CC RID: 42444 RVA: 0x002983D4 File Offset: 0x002965D4
		// (set) Token: 0x0600A5CD RID: 42445 RVA: 0x000519D7 File Offset: 0x0004FBD7
		public unsafe ToggleableLight ButtonLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ButtonLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ToggleableLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ButtonLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700331F RID: 13087
		// (get) Token: 0x0600A5CE RID: 42446 RVA: 0x00298404 File Offset: 0x00296604
		// (set) Token: 0x0600A5CF RID: 42447 RVA: 0x000519F6 File Offset: 0x0004FBF6
		public unsafe Animation ButtonAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ButtonAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ButtonAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003320 RID: 13088
		// (get) Token: 0x0600A5D0 RID: 42448 RVA: 0x00298434 File Offset: 0x00296634
		// (set) Token: 0x0600A5D1 RID: 42449 RVA: 0x00051A15 File Offset: 0x0004FC15
		public unsafe Animation HatchAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_HatchAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_HatchAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003321 RID: 13089
		// (get) Token: 0x0600A5D2 RID: 42450 RVA: 0x00298464 File Offset: 0x00296664
		// (set) Token: 0x0600A5D3 RID: 42451 RVA: 0x00051A34 File Offset: 0x0004FC34
		public unsafe Animation CashAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CashAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CashAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003322 RID: 13090
		// (get) Token: 0x0600A5D4 RID: 42452 RVA: 0x00298494 File Offset: 0x00296694
		// (set) Token: 0x0600A5D5 RID: 42453 RVA: 0x00051A53 File Offset: 0x0004FC53
		public unsafe RectTransform OpenHatchInstruction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_OpenHatchInstruction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_OpenHatchInstruction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003323 RID: 13091
		// (get) Token: 0x0600A5D6 RID: 42454 RVA: 0x002984C4 File Offset: 0x002966C4
		// (set) Token: 0x0600A5D7 RID: 42455 RVA: 0x00051A72 File Offset: 0x0004FC72
		public unsafe RectTransform InsertTrashInstruction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_InsertTrashInstruction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_InsertTrashInstruction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003324 RID: 13092
		// (get) Token: 0x0600A5D8 RID: 42456 RVA: 0x002984F4 File Offset: 0x002966F4
		// (set) Token: 0x0600A5D9 RID: 42457 RVA: 0x00051A91 File Offset: 0x0004FC91
		public unsafe RectTransform PressBeginInstruction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_PressBeginInstruction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_PressBeginInstruction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003325 RID: 13093
		// (get) Token: 0x0600A5DA RID: 42458 RVA: 0x00298524 File Offset: 0x00296724
		// (set) Token: 0x0600A5DB RID: 42459 RVA: 0x00051AB0 File Offset: 0x0004FCB0
		public unsafe RectTransform ProcessingScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ProcessingScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ProcessingScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003326 RID: 13094
		// (get) Token: 0x0600A5DC RID: 42460 RVA: 0x00298554 File Offset: 0x00296754
		// (set) Token: 0x0600A5DD RID: 42461 RVA: 0x00051ACF File Offset: 0x0004FCCF
		public unsafe TextMeshProUGUI ProcessingLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ProcessingLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ProcessingLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003327 RID: 13095
		// (get) Token: 0x0600A5DE RID: 42462 RVA: 0x00298584 File Offset: 0x00296784
		// (set) Token: 0x0600A5DF RID: 42463 RVA: 0x00051AEE File Offset: 0x0004FCEE
		public unsafe TextMeshProUGUI ValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_ValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003328 RID: 13096
		// (get) Token: 0x0600A5E0 RID: 42464 RVA: 0x002985B4 File Offset: 0x002967B4
		// (set) Token: 0x0600A5E1 RID: 42465 RVA: 0x00051B0D File Offset: 0x0004FD0D
		public unsafe BoxCollider CheckCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CheckCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CheckCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003329 RID: 13097
		// (get) Token: 0x0600A5E2 RID: 42466 RVA: 0x002985E4 File Offset: 0x002967E4
		// (set) Token: 0x0600A5E3 RID: 42467 RVA: 0x00051B2C File Offset: 0x0004FD2C
		public unsafe Transform Cash
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_Cash);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_Cash), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700332A RID: 13098
		// (get) Token: 0x0600A5E4 RID: 42468 RVA: 0x00298614 File Offset: 0x00296814
		// (set) Token: 0x0600A5E5 RID: 42469 RVA: 0x00051B4B File Offset: 0x0004FD4B
		public unsafe GameObject BankNote
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_BankNote);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_BankNote), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700332B RID: 13099
		// (get) Token: 0x0600A5E6 RID: 42470 RVA: 0x00298644 File Offset: 0x00296844
		// (set) Token: 0x0600A5E7 RID: 42471 RVA: 0x00051B6A File Offset: 0x0004FD6A
		public unsafe AudioSourceController OpenSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_OpenSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_OpenSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700332C RID: 13100
		// (get) Token: 0x0600A5E8 RID: 42472 RVA: 0x00298674 File Offset: 0x00296874
		// (set) Token: 0x0600A5E9 RID: 42473 RVA: 0x00051B89 File Offset: 0x0004FD89
		public unsafe AudioSourceController CloseSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CloseSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CloseSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700332D RID: 13101
		// (get) Token: 0x0600A5EA RID: 42474 RVA: 0x002986A4 File Offset: 0x002968A4
		// (set) Token: 0x0600A5EB RID: 42475 RVA: 0x00051BA8 File Offset: 0x0004FDA8
		public unsafe AudioSourceController PressSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_PressSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_PressSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700332E RID: 13102
		// (get) Token: 0x0600A5EC RID: 42476 RVA: 0x002986D4 File Offset: 0x002968D4
		// (set) Token: 0x0600A5ED RID: 42477 RVA: 0x00051BC7 File Offset: 0x0004FDC7
		public unsafe AudioSourceController DoneSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_DoneSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_DoneSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700332F RID: 13103
		// (get) Token: 0x0600A5EE RID: 42478 RVA: 0x00298704 File Offset: 0x00296904
		// (set) Token: 0x0600A5EF RID: 42479 RVA: 0x00051BE6 File Offset: 0x0004FDE6
		public unsafe AudioSourceController CashEjectSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CashEjectSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_CashEjectSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003330 RID: 13104
		// (get) Token: 0x0600A5F0 RID: 42480 RVA: 0x00298734 File Offset: 0x00296934
		// (set) Token: 0x0600A5F1 RID: 42481 RVA: 0x00051C05 File Offset: 0x0004FE05
		public unsafe float cashValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_cashValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_cashValue)) = value;
			}
		}

		// Token: 0x17003331 RID: 13105
		// (get) Token: 0x0600A5F2 RID: 42482 RVA: 0x0029875C File Offset: 0x0029695C
		// (set) Token: 0x0600A5F3 RID: 42483 RVA: 0x00051C20 File Offset: 0x0004FE20
		public unsafe UnityEvent onStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_onStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_onStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003332 RID: 13106
		// (get) Token: 0x0600A5F4 RID: 42484 RVA: 0x0029878C File Offset: 0x0029698C
		// (set) Token: 0x0600A5F5 RID: 42485 RVA: 0x00051C3F File Offset: 0x0004FE3F
		public unsafe UnityEvent onStop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_onStop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_onStop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003333 RID: 13107
		// (get) Token: 0x0600A5F6 RID: 42486 RVA: 0x002987BC File Offset: 0x002969BC
		// (set) Token: 0x0600A5F7 RID: 42487 RVA: 0x00051C5E File Offset: 0x0004FE5E
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003334 RID: 13108
		// (get) Token: 0x0600A5F8 RID: 42488 RVA: 0x002987E4 File Offset: 0x002969E4
		// (set) Token: 0x0600A5F9 RID: 42489 RVA: 0x00051C79 File Offset: 0x0004FE79
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04006F02 RID: 28418
		private static readonly IntPtr NativeFieldInfoPtr__State_k__BackingField;

		// Token: 0x04006F03 RID: 28419
		private static readonly IntPtr NativeFieldInfoPtr__IsHatchOpen_k__BackingField;

		// Token: 0x04006F04 RID: 28420
		private static readonly IntPtr NativeFieldInfoPtr_DetectionMask;

		// Token: 0x04006F05 RID: 28421
		private static readonly IntPtr NativeFieldInfoPtr_HandleIntObj;

		// Token: 0x04006F06 RID: 28422
		private static readonly IntPtr NativeFieldInfoPtr_ButtonIntObj;

		// Token: 0x04006F07 RID: 28423
		private static readonly IntPtr NativeFieldInfoPtr_CashIntObj;

		// Token: 0x04006F08 RID: 28424
		private static readonly IntPtr NativeFieldInfoPtr_ButtonLight;

		// Token: 0x04006F09 RID: 28425
		private static readonly IntPtr NativeFieldInfoPtr_ButtonAnim;

		// Token: 0x04006F0A RID: 28426
		private static readonly IntPtr NativeFieldInfoPtr_HatchAnim;

		// Token: 0x04006F0B RID: 28427
		private static readonly IntPtr NativeFieldInfoPtr_CashAnim;

		// Token: 0x04006F0C RID: 28428
		private static readonly IntPtr NativeFieldInfoPtr_OpenHatchInstruction;

		// Token: 0x04006F0D RID: 28429
		private static readonly IntPtr NativeFieldInfoPtr_InsertTrashInstruction;

		// Token: 0x04006F0E RID: 28430
		private static readonly IntPtr NativeFieldInfoPtr_PressBeginInstruction;

		// Token: 0x04006F0F RID: 28431
		private static readonly IntPtr NativeFieldInfoPtr_ProcessingScreen;

		// Token: 0x04006F10 RID: 28432
		private static readonly IntPtr NativeFieldInfoPtr_ProcessingLabel;

		// Token: 0x04006F11 RID: 28433
		private static readonly IntPtr NativeFieldInfoPtr_ValueLabel;

		// Token: 0x04006F12 RID: 28434
		private static readonly IntPtr NativeFieldInfoPtr_CheckCollider;

		// Token: 0x04006F13 RID: 28435
		private static readonly IntPtr NativeFieldInfoPtr_Cash;

		// Token: 0x04006F14 RID: 28436
		private static readonly IntPtr NativeFieldInfoPtr_BankNote;

		// Token: 0x04006F15 RID: 28437
		private static readonly IntPtr NativeFieldInfoPtr_OpenSound;

		// Token: 0x04006F16 RID: 28438
		private static readonly IntPtr NativeFieldInfoPtr_CloseSound;

		// Token: 0x04006F17 RID: 28439
		private static readonly IntPtr NativeFieldInfoPtr_PressSound;

		// Token: 0x04006F18 RID: 28440
		private static readonly IntPtr NativeFieldInfoPtr_DoneSound;

		// Token: 0x04006F19 RID: 28441
		private static readonly IntPtr NativeFieldInfoPtr_CashEjectSound;

		// Token: 0x04006F1A RID: 28442
		private static readonly IntPtr NativeFieldInfoPtr_cashValue;

		// Token: 0x04006F1B RID: 28443
		private static readonly IntPtr NativeFieldInfoPtr_onStart;

		// Token: 0x04006F1C RID: 28444
		private static readonly IntPtr NativeFieldInfoPtr_onStop;

		// Token: 0x04006F1D RID: 28445
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04006F1E RID: 28446
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04006F1F RID: 28447
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_EState_0;

		// Token: 0x04006F20 RID: 28448
		private static readonly IntPtr NativeMethodInfoPtr_set_State_Protected_set_Void_EState_0;

		// Token: 0x04006F21 RID: 28449
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHatchOpen_Public_get_Boolean_0;

		// Token: 0x04006F22 RID: 28450
		private static readonly IntPtr NativeMethodInfoPtr_set_IsHatchOpen_Private_set_Void_Boolean_0;

		// Token: 0x04006F23 RID: 28451
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04006F24 RID: 28452
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04006F25 RID: 28453
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04006F26 RID: 28454
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x04006F27 RID: 28455
		private static readonly IntPtr NativeMethodInfoPtr_HandleInteracted_Public_Void_0;

		// Token: 0x04006F28 RID: 28456
		private static readonly IntPtr NativeMethodInfoPtr_ButtonInteracted_Public_Void_0;

		// Token: 0x04006F29 RID: 28457
		private static readonly IntPtr NativeMethodInfoPtr_CashInteracted_Public_Void_0;

		// Token: 0x04006F2A RID: 28458
		private static readonly IntPtr NativeMethodInfoPtr_SendCashCollected_Private_Void_0;

		// Token: 0x04006F2B RID: 28459
		private static readonly IntPtr NativeMethodInfoPtr_CashCollected_Private_Void_0;

		// Token: 0x04006F2C RID: 28460
		private static readonly IntPtr NativeMethodInfoPtr_EnableCash_Private_Void_0;

		// Token: 0x04006F2D RID: 28461
		private static readonly IntPtr NativeMethodInfoPtr_SetCashValue_Private_Void_Single_0;

		// Token: 0x04006F2E RID: 28462
		private static readonly IntPtr NativeMethodInfoPtr_Process_Private_IEnumerator_Boolean_0;

		// Token: 0x04006F2F RID: 28463
		private static readonly IntPtr NativeMethodInfoPtr_SendState_Public_Void_EState_0;

		// Token: 0x04006F30 RID: 28464
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Private_Void_NetworkConnection_EState_Boolean_0;

		// Token: 0x04006F31 RID: 28465
		private static readonly IntPtr NativeMethodInfoPtr_SetHatchOpen_Private_Void_Boolean_0;

		// Token: 0x04006F32 RID: 28466
		private static readonly IntPtr NativeMethodInfoPtr_GetTrash_Private_Il2CppReferenceArray_1_TrashItem_0;

		// Token: 0x04006F33 RID: 28467
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04006F34 RID: 28468
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006F35 RID: 28469
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04006F36 RID: 28470
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04006F37 RID: 28471
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04006F38 RID: 28472
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendCashCollected_2166136261_Private_Void_0;

		// Token: 0x04006F39 RID: 28473
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendCashCollected_2166136261_Private_Void_0;

		// Token: 0x04006F3A RID: 28474
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendCashCollected_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006F3B RID: 28475
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_CashCollected_2166136261_Private_Void_0;

		// Token: 0x04006F3C RID: 28476
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___CashCollected_2166136261_Private_Void_0;

		// Token: 0x04006F3D RID: 28477
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_CashCollected_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006F3E RID: 28478
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_EnableCash_2166136261_Private_Void_0;

		// Token: 0x04006F3F RID: 28479
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___EnableCash_2166136261_Private_Void_0;

		// Token: 0x04006F40 RID: 28480
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_EnableCash_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006F41 RID: 28481
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetCashValue_431000436_Private_Void_Single_0;

		// Token: 0x04006F42 RID: 28482
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetCashValue_431000436_Private_Void_Single_0;

		// Token: 0x04006F43 RID: 28483
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetCashValue_431000436_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006F44 RID: 28484
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendState_3569965459_Private_Void_EState_0;

		// Token: 0x04006F45 RID: 28485
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendState_3569965459_Public_Void_EState_0;

		// Token: 0x04006F46 RID: 28486
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendState_3569965459_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04006F47 RID: 28487
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0;

		// Token: 0x04006F48 RID: 28488
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0;

		// Token: 0x04006F49 RID: 28489
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetState_3790170803_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006F4A RID: 28490
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetState_3790170803_Private_Void_NetworkConnection_EState_Boolean_0;

		// Token: 0x04006F4B RID: 28491
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetState_3790170803_Private_Void_PooledReader_Channel_0;

		// Token: 0x04006F4C RID: 28492
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000BCE RID: 3022
		[OriginalName("Assembly-CSharp.dll", "", "EState")]
		public enum EState
		{
			// Token: 0x040094CB RID: 38091
			HatchClosed,
			// Token: 0x040094CC RID: 38092
			HatchOpen,
			// Token: 0x040094CD RID: 38093
			Processing
		}

		// Token: 0x02000BCF RID: 3023
		[ObfuscatedName("ScheduleOne.ObjectScripts.Recycler+<Process>d__45")]
		public sealed class _Process_d__45 : Il2CppSystem.Object
		{
			// Token: 0x0600DE3B RID: 56891 RVA: 0x00346E34 File Offset: 0x00345034
			// Note: this type is marked as 'beforefieldinit'.
			static _Process_d__45()
			{
				Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Recycler>.NativeClassPtr, "<Process>d__45");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr);
				Recycler._Process_d__45.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, "<>1__state");
				Recycler._Process_d__45.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, "<>2__current");
				Recycler._Process_d__45.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, "<>4__this");
				Recycler._Process_d__45.NativeFieldInfoPtr_startedByLocalPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, "startedByLocalPlayer");
				Recycler._Process_d__45.NativeFieldInfoPtr__value_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, "<value>5__2");
				Recycler._Process_d__45.NativeFieldInfoPtr__lerpTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, "<lerpTime>5__3");
				Recycler._Process_d__45.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, "<i>5__4");
				Recycler._Process_d__45.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, 100683592);
				Recycler._Process_d__45.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, 100683593);
				Recycler._Process_d__45.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, 100683594);
				Recycler._Process_d__45.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, 100683595);
				Recycler._Process_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, 100683596);
				Recycler._Process_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr, 100683597);
			}

			// Token: 0x0600DE3C RID: 56892 RVA: 0x00346F64 File Offset: 0x00345164
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Process_d__45(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Recycler._Process_d__45>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler._Process_d__45.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE3D RID: 56893 RVA: 0x00346FAC File Offset: 0x003451AC
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler._Process_d__45.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE3E RID: 56894 RVA: 0x00346FE0 File Offset: 0x003451E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289120, XrefRangeEnd = 289194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler._Process_d__45.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170044E7 RID: 17639
			// (get) Token: 0x0600DE3F RID: 56895 RVA: 0x0034701C File Offset: 0x0034521C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler._Process_d__45.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE40 RID: 56896 RVA: 0x0034705C File Offset: 0x0034525C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 289194, XrefRangeEnd = 289199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler._Process_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170044E8 RID: 17640
			// (get) Token: 0x0600DE41 RID: 56897 RVA: 0x00347090 File Offset: 0x00345290
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Recycler._Process_d__45.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE42 RID: 56898 RVA: 0x0006C58A File Offset: 0x0006A78A
			public _Process_d__45(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044E0 RID: 17632
			// (get) Token: 0x0600DE43 RID: 56899 RVA: 0x003470D0 File Offset: 0x003452D0
			// (set) Token: 0x0600DE44 RID: 56900 RVA: 0x0006C593 File Offset: 0x0006A793
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044E1 RID: 17633
			// (get) Token: 0x0600DE45 RID: 56901 RVA: 0x003470F8 File Offset: 0x003452F8
			// (set) Token: 0x0600DE46 RID: 56902 RVA: 0x0006C5AE File Offset: 0x0006A7AE
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044E2 RID: 17634
			// (get) Token: 0x0600DE47 RID: 56903 RVA: 0x00347128 File Offset: 0x00345328
			// (set) Token: 0x0600DE48 RID: 56904 RVA: 0x0006C5CD File Offset: 0x0006A7CD
			public unsafe Recycler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Recycler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044E3 RID: 17635
			// (get) Token: 0x0600DE49 RID: 56905 RVA: 0x00347158 File Offset: 0x00345358
			// (set) Token: 0x0600DE4A RID: 56906 RVA: 0x0006C5EC File Offset: 0x0006A7EC
			public unsafe bool startedByLocalPlayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr_startedByLocalPlayer);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr_startedByLocalPlayer)) = value;
				}
			}

			// Token: 0x170044E4 RID: 17636
			// (get) Token: 0x0600DE4B RID: 56907 RVA: 0x00347180 File Offset: 0x00345380
			// (set) Token: 0x0600DE4C RID: 56908 RVA: 0x0006C607 File Offset: 0x0006A807
			public unsafe float _value_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr__value_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr__value_5__2)) = value;
				}
			}

			// Token: 0x170044E5 RID: 17637
			// (get) Token: 0x0600DE4D RID: 56909 RVA: 0x003471A8 File Offset: 0x003453A8
			// (set) Token: 0x0600DE4E RID: 56910 RVA: 0x0006C622 File Offset: 0x0006A822
			public unsafe float _lerpTime_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr__lerpTime_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr__lerpTime_5__3)) = value;
				}
			}

			// Token: 0x170044E6 RID: 17638
			// (get) Token: 0x0600DE4F RID: 56911 RVA: 0x003471D0 File Offset: 0x003453D0
			// (set) Token: 0x0600DE50 RID: 56912 RVA: 0x0006C63D File Offset: 0x0006A83D
			public unsafe float _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Recycler._Process_d__45.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x040094CE RID: 38094
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040094CF RID: 38095
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040094D0 RID: 38096
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040094D1 RID: 38097
			private static readonly IntPtr NativeFieldInfoPtr_startedByLocalPlayer;

			// Token: 0x040094D2 RID: 38098
			private static readonly IntPtr NativeFieldInfoPtr__value_5__2;

			// Token: 0x040094D3 RID: 38099
			private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__3;

			// Token: 0x040094D4 RID: 38100
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x040094D5 RID: 38101
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040094D6 RID: 38102
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094D7 RID: 38103
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040094D8 RID: 38104
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040094D9 RID: 38105
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040094DA RID: 38106
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
