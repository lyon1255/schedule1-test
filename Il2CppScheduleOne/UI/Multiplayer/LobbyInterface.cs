using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Networking;
using Il2CppSteamworks;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Multiplayer
{
	// Token: 0x020006B6 RID: 1718
	public class LobbyInterface : PersistentSingleton<LobbyInterface>
	{
		// Token: 0x06009AF9 RID: 39673 RVA: 0x00275804 File Offset: 0x00273A04
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyInterface()
		{
			Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Multiplayer", "LobbyInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr);
			LobbyInterface.NativeFieldInfoPtr_Lobby = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, "Lobby");
			LobbyInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, "Canvas");
			LobbyInterface.NativeFieldInfoPtr_LobbyTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, "LobbyTitle");
			LobbyInterface.NativeFieldInfoPtr_PlayerSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, "PlayerSlots");
			LobbyInterface.NativeFieldInfoPtr_InviteButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, "InviteButton");
			LobbyInterface.NativeFieldInfoPtr_LeaveButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, "LeaveButton");
			LobbyInterface.NativeFieldInfoPtr_InviteHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, "InviteHint");
			LobbyInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682356);
			LobbyInterface.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682357);
			LobbyInterface.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682358);
			LobbyInterface.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682359);
			LobbyInterface.NativeMethodInfoPtr_LeaveClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682360);
			LobbyInterface.NativeMethodInfoPtr_InviteClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682361);
			LobbyInterface.NativeMethodInfoPtr_UpdateButtons_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682362);
			LobbyInterface.NativeMethodInfoPtr_UpdatePlayers_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682363);
			LobbyInterface.NativeMethodInfoPtr_SetPlayer_Public_Void_Int32_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682364);
			LobbyInterface.NativeMethodInfoPtr_ClearPlayer_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682365);
			LobbyInterface.NativeMethodInfoPtr_GetAvatar_Private_Texture2D_CSteamID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682366);
			LobbyInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682367);
			LobbyInterface.NativeMethodInfoPtr__Awake_b__7_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr, 100682368);
		}

		// Token: 0x06009AFA RID: 39674 RVA: 0x002759C4 File Offset: 0x00273BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275281, XrefRangeEnd = 275322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LobbyInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AFB RID: 39675 RVA: 0x00275A00 File Offset: 0x00273C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275322, XrefRangeEnd = 275345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LobbyInterface.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AFC RID: 39676 RVA: 0x00275A3C File Offset: 0x00273C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275345, XrefRangeEnd = 275353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AFD RID: 39677 RVA: 0x00275A70 File Offset: 0x00273C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275353, XrefRangeEnd = 275355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AFE RID: 39678 RVA: 0x00275AB0 File Offset: 0x00273CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275355, XrefRangeEnd = 275357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LeaveClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_LeaveClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009AFF RID: 39679 RVA: 0x00275AE4 File Offset: 0x00273CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275357, XrefRangeEnd = 275363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InviteClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_InviteClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B00 RID: 39680 RVA: 0x00275B18 File Offset: 0x00273D18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275372, RefRangeEnd = 275374, XrefRangeStart = 275363, XrefRangeEnd = 275372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateButtons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_UpdateButtons_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B01 RID: 39681 RVA: 0x00275B4C File Offset: 0x00273D4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275392, RefRangeEnd = 275394, XrefRangeStart = 275374, XrefRangeEnd = 275392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePlayers()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_UpdatePlayers_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B02 RID: 39682 RVA: 0x00275B80 File Offset: 0x00273D80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 275406, RefRangeEnd = 275408, XrefRangeStart = 275394, XrefRangeEnd = 275406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPlayer(int index, CSteamID player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref player;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_SetPlayer_Public_Void_Int32_CSteamID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B03 RID: 39683 RVA: 0x00275BCC File Offset: 0x00273DCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275416, RefRangeEnd = 275417, XrefRangeStart = 275408, XrefRangeEnd = 275416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPlayer(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_ClearPlayer_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B04 RID: 39684 RVA: 0x00275C0C File Offset: 0x00273E0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275433, RefRangeEnd = 275434, XrefRangeStart = 275417, XrefRangeEnd = 275433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D GetAvatar(CSteamID user)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref user;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr_GetAvatar_Private_Texture2D_CSteamID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x06009B05 RID: 39685 RVA: 0x00275C58 File Offset: 0x00273E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275434, XrefRangeEnd = 275437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B06 RID: 39686 RVA: 0x00275C94 File Offset: 0x00273E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275437, XrefRangeEnd = 275457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__7_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyInterface.NativeMethodInfoPtr__Awake_b__7_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B07 RID: 39687 RVA: 0x0004BE21 File Offset: 0x0004A021
		public LobbyInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FBC RID: 12220
		// (get) Token: 0x06009B08 RID: 39688 RVA: 0x00275CC8 File Offset: 0x00273EC8
		// (set) Token: 0x06009B09 RID: 39689 RVA: 0x0004BE2A File Offset: 0x0004A02A
		public unsafe Lobby Lobby
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_Lobby);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Lobby>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_Lobby), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FBD RID: 12221
		// (get) Token: 0x06009B0A RID: 39690 RVA: 0x00275CF8 File Offset: 0x00273EF8
		// (set) Token: 0x06009B0B RID: 39691 RVA: 0x0004BE49 File Offset: 0x0004A049
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FBE RID: 12222
		// (get) Token: 0x06009B0C RID: 39692 RVA: 0x00275D28 File Offset: 0x00273F28
		// (set) Token: 0x06009B0D RID: 39693 RVA: 0x0004BE68 File Offset: 0x0004A068
		public unsafe TextMeshProUGUI LobbyTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_LobbyTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_LobbyTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FBF RID: 12223
		// (get) Token: 0x06009B0E RID: 39694 RVA: 0x00275D58 File Offset: 0x00273F58
		// (set) Token: 0x06009B0F RID: 39695 RVA: 0x0004BE87 File Offset: 0x0004A087
		public unsafe Il2CppReferenceArray<RectTransform> PlayerSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_PlayerSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_PlayerSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FC0 RID: 12224
		// (get) Token: 0x06009B10 RID: 39696 RVA: 0x00275D88 File Offset: 0x00273F88
		// (set) Token: 0x06009B11 RID: 39697 RVA: 0x0004BEA6 File Offset: 0x0004A0A6
		public unsafe Button InviteButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_InviteButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_InviteButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FC1 RID: 12225
		// (get) Token: 0x06009B12 RID: 39698 RVA: 0x00275DB8 File Offset: 0x00273FB8
		// (set) Token: 0x06009B13 RID: 39699 RVA: 0x0004BEC5 File Offset: 0x0004A0C5
		public unsafe Button LeaveButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_LeaveButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_LeaveButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FC2 RID: 12226
		// (get) Token: 0x06009B14 RID: 39700 RVA: 0x00275DE8 File Offset: 0x00273FE8
		// (set) Token: 0x06009B15 RID: 39701 RVA: 0x0004BEE4 File Offset: 0x0004A0E4
		public unsafe GameObject InviteHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_InviteHint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyInterface.NativeFieldInfoPtr_InviteHint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006832 RID: 26674
		private static readonly IntPtr NativeFieldInfoPtr_Lobby;

		// Token: 0x04006833 RID: 26675
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006834 RID: 26676
		private static readonly IntPtr NativeFieldInfoPtr_LobbyTitle;

		// Token: 0x04006835 RID: 26677
		private static readonly IntPtr NativeFieldInfoPtr_PlayerSlots;

		// Token: 0x04006836 RID: 26678
		private static readonly IntPtr NativeFieldInfoPtr_InviteButton;

		// Token: 0x04006837 RID: 26679
		private static readonly IntPtr NativeFieldInfoPtr_LeaveButton;

		// Token: 0x04006838 RID: 26680
		private static readonly IntPtr NativeFieldInfoPtr_InviteHint;

		// Token: 0x04006839 RID: 26681
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400683A RID: 26682
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400683B RID: 26683
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400683C RID: 26684
		private static readonly IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x0400683D RID: 26685
		private static readonly IntPtr NativeMethodInfoPtr_LeaveClicked_Public_Void_0;

		// Token: 0x0400683E RID: 26686
		private static readonly IntPtr NativeMethodInfoPtr_InviteClicked_Public_Void_0;

		// Token: 0x0400683F RID: 26687
		private static readonly IntPtr NativeMethodInfoPtr_UpdateButtons_Private_Void_0;

		// Token: 0x04006840 RID: 26688
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePlayers_Private_Void_0;

		// Token: 0x04006841 RID: 26689
		private static readonly IntPtr NativeMethodInfoPtr_SetPlayer_Public_Void_Int32_CSteamID_0;

		// Token: 0x04006842 RID: 26690
		private static readonly IntPtr NativeMethodInfoPtr_ClearPlayer_Public_Void_Int32_0;

		// Token: 0x04006843 RID: 26691
		private static readonly IntPtr NativeMethodInfoPtr_GetAvatar_Private_Texture2D_CSteamID_0;

		// Token: 0x04006844 RID: 26692
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006845 RID: 26693
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__7_0_Private_Void_0;
	}
}
