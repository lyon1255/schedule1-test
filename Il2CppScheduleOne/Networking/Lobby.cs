using System;
using Il2CppFishNet.Managing;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSteamworks;
using Il2CppSystem;

namespace Il2CppScheduleOne.Networking
{
	// Token: 0x0200036D RID: 877
	public class Lobby : PersistentSingleton<Lobby>
	{
		// Token: 0x06004471 RID: 17521 RVA: 0x0015246C File Offset: 0x0015066C
		// Note: this type is marked as 'beforefieldinit'.
		static Lobby()
		{
			Il2CppClassPointerStore<Lobby>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Networking", "Lobby");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lobby>.NativeClassPtr);
			Lobby.NativeFieldInfoPtr_ENABLED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "ENABLED");
			Lobby.NativeFieldInfoPtr_PLAYER_LIMIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "PLAYER_LIMIT");
			Lobby.NativeFieldInfoPtr_JOIN_READY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "JOIN_READY");
			Lobby.NativeFieldInfoPtr_LOAD_TUTORIAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "LOAD_TUTORIAL");
			Lobby.NativeFieldInfoPtr_HOST_LOADING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "HOST_LOADING");
			Lobby.NativeFieldInfoPtr_NetworkManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "NetworkManager");
			Lobby.NativeFieldInfoPtr__LobbyID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "<LobbyID>k__BackingField");
			Lobby.NativeFieldInfoPtr__LocalPlayerID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "<LocalPlayerID>k__BackingField");
			Lobby.NativeFieldInfoPtr_Players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "Players");
			Lobby.NativeFieldInfoPtr_onLobbyChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "onLobbyChange");
			Lobby.NativeFieldInfoPtr_LobbyCreatedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "LobbyCreatedCallback");
			Lobby.NativeFieldInfoPtr_LobbyEnteredCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "LobbyEnteredCallback");
			Lobby.NativeFieldInfoPtr_ChatUpdateCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "ChatUpdateCallback");
			Lobby.NativeFieldInfoPtr_GameLobbyJoinRequestedCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "GameLobbyJoinRequestedCallback");
			Lobby.NativeFieldInfoPtr_LobbyChatMessageCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "LobbyChatMessageCallback");
			Lobby.NativeFieldInfoPtr_DebugSteamId64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "DebugSteamId64");
			Lobby.NativeMethodInfoPtr_get_IsHost_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671656);
			Lobby.NativeMethodInfoPtr_get_LobbyID_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671657);
			Lobby.NativeMethodInfoPtr_set_LobbyID_Private_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671658);
			Lobby.NativeMethodInfoPtr_get_LobbySteamID_Public_get_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671659);
			Lobby.NativeMethodInfoPtr_get_IsInLobby_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671660);
			Lobby.NativeMethodInfoPtr_get_PlayerCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671661);
			Lobby.NativeMethodInfoPtr_get_LocalPlayerID_Public_get_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671662);
			Lobby.NativeMethodInfoPtr_set_LocalPlayerID_Private_set_Void_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671663);
			Lobby.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671664);
			Lobby.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671665);
			Lobby.NativeMethodInfoPtr_InitializeCallbacks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671666);
			Lobby.NativeMethodInfoPtr_TryOpenInviteInterface_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671667);
			Lobby.NativeMethodInfoPtr_LeaveLobby_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671668);
			Lobby.NativeMethodInfoPtr_CreateLobby_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671669);
			Lobby.NativeMethodInfoPtr_GetLaunchLobby_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671670);
			Lobby.NativeMethodInfoPtr_UpdateLobbyMembers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671671);
			Lobby.NativeMethodInfoPtr_DebugJoin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671672);
			Lobby.NativeMethodInfoPtr_JoinAsClient_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671673);
			Lobby.NativeMethodInfoPtr_SendLobbyMessage_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671674);
			Lobby.NativeMethodInfoPtr_SetLobbyData_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671675);
			Lobby.NativeMethodInfoPtr_OnLobbyCreated_Private_Void_LobbyCreated_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671676);
			Lobby.NativeMethodInfoPtr_OnLobbyEntered_Private_Void_LobbyEnter_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671677);
			Lobby.NativeMethodInfoPtr_PlayerEnterOrLeave_Private_Void_LobbyChatUpdate_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671678);
			Lobby.NativeMethodInfoPtr_LobbyJoinRequested_Private_Void_GameLobbyJoinRequested_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671679);
			Lobby.NativeMethodInfoPtr_OnLobbyChatMessage_Private_Void_LobbyChatMsg_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671680);
			Lobby.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby>.NativeClassPtr, 100671681);
		}

		// Token: 0x170014C0 RID: 5312
		// (get) Token: 0x06004472 RID: 17522 RVA: 0x001527E4 File Offset: 0x001509E4
		public unsafe bool IsHost
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 154920, RefRangeEnd = 154940, XrefRangeStart = 154919, XrefRangeEnd = 154920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_get_IsHost_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170014C1 RID: 5313
		// (get) Token: 0x06004473 RID: 17523 RVA: 0x00152820 File Offset: 0x00150A20
		// (set) Token: 0x06004474 RID: 17524 RVA: 0x0015285C File Offset: 0x00150A5C
		public unsafe ulong LobbyID
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_get_LobbyID_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_set_LobbyID_Private_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170014C2 RID: 5314
		// (get) Token: 0x06004475 RID: 17525 RVA: 0x0015289C File Offset: 0x00150A9C
		public unsafe CSteamID LobbySteamID
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 19646, RefRangeEnd = 19660, XrefRangeStart = 19646, XrefRangeEnd = 19660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_get_LobbySteamID_Public_get_CSteamID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170014C3 RID: 5315
		// (get) Token: 0x06004476 RID: 17526 RVA: 0x001528D8 File Offset: 0x00150AD8
		public unsafe bool IsInLobby
		{
			[CallerCount(33)]
			[CachedScanResults(RefRangeStart = 154940, RefRangeEnd = 154973, XrefRangeStart = 154940, XrefRangeEnd = 154940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_get_IsInLobby_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170014C4 RID: 5316
		// (get) Token: 0x06004477 RID: 17527 RVA: 0x00152914 File Offset: 0x00150B14
		public unsafe int PlayerCount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 154991, RefRangeEnd = 154994, XrefRangeStart = 154973, XrefRangeEnd = 154991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_get_PlayerCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170014C5 RID: 5317
		// (get) Token: 0x06004478 RID: 17528 RVA: 0x00152950 File Offset: 0x00150B50
		// (set) Token: 0x06004479 RID: 17529 RVA: 0x0015298C File Offset: 0x00150B8C
		public unsafe CSteamID LocalPlayerID
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 19662, RefRangeEnd = 19669, XrefRangeStart = 19662, XrefRangeEnd = 19669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_get_LocalPlayerID_Public_get_CSteamID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_set_LocalPlayerID_Private_set_Void_CSteamID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600447A RID: 17530 RVA: 0x001529CC File Offset: 0x00150BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154994, XrefRangeEnd = 155011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lobby.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600447B RID: 17531 RVA: 0x00152A08 File Offset: 0x00150C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155011, XrefRangeEnd = 155053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Lobby.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600447C RID: 17532 RVA: 0x00152A44 File Offset: 0x00150C44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155103, RefRangeEnd = 155104, XrefRangeStart = 155053, XrefRangeEnd = 155103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeCallbacks()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_InitializeCallbacks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600447D RID: 17533 RVA: 0x00152A78 File Offset: 0x00150C78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 155119, RefRangeEnd = 155120, XrefRangeStart = 155104, XrefRangeEnd = 155119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryOpenInviteInterface()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_TryOpenInviteInterface_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600447E RID: 17534 RVA: 0x00152AAC File Offset: 0x00150CAC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 155130, RefRangeEnd = 155135, XrefRangeStart = 155120, XrefRangeEnd = 155130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LeaveLobby()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_LeaveLobby_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600447F RID: 17535 RVA: 0x00152AE0 File Offset: 0x00150CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155135, XrefRangeEnd = 155136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateLobby()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_CreateLobby_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004480 RID: 17536 RVA: 0x00152B14 File Offset: 0x00150D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155136, XrefRangeEnd = 155143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLaunchLobby()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_GetLaunchLobby_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004481 RID: 17537 RVA: 0x00152B4C File Offset: 0x00150D4C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 155150, RefRangeEnd = 155154, XrefRangeStart = 155143, XrefRangeEnd = 155150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLobbyMembers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_UpdateLobbyMembers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004482 RID: 17538 RVA: 0x00152B80 File Offset: 0x00150D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155154, XrefRangeEnd = 155155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DebugJoin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_DebugJoin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004483 RID: 17539 RVA: 0x00152BB4 File Offset: 0x00150DB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 155161, RefRangeEnd = 155163, XrefRangeStart = 155155, XrefRangeEnd = 155161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void JoinAsClient(string steamId64)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(steamId64);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_JoinAsClient_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004484 RID: 17540 RVA: 0x00152BF8 File Offset: 0x00150DF8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 155172, RefRangeEnd = 155175, XrefRangeStart = 155163, XrefRangeEnd = 155172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendLobbyMessage(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_SendLobbyMessage_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004485 RID: 17541 RVA: 0x00152C3C File Offset: 0x00150E3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 155182, RefRangeEnd = 155186, XrefRangeStart = 155175, XrefRangeEnd = 155182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLobbyData(string key, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_SetLobbyData_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004486 RID: 17542 RVA: 0x00152C90 File Offset: 0x00150E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155186, XrefRangeEnd = 155233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLobbyCreated(LobbyCreated_t result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_OnLobbyCreated_Private_Void_LobbyCreated_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004487 RID: 17543 RVA: 0x00152CD0 File Offset: 0x00150ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155233, XrefRangeEnd = 155319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLobbyEntered(LobbyEnter_t result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_OnLobbyEntered_Private_Void_LobbyEnter_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004488 RID: 17544 RVA: 0x00152D10 File Offset: 0x00150F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155319, XrefRangeEnd = 155334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerEnterOrLeave(LobbyChatUpdate_t result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_PlayerEnterOrLeave_Private_Void_LobbyChatUpdate_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004489 RID: 17545 RVA: 0x00152D50 File Offset: 0x00150F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155334, XrefRangeEnd = 155347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LobbyJoinRequested(GameLobbyJoinRequested_t result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_LobbyJoinRequested_Private_Void_GameLobbyJoinRequested_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600448A RID: 17546 RVA: 0x00152D90 File Offset: 0x00150F90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155347, XrefRangeEnd = 155384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLobbyChatMessage(LobbyChatMsg_t result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref result;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr_OnLobbyChatMessage_Private_Void_LobbyChatMsg_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600448B RID: 17547 RVA: 0x00152DD0 File Offset: 0x00150FD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155384, XrefRangeEnd = 155398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Lobby() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lobby>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600448C RID: 17548 RVA: 0x000216DC File Offset: 0x0001F8DC
		public Lobby(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x0600448D RID: 17549 RVA: 0x00152E0C File Offset: 0x0015100C
		// (set) Token: 0x0600448E RID: 17550 RVA: 0x000216E5 File Offset: 0x0001F8E5
		public unsafe static bool ENABLED
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(Lobby.NativeFieldInfoPtr_ENABLED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lobby.NativeFieldInfoPtr_ENABLED, (void*)(&value));
			}
		}

		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x0600448F RID: 17551 RVA: 0x00152E28 File Offset: 0x00151028
		// (set) Token: 0x06004490 RID: 17552 RVA: 0x000216F3 File Offset: 0x0001F8F3
		public unsafe static int PLAYER_LIMIT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Lobby.NativeFieldInfoPtr_PLAYER_LIMIT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lobby.NativeFieldInfoPtr_PLAYER_LIMIT, (void*)(&value));
			}
		}

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x06004491 RID: 17553 RVA: 0x00152E44 File Offset: 0x00151044
		// (set) Token: 0x06004492 RID: 17554 RVA: 0x00021701 File Offset: 0x0001F901
		public unsafe static string JOIN_READY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Lobby.NativeFieldInfoPtr_JOIN_READY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lobby.NativeFieldInfoPtr_JOIN_READY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x06004493 RID: 17555 RVA: 0x00152E64 File Offset: 0x00151064
		// (set) Token: 0x06004494 RID: 17556 RVA: 0x00021713 File Offset: 0x0001F913
		public unsafe static string LOAD_TUTORIAL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Lobby.NativeFieldInfoPtr_LOAD_TUTORIAL, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lobby.NativeFieldInfoPtr_LOAD_TUTORIAL, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x06004495 RID: 17557 RVA: 0x00152E84 File Offset: 0x00151084
		// (set) Token: 0x06004496 RID: 17558 RVA: 0x00021725 File Offset: 0x0001F925
		public unsafe static string HOST_LOADING
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Lobby.NativeFieldInfoPtr_HOST_LOADING, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Lobby.NativeFieldInfoPtr_HOST_LOADING, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x06004497 RID: 17559 RVA: 0x00152EA4 File Offset: 0x001510A4
		// (set) Token: 0x06004498 RID: 17560 RVA: 0x00021737 File Offset: 0x0001F937
		public unsafe NetworkManager NetworkManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_NetworkManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_NetworkManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014B6 RID: 5302
		// (get) Token: 0x06004499 RID: 17561 RVA: 0x00152ED4 File Offset: 0x001510D4
		// (set) Token: 0x0600449A RID: 17562 RVA: 0x00021756 File Offset: 0x0001F956
		public unsafe ulong _LobbyID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr__LobbyID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr__LobbyID_k__BackingField)) = value;
			}
		}

		// Token: 0x170014B7 RID: 5303
		// (get) Token: 0x0600449B RID: 17563 RVA: 0x00152EFC File Offset: 0x001510FC
		// (set) Token: 0x0600449C RID: 17564 RVA: 0x00021771 File Offset: 0x0001F971
		public unsafe CSteamID _LocalPlayerID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr__LocalPlayerID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr__LocalPlayerID_k__BackingField)) = value;
			}
		}

		// Token: 0x170014B8 RID: 5304
		// (get) Token: 0x0600449D RID: 17565 RVA: 0x00152F24 File Offset: 0x00151124
		// (set) Token: 0x0600449E RID: 17566 RVA: 0x0002178C File Offset: 0x0001F98C
		public unsafe Il2CppStructArray<CSteamID> Players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_Players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<CSteamID>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_Players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014B9 RID: 5305
		// (get) Token: 0x0600449F RID: 17567 RVA: 0x00152F54 File Offset: 0x00151154
		// (set) Token: 0x060044A0 RID: 17568 RVA: 0x000217AB File Offset: 0x0001F9AB
		public unsafe Action onLobbyChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_onLobbyChange);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_onLobbyChange), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014BA RID: 5306
		// (get) Token: 0x060044A1 RID: 17569 RVA: 0x00152F84 File Offset: 0x00151184
		// (set) Token: 0x060044A2 RID: 17570 RVA: 0x000217CA File Offset: 0x0001F9CA
		public unsafe Callback<LobbyCreated_t> LobbyCreatedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_LobbyCreatedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<LobbyCreated_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_LobbyCreatedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014BB RID: 5307
		// (get) Token: 0x060044A3 RID: 17571 RVA: 0x00152FB4 File Offset: 0x001511B4
		// (set) Token: 0x060044A4 RID: 17572 RVA: 0x000217E9 File Offset: 0x0001F9E9
		public unsafe Callback<LobbyEnter_t> LobbyEnteredCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_LobbyEnteredCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<LobbyEnter_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_LobbyEnteredCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014BC RID: 5308
		// (get) Token: 0x060044A5 RID: 17573 RVA: 0x00152FE4 File Offset: 0x001511E4
		// (set) Token: 0x060044A6 RID: 17574 RVA: 0x00021808 File Offset: 0x0001FA08
		public unsafe Callback<LobbyChatUpdate_t> ChatUpdateCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_ChatUpdateCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<LobbyChatUpdate_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_ChatUpdateCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014BD RID: 5309
		// (get) Token: 0x060044A7 RID: 17575 RVA: 0x00153014 File Offset: 0x00151214
		// (set) Token: 0x060044A8 RID: 17576 RVA: 0x00021827 File Offset: 0x0001FA27
		public unsafe Callback<GameLobbyJoinRequested_t> GameLobbyJoinRequestedCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_GameLobbyJoinRequestedCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<GameLobbyJoinRequested_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_GameLobbyJoinRequestedCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014BE RID: 5310
		// (get) Token: 0x060044A9 RID: 17577 RVA: 0x00153044 File Offset: 0x00151244
		// (set) Token: 0x060044AA RID: 17578 RVA: 0x00021846 File Offset: 0x0001FA46
		public unsafe Callback<LobbyChatMsg_t> LobbyChatMessageCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_LobbyChatMessageCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Callback<LobbyChatMsg_t>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_LobbyChatMessageCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014BF RID: 5311
		// (get) Token: 0x060044AB RID: 17579 RVA: 0x00153074 File Offset: 0x00151274
		// (set) Token: 0x060044AC RID: 17580 RVA: 0x00021865 File Offset: 0x0001FA65
		public unsafe string DebugSteamId64
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_DebugSteamId64);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Lobby.NativeFieldInfoPtr_DebugSteamId64), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002DD6 RID: 11734
		private static readonly IntPtr NativeFieldInfoPtr_ENABLED;

		// Token: 0x04002DD7 RID: 11735
		private static readonly IntPtr NativeFieldInfoPtr_PLAYER_LIMIT;

		// Token: 0x04002DD8 RID: 11736
		private static readonly IntPtr NativeFieldInfoPtr_JOIN_READY;

		// Token: 0x04002DD9 RID: 11737
		private static readonly IntPtr NativeFieldInfoPtr_LOAD_TUTORIAL;

		// Token: 0x04002DDA RID: 11738
		private static readonly IntPtr NativeFieldInfoPtr_HOST_LOADING;

		// Token: 0x04002DDB RID: 11739
		private static readonly IntPtr NativeFieldInfoPtr_NetworkManager;

		// Token: 0x04002DDC RID: 11740
		private static readonly IntPtr NativeFieldInfoPtr__LobbyID_k__BackingField;

		// Token: 0x04002DDD RID: 11741
		private static readonly IntPtr NativeFieldInfoPtr__LocalPlayerID_k__BackingField;

		// Token: 0x04002DDE RID: 11742
		private static readonly IntPtr NativeFieldInfoPtr_Players;

		// Token: 0x04002DDF RID: 11743
		private static readonly IntPtr NativeFieldInfoPtr_onLobbyChange;

		// Token: 0x04002DE0 RID: 11744
		private static readonly IntPtr NativeFieldInfoPtr_LobbyCreatedCallback;

		// Token: 0x04002DE1 RID: 11745
		private static readonly IntPtr NativeFieldInfoPtr_LobbyEnteredCallback;

		// Token: 0x04002DE2 RID: 11746
		private static readonly IntPtr NativeFieldInfoPtr_ChatUpdateCallback;

		// Token: 0x04002DE3 RID: 11747
		private static readonly IntPtr NativeFieldInfoPtr_GameLobbyJoinRequestedCallback;

		// Token: 0x04002DE4 RID: 11748
		private static readonly IntPtr NativeFieldInfoPtr_LobbyChatMessageCallback;

		// Token: 0x04002DE5 RID: 11749
		private static readonly IntPtr NativeFieldInfoPtr_DebugSteamId64;

		// Token: 0x04002DE6 RID: 11750
		private static readonly IntPtr NativeMethodInfoPtr_get_IsHost_Public_get_Boolean_0;

		// Token: 0x04002DE7 RID: 11751
		private static readonly IntPtr NativeMethodInfoPtr_get_LobbyID_Public_get_UInt64_0;

		// Token: 0x04002DE8 RID: 11752
		private static readonly IntPtr NativeMethodInfoPtr_set_LobbyID_Private_set_Void_UInt64_0;

		// Token: 0x04002DE9 RID: 11753
		private static readonly IntPtr NativeMethodInfoPtr_get_LobbySteamID_Public_get_CSteamID_0;

		// Token: 0x04002DEA RID: 11754
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInLobby_Public_get_Boolean_0;

		// Token: 0x04002DEB RID: 11755
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerCount_Public_get_Int32_0;

		// Token: 0x04002DEC RID: 11756
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPlayerID_Public_get_CSteamID_0;

		// Token: 0x04002DED RID: 11757
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalPlayerID_Private_set_Void_CSteamID_0;

		// Token: 0x04002DEE RID: 11758
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04002DEF RID: 11759
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04002DF0 RID: 11760
		private static readonly IntPtr NativeMethodInfoPtr_InitializeCallbacks_Private_Void_0;

		// Token: 0x04002DF1 RID: 11761
		private static readonly IntPtr NativeMethodInfoPtr_TryOpenInviteInterface_Public_Void_0;

		// Token: 0x04002DF2 RID: 11762
		private static readonly IntPtr NativeMethodInfoPtr_LeaveLobby_Public_Void_0;

		// Token: 0x04002DF3 RID: 11763
		private static readonly IntPtr NativeMethodInfoPtr_CreateLobby_Private_Void_0;

		// Token: 0x04002DF4 RID: 11764
		private static readonly IntPtr NativeMethodInfoPtr_GetLaunchLobby_Private_String_0;

		// Token: 0x04002DF5 RID: 11765
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLobbyMembers_Private_Void_0;

		// Token: 0x04002DF6 RID: 11766
		private static readonly IntPtr NativeMethodInfoPtr_DebugJoin_Public_Void_0;

		// Token: 0x04002DF7 RID: 11767
		private static readonly IntPtr NativeMethodInfoPtr_JoinAsClient_Public_Void_String_0;

		// Token: 0x04002DF8 RID: 11768
		private static readonly IntPtr NativeMethodInfoPtr_SendLobbyMessage_Public_Void_String_0;

		// Token: 0x04002DF9 RID: 11769
		private static readonly IntPtr NativeMethodInfoPtr_SetLobbyData_Public_Void_String_String_0;

		// Token: 0x04002DFA RID: 11770
		private static readonly IntPtr NativeMethodInfoPtr_OnLobbyCreated_Private_Void_LobbyCreated_t_0;

		// Token: 0x04002DFB RID: 11771
		private static readonly IntPtr NativeMethodInfoPtr_OnLobbyEntered_Private_Void_LobbyEnter_t_0;

		// Token: 0x04002DFC RID: 11772
		private static readonly IntPtr NativeMethodInfoPtr_PlayerEnterOrLeave_Private_Void_LobbyChatUpdate_t_0;

		// Token: 0x04002DFD RID: 11773
		private static readonly IntPtr NativeMethodInfoPtr_LobbyJoinRequested_Private_Void_GameLobbyJoinRequested_t_0;

		// Token: 0x04002DFE RID: 11774
		private static readonly IntPtr NativeMethodInfoPtr_OnLobbyChatMessage_Private_Void_LobbyChatMsg_t_0;

		// Token: 0x04002DFF RID: 11775
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000967 RID: 2407
		[ObfuscatedName("ScheduleOne.Networking.Lobby+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600C941 RID: 51521 RVA: 0x0030BAC8 File Offset: 0x00309CC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Lobby.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Lobby>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Lobby.__c>.NativeClassPtr);
				Lobby.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby.__c>.NativeClassPtr, "<>9");
				Lobby.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Lobby.__c>.NativeClassPtr, "<>9__17_0");
				Lobby.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby.__c>.NativeClassPtr, 100671683);
				Lobby.__c.NativeMethodInfoPtr__get_PlayerCount_b__17_0_Internal_Boolean_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Lobby.__c>.NativeClassPtr, 100671684);
			}

			// Token: 0x0600C942 RID: 51522 RVA: 0x0030BB44 File Offset: 0x00309D44
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Lobby.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C943 RID: 51523 RVA: 0x0030BB80 File Offset: 0x00309D80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154914, XrefRangeEnd = 154919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_PlayerCount_b__17_0(CSteamID p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Lobby.__c.NativeMethodInfoPtr__get_PlayerCount_b__17_0_Internal_Boolean_CSteamID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C944 RID: 51524 RVA: 0x00061E2F File Offset: 0x0006002F
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EC8 RID: 16072
			// (get) Token: 0x0600C945 RID: 51525 RVA: 0x0030BBCC File Offset: 0x00309DCC
			// (set) Token: 0x0600C946 RID: 51526 RVA: 0x00061E38 File Offset: 0x00060038
			public unsafe static Lobby.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Lobby.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lobby.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Lobby.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EC9 RID: 16073
			// (get) Token: 0x0600C947 RID: 51527 RVA: 0x0030BBF4 File Offset: 0x00309DF4
			// (set) Token: 0x0600C948 RID: 51528 RVA: 0x00061E4A File Offset: 0x0006004A
			public unsafe static Func<CSteamID, bool> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Lobby.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CSteamID, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Lobby.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008839 RID: 34873
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400883A RID: 34874
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x0400883B RID: 34875
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400883C RID: 34876
			private static readonly IntPtr NativeMethodInfoPtr__get_PlayerCount_b__17_0_Internal_Boolean_CSteamID_0;
		}
	}
}
