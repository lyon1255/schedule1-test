using System;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200062F RID: 1583
	public class DailySummary : NetworkSingleton<DailySummary>
	{
		// Token: 0x06008BAA RID: 35754 RVA: 0x00248340 File Offset: 0x00246540
		// Note: this type is marked as 'beforefieldinit'.
		static DailySummary()
		{
			Il2CppClassPointerStore<DailySummary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DailySummary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailySummary>.NativeClassPtr);
			DailySummary.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "<IsOpen>k__BackingField");
			DailySummary.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "Canvas");
			DailySummary.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "Container");
			DailySummary.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "Anim");
			DailySummary.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "TitleLabel");
			DailySummary.NativeFieldInfoPtr_ProductEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "ProductEntries");
			DailySummary.NativeFieldInfoPtr_PlayerEarningsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "PlayerEarningsLabel");
			DailySummary.NativeFieldInfoPtr_DealerEarningsLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "DealerEarningsLabel");
			DailySummary.NativeFieldInfoPtr_XPGainedLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "XPGainedLabel");
			DailySummary.NativeFieldInfoPtr_onClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "onClosed");
			DailySummary.NativeFieldInfoPtr_itemsSoldByPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "itemsSoldByPlayer");
			DailySummary.NativeFieldInfoPtr_moneyEarnedByPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "moneyEarnedByPlayer");
			DailySummary.NativeFieldInfoPtr_moneyEarnedByDealers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "moneyEarnedByDealers");
			DailySummary.NativeFieldInfoPtr__xpGained_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "<xpGained>k__BackingField");
			DailySummary.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.UI.DailySummaryAssembly-CSharp.dll_Excuted");
			DailySummary.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.UI.DailySummaryAssembly-CSharp.dll_Excuted");
			DailySummary.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680642);
			DailySummary.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680643);
			DailySummary.NativeMethodInfoPtr_get_xpGained_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680644);
			DailySummary.NativeMethodInfoPtr_set_xpGained_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680645);
			DailySummary.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680646);
			DailySummary.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680647);
			DailySummary.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680648);
			DailySummary.NativeMethodInfoPtr_SleepEnd_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680649);
			DailySummary.NativeMethodInfoPtr_AddSoldItem_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680650);
			DailySummary.NativeMethodInfoPtr_AddPlayerMoney_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680651);
			DailySummary.NativeMethodInfoPtr_AddDealerMoney_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680652);
			DailySummary.NativeMethodInfoPtr_AddXP_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680653);
			DailySummary.NativeMethodInfoPtr_ClearStats_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680654);
			DailySummary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680655);
			DailySummary.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680656);
			DailySummary.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680657);
			DailySummary.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680658);
			DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddSoldItem_3643459082_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680659);
			DailySummary.NativeMethodInfoPtr_RpcLogic___AddSoldItem_3643459082_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680660);
			DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddSoldItem_3643459082_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680661);
			DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerMoney_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680662);
			DailySummary.NativeMethodInfoPtr_RpcLogic___AddPlayerMoney_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680663);
			DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddPlayerMoney_431000436_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680664);
			DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddDealerMoney_431000436_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680665);
			DailySummary.NativeMethodInfoPtr_RpcLogic___AddDealerMoney_431000436_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680666);
			DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddDealerMoney_431000436_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680667);
			DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddXP_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680668);
			DailySummary.NativeMethodInfoPtr_RpcLogic___AddXP_3316948804_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680669);
			DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddXP_3316948804_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680670);
			DailySummary.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, 100680671);
		}

		// Token: 0x17002AA7 RID: 10919
		// (get) Token: 0x06008BAB RID: 35755 RVA: 0x00248708 File Offset: 0x00246908
		// (set) Token: 0x06008BAC RID: 35756 RVA: 0x00248744 File Offset: 0x00246944
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002AA8 RID: 10920
		// (get) Token: 0x06008BAD RID: 35757 RVA: 0x00248784 File Offset: 0x00246984
		// (set) Token: 0x06008BAE RID: 35758 RVA: 0x002487C0 File Offset: 0x002469C0
		public unsafe int xpGained
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_get_xpGained_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_set_xpGained_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008BAF RID: 35759 RVA: 0x00248800 File Offset: 0x00246A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255669, XrefRangeEnd = 255687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailySummary.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BB0 RID: 35760 RVA: 0x0024883C File Offset: 0x00246A3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255769, RefRangeEnd = 255770, XrefRangeStart = 255687, XrefRangeEnd = 255769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BB1 RID: 35761 RVA: 0x00248870 File Offset: 0x00246A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255770, XrefRangeEnd = 255780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BB2 RID: 35762 RVA: 0x002488A4 File Offset: 0x00246AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255780, XrefRangeEnd = 255783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SleepEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_SleepEnd_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BB3 RID: 35763 RVA: 0x002488D8 File Offset: 0x00246AD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255784, RefRangeEnd = 255785, XrefRangeStart = 255783, XrefRangeEnd = 255784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSoldItem(string id, int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_AddSoldItem_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BB4 RID: 35764 RVA: 0x00248928 File Offset: 0x00246B28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255804, RefRangeEnd = 255805, XrefRangeStart = 255785, XrefRangeEnd = 255804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPlayerMoney(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_AddPlayerMoney_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BB5 RID: 35765 RVA: 0x00248968 File Offset: 0x00246B68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255824, RefRangeEnd = 255825, XrefRangeStart = 255805, XrefRangeEnd = 255824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddDealerMoney(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_AddDealerMoney_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BB6 RID: 35766 RVA: 0x002489A8 File Offset: 0x00246BA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255845, RefRangeEnd = 255846, XrefRangeStart = 255825, XrefRangeEnd = 255845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddXP(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_AddXP_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BB7 RID: 35767 RVA: 0x002489E8 File Offset: 0x00246BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearStats()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_ClearStats_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BB8 RID: 35768 RVA: 0x00248A1C File Offset: 0x00246C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255846, XrefRangeEnd = 255856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DailySummary() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailySummary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BB9 RID: 35769 RVA: 0x00248A58 File Offset: 0x00246C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255856, XrefRangeEnd = 255884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailySummary.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BBA RID: 35770 RVA: 0x00248A94 File Offset: 0x00246C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255884, XrefRangeEnd = 255887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailySummary.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BBB RID: 35771 RVA: 0x00248AD0 File Offset: 0x00246CD0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailySummary.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BBC RID: 35772 RVA: 0x00248B0C File Offset: 0x00246D0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255918, RefRangeEnd = 255919, XrefRangeStart = 255887, XrefRangeEnd = 255918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddSoldItem_3643459082(string id, int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddSoldItem_3643459082_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BBD RID: 35773 RVA: 0x00248B5C File Offset: 0x00246D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255919, XrefRangeEnd = 255932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___AddSoldItem_3643459082(string id, int amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcLogic___AddSoldItem_3643459082_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BBE RID: 35774 RVA: 0x00248BAC File Offset: 0x00246DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255932, XrefRangeEnd = 255944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddSoldItem_3643459082(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddSoldItem_3643459082_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BBF RID: 35775 RVA: 0x00248BFC File Offset: 0x00246DFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255804, RefRangeEnd = 255805, XrefRangeStart = 255804, XrefRangeEnd = 255805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddPlayerMoney_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerMoney_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BC0 RID: 35776 RVA: 0x00248C3C File Offset: 0x00246E3C
		[CallerCount(0)]
		public unsafe void RpcLogic___AddPlayerMoney_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcLogic___AddPlayerMoney_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BC1 RID: 35777 RVA: 0x00248C7C File Offset: 0x00246E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255944, XrefRangeEnd = 255946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddPlayerMoney_431000436(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddPlayerMoney_431000436_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BC2 RID: 35778 RVA: 0x00248CCC File Offset: 0x00246ECC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255824, RefRangeEnd = 255825, XrefRangeStart = 255824, XrefRangeEnd = 255825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddDealerMoney_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddDealerMoney_431000436_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BC3 RID: 35779 RVA: 0x00248D0C File Offset: 0x00246F0C
		[CallerCount(0)]
		public unsafe void RpcLogic___AddDealerMoney_431000436(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcLogic___AddDealerMoney_431000436_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BC4 RID: 35780 RVA: 0x00248D4C File Offset: 0x00246F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255946, XrefRangeEnd = 255948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddDealerMoney_431000436(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddDealerMoney_431000436_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BC5 RID: 35781 RVA: 0x00248D9C File Offset: 0x00246F9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255845, RefRangeEnd = 255846, XrefRangeStart = 255845, XrefRangeEnd = 255846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_AddXP_3316948804(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcWriter___Observers_AddXP_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BC6 RID: 35782 RVA: 0x00248DDC File Offset: 0x00246FDC
		[CallerCount(0)]
		public unsafe void RpcLogic___AddXP_3316948804(int xp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref xp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcLogic___AddXP_3316948804_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BC7 RID: 35783 RVA: 0x00248E1C File Offset: 0x0024701C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255948, XrefRangeEnd = 255951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_AddXP_3316948804(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.NativeMethodInfoPtr_RpcReader___Observers_AddXP_3316948804_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BC8 RID: 35784 RVA: 0x00248E6C File Offset: 0x0024706C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255951, XrefRangeEnd = 255954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DailySummary.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BC9 RID: 35785 RVA: 0x00042E24 File Offset: 0x00041024
		public DailySummary(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A97 RID: 10903
		// (get) Token: 0x06008BCA RID: 35786 RVA: 0x00248EA8 File Offset: 0x002470A8
		// (set) Token: 0x06008BCB RID: 35787 RVA: 0x00042E2D File Offset: 0x0004102D
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002A98 RID: 10904
		// (get) Token: 0x06008BCC RID: 35788 RVA: 0x00248ED0 File Offset: 0x002470D0
		// (set) Token: 0x06008BCD RID: 35789 RVA: 0x00042E48 File Offset: 0x00041048
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A99 RID: 10905
		// (get) Token: 0x06008BCE RID: 35790 RVA: 0x00248F00 File Offset: 0x00247100
		// (set) Token: 0x06008BCF RID: 35791 RVA: 0x00042E67 File Offset: 0x00041067
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A9A RID: 10906
		// (get) Token: 0x06008BD0 RID: 35792 RVA: 0x00248F30 File Offset: 0x00247130
		// (set) Token: 0x06008BD1 RID: 35793 RVA: 0x00042E86 File Offset: 0x00041086
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A9B RID: 10907
		// (get) Token: 0x06008BD2 RID: 35794 RVA: 0x00248F60 File Offset: 0x00247160
		// (set) Token: 0x06008BD3 RID: 35795 RVA: 0x00042EA5 File Offset: 0x000410A5
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A9C RID: 10908
		// (get) Token: 0x06008BD4 RID: 35796 RVA: 0x00248F90 File Offset: 0x00247190
		// (set) Token: 0x06008BD5 RID: 35797 RVA: 0x00042EC4 File Offset: 0x000410C4
		public unsafe Il2CppReferenceArray<RectTransform> ProductEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_ProductEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_ProductEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A9D RID: 10909
		// (get) Token: 0x06008BD6 RID: 35798 RVA: 0x00248FC0 File Offset: 0x002471C0
		// (set) Token: 0x06008BD7 RID: 35799 RVA: 0x00042EE3 File Offset: 0x000410E3
		public unsafe TextMeshProUGUI PlayerEarningsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_PlayerEarningsLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_PlayerEarningsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A9E RID: 10910
		// (get) Token: 0x06008BD8 RID: 35800 RVA: 0x00248FF0 File Offset: 0x002471F0
		// (set) Token: 0x06008BD9 RID: 35801 RVA: 0x00042F02 File Offset: 0x00041102
		public unsafe TextMeshProUGUI DealerEarningsLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_DealerEarningsLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_DealerEarningsLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A9F RID: 10911
		// (get) Token: 0x06008BDA RID: 35802 RVA: 0x00249020 File Offset: 0x00247220
		// (set) Token: 0x06008BDB RID: 35803 RVA: 0x00042F21 File Offset: 0x00041121
		public unsafe TextMeshProUGUI XPGainedLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_XPGainedLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_XPGainedLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AA0 RID: 10912
		// (get) Token: 0x06008BDC RID: 35804 RVA: 0x00249050 File Offset: 0x00247250
		// (set) Token: 0x06008BDD RID: 35805 RVA: 0x00042F40 File Offset: 0x00041140
		public unsafe UnityEvent onClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_onClosed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_onClosed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AA1 RID: 10913
		// (get) Token: 0x06008BDE RID: 35806 RVA: 0x00249080 File Offset: 0x00247280
		// (set) Token: 0x06008BDF RID: 35807 RVA: 0x00042F5F File Offset: 0x0004115F
		public unsafe Dictionary<string, int> itemsSoldByPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_itemsSoldByPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_itemsSoldByPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AA2 RID: 10914
		// (get) Token: 0x06008BE0 RID: 35808 RVA: 0x002490B0 File Offset: 0x002472B0
		// (set) Token: 0x06008BE1 RID: 35809 RVA: 0x00042F7E File Offset: 0x0004117E
		public unsafe float moneyEarnedByPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_moneyEarnedByPlayer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_moneyEarnedByPlayer)) = value;
			}
		}

		// Token: 0x17002AA3 RID: 10915
		// (get) Token: 0x06008BE2 RID: 35810 RVA: 0x002490D8 File Offset: 0x002472D8
		// (set) Token: 0x06008BE3 RID: 35811 RVA: 0x00042F99 File Offset: 0x00041199
		public unsafe float moneyEarnedByDealers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_moneyEarnedByDealers);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_moneyEarnedByDealers)) = value;
			}
		}

		// Token: 0x17002AA4 RID: 10916
		// (get) Token: 0x06008BE4 RID: 35812 RVA: 0x00249100 File Offset: 0x00247300
		// (set) Token: 0x06008BE5 RID: 35813 RVA: 0x00042FB4 File Offset: 0x000411B4
		public unsafe int _xpGained_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr__xpGained_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr__xpGained_k__BackingField)) = value;
			}
		}

		// Token: 0x17002AA5 RID: 10917
		// (get) Token: 0x06008BE6 RID: 35814 RVA: 0x00249128 File Offset: 0x00247328
		// (set) Token: 0x06008BE7 RID: 35815 RVA: 0x00042FCF File Offset: 0x000411CF
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17002AA6 RID: 10918
		// (get) Token: 0x06008BE8 RID: 35816 RVA: 0x00249150 File Offset: 0x00247350
		// (set) Token: 0x06008BE9 RID: 35817 RVA: 0x00042FEA File Offset: 0x000411EA
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04005EB1 RID: 24241
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04005EB2 RID: 24242
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04005EB3 RID: 24243
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04005EB4 RID: 24244
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x04005EB5 RID: 24245
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x04005EB6 RID: 24246
		private static readonly IntPtr NativeFieldInfoPtr_ProductEntries;

		// Token: 0x04005EB7 RID: 24247
		private static readonly IntPtr NativeFieldInfoPtr_PlayerEarningsLabel;

		// Token: 0x04005EB8 RID: 24248
		private static readonly IntPtr NativeFieldInfoPtr_DealerEarningsLabel;

		// Token: 0x04005EB9 RID: 24249
		private static readonly IntPtr NativeFieldInfoPtr_XPGainedLabel;

		// Token: 0x04005EBA RID: 24250
		private static readonly IntPtr NativeFieldInfoPtr_onClosed;

		// Token: 0x04005EBB RID: 24251
		private static readonly IntPtr NativeFieldInfoPtr_itemsSoldByPlayer;

		// Token: 0x04005EBC RID: 24252
		private static readonly IntPtr NativeFieldInfoPtr_moneyEarnedByPlayer;

		// Token: 0x04005EBD RID: 24253
		private static readonly IntPtr NativeFieldInfoPtr_moneyEarnedByDealers;

		// Token: 0x04005EBE RID: 24254
		private static readonly IntPtr NativeFieldInfoPtr__xpGained_k__BackingField;

		// Token: 0x04005EBF RID: 24255
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04005EC0 RID: 24256
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04005EC1 RID: 24257
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04005EC2 RID: 24258
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04005EC3 RID: 24259
		private static readonly IntPtr NativeMethodInfoPtr_get_xpGained_Public_get_Int32_0;

		// Token: 0x04005EC4 RID: 24260
		private static readonly IntPtr NativeMethodInfoPtr_set_xpGained_Private_set_Void_Int32_0;

		// Token: 0x04005EC5 RID: 24261
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04005EC6 RID: 24262
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04005EC7 RID: 24263
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04005EC8 RID: 24264
		private static readonly IntPtr NativeMethodInfoPtr_SleepEnd_Private_Void_0;

		// Token: 0x04005EC9 RID: 24265
		private static readonly IntPtr NativeMethodInfoPtr_AddSoldItem_Public_Void_String_Int32_0;

		// Token: 0x04005ECA RID: 24266
		private static readonly IntPtr NativeMethodInfoPtr_AddPlayerMoney_Public_Void_Single_0;

		// Token: 0x04005ECB RID: 24267
		private static readonly IntPtr NativeMethodInfoPtr_AddDealerMoney_Public_Void_Single_0;

		// Token: 0x04005ECC RID: 24268
		private static readonly IntPtr NativeMethodInfoPtr_AddXP_Public_Void_Int32_0;

		// Token: 0x04005ECD RID: 24269
		private static readonly IntPtr NativeMethodInfoPtr_ClearStats_Private_Void_0;

		// Token: 0x04005ECE RID: 24270
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005ECF RID: 24271
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04005ED0 RID: 24272
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04005ED1 RID: 24273
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04005ED2 RID: 24274
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddSoldItem_3643459082_Private_Void_String_Int32_0;

		// Token: 0x04005ED3 RID: 24275
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddSoldItem_3643459082_Public_Void_String_Int32_0;

		// Token: 0x04005ED4 RID: 24276
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddSoldItem_3643459082_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005ED5 RID: 24277
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddPlayerMoney_431000436_Private_Void_Single_0;

		// Token: 0x04005ED6 RID: 24278
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddPlayerMoney_431000436_Public_Void_Single_0;

		// Token: 0x04005ED7 RID: 24279
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddPlayerMoney_431000436_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005ED8 RID: 24280
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddDealerMoney_431000436_Private_Void_Single_0;

		// Token: 0x04005ED9 RID: 24281
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddDealerMoney_431000436_Public_Void_Single_0;

		// Token: 0x04005EDA RID: 24282
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddDealerMoney_431000436_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005EDB RID: 24283
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_AddXP_3316948804_Private_Void_Int32_0;

		// Token: 0x04005EDC RID: 24284
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___AddXP_3316948804_Public_Void_Int32_0;

		// Token: 0x04005EDD RID: 24285
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_AddXP_3316948804_Private_Void_PooledReader_Channel_0;

		// Token: 0x04005EDE RID: 24286
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000B18 RID: 2840
		[ObfuscatedName("ScheduleOne.UI.DailySummary+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D6DF RID: 55007 RVA: 0x00331FC8 File Offset: 0x003301C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DailySummary>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0>.NativeClassPtr);
				DailySummary.__c__DisplayClass21_0.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0>.NativeClassPtr, "items");
				DailySummary.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0>.NativeClassPtr, "<>4__this");
				DailySummary.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0>.NativeClassPtr, 100680672);
				DailySummary.__c__DisplayClass21_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0>.NativeClassPtr, 100680673);
			}

			// Token: 0x0600D6E0 RID: 55008 RVA: 0x00332044 File Offset: 0x00330244
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6E1 RID: 55009 RVA: 0x00332080 File Offset: 0x00330280
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255664, XrefRangeEnd = 255669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass21_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D6E2 RID: 55010 RVA: 0x0006891C File Offset: 0x00066B1C
			public __c__DisplayClass21_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004290 RID: 17040
			// (get) Token: 0x0600D6E3 RID: 55011 RVA: 0x003320C0 File Offset: 0x003302C0
			// (set) Token: 0x0600D6E4 RID: 55012 RVA: 0x00068925 File Offset: 0x00066B25
			public unsafe Il2CppStringArray items
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass21_0.NativeFieldInfoPtr_items);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass21_0.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004291 RID: 17041
			// (get) Token: 0x0600D6E5 RID: 55013 RVA: 0x003320F0 File Offset: 0x003302F0
			// (set) Token: 0x0600D6E6 RID: 55014 RVA: 0x00068944 File Offset: 0x00066B44
			public unsafe DailySummary __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailySummary>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass21_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400907D RID: 36989
			private static readonly IntPtr NativeFieldInfoPtr_items;

			// Token: 0x0400907E RID: 36990
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400907F RID: 36991
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009080 RID: 36992
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C6F RID: 3183
			[ObfuscatedName("ScheduleOne.UI.DailySummary+<>c__DisplayClass21_0+<<Open>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E50D RID: 58637 RVA: 0x0035AD54 File Offset: 0x00358F54
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0>.NativeClassPtr, "<<Open>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680674);
					DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680675);
					DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680676);
					DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680677);
					DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680678);
					DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100680679);
				}

				// Token: 0x0600E50E RID: 58638 RVA: 0x0035AE34 File Offset: 0x00359034
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E50F RID: 58639 RVA: 0x0035AE7C File Offset: 0x0035907C
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E510 RID: 58640 RVA: 0x0035AEB0 File Offset: 0x003590B0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255653, XrefRangeEnd = 255659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004733 RID: 18227
				// (get) Token: 0x0600E511 RID: 58641 RVA: 0x0035AEEC File Offset: 0x003590EC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E512 RID: 58642 RVA: 0x0035AF2C File Offset: 0x0035912C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255659, XrefRangeEnd = 255664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004734 RID: 18228
				// (get) Token: 0x0600E513 RID: 58643 RVA: 0x0035AF60 File Offset: 0x00359160
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E514 RID: 58644 RVA: 0x0006FB28 File Offset: 0x0006DD28
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004730 RID: 18224
				// (get) Token: 0x0600E515 RID: 58645 RVA: 0x0035AFA0 File Offset: 0x003591A0
				// (set) Token: 0x0600E516 RID: 58646 RVA: 0x0006FB31 File Offset: 0x0006DD31
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004731 RID: 18225
				// (get) Token: 0x0600E517 RID: 58647 RVA: 0x0035AFC8 File Offset: 0x003591C8
				// (set) Token: 0x0600E518 RID: 58648 RVA: 0x0006FB4C File Offset: 0x0006DD4C
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004732 RID: 18226
				// (get) Token: 0x0600E519 RID: 58649 RVA: 0x0035AFF8 File Offset: 0x003591F8
				// (set) Token: 0x0600E51A RID: 58650 RVA: 0x0006FB6B File Offset: 0x0006DD6B
				public unsafe DailySummary.__c__DisplayClass21_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailySummary.__c__DisplayClass21_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DailySummary.__c__DisplayClass21_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400992E RID: 39214
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400992F RID: 39215
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009930 RID: 39216
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009931 RID: 39217
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009932 RID: 39218
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009933 RID: 39219
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009934 RID: 39220
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009935 RID: 39221
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009936 RID: 39222
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
