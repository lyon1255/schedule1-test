using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ObjectScripts;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Law
{
	// Token: 0x020003D5 RID: 981
	public class CurfewManager : NetworkSingleton<CurfewManager>
	{
		// Token: 0x06004B95 RID: 19349 RVA: 0x0016CF80 File Offset: 0x0016B180
		// Note: this type is marked as 'beforefieldinit'.
		static CurfewManager()
		{
			Il2CppClassPointerStore<CurfewManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Law", "CurfewManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr);
			CurfewManager.NativeFieldInfoPtr_WARNING_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "WARNING_TIME");
			CurfewManager.NativeFieldInfoPtr_CURFEW_START_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "CURFEW_START_TIME");
			CurfewManager.NativeFieldInfoPtr_CURFEW_END_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "CURFEW_END_TIME");
			CurfewManager.NativeFieldInfoPtr__IsEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "<IsEnabled>k__BackingField");
			CurfewManager.NativeFieldInfoPtr__IsCurrentlyActive_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "<IsCurrentlyActive>k__BackingField");
			CurfewManager.NativeFieldInfoPtr_VMSBoards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "VMSBoards");
			CurfewManager.NativeFieldInfoPtr_CurfewWarningSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "CurfewWarningSound");
			CurfewManager.NativeFieldInfoPtr_CurfewAlarmSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "CurfewAlarmSound");
			CurfewManager.NativeFieldInfoPtr_onCurfewEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "onCurfewEnabled");
			CurfewManager.NativeFieldInfoPtr_onCurfewDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "onCurfewDisabled");
			CurfewManager.NativeFieldInfoPtr_onCurfewHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "onCurfewHint");
			CurfewManager.NativeFieldInfoPtr_onCurfewWarning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "onCurfewWarning");
			CurfewManager.NativeFieldInfoPtr_warningPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "warningPlayed");
			CurfewManager.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Law.CurfewManagerAssembly-CSharp.dll_Excuted");
			CurfewManager.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Law.CurfewManagerAssembly-CSharp.dll_Excuted");
			CurfewManager.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672658);
			CurfewManager.NativeMethodInfoPtr_set_IsEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672659);
			CurfewManager.NativeMethodInfoPtr_get_IsCurrentlyActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672660);
			CurfewManager.NativeMethodInfoPtr_set_IsCurrentlyActive_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672661);
			CurfewManager.NativeMethodInfoPtr_get_IsCurrentlyActiveWithTolerance_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672662);
			CurfewManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672663);
			CurfewManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672664);
			CurfewManager.NativeMethodInfoPtr_Enable_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672665);
			CurfewManager.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672666);
			CurfewManager.NativeMethodInfoPtr_MinPass_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672667);
			CurfewManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672668);
			CurfewManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672669);
			CurfewManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672670);
			CurfewManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672671);
			CurfewManager.NativeMethodInfoPtr_RpcWriter___Observers_Enable_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672672);
			CurfewManager.NativeMethodInfoPtr_RpcLogic___Enable_328543758_Public_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672673);
			CurfewManager.NativeMethodInfoPtr_RpcReader___Observers_Enable_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672674);
			CurfewManager.NativeMethodInfoPtr_RpcWriter___Target_Enable_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672675);
			CurfewManager.NativeMethodInfoPtr_RpcReader___Target_Enable_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672676);
			CurfewManager.NativeMethodInfoPtr_RpcWriter___Observers_Disable_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672677);
			CurfewManager.NativeMethodInfoPtr_RpcLogic___Disable_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672678);
			CurfewManager.NativeMethodInfoPtr_RpcReader___Observers_Disable_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672679);
			CurfewManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr, 100672680);
		}

		// Token: 0x170016B5 RID: 5813
		// (get) Token: 0x06004B96 RID: 19350 RVA: 0x0016D2A8 File Offset: 0x0016B4A8
		// (set) Token: 0x06004B97 RID: 19351 RVA: 0x0016D2E4 File Offset: 0x0016B4E4
		public unsafe bool IsEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_set_IsEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016B6 RID: 5814
		// (get) Token: 0x06004B98 RID: 19352 RVA: 0x0016D324 File Offset: 0x0016B524
		// (set) Token: 0x06004B99 RID: 19353 RVA: 0x0016D360 File Offset: 0x0016B560
		public unsafe bool IsCurrentlyActive
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_get_IsCurrentlyActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_set_IsCurrentlyActive_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170016B7 RID: 5815
		// (get) Token: 0x06004B9A RID: 19354 RVA: 0x0016D3A0 File Offset: 0x0016B5A0
		public unsafe bool IsCurrentlyActiveWithTolerance
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 164850, RefRangeEnd = 164851, XrefRangeStart = 164849, XrefRangeEnd = 164850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_get_IsCurrentlyActiveWithTolerance_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004B9B RID: 19355 RVA: 0x0016D3DC File Offset: 0x0016B5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164851, XrefRangeEnd = 164873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CurfewManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B9C RID: 19356 RVA: 0x0016D418 File Offset: 0x0016B618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164873, XrefRangeEnd = 164875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CurfewManager.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B9D RID: 19357 RVA: 0x0016D468 File Offset: 0x0016B668
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164901, RefRangeEnd = 164903, XrefRangeStart = 164875, XrefRangeEnd = 164901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enable(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_Enable_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B9E RID: 19358 RVA: 0x0016D4AC File Offset: 0x0016B6AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164921, RefRangeEnd = 164923, XrefRangeStart = 164903, XrefRangeEnd = 164921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B9F RID: 19359 RVA: 0x0016D4E0 File Offset: 0x0016B6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164923, XrefRangeEnd = 164929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_MinPass_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BA0 RID: 19360 RVA: 0x0016D514 File Offset: 0x0016B714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164929, XrefRangeEnd = 164932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CurfewManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurfewManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BA1 RID: 19361 RVA: 0x0016D550 File Offset: 0x0016B750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164932, XrefRangeEnd = 164954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CurfewManager.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BA2 RID: 19362 RVA: 0x0016D58C File Offset: 0x0016B78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164954, XrefRangeEnd = 164957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CurfewManager.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BA3 RID: 19363 RVA: 0x0016D5C8 File Offset: 0x0016B7C8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CurfewManager.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BA4 RID: 19364 RVA: 0x0016D604 File Offset: 0x0016B804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164957, XrefRangeEnd = 164975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Enable_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcWriter___Observers_Enable_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BA5 RID: 19365 RVA: 0x0016D648 File Offset: 0x0016B848
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164979, RefRangeEnd = 164981, XrefRangeStart = 164975, XrefRangeEnd = 164979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Enable_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcLogic___Enable_328543758_Public_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BA6 RID: 19366 RVA: 0x0016D68C File Offset: 0x0016B88C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164981, XrefRangeEnd = 164983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Enable_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcReader___Observers_Enable_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BA7 RID: 19367 RVA: 0x0016D6DC File Offset: 0x0016B8DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164983, XrefRangeEnd = 165001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_Enable_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcWriter___Target_Enable_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BA8 RID: 19368 RVA: 0x0016D720 File Offset: 0x0016B920
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165001, XrefRangeEnd = 165004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_Enable_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcReader___Target_Enable_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BA9 RID: 19369 RVA: 0x0016D770 File Offset: 0x0016B970
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 164921, RefRangeEnd = 164923, XrefRangeStart = 164921, XrefRangeEnd = 164923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Disable_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcWriter___Observers_Disable_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BAA RID: 19370 RVA: 0x0016D7A4 File Offset: 0x0016B9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165004, XrefRangeEnd = 165008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Disable_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcLogic___Disable_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BAB RID: 19371 RVA: 0x0016D7D8 File Offset: 0x0016B9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165008, XrefRangeEnd = 165013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Disable_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CurfewManager.NativeMethodInfoPtr_RpcReader___Observers_Disable_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BAC RID: 19372 RVA: 0x0016D828 File Offset: 0x0016BA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165013, XrefRangeEnd = 165016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CurfewManager.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BAD RID: 19373 RVA: 0x0002456B File Offset: 0x0002276B
		public CurfewManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170016A6 RID: 5798
		// (get) Token: 0x06004BAE RID: 19374 RVA: 0x0016D864 File Offset: 0x0016BA64
		// (set) Token: 0x06004BAF RID: 19375 RVA: 0x00024574 File Offset: 0x00022774
		public unsafe static int WARNING_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CurfewManager.NativeFieldInfoPtr_WARNING_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CurfewManager.NativeFieldInfoPtr_WARNING_TIME, (void*)(&value));
			}
		}

		// Token: 0x170016A7 RID: 5799
		// (get) Token: 0x06004BB0 RID: 19376 RVA: 0x0016D880 File Offset: 0x0016BA80
		// (set) Token: 0x06004BB1 RID: 19377 RVA: 0x00024582 File Offset: 0x00022782
		public unsafe static int CURFEW_START_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CurfewManager.NativeFieldInfoPtr_CURFEW_START_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CurfewManager.NativeFieldInfoPtr_CURFEW_START_TIME, (void*)(&value));
			}
		}

		// Token: 0x170016A8 RID: 5800
		// (get) Token: 0x06004BB2 RID: 19378 RVA: 0x0016D89C File Offset: 0x0016BA9C
		// (set) Token: 0x06004BB3 RID: 19379 RVA: 0x00024590 File Offset: 0x00022790
		public unsafe static int CURFEW_END_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CurfewManager.NativeFieldInfoPtr_CURFEW_END_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CurfewManager.NativeFieldInfoPtr_CURFEW_END_TIME, (void*)(&value));
			}
		}

		// Token: 0x170016A9 RID: 5801
		// (get) Token: 0x06004BB4 RID: 19380 RVA: 0x0016D8B8 File Offset: 0x0016BAB8
		// (set) Token: 0x06004BB5 RID: 19381 RVA: 0x0002459E File Offset: 0x0002279E
		public unsafe bool _IsEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr__IsEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr__IsEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x170016AA RID: 5802
		// (get) Token: 0x06004BB6 RID: 19382 RVA: 0x0016D8E0 File Offset: 0x0016BAE0
		// (set) Token: 0x06004BB7 RID: 19383 RVA: 0x000245B9 File Offset: 0x000227B9
		public unsafe bool _IsCurrentlyActive_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr__IsCurrentlyActive_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr__IsCurrentlyActive_k__BackingField)) = value;
			}
		}

		// Token: 0x170016AB RID: 5803
		// (get) Token: 0x06004BB8 RID: 19384 RVA: 0x0016D908 File Offset: 0x0016BB08
		// (set) Token: 0x06004BB9 RID: 19385 RVA: 0x000245D4 File Offset: 0x000227D4
		public unsafe Il2CppReferenceArray<VMSBoard> VMSBoards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_VMSBoards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<VMSBoard>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_VMSBoards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016AC RID: 5804
		// (get) Token: 0x06004BBA RID: 19386 RVA: 0x0016D938 File Offset: 0x0016BB38
		// (set) Token: 0x06004BBB RID: 19387 RVA: 0x000245F3 File Offset: 0x000227F3
		public unsafe AudioSourceController CurfewWarningSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_CurfewWarningSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_CurfewWarningSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016AD RID: 5805
		// (get) Token: 0x06004BBC RID: 19388 RVA: 0x0016D968 File Offset: 0x0016BB68
		// (set) Token: 0x06004BBD RID: 19389 RVA: 0x00024612 File Offset: 0x00022812
		public unsafe AudioSourceController CurfewAlarmSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_CurfewAlarmSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_CurfewAlarmSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016AE RID: 5806
		// (get) Token: 0x06004BBE RID: 19390 RVA: 0x0016D998 File Offset: 0x0016BB98
		// (set) Token: 0x06004BBF RID: 19391 RVA: 0x00024631 File Offset: 0x00022831
		public unsafe UnityEvent onCurfewEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewEnabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewEnabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016AF RID: 5807
		// (get) Token: 0x06004BC0 RID: 19392 RVA: 0x0016D9C8 File Offset: 0x0016BBC8
		// (set) Token: 0x06004BC1 RID: 19393 RVA: 0x00024650 File Offset: 0x00022850
		public unsafe UnityEvent onCurfewDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewDisabled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewDisabled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016B0 RID: 5808
		// (get) Token: 0x06004BC2 RID: 19394 RVA: 0x0016D9F8 File Offset: 0x0016BBF8
		// (set) Token: 0x06004BC3 RID: 19395 RVA: 0x0002466F File Offset: 0x0002286F
		public unsafe UnityEvent onCurfewHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewHint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewHint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016B1 RID: 5809
		// (get) Token: 0x06004BC4 RID: 19396 RVA: 0x0016DA28 File Offset: 0x0016BC28
		// (set) Token: 0x06004BC5 RID: 19397 RVA: 0x0002468E File Offset: 0x0002288E
		public unsafe UnityEvent onCurfewWarning
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewWarning);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_onCurfewWarning), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170016B2 RID: 5810
		// (get) Token: 0x06004BC6 RID: 19398 RVA: 0x0016DA58 File Offset: 0x0016BC58
		// (set) Token: 0x06004BC7 RID: 19399 RVA: 0x000246AD File Offset: 0x000228AD
		public unsafe bool warningPlayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_warningPlayed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_warningPlayed)) = value;
			}
		}

		// Token: 0x170016B3 RID: 5811
		// (get) Token: 0x06004BC8 RID: 19400 RVA: 0x0016DA80 File Offset: 0x0016BC80
		// (set) Token: 0x06004BC9 RID: 19401 RVA: 0x000246C8 File Offset: 0x000228C8
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170016B4 RID: 5812
		// (get) Token: 0x06004BCA RID: 19402 RVA: 0x0016DAA8 File Offset: 0x0016BCA8
		// (set) Token: 0x06004BCB RID: 19403 RVA: 0x000246E3 File Offset: 0x000228E3
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CurfewManager.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040032F2 RID: 13042
		private static readonly IntPtr NativeFieldInfoPtr_WARNING_TIME;

		// Token: 0x040032F3 RID: 13043
		private static readonly IntPtr NativeFieldInfoPtr_CURFEW_START_TIME;

		// Token: 0x040032F4 RID: 13044
		private static readonly IntPtr NativeFieldInfoPtr_CURFEW_END_TIME;

		// Token: 0x040032F5 RID: 13045
		private static readonly IntPtr NativeFieldInfoPtr__IsEnabled_k__BackingField;

		// Token: 0x040032F6 RID: 13046
		private static readonly IntPtr NativeFieldInfoPtr__IsCurrentlyActive_k__BackingField;

		// Token: 0x040032F7 RID: 13047
		private static readonly IntPtr NativeFieldInfoPtr_VMSBoards;

		// Token: 0x040032F8 RID: 13048
		private static readonly IntPtr NativeFieldInfoPtr_CurfewWarningSound;

		// Token: 0x040032F9 RID: 13049
		private static readonly IntPtr NativeFieldInfoPtr_CurfewAlarmSound;

		// Token: 0x040032FA RID: 13050
		private static readonly IntPtr NativeFieldInfoPtr_onCurfewEnabled;

		// Token: 0x040032FB RID: 13051
		private static readonly IntPtr NativeFieldInfoPtr_onCurfewDisabled;

		// Token: 0x040032FC RID: 13052
		private static readonly IntPtr NativeFieldInfoPtr_onCurfewHint;

		// Token: 0x040032FD RID: 13053
		private static readonly IntPtr NativeFieldInfoPtr_onCurfewWarning;

		// Token: 0x040032FE RID: 13054
		private static readonly IntPtr NativeFieldInfoPtr_warningPlayed;

		// Token: 0x040032FF RID: 13055
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003300 RID: 13056
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003301 RID: 13057
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0;

		// Token: 0x04003302 RID: 13058
		private static readonly IntPtr NativeMethodInfoPtr_set_IsEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x04003303 RID: 13059
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCurrentlyActive_Public_get_Boolean_0;

		// Token: 0x04003304 RID: 13060
		private static readonly IntPtr NativeMethodInfoPtr_set_IsCurrentlyActive_Protected_set_Void_Boolean_0;

		// Token: 0x04003305 RID: 13061
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCurrentlyActiveWithTolerance_Public_get_Boolean_0;

		// Token: 0x04003306 RID: 13062
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04003307 RID: 13063
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003308 RID: 13064
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Void_NetworkConnection_0;

		// Token: 0x04003309 RID: 13065
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;

		// Token: 0x0400330A RID: 13066
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Private_Void_0;

		// Token: 0x0400330B RID: 13067
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400330C RID: 13068
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400330D RID: 13069
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400330E RID: 13070
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400330F RID: 13071
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Enable_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04003310 RID: 13072
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Enable_328543758_Public_Void_NetworkConnection_0;

		// Token: 0x04003311 RID: 13073
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Enable_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003312 RID: 13074
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_Enable_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x04003313 RID: 13075
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_Enable_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003314 RID: 13076
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Disable_2166136261_Private_Void_0;

		// Token: 0x04003315 RID: 13077
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Disable_2166136261_Public_Void_0;

		// Token: 0x04003316 RID: 13078
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Disable_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003317 RID: 13079
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
