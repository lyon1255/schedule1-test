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
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x020004A7 RID: 1191
	public class SlotMachine : NetworkBehaviour
	{
		// Token: 0x06006853 RID: 26707 RVA: 0x001D4B90 File Offset: 0x001D2D90
		// Note: this type is marked as 'beforefieldinit'.
		static SlotMachine()
		{
			Il2CppClassPointerStore<SlotMachine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "SlotMachine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr);
			SlotMachine.NativeFieldInfoPtr_BetAmounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "BetAmounts");
			SlotMachine.NativeFieldInfoPtr__IsSpinning_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "<IsSpinning>k__BackingField");
			SlotMachine.NativeFieldInfoPtr_DownButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "DownButton");
			SlotMachine.NativeFieldInfoPtr_UpButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "UpButton");
			SlotMachine.NativeFieldInfoPtr_HandleIntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "HandleIntObj");
			SlotMachine.NativeFieldInfoPtr_BetAmountLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "BetAmountLabel");
			SlotMachine.NativeFieldInfoPtr_Reels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "Reels");
			SlotMachine.NativeFieldInfoPtr_SpinLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "SpinLoop");
			SlotMachine.NativeFieldInfoPtr_ScreenAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "ScreenAnimation");
			SlotMachine.NativeFieldInfoPtr_JackpotParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "JackpotParticles");
			SlotMachine.NativeFieldInfoPtr_WinAmountLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "WinAmountLabels");
			SlotMachine.NativeFieldInfoPtr_MiniWinAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "MiniWinAnimation");
			SlotMachine.NativeFieldInfoPtr_SmallWinAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "SmallWinAnimation");
			SlotMachine.NativeFieldInfoPtr_BigWinAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "BigWinAnimation");
			SlotMachine.NativeFieldInfoPtr_JackpotAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "JackpotAnimation");
			SlotMachine.NativeFieldInfoPtr_MiniWinSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "MiniWinSound");
			SlotMachine.NativeFieldInfoPtr_SmallWinSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "SmallWinSound");
			SlotMachine.NativeFieldInfoPtr_BigWinSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "BigWinSound");
			SlotMachine.NativeFieldInfoPtr_JackpotSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "JackpotSound");
			SlotMachine.NativeFieldInfoPtr_onDownPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "onDownPressed");
			SlotMachine.NativeFieldInfoPtr_onUpPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "onUpPressed");
			SlotMachine.NativeFieldInfoPtr_onHandlePulled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "onHandlePulled");
			SlotMachine.NativeFieldInfoPtr_currentBetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "currentBetIndex");
			SlotMachine.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Casino.SlotMachineAssembly-CSharp.dll_Excuted");
			SlotMachine.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Casino.SlotMachineAssembly-CSharp.dll_Excuted");
			SlotMachine.NativeMethodInfoPtr_get_IsSpinning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676577);
			SlotMachine.NativeMethodInfoPtr_set_IsSpinning_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676578);
			SlotMachine.NativeMethodInfoPtr_get_currentBetAmount_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676579);
			SlotMachine.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676580);
			SlotMachine.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676581);
			SlotMachine.NativeMethodInfoPtr_DownHovered_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676582);
			SlotMachine.NativeMethodInfoPtr_DownInteracted_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676583);
			SlotMachine.NativeMethodInfoPtr_UpHovered_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676584);
			SlotMachine.NativeMethodInfoPtr_UpInteracted_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676585);
			SlotMachine.NativeMethodInfoPtr_HandleHovered_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676586);
			SlotMachine.NativeMethodInfoPtr_HandleInteracted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676587);
			SlotMachine.NativeMethodInfoPtr_SendBetIndex_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676588);
			SlotMachine.NativeMethodInfoPtr_SetBetIndex_Public_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676589);
			SlotMachine.NativeMethodInfoPtr_SendStartSpin_Public_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676590);
			SlotMachine.NativeMethodInfoPtr_StartSpin_Public_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676591);
			SlotMachine.NativeMethodInfoPtr_EvaluateOutcome_Private_EOutcome_Il2CppStructArray_1_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676592);
			SlotMachine.NativeMethodInfoPtr_GetWinAmount_Private_Int32_EOutcome_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676593);
			SlotMachine.NativeMethodInfoPtr_DisplayOutcome_Private_Void_EOutcome_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676594);
			SlotMachine.NativeMethodInfoPtr_GetRandomSymbol_Public_Static_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676595);
			SlotMachine.NativeMethodInfoPtr_IsFruit_Private_Boolean_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676596);
			SlotMachine.NativeMethodInfoPtr_IsAllFruit_Private_Boolean_Il2CppStructArray_1_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676597);
			SlotMachine.NativeMethodInfoPtr_IsUniform_Private_Boolean_Il2CppStructArray_1_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676598);
			SlotMachine.NativeMethodInfoPtr_SimulateMany_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676599);
			SlotMachine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676600);
			SlotMachine.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676602);
			SlotMachine.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676603);
			SlotMachine.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676604);
			SlotMachine.NativeMethodInfoPtr_RpcWriter___Server_SendBetIndex_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676605);
			SlotMachine.NativeMethodInfoPtr_RpcLogic___SendBetIndex_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676606);
			SlotMachine.NativeMethodInfoPtr_RpcReader___Server_SendBetIndex_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676607);
			SlotMachine.NativeMethodInfoPtr_RpcWriter___Observers_SetBetIndex_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676608);
			SlotMachine.NativeMethodInfoPtr_RpcLogic___SetBetIndex_2681120339_Public_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676609);
			SlotMachine.NativeMethodInfoPtr_RpcReader___Observers_SetBetIndex_2681120339_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676610);
			SlotMachine.NativeMethodInfoPtr_RpcWriter___Target_SetBetIndex_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676611);
			SlotMachine.NativeMethodInfoPtr_RpcReader___Target_SetBetIndex_2681120339_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676612);
			SlotMachine.NativeMethodInfoPtr_RpcWriter___Server_SendStartSpin_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676613);
			SlotMachine.NativeMethodInfoPtr_RpcLogic___SendStartSpin_2681120339_Public_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676614);
			SlotMachine.NativeMethodInfoPtr_RpcReader___Server_SendStartSpin_2681120339_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676615);
			SlotMachine.NativeMethodInfoPtr_RpcWriter___Observers_StartSpin_2659526290_Private_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676616);
			SlotMachine.NativeMethodInfoPtr_RpcLogic___StartSpin_2659526290_Public_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676617);
			SlotMachine.NativeMethodInfoPtr_RpcReader___Observers_StartSpin_2659526290_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676618);
			SlotMachine.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676619);
		}

		// Token: 0x17001F69 RID: 8041
		// (get) Token: 0x06006854 RID: 26708 RVA: 0x001D50FC File Offset: 0x001D32FC
		// (set) Token: 0x06006855 RID: 26709 RVA: 0x001D5138 File Offset: 0x001D3338
		public unsafe bool IsSpinning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_get_IsSpinning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_set_IsSpinning_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F6A RID: 8042
		// (get) Token: 0x06006856 RID: 26710 RVA: 0x001D5178 File Offset: 0x001D3378
		public unsafe int currentBetAmount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 211347, RefRangeEnd = 211350, XrefRangeStart = 211343, XrefRangeEnd = 211347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_get_currentBetAmount_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006857 RID: 26711 RVA: 0x001D51B4 File Offset: 0x001D33B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211350, XrefRangeEnd = 211351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SlotMachine.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006858 RID: 26712 RVA: 0x001D51F0 File Offset: 0x001D33F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211351, XrefRangeEnd = 211353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SlotMachine.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006859 RID: 26713 RVA: 0x001D5240 File Offset: 0x001D3440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211353, XrefRangeEnd = 211356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DownHovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_DownHovered_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600685A RID: 26714 RVA: 0x001D5274 File Offset: 0x001D3474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211356, XrefRangeEnd = 211358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DownInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_DownInteracted_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600685B RID: 26715 RVA: 0x001D52A8 File Offset: 0x001D34A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211358, XrefRangeEnd = 211361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpHovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_UpHovered_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600685C RID: 26716 RVA: 0x001D52DC File Offset: 0x001D34DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211361, XrefRangeEnd = 211373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_UpInteracted_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600685D RID: 26717 RVA: 0x001D5310 File Offset: 0x001D3510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211373, XrefRangeEnd = 211385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleHovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_HandleHovered_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600685E RID: 26718 RVA: 0x001D5344 File Offset: 0x001D3544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211385, XrefRangeEnd = 211424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_HandleInteracted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600685F RID: 26719 RVA: 0x001D5378 File Offset: 0x001D3578
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 211447, RefRangeEnd = 211449, XrefRangeStart = 211424, XrefRangeEnd = 211447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendBetIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_SendBetIndex_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006860 RID: 26720 RVA: 0x001D53B8 File Offset: 0x001D35B8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 211493, RefRangeEnd = 211498, XrefRangeStart = 211449, XrefRangeEnd = 211493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBetIndex(NetworkConnection conn, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_SetBetIndex_Public_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006861 RID: 26721 RVA: 0x001D5408 File Offset: 0x001D3608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211498, XrefRangeEnd = 211522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendStartSpin(NetworkConnection spinner, int betAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spinner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref betAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_SendStartSpin_Public_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006862 RID: 26722 RVA: 0x001D5458 File Offset: 0x001D3658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211522, XrefRangeEnd = 211547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSpin(NetworkConnection spinner, Il2CppStructArray<SlotMachine.ESymbol> symbols, int betAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spinner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref betAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_StartSpin_Public_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006863 RID: 26723 RVA: 0x001D54BC File Offset: 0x001D36BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 211549, RefRangeEnd = 211550, XrefRangeStart = 211547, XrefRangeEnd = 211549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SlotMachine.EOutcome EvaluateOutcome(Il2CppStructArray<SlotMachine.ESymbol> outcome)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(outcome);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_EvaluateOutcome_Private_EOutcome_Il2CppStructArray_1_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006864 RID: 26724 RVA: 0x001D550C File Offset: 0x001D370C
		[CallerCount(0)]
		public unsafe int GetWinAmount(SlotMachine.EOutcome outcome, int betAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref betAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_GetWinAmount_Private_Int32_EOutcome_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006865 RID: 26725 RVA: 0x001D5564 File Offset: 0x001D3764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211550, XrefRangeEnd = 211554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplayOutcome(SlotMachine.EOutcome outcome, int winAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref winAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_DisplayOutcome_Private_Void_EOutcome_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006866 RID: 26726 RVA: 0x001D55B0 File Offset: 0x001D37B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 211570, RefRangeEnd = 211573, XrefRangeStart = 211554, XrefRangeEnd = 211570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SlotMachine.ESymbol GetRandomSymbol()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_GetRandomSymbol_Public_Static_ESymbol_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006867 RID: 26727 RVA: 0x001D55E0 File Offset: 0x001D37E0
		[CallerCount(0)]
		public unsafe bool IsFruit(SlotMachine.ESymbol symbol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref symbol;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_IsFruit_Private_Boolean_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006868 RID: 26728 RVA: 0x001D562C File Offset: 0x001D382C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211573, XrefRangeEnd = 211574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAllFruit(Il2CppStructArray<SlotMachine.ESymbol> symbols)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_IsAllFruit_Private_Boolean_Il2CppStructArray_1_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006869 RID: 26729 RVA: 0x001D567C File Offset: 0x001D387C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211574, XrefRangeEnd = 211575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsUniform(Il2CppStructArray<SlotMachine.ESymbol> symbols)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_IsUniform_Private_Boolean_Il2CppStructArray_1_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600686A RID: 26730 RVA: 0x001D56CC File Offset: 0x001D38CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211575, XrefRangeEnd = 211623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SimulateMany()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_SimulateMany_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600686B RID: 26731 RVA: 0x001D5700 File Offset: 0x001D3900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211623, XrefRangeEnd = 211624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SlotMachine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600686C RID: 26732 RVA: 0x001D573C File Offset: 0x001D393C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211624, XrefRangeEnd = 211656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SlotMachine.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600686D RID: 26733 RVA: 0x001D5778 File Offset: 0x001D3978
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SlotMachine.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600686E RID: 26734 RVA: 0x001D57B4 File Offset: 0x001D39B4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SlotMachine.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600686F RID: 26735 RVA: 0x001D57F0 File Offset: 0x001D39F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211656, XrefRangeEnd = 211676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendBetIndex_3316948804(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcWriter___Server_SendBetIndex_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006870 RID: 26736 RVA: 0x001D5830 File Offset: 0x001D3A30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211676, XrefRangeEnd = 211677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendBetIndex_3316948804(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcLogic___SendBetIndex_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006871 RID: 26737 RVA: 0x001D5870 File Offset: 0x001D3A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211677, XrefRangeEnd = 211682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendBetIndex_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcReader___Server_SendBetIndex_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006872 RID: 26738 RVA: 0x001D58D4 File Offset: 0x001D3AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211682, XrefRangeEnd = 211702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetBetIndex_2681120339(NetworkConnection conn, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcWriter___Observers_SetBetIndex_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006873 RID: 26739 RVA: 0x001D5924 File Offset: 0x001D3B24
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 211710, RefRangeEnd = 211713, XrefRangeStart = 211702, XrefRangeEnd = 211710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetBetIndex_2681120339(NetworkConnection conn, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcLogic___SetBetIndex_2681120339_Public_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006874 RID: 26740 RVA: 0x001D5974 File Offset: 0x001D3B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211713, XrefRangeEnd = 211718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetBetIndex_2681120339(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcReader___Observers_SetBetIndex_2681120339_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006875 RID: 26741 RVA: 0x001D59C4 File Offset: 0x001D3BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211718, XrefRangeEnd = 211738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetBetIndex_2681120339(NetworkConnection conn, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcWriter___Target_SetBetIndex_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006876 RID: 26742 RVA: 0x001D5A14 File Offset: 0x001D3C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211738, XrefRangeEnd = 211743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetBetIndex_2681120339(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcReader___Target_SetBetIndex_2681120339_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006877 RID: 26743 RVA: 0x001D5A64 File Offset: 0x001D3C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211743, XrefRangeEnd = 211764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendStartSpin_2681120339(NetworkConnection spinner, int betAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spinner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref betAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcWriter___Server_SendStartSpin_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006878 RID: 26744 RVA: 0x001D5AB4 File Offset: 0x001D3CB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 211796, RefRangeEnd = 211799, XrefRangeStart = 211764, XrefRangeEnd = 211796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendStartSpin_2681120339(NetworkConnection spinner, int betAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spinner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref betAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcLogic___SendStartSpin_2681120339_Public_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006879 RID: 26745 RVA: 0x001D5B04 File Offset: 0x001D3D04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211799, XrefRangeEnd = 211805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendStartSpin_2681120339(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcReader___Server_SendStartSpin_2681120339_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600687A RID: 26746 RVA: 0x001D5B68 File Offset: 0x001D3D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211805, XrefRangeEnd = 211818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartSpin_2659526290(NetworkConnection spinner, Il2CppStructArray<SlotMachine.ESymbol> symbols, int betAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spinner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref betAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcWriter___Observers_StartSpin_2659526290_Private_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600687B RID: 26747 RVA: 0x001D5BCC File Offset: 0x001D3DCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 211835, RefRangeEnd = 211838, XrefRangeStart = 211818, XrefRangeEnd = 211835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartSpin_2659526290(NetworkConnection spinner, Il2CppStructArray<SlotMachine.ESymbol> symbols, int betAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spinner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref betAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcLogic___StartSpin_2659526290_Public_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600687C RID: 26748 RVA: 0x001D5C30 File Offset: 0x001D3E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211838, XrefRangeEnd = 211845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartSpin_2659526290(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcReader___Observers_StartSpin_2659526290_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600687D RID: 26749 RVA: 0x001D5C80 File Offset: 0x001D3E80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 211884, RefRangeEnd = 211885, XrefRangeStart = 211845, XrefRangeEnd = 211884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600687E RID: 26750 RVA: 0x00031293 File Offset: 0x0002F493
		public SlotMachine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F50 RID: 8016
		// (get) Token: 0x0600687F RID: 26751 RVA: 0x001D5CB4 File Offset: 0x001D3EB4
		// (set) Token: 0x06006880 RID: 26752 RVA: 0x0003129C File Offset: 0x0002F49C
		public unsafe static Il2CppStructArray<int> BetAmounts
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SlotMachine.NativeFieldInfoPtr_BetAmounts, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SlotMachine.NativeFieldInfoPtr_BetAmounts, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F51 RID: 8017
		// (get) Token: 0x06006881 RID: 26753 RVA: 0x001D5CDC File Offset: 0x001D3EDC
		// (set) Token: 0x06006882 RID: 26754 RVA: 0x000312AE File Offset: 0x0002F4AE
		public unsafe bool _IsSpinning_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr__IsSpinning_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr__IsSpinning_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F52 RID: 8018
		// (get) Token: 0x06006883 RID: 26755 RVA: 0x001D5D04 File Offset: 0x001D3F04
		// (set) Token: 0x06006884 RID: 26756 RVA: 0x000312C9 File Offset: 0x0002F4C9
		public unsafe InteractableObject DownButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_DownButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_DownButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F53 RID: 8019
		// (get) Token: 0x06006885 RID: 26757 RVA: 0x001D5D34 File Offset: 0x001D3F34
		// (set) Token: 0x06006886 RID: 26758 RVA: 0x000312E8 File Offset: 0x0002F4E8
		public unsafe InteractableObject UpButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_UpButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_UpButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F54 RID: 8020
		// (get) Token: 0x06006887 RID: 26759 RVA: 0x001D5D64 File Offset: 0x001D3F64
		// (set) Token: 0x06006888 RID: 26760 RVA: 0x00031307 File Offset: 0x0002F507
		public unsafe InteractableObject HandleIntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_HandleIntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_HandleIntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F55 RID: 8021
		// (get) Token: 0x06006889 RID: 26761 RVA: 0x001D5D94 File Offset: 0x001D3F94
		// (set) Token: 0x0600688A RID: 26762 RVA: 0x00031326 File Offset: 0x0002F526
		public unsafe TextMeshPro BetAmountLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_BetAmountLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_BetAmountLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F56 RID: 8022
		// (get) Token: 0x0600688B RID: 26763 RVA: 0x001D5DC4 File Offset: 0x001D3FC4
		// (set) Token: 0x0600688C RID: 26764 RVA: 0x00031345 File Offset: 0x0002F545
		public unsafe Il2CppReferenceArray<SlotReel> Reels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_Reels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SlotReel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_Reels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F57 RID: 8023
		// (get) Token: 0x0600688D RID: 26765 RVA: 0x001D5DF4 File Offset: 0x001D3FF4
		// (set) Token: 0x0600688E RID: 26766 RVA: 0x00031364 File Offset: 0x0002F564
		public unsafe AudioSourceController SpinLoop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_SpinLoop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_SpinLoop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F58 RID: 8024
		// (get) Token: 0x0600688F RID: 26767 RVA: 0x001D5E24 File Offset: 0x001D4024
		// (set) Token: 0x06006890 RID: 26768 RVA: 0x00031383 File Offset: 0x0002F583
		public unsafe Animation ScreenAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_ScreenAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_ScreenAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F59 RID: 8025
		// (get) Token: 0x06006891 RID: 26769 RVA: 0x001D5E54 File Offset: 0x001D4054
		// (set) Token: 0x06006892 RID: 26770 RVA: 0x000313A2 File Offset: 0x0002F5A2
		public unsafe Il2CppReferenceArray<ParticleSystem> JackpotParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_JackpotParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_JackpotParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F5A RID: 8026
		// (get) Token: 0x06006893 RID: 26771 RVA: 0x001D5E84 File Offset: 0x001D4084
		// (set) Token: 0x06006894 RID: 26772 RVA: 0x000313C1 File Offset: 0x0002F5C1
		public unsafe Il2CppReferenceArray<TextMeshProUGUI> WinAmountLabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_WinAmountLabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMeshProUGUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_WinAmountLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F5B RID: 8027
		// (get) Token: 0x06006895 RID: 26773 RVA: 0x001D5EB4 File Offset: 0x001D40B4
		// (set) Token: 0x06006896 RID: 26774 RVA: 0x000313E0 File Offset: 0x0002F5E0
		public unsafe AnimationClip MiniWinAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_MiniWinAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_MiniWinAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F5C RID: 8028
		// (get) Token: 0x06006897 RID: 26775 RVA: 0x001D5EE4 File Offset: 0x001D40E4
		// (set) Token: 0x06006898 RID: 26776 RVA: 0x000313FF File Offset: 0x0002F5FF
		public unsafe AnimationClip SmallWinAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_SmallWinAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_SmallWinAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F5D RID: 8029
		// (get) Token: 0x06006899 RID: 26777 RVA: 0x001D5F14 File Offset: 0x001D4114
		// (set) Token: 0x0600689A RID: 26778 RVA: 0x0003141E File Offset: 0x0002F61E
		public unsafe AnimationClip BigWinAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_BigWinAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_BigWinAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F5E RID: 8030
		// (get) Token: 0x0600689B RID: 26779 RVA: 0x001D5F44 File Offset: 0x001D4144
		// (set) Token: 0x0600689C RID: 26780 RVA: 0x0003143D File Offset: 0x0002F63D
		public unsafe AnimationClip JackpotAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_JackpotAnimation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_JackpotAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F5F RID: 8031
		// (get) Token: 0x0600689D RID: 26781 RVA: 0x001D5F74 File Offset: 0x001D4174
		// (set) Token: 0x0600689E RID: 26782 RVA: 0x0003145C File Offset: 0x0002F65C
		public unsafe AudioSourceController MiniWinSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_MiniWinSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_MiniWinSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F60 RID: 8032
		// (get) Token: 0x0600689F RID: 26783 RVA: 0x001D5FA4 File Offset: 0x001D41A4
		// (set) Token: 0x060068A0 RID: 26784 RVA: 0x0003147B File Offset: 0x0002F67B
		public unsafe AudioSourceController SmallWinSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_SmallWinSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_SmallWinSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F61 RID: 8033
		// (get) Token: 0x060068A1 RID: 26785 RVA: 0x001D5FD4 File Offset: 0x001D41D4
		// (set) Token: 0x060068A2 RID: 26786 RVA: 0x0003149A File Offset: 0x0002F69A
		public unsafe AudioSourceController BigWinSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_BigWinSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_BigWinSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F62 RID: 8034
		// (get) Token: 0x060068A3 RID: 26787 RVA: 0x001D6004 File Offset: 0x001D4204
		// (set) Token: 0x060068A4 RID: 26788 RVA: 0x000314B9 File Offset: 0x0002F6B9
		public unsafe AudioSourceController JackpotSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_JackpotSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_JackpotSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F63 RID: 8035
		// (get) Token: 0x060068A5 RID: 26789 RVA: 0x001D6034 File Offset: 0x001D4234
		// (set) Token: 0x060068A6 RID: 26790 RVA: 0x000314D8 File Offset: 0x0002F6D8
		public unsafe UnityEvent onDownPressed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_onDownPressed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_onDownPressed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F64 RID: 8036
		// (get) Token: 0x060068A7 RID: 26791 RVA: 0x001D6064 File Offset: 0x001D4264
		// (set) Token: 0x060068A8 RID: 26792 RVA: 0x000314F7 File Offset: 0x0002F6F7
		public unsafe UnityEvent onUpPressed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_onUpPressed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_onUpPressed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F65 RID: 8037
		// (get) Token: 0x060068A9 RID: 26793 RVA: 0x001D6094 File Offset: 0x001D4294
		// (set) Token: 0x060068AA RID: 26794 RVA: 0x00031516 File Offset: 0x0002F716
		public unsafe UnityEvent onHandlePulled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_onHandlePulled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_onHandlePulled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F66 RID: 8038
		// (get) Token: 0x060068AB RID: 26795 RVA: 0x001D60C4 File Offset: 0x001D42C4
		// (set) Token: 0x060068AC RID: 26796 RVA: 0x00031535 File Offset: 0x0002F735
		public unsafe int currentBetIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_currentBetIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_currentBetIndex)) = value;
			}
		}

		// Token: 0x17001F67 RID: 8039
		// (get) Token: 0x060068AD RID: 26797 RVA: 0x001D60EC File Offset: 0x001D42EC
		// (set) Token: 0x060068AE RID: 26798 RVA: 0x00031550 File Offset: 0x0002F750
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001F68 RID: 8040
		// (get) Token: 0x060068AF RID: 26799 RVA: 0x001D6114 File Offset: 0x001D4314
		// (set) Token: 0x060068B0 RID: 26800 RVA: 0x0003156B File Offset: 0x0002F76B
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004783 RID: 18307
		private static readonly IntPtr NativeFieldInfoPtr_BetAmounts;

		// Token: 0x04004784 RID: 18308
		private static readonly IntPtr NativeFieldInfoPtr__IsSpinning_k__BackingField;

		// Token: 0x04004785 RID: 18309
		private static readonly IntPtr NativeFieldInfoPtr_DownButton;

		// Token: 0x04004786 RID: 18310
		private static readonly IntPtr NativeFieldInfoPtr_UpButton;

		// Token: 0x04004787 RID: 18311
		private static readonly IntPtr NativeFieldInfoPtr_HandleIntObj;

		// Token: 0x04004788 RID: 18312
		private static readonly IntPtr NativeFieldInfoPtr_BetAmountLabel;

		// Token: 0x04004789 RID: 18313
		private static readonly IntPtr NativeFieldInfoPtr_Reels;

		// Token: 0x0400478A RID: 18314
		private static readonly IntPtr NativeFieldInfoPtr_SpinLoop;

		// Token: 0x0400478B RID: 18315
		private static readonly IntPtr NativeFieldInfoPtr_ScreenAnimation;

		// Token: 0x0400478C RID: 18316
		private static readonly IntPtr NativeFieldInfoPtr_JackpotParticles;

		// Token: 0x0400478D RID: 18317
		private static readonly IntPtr NativeFieldInfoPtr_WinAmountLabels;

		// Token: 0x0400478E RID: 18318
		private static readonly IntPtr NativeFieldInfoPtr_MiniWinAnimation;

		// Token: 0x0400478F RID: 18319
		private static readonly IntPtr NativeFieldInfoPtr_SmallWinAnimation;

		// Token: 0x04004790 RID: 18320
		private static readonly IntPtr NativeFieldInfoPtr_BigWinAnimation;

		// Token: 0x04004791 RID: 18321
		private static readonly IntPtr NativeFieldInfoPtr_JackpotAnimation;

		// Token: 0x04004792 RID: 18322
		private static readonly IntPtr NativeFieldInfoPtr_MiniWinSound;

		// Token: 0x04004793 RID: 18323
		private static readonly IntPtr NativeFieldInfoPtr_SmallWinSound;

		// Token: 0x04004794 RID: 18324
		private static readonly IntPtr NativeFieldInfoPtr_BigWinSound;

		// Token: 0x04004795 RID: 18325
		private static readonly IntPtr NativeFieldInfoPtr_JackpotSound;

		// Token: 0x04004796 RID: 18326
		private static readonly IntPtr NativeFieldInfoPtr_onDownPressed;

		// Token: 0x04004797 RID: 18327
		private static readonly IntPtr NativeFieldInfoPtr_onUpPressed;

		// Token: 0x04004798 RID: 18328
		private static readonly IntPtr NativeFieldInfoPtr_onHandlePulled;

		// Token: 0x04004799 RID: 18329
		private static readonly IntPtr NativeFieldInfoPtr_currentBetIndex;

		// Token: 0x0400479A RID: 18330
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400479B RID: 18331
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400479C RID: 18332
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSpinning_Public_get_Boolean_0;

		// Token: 0x0400479D RID: 18333
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSpinning_Private_set_Void_Boolean_0;

		// Token: 0x0400479E RID: 18334
		private static readonly IntPtr NativeMethodInfoPtr_get_currentBetAmount_Private_get_Int32_0;

		// Token: 0x0400479F RID: 18335
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040047A0 RID: 18336
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040047A1 RID: 18337
		private static readonly IntPtr NativeMethodInfoPtr_DownHovered_Private_Void_1;

		// Token: 0x040047A2 RID: 18338
		private static readonly IntPtr NativeMethodInfoPtr_DownInteracted_Private_Void_1;

		// Token: 0x040047A3 RID: 18339
		private static readonly IntPtr NativeMethodInfoPtr_UpHovered_Private_Void_1;

		// Token: 0x040047A4 RID: 18340
		private static readonly IntPtr NativeMethodInfoPtr_UpInteracted_Private_Void_1;

		// Token: 0x040047A5 RID: 18341
		private static readonly IntPtr NativeMethodInfoPtr_HandleHovered_Private_Void_1;

		// Token: 0x040047A6 RID: 18342
		private static readonly IntPtr NativeMethodInfoPtr_HandleInteracted_Public_Void_0;

		// Token: 0x040047A7 RID: 18343
		private static readonly IntPtr NativeMethodInfoPtr_SendBetIndex_Private_Void_Int32_0;

		// Token: 0x040047A8 RID: 18344
		private static readonly IntPtr NativeMethodInfoPtr_SetBetIndex_Public_Void_NetworkConnection_Int32_0;

		// Token: 0x040047A9 RID: 18345
		private static readonly IntPtr NativeMethodInfoPtr_SendStartSpin_Public_Void_NetworkConnection_Int32_0;

		// Token: 0x040047AA RID: 18346
		private static readonly IntPtr NativeMethodInfoPtr_StartSpin_Public_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0;

		// Token: 0x040047AB RID: 18347
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateOutcome_Private_EOutcome_Il2CppStructArray_1_ESymbol_0;

		// Token: 0x040047AC RID: 18348
		private static readonly IntPtr NativeMethodInfoPtr_GetWinAmount_Private_Int32_EOutcome_Int32_0;

		// Token: 0x040047AD RID: 18349
		private static readonly IntPtr NativeMethodInfoPtr_DisplayOutcome_Private_Void_EOutcome_Int32_0;

		// Token: 0x040047AE RID: 18350
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomSymbol_Public_Static_ESymbol_0;

		// Token: 0x040047AF RID: 18351
		private static readonly IntPtr NativeMethodInfoPtr_IsFruit_Private_Boolean_ESymbol_0;

		// Token: 0x040047B0 RID: 18352
		private static readonly IntPtr NativeMethodInfoPtr_IsAllFruit_Private_Boolean_Il2CppStructArray_1_ESymbol_0;

		// Token: 0x040047B1 RID: 18353
		private static readonly IntPtr NativeMethodInfoPtr_IsUniform_Private_Boolean_Il2CppStructArray_1_ESymbol_0;

		// Token: 0x040047B2 RID: 18354
		private static readonly IntPtr NativeMethodInfoPtr_SimulateMany_Public_Void_0;

		// Token: 0x040047B3 RID: 18355
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040047B4 RID: 18356
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040047B5 RID: 18357
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040047B6 RID: 18358
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040047B7 RID: 18359
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendBetIndex_3316948804_Private_Void_Int32_0;

		// Token: 0x040047B8 RID: 18360
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendBetIndex_3316948804_Private_Void_Int32_0;

		// Token: 0x040047B9 RID: 18361
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendBetIndex_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040047BA RID: 18362
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetBetIndex_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x040047BB RID: 18363
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetBetIndex_2681120339_Public_Void_NetworkConnection_Int32_0;

		// Token: 0x040047BC RID: 18364
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetBetIndex_2681120339_Private_Void_PooledReader_Channel_0;

		// Token: 0x040047BD RID: 18365
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetBetIndex_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x040047BE RID: 18366
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetBetIndex_2681120339_Private_Void_PooledReader_Channel_0;

		// Token: 0x040047BF RID: 18367
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendStartSpin_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x040047C0 RID: 18368
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendStartSpin_2681120339_Public_Void_NetworkConnection_Int32_0;

		// Token: 0x040047C1 RID: 18369
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendStartSpin_2681120339_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040047C2 RID: 18370
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartSpin_2659526290_Private_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0;

		// Token: 0x040047C3 RID: 18371
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartSpin_2659526290_Public_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0;

		// Token: 0x040047C4 RID: 18372
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartSpin_2659526290_Private_Void_PooledReader_Channel_0;

		// Token: 0x040047C5 RID: 18373
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x02000A4B RID: 2635
		[OriginalName("Assembly-CSharp.dll", "", "ESymbol")]
		public enum ESymbol
		{
			// Token: 0x04008C66 RID: 35942
			Cherry,
			// Token: 0x04008C67 RID: 35943
			Lemon,
			// Token: 0x04008C68 RID: 35944
			Grape,
			// Token: 0x04008C69 RID: 35945
			Watermelon,
			// Token: 0x04008C6A RID: 35946
			Bell,
			// Token: 0x04008C6B RID: 35947
			Seven
		}

		// Token: 0x02000A4C RID: 2636
		[OriginalName("Assembly-CSharp.dll", "", "EOutcome")]
		public enum EOutcome
		{
			// Token: 0x04008C6D RID: 35949
			Jackpot,
			// Token: 0x04008C6E RID: 35950
			BigWin,
			// Token: 0x04008C6F RID: 35951
			SmallWin,
			// Token: 0x04008C70 RID: 35952
			MiniWin,
			// Token: 0x04008C71 RID: 35953
			NoWin
		}

		// Token: 0x02000A4D RID: 2637
		[ObfuscatedName("ScheduleOne.Casino.SlotMachine+<>c__DisplayClass41_0")]
		public sealed class __c__DisplayClass41_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D012 RID: 53266 RVA: 0x0031EE2C File Offset: 0x0031D02C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass41_0()
			{
				Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "<>c__DisplayClass41_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr);
				SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr, "<>4__this");
				SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_symbols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr, "symbols");
				SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_betAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr, "betAmount");
				SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_spinner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr, "spinner");
				SlotMachine.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr, 100676620);
				SlotMachine.__c__DisplayClass41_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr, 100676621);
			}

			// Token: 0x0600D013 RID: 53267 RVA: 0x0031EED0 File Offset: 0x0031D0D0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass41_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D014 RID: 53268 RVA: 0x0031EF0C File Offset: 0x0031D10C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211338, XrefRangeEnd = 211343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D015 RID: 53269 RVA: 0x000653ED File Offset: 0x000635ED
			public __c__DisplayClass41_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040A0 RID: 16544
			// (get) Token: 0x0600D016 RID: 53270 RVA: 0x0031EF4C File Offset: 0x0031D14C
			// (set) Token: 0x0600D017 RID: 53271 RVA: 0x000653F6 File Offset: 0x000635F6
			public unsafe SlotMachine __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SlotMachine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040A1 RID: 16545
			// (get) Token: 0x0600D018 RID: 53272 RVA: 0x0031EF7C File Offset: 0x0031D17C
			// (set) Token: 0x0600D019 RID: 53273 RVA: 0x00065415 File Offset: 0x00063615
			public unsafe Il2CppStructArray<SlotMachine.ESymbol> symbols
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_symbols);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<SlotMachine.ESymbol>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_symbols), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040A2 RID: 16546
			// (get) Token: 0x0600D01A RID: 53274 RVA: 0x0031EFAC File Offset: 0x0031D1AC
			// (set) Token: 0x0600D01B RID: 53275 RVA: 0x00065434 File Offset: 0x00063634
			public unsafe int betAmount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_betAmount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_betAmount)) = value;
				}
			}

			// Token: 0x170040A3 RID: 16547
			// (get) Token: 0x0600D01C RID: 53276 RVA: 0x0031EFD4 File Offset: 0x0031D1D4
			// (set) Token: 0x0600D01D RID: 53277 RVA: 0x0006544F File Offset: 0x0006364F
			public unsafe NetworkConnection spinner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_spinner);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_spinner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C72 RID: 35954
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C73 RID: 35955
			private static readonly IntPtr NativeFieldInfoPtr_symbols;

			// Token: 0x04008C74 RID: 35956
			private static readonly IntPtr NativeFieldInfoPtr_betAmount;

			// Token: 0x04008C75 RID: 35957
			private static readonly IntPtr NativeFieldInfoPtr_spinner;

			// Token: 0x04008C76 RID: 35958
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C77 RID: 35959
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C5C RID: 3164
			[ObfuscatedName("ScheduleOne.Casino.SlotMachine+<>c__DisplayClass41_0+<<StartSpin>g__Spin|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E3CA RID: 58314 RVA: 0x003571C0 File Offset: 0x003553C0
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique()
				{
					Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr, "<<StartSpin>g__Spin|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr);
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, "<>1__state");
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, "<>2__current");
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, "<>4__this");
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr__outcome_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, "<outcome>5__2");
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, "<i>5__3");
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, 100676622);
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, 100676623);
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, 100676624);
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, 100676625);
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, 100676626);
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, 100676627);
				}

				// Token: 0x0600E3CB RID: 58315 RVA: 0x003572C8 File Offset: 0x003554C8
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E3CC RID: 58316 RVA: 0x00357310 File Offset: 0x00355510
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E3CD RID: 58317 RVA: 0x00357344 File Offset: 0x00355544
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211325, XrefRangeEnd = 211333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170046B9 RID: 18105
				// (get) Token: 0x0600E3CE RID: 58318 RVA: 0x00357380 File Offset: 0x00355580
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E3CF RID: 58319 RVA: 0x003573C0 File Offset: 0x003555C0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211333, XrefRangeEnd = 211338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170046BA RID: 18106
				// (get) Token: 0x0600E3D0 RID: 58320 RVA: 0x003573F4 File Offset: 0x003555F4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E3D1 RID: 58321 RVA: 0x0006F089 File Offset: 0x0006D289
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170046B4 RID: 18100
				// (get) Token: 0x0600E3D2 RID: 58322 RVA: 0x00357434 File Offset: 0x00355634
				// (set) Token: 0x0600E3D3 RID: 58323 RVA: 0x0006F092 File Offset: 0x0006D292
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170046B5 RID: 18101
				// (get) Token: 0x0600E3D4 RID: 58324 RVA: 0x0035745C File Offset: 0x0035565C
				// (set) Token: 0x0600E3D5 RID: 58325 RVA: 0x0006F0AD File Offset: 0x0006D2AD
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046B6 RID: 18102
				// (get) Token: 0x0600E3D6 RID: 58326 RVA: 0x0035748C File Offset: 0x0035568C
				// (set) Token: 0x0600E3D7 RID: 58327 RVA: 0x0006F0CC File Offset: 0x0006D2CC
				public unsafe SlotMachine.__c__DisplayClass41_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SlotMachine.__c__DisplayClass41_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046B7 RID: 18103
				// (get) Token: 0x0600E3D8 RID: 58328 RVA: 0x003574BC File Offset: 0x003556BC
				// (set) Token: 0x0600E3D9 RID: 58329 RVA: 0x0006F0EB File Offset: 0x0006D2EB
				public unsafe SlotMachine.EOutcome _outcome_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr__outcome_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr__outcome_5__2)) = value;
					}
				}

				// Token: 0x170046B8 RID: 18104
				// (get) Token: 0x0600E3DA RID: 58330 RVA: 0x003574E4 File Offset: 0x003556E4
				// (set) Token: 0x0600E3DB RID: 58331 RVA: 0x0006F106 File Offset: 0x0006D306
				public unsafe int _i_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr__i_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
					}
				}

				// Token: 0x04009869 RID: 39017
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400986A RID: 39018
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400986B RID: 39019
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400986C RID: 39020
				private static readonly IntPtr NativeFieldInfoPtr__outcome_5__2;

				// Token: 0x0400986D RID: 39021
				private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

				// Token: 0x0400986E RID: 39022
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400986F RID: 39023
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009870 RID: 39024
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009871 RID: 39025
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009872 RID: 39026
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009873 RID: 39027
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
