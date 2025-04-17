using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200064F RID: 1615
	public class PawnShopInterface : Singleton<PawnShopInterface>
	{
		// Token: 0x06008F64 RID: 36708 RVA: 0x0025328C File Offset: 0x0025148C
		// Note: this type is marked as 'beforefieldinit'.
		static PawnShopInterface()
		{
			Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "PawnShopInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr);
			PawnShopInterface.NativeFieldInfoPtr_PAYMENT_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "PAYMENT_MIN");
			PawnShopInterface.NativeFieldInfoPtr_PAYMENT_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "PAYMENT_MAX");
			PawnShopInterface.NativeFieldInfoPtr_THINK_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "THINK_TIME");
			PawnShopInterface.NativeFieldInfoPtr_MIN_VALUE_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "MIN_VALUE_MULTIPLIER");
			PawnShopInterface.NativeFieldInfoPtr_MAX_VALUE_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "MAX_VALUE_MULTIPLIER");
			PawnShopInterface.NativeFieldInfoPtr_PAWN_SLOT_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "PAWN_SLOT_COUNT");
			PawnShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			PawnShopInterface.NativeFieldInfoPtr_CurrentState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "CurrentState");
			PawnShopInterface.NativeFieldInfoPtr_PlayerResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "PlayerResponse");
			PawnShopInterface.NativeFieldInfoPtr_CurrentNegotiationRound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "CurrentNegotiationRound");
			PawnShopInterface.NativeFieldInfoPtr_InitialShopOffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "InitialShopOffer");
			PawnShopInterface.NativeFieldInfoPtr_LastShopOffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "LastShopOffer");
			PawnShopInterface.NativeFieldInfoPtr_LastRefusedAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "LastRefusedAmount");
			PawnShopInterface.NativeFieldInfoPtr_PawnShopNPC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "PawnShopNPC");
			PawnShopInterface.NativeFieldInfoPtr__SelectedPayment_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "<SelectedPayment>k__BackingField");
			PawnShopInterface.NativeFieldInfoPtr__NPCAnger_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "<NPCAnger>k__BackingField");
			PawnShopInterface.NativeFieldInfoPtr_RandomCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "RandomCurve");
			PawnShopInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "Canvas");
			PawnShopInterface.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "Container");
			PawnShopInterface.NativeFieldInfoPtr_Slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "Slots");
			PawnShopInterface.NativeFieldInfoPtr_ValueRangeLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "ValueRangeLabels");
			PawnShopInterface.NativeFieldInfoPtr_TotalValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "TotalValueLabel");
			PawnShopInterface.NativeFieldInfoPtr_StartButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "StartButton");
			PawnShopInterface.NativeFieldInfoPtr_Step1Animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "Step1Animation");
			PawnShopInterface.NativeFieldInfoPtr_Step1CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "Step1CanvasGroup");
			PawnShopInterface.NativeFieldInfoPtr_Step2Animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "Step2Animation");
			PawnShopInterface.NativeFieldInfoPtr_Step2CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "Step2CanvasGroup");
			PawnShopInterface.NativeFieldInfoPtr_FadeInAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "FadeInAnim");
			PawnShopInterface.NativeFieldInfoPtr_FadeOutAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "FadeOutAnim");
			PawnShopInterface.NativeFieldInfoPtr_OfferInputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "OfferInputField");
			PawnShopInterface.NativeFieldInfoPtr_AngerSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "AngerSlider");
			PawnShopInterface.NativeFieldInfoPtr_AcceptCounterButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "AcceptCounterButtonLabel");
			PawnShopInterface.NativeFieldInfoPtr_OfferLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "OfferLines");
			PawnShopInterface.NativeFieldInfoPtr_ThinkLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "ThinkLines");
			PawnShopInterface.NativeFieldInfoPtr_AcceptLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "AcceptLines");
			PawnShopInterface.NativeFieldInfoPtr_CounterLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "CounterLines");
			PawnShopInterface.NativeFieldInfoPtr_RefusalLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "RefusalLines");
			PawnShopInterface.NativeFieldInfoPtr_DealFinalizedLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "DealFinalizedLines");
			PawnShopInterface.NativeFieldInfoPtr_AngeredLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "AngeredLines");
			PawnShopInterface.NativeFieldInfoPtr_CrashOutLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "CrashOutLines");
			PawnShopInterface.NativeFieldInfoPtr_PawnSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "PawnSlots");
			PawnShopInterface.NativeFieldInfoPtr_routine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "routine");
			PawnShopInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681076);
			PawnShopInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681077);
			PawnShopInterface.NativeMethodInfoPtr_get_SelectedPayment_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681078);
			PawnShopInterface.NativeMethodInfoPtr_set_SelectedPayment_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681079);
			PawnShopInterface.NativeMethodInfoPtr_get_NPCAnger_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681080);
			PawnShopInterface.NativeMethodInfoPtr_set_NPCAnger_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681081);
			PawnShopInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681082);
			PawnShopInterface.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681083);
			PawnShopInterface.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681084);
			PawnShopInterface.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681085);
			PawnShopInterface.NativeMethodInfoPtr_Close_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681086);
			PawnShopInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681087);
			PawnShopInterface.NativeMethodInfoPtr_OnMinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681088);
			PawnShopInterface.NativeMethodInfoPtr_OnDayPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681089);
			PawnShopInterface.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681090);
			PawnShopInterface.NativeMethodInfoPtr_GetPawnItems_Private_List_1_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681091);
			PawnShopInterface.NativeMethodInfoPtr_PawnSlotChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681092);
			PawnShopInterface.NativeMethodInfoPtr_UpdateValueRangeLabels_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681093);
			PawnShopInterface.NativeMethodInfoPtr_StartButtonPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681094);
			PawnShopInterface.NativeMethodInfoPtr_StartNegotiation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681095);
			PawnShopInterface.NativeMethodInfoPtr_PlayShopResponse_Private_Void_EShopResponse_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681096);
			PawnShopInterface.NativeMethodInfoPtr_EvaluateCounter_Private_EShopResponse_Single_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681097);
			PawnShopInterface.NativeMethodInfoPtr_EndNegotiation_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681098);
			PawnShopInterface.NativeMethodInfoPtr_PaymentSubmitted_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681099);
			PawnShopInterface.NativeMethodInfoPtr_ChangePayment_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681100);
			PawnShopInterface.NativeMethodInfoPtr_SetSelectedPayment_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681101);
			PawnShopInterface.NativeMethodInfoPtr_SetPlayerResponse_Public_Void_EPlayerResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681102);
			PawnShopInterface.NativeMethodInfoPtr_AcceptOrCounter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681103);
			PawnShopInterface.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681104);
			PawnShopInterface.NativeMethodInfoPtr_ChangeAnger_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681105);
			PawnShopInterface.NativeMethodInfoPtr_SetAngeredToday_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681106);
			PawnShopInterface.NativeMethodInfoPtr_Think_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681107);
			PawnShopInterface.NativeMethodInfoPtr_SetOffer_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681108);
			PawnShopInterface.NativeMethodInfoPtr_FinalizeDeal_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681109);
			PawnShopInterface.NativeMethodInfoPtr_GetTotalValue_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681110);
			PawnShopInterface.NativeMethodInfoPtr_RoundOffer_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681111);
			PawnShopInterface.NativeMethodInfoPtr_GetItemValue_Private_Single_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681112);
			PawnShopInterface.NativeMethodInfoPtr_ResetUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681113);
			PawnShopInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681114);
			PawnShopInterface.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681115);
			PawnShopInterface.NativeMethodInfoPtr__StartNegotiation_b__67_1_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681116);
			PawnShopInterface.NativeMethodInfoPtr__StartNegotiation_b__67_2_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, 100681117);
		}

		// Token: 0x17002C07 RID: 11271
		// (get) Token: 0x06008F65 RID: 36709 RVA: 0x0025394C File Offset: 0x00251B4C
		// (set) Token: 0x06008F66 RID: 36710 RVA: 0x00253988 File Offset: 0x00251B88
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37988, RefRangeEnd = 38011, XrefRangeStart = 37988, XrefRangeEnd = 38011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002C08 RID: 11272
		// (get) Token: 0x06008F67 RID: 36711 RVA: 0x002539C8 File Offset: 0x00251BC8
		// (set) Token: 0x06008F68 RID: 36712 RVA: 0x00253A04 File Offset: 0x00251C04
		public unsafe float SelectedPayment
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_get_SelectedPayment_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_set_SelectedPayment_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002C09 RID: 11273
		// (get) Token: 0x06008F69 RID: 36713 RVA: 0x00253A44 File Offset: 0x00251C44
		// (set) Token: 0x06008F6A RID: 36714 RVA: 0x00253A80 File Offset: 0x00251C80
		public unsafe float NPCAnger
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_get_NPCAnger_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 83978, RefRangeEnd = 83980, XrefRangeStart = 83978, XrefRangeEnd = 83980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_set_NPCAnger_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008F6B RID: 36715 RVA: 0x00253AC0 File Offset: 0x00251CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260165, XrefRangeEnd = 260238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PawnShopInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F6C RID: 36716 RVA: 0x00253AFC File Offset: 0x00251CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260238, XrefRangeEnd = 260302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PawnShopInterface.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F6D RID: 36717 RVA: 0x00253B38 File Offset: 0x00251D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260302, XrefRangeEnd = 260336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PawnShopInterface.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F6E RID: 36718 RVA: 0x00253B74 File Offset: 0x00251D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260336, XrefRangeEnd = 260397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F6F RID: 36719 RVA: 0x00253BA8 File Offset: 0x00251DA8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 260448, RefRangeEnd = 260451, XrefRangeStart = 260397, XrefRangeEnd = 260448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool returnItemsToPlayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref returnItemsToPlayer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_Close_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F70 RID: 36720 RVA: 0x00253BE8 File Offset: 0x00251DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260451, XrefRangeEnd = 260452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F71 RID: 36721 RVA: 0x00253C2C File Offset: 0x00251E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260452, XrefRangeEnd = 260453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_OnMinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F72 RID: 36722 RVA: 0x00253C60 File Offset: 0x00251E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260453, XrefRangeEnd = 260454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDayPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_OnDayPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F73 RID: 36723 RVA: 0x00253C94 File Offset: 0x00251E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260454, XrefRangeEnd = 260479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F74 RID: 36724 RVA: 0x00253CC8 File Offset: 0x00251EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260479, XrefRangeEnd = 260489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ItemInstance> GetPawnItems()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_GetPawnItems_Private_List_1_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemInstance>>(intPtr3) : null;
		}

		// Token: 0x06008F75 RID: 36725 RVA: 0x00253D08 File Offset: 0x00251F08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260489, XrefRangeEnd = 260490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PawnSlotChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_PawnSlotChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F76 RID: 36726 RVA: 0x00253D3C File Offset: 0x00251F3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 260513, RefRangeEnd = 260515, XrefRangeStart = 260490, XrefRangeEnd = 260513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateValueRangeLabels()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_UpdateValueRangeLabels_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F77 RID: 36727 RVA: 0x00253D70 File Offset: 0x00251F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260515, XrefRangeEnd = 260522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartButtonPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_StartButtonPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F78 RID: 36728 RVA: 0x00253DA4 File Offset: 0x00251FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartNegotiation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_StartNegotiation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F79 RID: 36729 RVA: 0x00253DD8 File Offset: 0x00251FD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260522, XrefRangeEnd = 260528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayShopResponse(PawnShopInterface.EShopResponse response, float counter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref response;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref counter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_PlayShopResponse_Private_Void_EShopResponse_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F7A RID: 36730 RVA: 0x00253E24 File Offset: 0x00252024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260528, XrefRangeEnd = 260557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PawnShopInterface.EShopResponse EvaluateCounter(float lastShopOffer, float playerOffer, out float counterAmount, out float angerChange)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lastShopOffer;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerOffer;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &counterAmount;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &angerChange;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_EvaluateCounter_Private_EShopResponse_Single_Single_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008F7B RID: 36731 RVA: 0x00253E98 File Offset: 0x00252098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260557, XrefRangeEnd = 260561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndNegotiation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_EndNegotiation_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F7C RID: 36732 RVA: 0x00253ECC File Offset: 0x002520CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260561, XrefRangeEnd = 260563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PaymentSubmitted(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_PaymentSubmitted_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F7D RID: 36733 RVA: 0x00253F10 File Offset: 0x00252110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260563, XrefRangeEnd = 260564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangePayment(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_ChangePayment_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F7E RID: 36734 RVA: 0x00253F50 File Offset: 0x00252150
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 260584, RefRangeEnd = 260587, XrefRangeStart = 260564, XrefRangeEnd = 260584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelectedPayment(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_SetSelectedPayment_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F7F RID: 36735 RVA: 0x00253F90 File Offset: 0x00252190
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 260597, RefRangeEnd = 260600, XrefRangeStart = 260587, XrefRangeEnd = 260597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayerResponse(PawnShopInterface.EPlayerResponse response)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref response;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_SetPlayerResponse_Public_Void_EPlayerResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F80 RID: 36736 RVA: 0x00253FD0 File Offset: 0x002521D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260600, XrefRangeEnd = 260601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AcceptOrCounter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_AcceptOrCounter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F81 RID: 36737 RVA: 0x00254004 File Offset: 0x00252204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260601, XrefRangeEnd = 260602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F82 RID: 36738 RVA: 0x00254038 File Offset: 0x00252238
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260635, RefRangeEnd = 260636, XrefRangeStart = 260602, XrefRangeEnd = 260635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeAnger(float change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref change;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_ChangeAnger_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F83 RID: 36739 RVA: 0x00254078 File Offset: 0x00252278
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 260655, RefRangeEnd = 260657, XrefRangeStart = 260636, XrefRangeEnd = 260655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAngeredToday(bool angered)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angered;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_SetAngeredToday_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F84 RID: 36740 RVA: 0x002540B8 File Offset: 0x002522B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260661, RefRangeEnd = 260662, XrefRangeStart = 260657, XrefRangeEnd = 260661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Think()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_Think_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F85 RID: 36741 RVA: 0x002540EC File Offset: 0x002522EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260676, RefRangeEnd = 260677, XrefRangeStart = 260662, XrefRangeEnd = 260676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOffer(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_SetOffer_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F86 RID: 36742 RVA: 0x0025412C File Offset: 0x0025232C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260687, RefRangeEnd = 260688, XrefRangeStart = 260677, XrefRangeEnd = 260687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinalizeDeal(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_FinalizeDeal_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F87 RID: 36743 RVA: 0x0025416C File Offset: 0x0025236C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260688, XrefRangeEnd = 260690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTotalValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_GetTotalValue_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008F88 RID: 36744 RVA: 0x002541A8 File Offset: 0x002523A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 260691, RefRangeEnd = 260693, XrefRangeStart = 260690, XrefRangeEnd = 260691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float RoundOffer(float offer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref offer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_RoundOffer_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008F89 RID: 36745 RVA: 0x002541F4 File Offset: 0x002523F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 260723, RefRangeEnd = 260725, XrefRangeStart = 260693, XrefRangeEnd = 260723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetItemValue(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_GetItemValue_Private_Single_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008F8A RID: 36746 RVA: 0x00254244 File Offset: 0x00252444
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 260732, RefRangeEnd = 260735, XrefRangeStart = 260725, XrefRangeEnd = 260732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_ResetUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F8B RID: 36747 RVA: 0x00254278 File Offset: 0x00252478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260735, XrefRangeEnd = 260738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PawnShopInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008F8C RID: 36748 RVA: 0x002542B4 File Offset: 0x002524B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260738, XrefRangeEnd = 260743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008F8D RID: 36749 RVA: 0x002542F4 File Offset: 0x002524F4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 260743, RefRangeEnd = 260752, XrefRangeStart = 260743, XrefRangeEnd = 260743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _StartNegotiation_b__67_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr__StartNegotiation_b__67_1_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008F8E RID: 36750 RVA: 0x00254330 File Offset: 0x00252530
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 260743, RefRangeEnd = 260752, XrefRangeStart = 260743, XrefRangeEnd = 260752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _StartNegotiation_b__67_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.NativeMethodInfoPtr__StartNegotiation_b__67_2_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008F8F RID: 36751 RVA: 0x0004520D File Offset: 0x0004340D
		public PawnShopInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002BDD RID: 11229
		// (get) Token: 0x06008F90 RID: 36752 RVA: 0x0025436C File Offset: 0x0025256C
		// (set) Token: 0x06008F91 RID: 36753 RVA: 0x00045216 File Offset: 0x00043416
		public unsafe static float PAYMENT_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PawnShopInterface.NativeFieldInfoPtr_PAYMENT_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PawnShopInterface.NativeFieldInfoPtr_PAYMENT_MIN, (void*)(&value));
			}
		}

		// Token: 0x17002BDE RID: 11230
		// (get) Token: 0x06008F92 RID: 36754 RVA: 0x00254388 File Offset: 0x00252588
		// (set) Token: 0x06008F93 RID: 36755 RVA: 0x00045224 File Offset: 0x00043424
		public unsafe static float PAYMENT_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PawnShopInterface.NativeFieldInfoPtr_PAYMENT_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PawnShopInterface.NativeFieldInfoPtr_PAYMENT_MAX, (void*)(&value));
			}
		}

		// Token: 0x17002BDF RID: 11231
		// (get) Token: 0x06008F94 RID: 36756 RVA: 0x002543A4 File Offset: 0x002525A4
		// (set) Token: 0x06008F95 RID: 36757 RVA: 0x00045232 File Offset: 0x00043432
		public unsafe static float THINK_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PawnShopInterface.NativeFieldInfoPtr_THINK_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PawnShopInterface.NativeFieldInfoPtr_THINK_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002BE0 RID: 11232
		// (get) Token: 0x06008F96 RID: 36758 RVA: 0x002543C0 File Offset: 0x002525C0
		// (set) Token: 0x06008F97 RID: 36759 RVA: 0x00045240 File Offset: 0x00043440
		public unsafe static float MIN_VALUE_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PawnShopInterface.NativeFieldInfoPtr_MIN_VALUE_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PawnShopInterface.NativeFieldInfoPtr_MIN_VALUE_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17002BE1 RID: 11233
		// (get) Token: 0x06008F98 RID: 36760 RVA: 0x002543DC File Offset: 0x002525DC
		// (set) Token: 0x06008F99 RID: 36761 RVA: 0x0004524E File Offset: 0x0004344E
		public unsafe static float MAX_VALUE_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PawnShopInterface.NativeFieldInfoPtr_MAX_VALUE_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PawnShopInterface.NativeFieldInfoPtr_MAX_VALUE_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17002BE2 RID: 11234
		// (get) Token: 0x06008F9A RID: 36762 RVA: 0x002543F8 File Offset: 0x002525F8
		// (set) Token: 0x06008F9B RID: 36763 RVA: 0x0004525C File Offset: 0x0004345C
		public unsafe static int PAWN_SLOT_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PawnShopInterface.NativeFieldInfoPtr_PAWN_SLOT_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PawnShopInterface.NativeFieldInfoPtr_PAWN_SLOT_COUNT, (void*)(&value));
			}
		}

		// Token: 0x17002BE3 RID: 11235
		// (get) Token: 0x06008F9C RID: 36764 RVA: 0x00254414 File Offset: 0x00252614
		// (set) Token: 0x06008F9D RID: 36765 RVA: 0x0004526A File Offset: 0x0004346A
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002BE4 RID: 11236
		// (get) Token: 0x06008F9E RID: 36766 RVA: 0x0025443C File Offset: 0x0025263C
		// (set) Token: 0x06008F9F RID: 36767 RVA: 0x00045285 File Offset: 0x00043485
		public unsafe PawnShopInterface.EState CurrentState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CurrentState);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CurrentState)) = value;
			}
		}

		// Token: 0x17002BE5 RID: 11237
		// (get) Token: 0x06008FA0 RID: 36768 RVA: 0x00254464 File Offset: 0x00252664
		// (set) Token: 0x06008FA1 RID: 36769 RVA: 0x000452A0 File Offset: 0x000434A0
		public unsafe PawnShopInterface.EPlayerResponse PlayerResponse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_PlayerResponse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_PlayerResponse)) = value;
			}
		}

		// Token: 0x17002BE6 RID: 11238
		// (get) Token: 0x06008FA2 RID: 36770 RVA: 0x0025448C File Offset: 0x0025268C
		// (set) Token: 0x06008FA3 RID: 36771 RVA: 0x000452BB File Offset: 0x000434BB
		public unsafe int CurrentNegotiationRound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CurrentNegotiationRound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CurrentNegotiationRound)) = value;
			}
		}

		// Token: 0x17002BE7 RID: 11239
		// (get) Token: 0x06008FA4 RID: 36772 RVA: 0x002544B4 File Offset: 0x002526B4
		// (set) Token: 0x06008FA5 RID: 36773 RVA: 0x000452D6 File Offset: 0x000434D6
		public unsafe float InitialShopOffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_InitialShopOffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_InitialShopOffer)) = value;
			}
		}

		// Token: 0x17002BE8 RID: 11240
		// (get) Token: 0x06008FA6 RID: 36774 RVA: 0x002544DC File Offset: 0x002526DC
		// (set) Token: 0x06008FA7 RID: 36775 RVA: 0x000452F1 File Offset: 0x000434F1
		public unsafe float LastShopOffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_LastShopOffer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_LastShopOffer)) = value;
			}
		}

		// Token: 0x17002BE9 RID: 11241
		// (get) Token: 0x06008FA8 RID: 36776 RVA: 0x00254504 File Offset: 0x00252704
		// (set) Token: 0x06008FA9 RID: 36777 RVA: 0x0004530C File Offset: 0x0004350C
		public unsafe float LastRefusedAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_LastRefusedAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_LastRefusedAmount)) = value;
			}
		}

		// Token: 0x17002BEA RID: 11242
		// (get) Token: 0x06008FAA RID: 36778 RVA: 0x0025452C File Offset: 0x0025272C
		// (set) Token: 0x06008FAB RID: 36779 RVA: 0x00045327 File Offset: 0x00043527
		public unsafe NPC PawnShopNPC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_PawnShopNPC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_PawnShopNPC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BEB RID: 11243
		// (get) Token: 0x06008FAC RID: 36780 RVA: 0x0025455C File Offset: 0x0025275C
		// (set) Token: 0x06008FAD RID: 36781 RVA: 0x00045346 File Offset: 0x00043546
		public unsafe float _SelectedPayment_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr__SelectedPayment_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr__SelectedPayment_k__BackingField)) = value;
			}
		}

		// Token: 0x17002BEC RID: 11244
		// (get) Token: 0x06008FAE RID: 36782 RVA: 0x00254584 File Offset: 0x00252784
		// (set) Token: 0x06008FAF RID: 36783 RVA: 0x00045361 File Offset: 0x00043561
		public unsafe float _NPCAnger_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr__NPCAnger_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr__NPCAnger_k__BackingField)) = value;
			}
		}

		// Token: 0x17002BED RID: 11245
		// (get) Token: 0x06008FB0 RID: 36784 RVA: 0x002545AC File Offset: 0x002527AC
		// (set) Token: 0x06008FB1 RID: 36785 RVA: 0x0004537C File Offset: 0x0004357C
		public unsafe AnimationCurve RandomCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_RandomCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_RandomCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BEE RID: 11246
		// (get) Token: 0x06008FB2 RID: 36786 RVA: 0x002545DC File Offset: 0x002527DC
		// (set) Token: 0x06008FB3 RID: 36787 RVA: 0x0004539B File Offset: 0x0004359B
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BEF RID: 11247
		// (get) Token: 0x06008FB4 RID: 36788 RVA: 0x0025460C File Offset: 0x0025280C
		// (set) Token: 0x06008FB5 RID: 36789 RVA: 0x000453BA File Offset: 0x000435BA
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BF0 RID: 11248
		// (get) Token: 0x06008FB6 RID: 36790 RVA: 0x0025463C File Offset: 0x0025283C
		// (set) Token: 0x06008FB7 RID: 36791 RVA: 0x000453D9 File Offset: 0x000435D9
		public unsafe Il2CppReferenceArray<ItemSlotUI> Slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlotUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BF1 RID: 11249
		// (get) Token: 0x06008FB8 RID: 36792 RVA: 0x0025466C File Offset: 0x0025286C
		// (set) Token: 0x06008FB9 RID: 36793 RVA: 0x000453F8 File Offset: 0x000435F8
		public unsafe Il2CppReferenceArray<TextMeshProUGUI> ValueRangeLabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_ValueRangeLabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMeshProUGUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_ValueRangeLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BF2 RID: 11250
		// (get) Token: 0x06008FBA RID: 36794 RVA: 0x0025469C File Offset: 0x0025289C
		// (set) Token: 0x06008FBB RID: 36795 RVA: 0x00045417 File Offset: 0x00043617
		public unsafe TextMeshProUGUI TotalValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_TotalValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_TotalValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BF3 RID: 11251
		// (get) Token: 0x06008FBC RID: 36796 RVA: 0x002546CC File Offset: 0x002528CC
		// (set) Token: 0x06008FBD RID: 36797 RVA: 0x00045436 File Offset: 0x00043636
		public unsafe Button StartButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_StartButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_StartButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BF4 RID: 11252
		// (get) Token: 0x06008FBE RID: 36798 RVA: 0x002546FC File Offset: 0x002528FC
		// (set) Token: 0x06008FBF RID: 36799 RVA: 0x00045455 File Offset: 0x00043655
		public unsafe Animation Step1Animation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step1Animation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step1Animation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BF5 RID: 11253
		// (get) Token: 0x06008FC0 RID: 36800 RVA: 0x0025472C File Offset: 0x0025292C
		// (set) Token: 0x06008FC1 RID: 36801 RVA: 0x00045474 File Offset: 0x00043674
		public unsafe CanvasGroup Step1CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step1CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step1CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BF6 RID: 11254
		// (get) Token: 0x06008FC2 RID: 36802 RVA: 0x0025475C File Offset: 0x0025295C
		// (set) Token: 0x06008FC3 RID: 36803 RVA: 0x00045493 File Offset: 0x00043693
		public unsafe Animation Step2Animation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step2Animation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step2Animation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BF7 RID: 11255
		// (get) Token: 0x06008FC4 RID: 36804 RVA: 0x0025478C File Offset: 0x0025298C
		// (set) Token: 0x06008FC5 RID: 36805 RVA: 0x000454B2 File Offset: 0x000436B2
		public unsafe CanvasGroup Step2CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step2CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_Step2CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BF8 RID: 11256
		// (get) Token: 0x06008FC6 RID: 36806 RVA: 0x002547BC File Offset: 0x002529BC
		// (set) Token: 0x06008FC7 RID: 36807 RVA: 0x000454D1 File Offset: 0x000436D1
		public unsafe AnimationClip FadeInAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_FadeInAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_FadeInAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BF9 RID: 11257
		// (get) Token: 0x06008FC8 RID: 36808 RVA: 0x002547EC File Offset: 0x002529EC
		// (set) Token: 0x06008FC9 RID: 36809 RVA: 0x000454F0 File Offset: 0x000436F0
		public unsafe AnimationClip FadeOutAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_FadeOutAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_FadeOutAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BFA RID: 11258
		// (get) Token: 0x06008FCA RID: 36810 RVA: 0x0025481C File Offset: 0x00252A1C
		// (set) Token: 0x06008FCB RID: 36811 RVA: 0x0004550F File Offset: 0x0004370F
		public unsafe TMP_InputField OfferInputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_OfferInputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_OfferInputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BFB RID: 11259
		// (get) Token: 0x06008FCC RID: 36812 RVA: 0x0025484C File Offset: 0x00252A4C
		// (set) Token: 0x06008FCD RID: 36813 RVA: 0x0004552E File Offset: 0x0004372E
		public unsafe Slider AngerSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AngerSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AngerSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BFC RID: 11260
		// (get) Token: 0x06008FCE RID: 36814 RVA: 0x0025487C File Offset: 0x00252A7C
		// (set) Token: 0x06008FCF RID: 36815 RVA: 0x0004554D File Offset: 0x0004374D
		public unsafe TextMeshProUGUI AcceptCounterButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AcceptCounterButtonLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AcceptCounterButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BFD RID: 11261
		// (get) Token: 0x06008FD0 RID: 36816 RVA: 0x002548AC File Offset: 0x00252AAC
		// (set) Token: 0x06008FD1 RID: 36817 RVA: 0x0004556C File Offset: 0x0004376C
		public unsafe Il2CppStringArray OfferLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_OfferLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_OfferLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BFE RID: 11262
		// (get) Token: 0x06008FD2 RID: 36818 RVA: 0x002548DC File Offset: 0x00252ADC
		// (set) Token: 0x06008FD3 RID: 36819 RVA: 0x0004558B File Offset: 0x0004378B
		public unsafe Il2CppStringArray ThinkLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_ThinkLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_ThinkLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BFF RID: 11263
		// (get) Token: 0x06008FD4 RID: 36820 RVA: 0x0025490C File Offset: 0x00252B0C
		// (set) Token: 0x06008FD5 RID: 36821 RVA: 0x000455AA File Offset: 0x000437AA
		public unsafe Il2CppStringArray AcceptLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AcceptLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AcceptLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C00 RID: 11264
		// (get) Token: 0x06008FD6 RID: 36822 RVA: 0x0025493C File Offset: 0x00252B3C
		// (set) Token: 0x06008FD7 RID: 36823 RVA: 0x000455C9 File Offset: 0x000437C9
		public unsafe Il2CppStringArray CounterLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CounterLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CounterLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C01 RID: 11265
		// (get) Token: 0x06008FD8 RID: 36824 RVA: 0x0025496C File Offset: 0x00252B6C
		// (set) Token: 0x06008FD9 RID: 36825 RVA: 0x000455E8 File Offset: 0x000437E8
		public unsafe Il2CppStringArray RefusalLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_RefusalLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_RefusalLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C02 RID: 11266
		// (get) Token: 0x06008FDA RID: 36826 RVA: 0x0025499C File Offset: 0x00252B9C
		// (set) Token: 0x06008FDB RID: 36827 RVA: 0x00045607 File Offset: 0x00043807
		public unsafe Il2CppStringArray DealFinalizedLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_DealFinalizedLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_DealFinalizedLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C03 RID: 11267
		// (get) Token: 0x06008FDC RID: 36828 RVA: 0x002549CC File Offset: 0x00252BCC
		// (set) Token: 0x06008FDD RID: 36829 RVA: 0x00045626 File Offset: 0x00043826
		public unsafe Il2CppStringArray AngeredLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AngeredLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_AngeredLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C04 RID: 11268
		// (get) Token: 0x06008FDE RID: 36830 RVA: 0x002549FC File Offset: 0x00252BFC
		// (set) Token: 0x06008FDF RID: 36831 RVA: 0x00045645 File Offset: 0x00043845
		public unsafe Il2CppStringArray CrashOutLines
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CrashOutLines);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_CrashOutLines), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C05 RID: 11269
		// (get) Token: 0x06008FE0 RID: 36832 RVA: 0x00254A2C File Offset: 0x00252C2C
		// (set) Token: 0x06008FE1 RID: 36833 RVA: 0x00045664 File Offset: 0x00043864
		public unsafe Il2CppReferenceArray<ItemSlot> PawnSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_PawnSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_PawnSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002C06 RID: 11270
		// (get) Token: 0x06008FE2 RID: 36834 RVA: 0x00254A5C File Offset: 0x00252C5C
		// (set) Token: 0x06008FE3 RID: 36835 RVA: 0x00045683 File Offset: 0x00043883
		public unsafe Coroutine routine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_routine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.NativeFieldInfoPtr_routine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006100 RID: 24832
		private static readonly IntPtr NativeFieldInfoPtr_PAYMENT_MIN;

		// Token: 0x04006101 RID: 24833
		private static readonly IntPtr NativeFieldInfoPtr_PAYMENT_MAX;

		// Token: 0x04006102 RID: 24834
		private static readonly IntPtr NativeFieldInfoPtr_THINK_TIME;

		// Token: 0x04006103 RID: 24835
		private static readonly IntPtr NativeFieldInfoPtr_MIN_VALUE_MULTIPLIER;

		// Token: 0x04006104 RID: 24836
		private static readonly IntPtr NativeFieldInfoPtr_MAX_VALUE_MULTIPLIER;

		// Token: 0x04006105 RID: 24837
		private static readonly IntPtr NativeFieldInfoPtr_PAWN_SLOT_COUNT;

		// Token: 0x04006106 RID: 24838
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006107 RID: 24839
		private static readonly IntPtr NativeFieldInfoPtr_CurrentState;

		// Token: 0x04006108 RID: 24840
		private static readonly IntPtr NativeFieldInfoPtr_PlayerResponse;

		// Token: 0x04006109 RID: 24841
		private static readonly IntPtr NativeFieldInfoPtr_CurrentNegotiationRound;

		// Token: 0x0400610A RID: 24842
		private static readonly IntPtr NativeFieldInfoPtr_InitialShopOffer;

		// Token: 0x0400610B RID: 24843
		private static readonly IntPtr NativeFieldInfoPtr_LastShopOffer;

		// Token: 0x0400610C RID: 24844
		private static readonly IntPtr NativeFieldInfoPtr_LastRefusedAmount;

		// Token: 0x0400610D RID: 24845
		private static readonly IntPtr NativeFieldInfoPtr_PawnShopNPC;

		// Token: 0x0400610E RID: 24846
		private static readonly IntPtr NativeFieldInfoPtr__SelectedPayment_k__BackingField;

		// Token: 0x0400610F RID: 24847
		private static readonly IntPtr NativeFieldInfoPtr__NPCAnger_k__BackingField;

		// Token: 0x04006110 RID: 24848
		private static readonly IntPtr NativeFieldInfoPtr_RandomCurve;

		// Token: 0x04006111 RID: 24849
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006112 RID: 24850
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006113 RID: 24851
		private static readonly IntPtr NativeFieldInfoPtr_Slots;

		// Token: 0x04006114 RID: 24852
		private static readonly IntPtr NativeFieldInfoPtr_ValueRangeLabels;

		// Token: 0x04006115 RID: 24853
		private static readonly IntPtr NativeFieldInfoPtr_TotalValueLabel;

		// Token: 0x04006116 RID: 24854
		private static readonly IntPtr NativeFieldInfoPtr_StartButton;

		// Token: 0x04006117 RID: 24855
		private static readonly IntPtr NativeFieldInfoPtr_Step1Animation;

		// Token: 0x04006118 RID: 24856
		private static readonly IntPtr NativeFieldInfoPtr_Step1CanvasGroup;

		// Token: 0x04006119 RID: 24857
		private static readonly IntPtr NativeFieldInfoPtr_Step2Animation;

		// Token: 0x0400611A RID: 24858
		private static readonly IntPtr NativeFieldInfoPtr_Step2CanvasGroup;

		// Token: 0x0400611B RID: 24859
		private static readonly IntPtr NativeFieldInfoPtr_FadeInAnim;

		// Token: 0x0400611C RID: 24860
		private static readonly IntPtr NativeFieldInfoPtr_FadeOutAnim;

		// Token: 0x0400611D RID: 24861
		private static readonly IntPtr NativeFieldInfoPtr_OfferInputField;

		// Token: 0x0400611E RID: 24862
		private static readonly IntPtr NativeFieldInfoPtr_AngerSlider;

		// Token: 0x0400611F RID: 24863
		private static readonly IntPtr NativeFieldInfoPtr_AcceptCounterButtonLabel;

		// Token: 0x04006120 RID: 24864
		private static readonly IntPtr NativeFieldInfoPtr_OfferLines;

		// Token: 0x04006121 RID: 24865
		private static readonly IntPtr NativeFieldInfoPtr_ThinkLines;

		// Token: 0x04006122 RID: 24866
		private static readonly IntPtr NativeFieldInfoPtr_AcceptLines;

		// Token: 0x04006123 RID: 24867
		private static readonly IntPtr NativeFieldInfoPtr_CounterLines;

		// Token: 0x04006124 RID: 24868
		private static readonly IntPtr NativeFieldInfoPtr_RefusalLines;

		// Token: 0x04006125 RID: 24869
		private static readonly IntPtr NativeFieldInfoPtr_DealFinalizedLines;

		// Token: 0x04006126 RID: 24870
		private static readonly IntPtr NativeFieldInfoPtr_AngeredLines;

		// Token: 0x04006127 RID: 24871
		private static readonly IntPtr NativeFieldInfoPtr_CrashOutLines;

		// Token: 0x04006128 RID: 24872
		private static readonly IntPtr NativeFieldInfoPtr_PawnSlots;

		// Token: 0x04006129 RID: 24873
		private static readonly IntPtr NativeFieldInfoPtr_routine;

		// Token: 0x0400612A RID: 24874
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400612B RID: 24875
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x0400612C RID: 24876
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedPayment_Public_get_Single_0;

		// Token: 0x0400612D RID: 24877
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedPayment_Private_set_Void_Single_0;

		// Token: 0x0400612E RID: 24878
		private static readonly IntPtr NativeMethodInfoPtr_get_NPCAnger_Public_get_Single_0;

		// Token: 0x0400612F RID: 24879
		private static readonly IntPtr NativeMethodInfoPtr_set_NPCAnger_Private_set_Void_Single_0;

		// Token: 0x04006130 RID: 24880
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006131 RID: 24881
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04006132 RID: 24882
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04006133 RID: 24883
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04006134 RID: 24884
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_Boolean_0;

		// Token: 0x04006135 RID: 24885
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04006136 RID: 24886
		private static readonly IntPtr NativeMethodInfoPtr_OnMinPass_Private_Void_0;

		// Token: 0x04006137 RID: 24887
		private static readonly IntPtr NativeMethodInfoPtr_OnDayPass_Private_Void_0;

		// Token: 0x04006138 RID: 24888
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006139 RID: 24889
		private static readonly IntPtr NativeMethodInfoPtr_GetPawnItems_Private_List_1_ItemInstance_0;

		// Token: 0x0400613A RID: 24890
		private static readonly IntPtr NativeMethodInfoPtr_PawnSlotChanged_Private_Void_0;

		// Token: 0x0400613B RID: 24891
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValueRangeLabels_Private_Void_0;

		// Token: 0x0400613C RID: 24892
		private static readonly IntPtr NativeMethodInfoPtr_StartButtonPressed_Public_Void_0;

		// Token: 0x0400613D RID: 24893
		private static readonly IntPtr NativeMethodInfoPtr_StartNegotiation_Private_Void_0;

		// Token: 0x0400613E RID: 24894
		private static readonly IntPtr NativeMethodInfoPtr_PlayShopResponse_Private_Void_EShopResponse_Single_0;

		// Token: 0x0400613F RID: 24895
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateCounter_Private_EShopResponse_Single_Single_byref_Single_byref_Single_0;

		// Token: 0x04006140 RID: 24896
		private static readonly IntPtr NativeMethodInfoPtr_EndNegotiation_Private_Void_0;

		// Token: 0x04006141 RID: 24897
		private static readonly IntPtr NativeMethodInfoPtr_PaymentSubmitted_Public_Void_String_0;

		// Token: 0x04006142 RID: 24898
		private static readonly IntPtr NativeMethodInfoPtr_ChangePayment_Public_Void_Single_0;

		// Token: 0x04006143 RID: 24899
		private static readonly IntPtr NativeMethodInfoPtr_SetSelectedPayment_Public_Void_Single_0;

		// Token: 0x04006144 RID: 24900
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayerResponse_Public_Void_EPlayerResponse_0;

		// Token: 0x04006145 RID: 24901
		private static readonly IntPtr NativeMethodInfoPtr_AcceptOrCounter_Public_Void_0;

		// Token: 0x04006146 RID: 24902
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

		// Token: 0x04006147 RID: 24903
		private static readonly IntPtr NativeMethodInfoPtr_ChangeAnger_Private_Void_Single_0;

		// Token: 0x04006148 RID: 24904
		private static readonly IntPtr NativeMethodInfoPtr_SetAngeredToday_Private_Void_Boolean_0;

		// Token: 0x04006149 RID: 24905
		private static readonly IntPtr NativeMethodInfoPtr_Think_Private_Void_0;

		// Token: 0x0400614A RID: 24906
		private static readonly IntPtr NativeMethodInfoPtr_SetOffer_Private_Void_Single_0;

		// Token: 0x0400614B RID: 24907
		private static readonly IntPtr NativeMethodInfoPtr_FinalizeDeal_Private_Void_Single_0;

		// Token: 0x0400614C RID: 24908
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalValue_Private_Single_0;

		// Token: 0x0400614D RID: 24909
		private static readonly IntPtr NativeMethodInfoPtr_RoundOffer_Private_Single_Single_0;

		// Token: 0x0400614E RID: 24910
		private static readonly IntPtr NativeMethodInfoPtr_GetItemValue_Private_Single_ItemInstance_0;

		// Token: 0x0400614F RID: 24911
		private static readonly IntPtr NativeMethodInfoPtr_ResetUI_Private_Void_0;

		// Token: 0x04006150 RID: 24912
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006151 RID: 24913
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04006152 RID: 24914
		private static readonly IntPtr NativeMethodInfoPtr__StartNegotiation_b__67_1_Private_Boolean_0;

		// Token: 0x04006153 RID: 24915
		private static readonly IntPtr NativeMethodInfoPtr__StartNegotiation_b__67_2_Private_Boolean_0;

		// Token: 0x02000B33 RID: 2867
		[OriginalName("Assembly-CSharp.dll", "", "EState")]
		public enum EState
		{
			// Token: 0x04009139 RID: 37177
			WaitingForOffer,
			// Token: 0x0400913A RID: 37178
			Negotiating
		}

		// Token: 0x02000B34 RID: 2868
		[OriginalName("Assembly-CSharp.dll", "", "EPlayerResponse")]
		public enum EPlayerResponse
		{
			// Token: 0x0400913C RID: 37180
			None,
			// Token: 0x0400913D RID: 37181
			Accept,
			// Token: 0x0400913E RID: 37182
			Counter,
			// Token: 0x0400913F RID: 37183
			Cancel
		}

		// Token: 0x02000B35 RID: 2869
		[OriginalName("Assembly-CSharp.dll", "", "EShopResponse")]
		public enum EShopResponse
		{
			// Token: 0x04009141 RID: 37185
			Accept,
			// Token: 0x04009142 RID: 37186
			Counter,
			// Token: 0x04009143 RID: 37187
			Refusal
		}

		// Token: 0x02000B36 RID: 2870
		[ObfuscatedName("ScheduleOne.UI.PawnShopInterface+<<StartNegotiation>g__NegotiationRoutine|67_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D828 RID: 55336 RVA: 0x00335880 File Offset: 0x00333A80
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique()
			{
				Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PawnShopInterface>.NativeClassPtr, "<<StartNegotiation>g__NegotiationRoutine|67_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr);
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, "<>1__state");
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, "<>2__current");
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, "<>4__this");
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr__shopResponse_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, "<shopResponse>5__2");
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr__counter_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, "<counter>5__3");
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, 100681118);
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, 100681119);
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, 100681120);
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, 100681121);
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, 100681122);
				PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr, 100681123);
			}

			// Token: 0x0600D829 RID: 55337 RVA: 0x00335988 File Offset: 0x00333B88
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D82A RID: 55338 RVA: 0x003359D0 File Offset: 0x00333BD0
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D82B RID: 55339 RVA: 0x00335A04 File Offset: 0x00333C04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260115, XrefRangeEnd = 260160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004306 RID: 17158
			// (get) Token: 0x0600D82C RID: 55340 RVA: 0x00335A40 File Offset: 0x00333C40
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D82D RID: 55341 RVA: 0x00335A80 File Offset: 0x00333C80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260160, XrefRangeEnd = 260165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004307 RID: 17159
			// (get) Token: 0x0600D82E RID: 55342 RVA: 0x00335AB4 File Offset: 0x00333CB4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D82F RID: 55343 RVA: 0x00069457 File Offset: 0x00067657
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004301 RID: 17153
			// (get) Token: 0x0600D830 RID: 55344 RVA: 0x00335AF4 File Offset: 0x00333CF4
			// (set) Token: 0x0600D831 RID: 55345 RVA: 0x00069460 File Offset: 0x00067660
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004302 RID: 17154
			// (get) Token: 0x0600D832 RID: 55346 RVA: 0x00335B1C File Offset: 0x00333D1C
			// (set) Token: 0x0600D833 RID: 55347 RVA: 0x0006947B File Offset: 0x0006767B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004303 RID: 17155
			// (get) Token: 0x0600D834 RID: 55348 RVA: 0x00335B4C File Offset: 0x00333D4C
			// (set) Token: 0x0600D835 RID: 55349 RVA: 0x0006949A File Offset: 0x0006769A
			public unsafe PawnShopInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PawnShopInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004304 RID: 17156
			// (get) Token: 0x0600D836 RID: 55350 RVA: 0x00335B7C File Offset: 0x00333D7C
			// (set) Token: 0x0600D837 RID: 55351 RVA: 0x000694B9 File Offset: 0x000676B9
			public unsafe PawnShopInterface.EShopResponse _shopResponse_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr__shopResponse_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr__shopResponse_5__2)) = value;
				}
			}

			// Token: 0x17004305 RID: 17157
			// (get) Token: 0x0600D838 RID: 55352 RVA: 0x00335BA4 File Offset: 0x00333DA4
			// (set) Token: 0x0600D839 RID: 55353 RVA: 0x000694D4 File Offset: 0x000676D4
			public unsafe float _counter_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr__counter_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PawnShopInterface.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaESSiObObUnique.NativeFieldInfoPtr__counter_5__3)) = value;
				}
			}

			// Token: 0x04009144 RID: 37188
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009145 RID: 37189
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009146 RID: 37190
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009147 RID: 37191
			private static readonly IntPtr NativeFieldInfoPtr__shopResponse_5__2;

			// Token: 0x04009148 RID: 37192
			private static readonly IntPtr NativeFieldInfoPtr__counter_5__3;

			// Token: 0x04009149 RID: 37193
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400914A RID: 37194
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400914B RID: 37195
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400914C RID: 37196
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400914D RID: 37197
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400914E RID: 37198
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
