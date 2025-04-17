using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Levelling;
using Il2CppScheduleOne.NPCs.CharacterClasses;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x02000772 RID: 1906
	public class DarkMarket : NetworkSingleton<DarkMarket>
	{
		// Token: 0x0600B4CA RID: 46282 RVA: 0x002CFC2C File Offset: 0x002CDE2C
		// Note: this type is marked as 'beforefieldinit'.
		static DarkMarket()
		{
			Il2CppClassPointerStore<DarkMarket>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "DarkMarket");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr);
			DarkMarket.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, "<IsOpen>k__BackingField");
			DarkMarket.NativeFieldInfoPtr__Unlocked_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, "<Unlocked>k__BackingField");
			DarkMarket.NativeFieldInfoPtr_AccessZone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, "AccessZone");
			DarkMarket.NativeFieldInfoPtr_MainDoor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, "MainDoor");
			DarkMarket.NativeFieldInfoPtr_Oscar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, "Oscar");
			DarkMarket.NativeFieldInfoPtr_UnlockRank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, "UnlockRank");
			DarkMarket.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Map.DarkMarketAssembly-CSharp.dll_Excuted");
			DarkMarket.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Map.DarkMarketAssembly-CSharp.dll_Excuted");
			DarkMarket.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100685531);
			DarkMarket.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100685532);
			DarkMarket.NativeMethodInfoPtr_get_Unlocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100685533);
			DarkMarket.NativeMethodInfoPtr_set_Unlocked_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100685534);
			DarkMarket.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100685535);
			DarkMarket.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100685536);
			DarkMarket.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100685537);
			DarkMarket.NativeMethodInfoPtr_ShouldBeOpen_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100685538);
			DarkMarket.NativeMethodInfoPtr_OnLoad_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100685539);
			DarkMarket.NativeMethodInfoPtr_SendUnlocked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100685540);
			DarkMarket.NativeMethodInfoPtr_SetUnlocked_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100685541);
			DarkMarket.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100685542);
			DarkMarket.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100685543);
			DarkMarket.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100685544);
			DarkMarket.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100685545);
			DarkMarket.NativeMethodInfoPtr_RpcWriter___Server_SendUnlocked_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100685546);
			DarkMarket.NativeMethodInfoPtr_RpcLogic___SendUnlocked_2166136261_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100685547);
			DarkMarket.NativeMethodInfoPtr_RpcReader___Server_SendUnlocked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100685548);
			DarkMarket.NativeMethodInfoPtr_RpcWriter___Observers_SetUnlocked_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100685549);
			DarkMarket.NativeMethodInfoPtr_RpcLogic___SetUnlocked_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100685550);
			DarkMarket.NativeMethodInfoPtr_RpcReader___Observers_SetUnlocked_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100685551);
			DarkMarket.NativeMethodInfoPtr_RpcWriter___Target_SetUnlocked_328543758_Private_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100685552);
			DarkMarket.NativeMethodInfoPtr_RpcReader___Target_SetUnlocked_328543758_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100685553);
			DarkMarket.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr, 100685554);
		}

		// Token: 0x17003815 RID: 14357
		// (get) Token: 0x0600B4CB RID: 46283 RVA: 0x002CFEDC File Offset: 0x002CE0DC
		// (set) Token: 0x0600B4CC RID: 46284 RVA: 0x002CFF18 File Offset: 0x002CE118
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003816 RID: 14358
		// (get) Token: 0x0600B4CD RID: 46285 RVA: 0x002CFF58 File Offset: 0x002CE158
		// (set) Token: 0x0600B4CE RID: 46286 RVA: 0x002CFF94 File Offset: 0x002CE194
		public unsafe bool Unlocked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_get_Unlocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_set_Unlocked_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B4CF RID: 46287 RVA: 0x002CFFD4 File Offset: 0x002CE1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309389, XrefRangeEnd = 309404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DarkMarket.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4D0 RID: 46288 RVA: 0x002D0010 File Offset: 0x002CE210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309404, XrefRangeEnd = 309406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DarkMarket.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4D1 RID: 46289 RVA: 0x002D0060 File Offset: 0x002CE260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309406, XrefRangeEnd = 309423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4D2 RID: 46290 RVA: 0x002D0094 File Offset: 0x002CE294
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309423, XrefRangeEnd = 309440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ShouldBeOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_ShouldBeOpen_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B4D3 RID: 46291 RVA: 0x002D00D0 File Offset: 0x002CE2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309440, XrefRangeEnd = 309482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLoad()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_OnLoad_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4D4 RID: 46292 RVA: 0x002D0104 File Offset: 0x002CE304
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 309503, RefRangeEnd = 309504, XrefRangeStart = 309482, XrefRangeEnd = 309503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendUnlocked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_SendUnlocked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4D5 RID: 46293 RVA: 0x002D0138 File Offset: 0x002CE338
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 309541, RefRangeEnd = 309548, XrefRangeStart = 309504, XrefRangeEnd = 309541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetUnlocked(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_SetUnlocked_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4D6 RID: 46294 RVA: 0x002D017C File Offset: 0x002CE37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309548, XrefRangeEnd = 309551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DarkMarket() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DarkMarket>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4D7 RID: 46295 RVA: 0x002D01B8 File Offset: 0x002CE3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309551, XrefRangeEnd = 309574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DarkMarket.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4D8 RID: 46296 RVA: 0x002D01F4 File Offset: 0x002CE3F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309574, XrefRangeEnd = 309577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DarkMarket.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4D9 RID: 46297 RVA: 0x002D0230 File Offset: 0x002CE430
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DarkMarket.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4DA RID: 46298 RVA: 0x002D026C File Offset: 0x002CE46C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309577, XrefRangeEnd = 309595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendUnlocked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_RpcWriter___Server_SendUnlocked_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4DB RID: 46299 RVA: 0x002D02A0 File Offset: 0x002CE4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309595, XrefRangeEnd = 309596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendUnlocked_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_RpcLogic___SendUnlocked_2166136261_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4DC RID: 46300 RVA: 0x002D02D4 File Offset: 0x002CE4D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309596, XrefRangeEnd = 309599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendUnlocked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_RpcReader___Server_SendUnlocked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4DD RID: 46301 RVA: 0x002D0338 File Offset: 0x002CE538
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309599, XrefRangeEnd = 309617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetUnlocked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_RpcWriter___Observers_SetUnlocked_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4DE RID: 46302 RVA: 0x002D037C File Offset: 0x002CE57C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 309637, RefRangeEnd = 309640, XrefRangeStart = 309617, XrefRangeEnd = 309637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetUnlocked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_RpcLogic___SetUnlocked_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4DF RID: 46303 RVA: 0x002D03C0 File Offset: 0x002CE5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309640, XrefRangeEnd = 309643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetUnlocked_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_RpcReader___Observers_SetUnlocked_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4E0 RID: 46304 RVA: 0x002D0410 File Offset: 0x002CE610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309643, XrefRangeEnd = 309661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetUnlocked_328543758(NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_RpcWriter___Target_SetUnlocked_328543758_Private_Void_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4E1 RID: 46305 RVA: 0x002D0454 File Offset: 0x002CE654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309661, XrefRangeEnd = 309664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetUnlocked_328543758(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DarkMarket.NativeMethodInfoPtr_RpcReader___Target_SetUnlocked_328543758_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4E2 RID: 46306 RVA: 0x002D04A4 File Offset: 0x002CE6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309664, XrefRangeEnd = 309667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DarkMarket.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B4E3 RID: 46307 RVA: 0x00058B58 File Offset: 0x00056D58
		public DarkMarket(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700380D RID: 14349
		// (get) Token: 0x0600B4E4 RID: 46308 RVA: 0x002D04E0 File Offset: 0x002CE6E0
		// (set) Token: 0x0600B4E5 RID: 46309 RVA: 0x00058B61 File Offset: 0x00056D61
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x1700380E RID: 14350
		// (get) Token: 0x0600B4E6 RID: 46310 RVA: 0x002D0508 File Offset: 0x002CE708
		// (set) Token: 0x0600B4E7 RID: 46311 RVA: 0x00058B7C File Offset: 0x00056D7C
		public unsafe bool _Unlocked_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr__Unlocked_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr__Unlocked_k__BackingField)) = value;
			}
		}

		// Token: 0x1700380F RID: 14351
		// (get) Token: 0x0600B4E8 RID: 46312 RVA: 0x002D0530 File Offset: 0x002CE730
		// (set) Token: 0x0600B4E9 RID: 46313 RVA: 0x00058B97 File Offset: 0x00056D97
		public unsafe DarkMarketAccessZone AccessZone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr_AccessZone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DarkMarketAccessZone>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr_AccessZone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003810 RID: 14352
		// (get) Token: 0x0600B4EA RID: 46314 RVA: 0x002D0560 File Offset: 0x002CE760
		// (set) Token: 0x0600B4EB RID: 46315 RVA: 0x00058BB6 File Offset: 0x00056DB6
		public unsafe DarkMarketMainDoor MainDoor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr_MainDoor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DarkMarketMainDoor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr_MainDoor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003811 RID: 14353
		// (get) Token: 0x0600B4EC RID: 46316 RVA: 0x002D0590 File Offset: 0x002CE790
		// (set) Token: 0x0600B4ED RID: 46317 RVA: 0x00058BD5 File Offset: 0x00056DD5
		public unsafe Oscar Oscar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr_Oscar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Oscar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr_Oscar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003812 RID: 14354
		// (get) Token: 0x0600B4EE RID: 46318 RVA: 0x002D05C0 File Offset: 0x002CE7C0
		// (set) Token: 0x0600B4EF RID: 46319 RVA: 0x00058BF4 File Offset: 0x00056DF4
		public unsafe FullRank UnlockRank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr_UnlockRank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr_UnlockRank)) = value;
			}
		}

		// Token: 0x17003813 RID: 14355
		// (get) Token: 0x0600B4F0 RID: 46320 RVA: 0x002D05E8 File Offset: 0x002CE7E8
		// (set) Token: 0x0600B4F1 RID: 46321 RVA: 0x00058C0F File Offset: 0x00056E0F
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003814 RID: 14356
		// (get) Token: 0x0600B4F2 RID: 46322 RVA: 0x002D0610 File Offset: 0x002CE810
		// (set) Token: 0x0600B4F3 RID: 46323 RVA: 0x00058C2A File Offset: 0x00056E2A
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DarkMarket.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040079D6 RID: 31190
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x040079D7 RID: 31191
		private static readonly IntPtr NativeFieldInfoPtr__Unlocked_k__BackingField;

		// Token: 0x040079D8 RID: 31192
		private static readonly IntPtr NativeFieldInfoPtr_AccessZone;

		// Token: 0x040079D9 RID: 31193
		private static readonly IntPtr NativeFieldInfoPtr_MainDoor;

		// Token: 0x040079DA RID: 31194
		private static readonly IntPtr NativeFieldInfoPtr_Oscar;

		// Token: 0x040079DB RID: 31195
		private static readonly IntPtr NativeFieldInfoPtr_UnlockRank;

		// Token: 0x040079DC RID: 31196
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040079DD RID: 31197
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040079DE RID: 31198
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040079DF RID: 31199
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x040079E0 RID: 31200
		private static readonly IntPtr NativeMethodInfoPtr_get_Unlocked_Public_get_Boolean_0;

		// Token: 0x040079E1 RID: 31201
		private static readonly IntPtr NativeMethodInfoPtr_set_Unlocked_Protected_set_Void_Boolean_0;

		// Token: 0x040079E2 RID: 31202
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040079E3 RID: 31203
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040079E4 RID: 31204
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040079E5 RID: 31205
		private static readonly IntPtr NativeMethodInfoPtr_ShouldBeOpen_Private_Boolean_0;

		// Token: 0x040079E6 RID: 31206
		private static readonly IntPtr NativeMethodInfoPtr_OnLoad_Private_Void_0;

		// Token: 0x040079E7 RID: 31207
		private static readonly IntPtr NativeMethodInfoPtr_SendUnlocked_Public_Void_0;

		// Token: 0x040079E8 RID: 31208
		private static readonly IntPtr NativeMethodInfoPtr_SetUnlocked_Private_Void_NetworkConnection_0;

		// Token: 0x040079E9 RID: 31209
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040079EA RID: 31210
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040079EB RID: 31211
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040079EC RID: 31212
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040079ED RID: 31213
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendUnlocked_2166136261_Private_Void_0;

		// Token: 0x040079EE RID: 31214
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendUnlocked_2166136261_Public_Void_0;

		// Token: 0x040079EF RID: 31215
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendUnlocked_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x040079F0 RID: 31216
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetUnlocked_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040079F1 RID: 31217
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetUnlocked_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040079F2 RID: 31218
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetUnlocked_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040079F3 RID: 31219
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetUnlocked_328543758_Private_Void_NetworkConnection_0;

		// Token: 0x040079F4 RID: 31220
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetUnlocked_328543758_Private_Void_PooledReader_Channel_0;

		// Token: 0x040079F5 RID: 31221
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
