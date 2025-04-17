using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.Clothing;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x020003E3 RID: 995
	public class PlayerClothing : NetworkBehaviour
	{
		// Token: 0x06004FEB RID: 20459 RVA: 0x0017D9EC File Offset: 0x0017BBEC
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerClothing()
		{
			Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "PlayerClothing");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr);
			PlayerClothing.NativeFieldInfoPtr_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, "Player");
			PlayerClothing.NativeFieldInfoPtr__ItemSlots_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, "<ItemSlots>k__BackingField");
			PlayerClothing.NativeFieldInfoPtr_ClothingSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, "ClothingSlots");
			PlayerClothing.NativeFieldInfoPtr_appliedClothing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, "appliedClothing");
			PlayerClothing.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.PlayerScripts.PlayerClothingAssembly-CSharp.dll_Excuted");
			PlayerClothing.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.PlayerScripts.PlayerClothingAssembly-CSharp.dll_Excuted");
			PlayerClothing.NativeMethodInfoPtr_get_ItemSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673318);
			PlayerClothing.NativeMethodInfoPtr_set_ItemSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673319);
			PlayerClothing.NativeMethodInfoPtr_get_appearanceSettings_Private_get_AvatarSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673320);
			PlayerClothing.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673321);
			PlayerClothing.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673322);
			PlayerClothing.NativeMethodInfoPtr_InsertClothing_Public_Void_ClothingInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673323);
			PlayerClothing.NativeMethodInfoPtr_ClothingChanged_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673324);
			PlayerClothing.NativeMethodInfoPtr_RefreshAppearance_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673325);
			PlayerClothing.NativeMethodInfoPtr_TryGetInventoryClothing_Private_Boolean_String_Color_byref_ClothingInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673326);
			PlayerClothing.NativeMethodInfoPtr_IsClothingApplied_Private_Boolean_AvatarSettings_ClothingInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673327);
			PlayerClothing.NativeMethodInfoPtr_ApplyClothing_Private_Void_AvatarSettings_ClothingInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673328);
			PlayerClothing.NativeMethodInfoPtr_SetStoredInstance_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673329);
			PlayerClothing.NativeMethodInfoPtr_SetStoredInstance_Internal_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673330);
			PlayerClothing.NativeMethodInfoPtr_SetItemSlotQuantity_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673331);
			PlayerClothing.NativeMethodInfoPtr_SetItemSlotQuantity_Internal_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673332);
			PlayerClothing.NativeMethodInfoPtr_SetSlotLocked_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673333);
			PlayerClothing.NativeMethodInfoPtr_SetSlotLocked_Internal_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673334);
			PlayerClothing.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673335);
			PlayerClothing.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673336);
			PlayerClothing.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673337);
			PlayerClothing.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673338);
			PlayerClothing.NativeMethodInfoPtr_RpcWriter___Server_SetStoredInstance_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673339);
			PlayerClothing.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_2652194801_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673340);
			PlayerClothing.NativeMethodInfoPtr_RpcReader___Server_SetStoredInstance_2652194801_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673341);
			PlayerClothing.NativeMethodInfoPtr_RpcWriter___Observers_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673342);
			PlayerClothing.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673343);
			PlayerClothing.NativeMethodInfoPtr_RpcReader___Observers_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673344);
			PlayerClothing.NativeMethodInfoPtr_RpcWriter___Target_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673345);
			PlayerClothing.NativeMethodInfoPtr_RpcReader___Target_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673346);
			PlayerClothing.NativeMethodInfoPtr_RpcWriter___Server_SetItemSlotQuantity_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673347);
			PlayerClothing.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_1692629761_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673348);
			PlayerClothing.NativeMethodInfoPtr_RpcReader___Server_SetItemSlotQuantity_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673349);
			PlayerClothing.NativeMethodInfoPtr_RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673350);
			PlayerClothing.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673351);
			PlayerClothing.NativeMethodInfoPtr_RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673352);
			PlayerClothing.NativeMethodInfoPtr_RpcWriter___Server_SetSlotLocked_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673353);
			PlayerClothing.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_3170825843_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673354);
			PlayerClothing.NativeMethodInfoPtr_RpcReader___Server_SetSlotLocked_3170825843_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673355);
			PlayerClothing.NativeMethodInfoPtr_RpcWriter___Target_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673356);
			PlayerClothing.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673357);
			PlayerClothing.NativeMethodInfoPtr_RpcReader___Target_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673358);
			PlayerClothing.NativeMethodInfoPtr_RpcWriter___Observers_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673359);
			PlayerClothing.NativeMethodInfoPtr_RpcReader___Observers_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673360);
			PlayerClothing.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr, 100673361);
		}

		// Token: 0x170017F7 RID: 6135
		// (get) Token: 0x06004FEC RID: 20460 RVA: 0x0017DE04 File Offset: 0x0017C004
		// (set) Token: 0x06004FED RID: 20461 RVA: 0x0017DE44 File Offset: 0x0017C044
		public unsafe virtual List<ItemSlot> ItemSlots
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_get_ItemSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_set_ItemSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017F8 RID: 6136
		// (get) Token: 0x06004FEE RID: 20462 RVA: 0x0017DE88 File Offset: 0x0017C088
		public unsafe AvatarSettings appearanceSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_get_appearanceSettings_Private_get_AvatarSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AvatarSettings>(intPtr3) : null;
			}
		}

		// Token: 0x06004FEF RID: 20463 RVA: 0x0017DEC8 File Offset: 0x0017C0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173684, XrefRangeEnd = 173685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerClothing.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FF0 RID: 20464 RVA: 0x0017DF04 File Offset: 0x0017C104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173685, XrefRangeEnd = 173690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerClothing.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FF1 RID: 20465 RVA: 0x0017DF54 File Offset: 0x0017C154
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173709, RefRangeEnd = 173710, XrefRangeStart = 173690, XrefRangeEnd = 173709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InsertClothing(ClothingInstance clothing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(clothing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_InsertClothing_Public_Void_ClothingInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FF2 RID: 20466 RVA: 0x0017DF98 File Offset: 0x0017C198
		[CallerCount(0)]
		public unsafe virtual void ClothingChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerClothing.NativeMethodInfoPtr_ClothingChanged_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FF3 RID: 20467 RVA: 0x0017DFD4 File Offset: 0x0017C1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173710, XrefRangeEnd = 173772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshAppearance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerClothing.NativeMethodInfoPtr_RefreshAppearance_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FF4 RID: 20468 RVA: 0x0017E010 File Offset: 0x0017C210
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 173795, RefRangeEnd = 173797, XrefRangeStart = 173772, XrefRangeEnd = 173795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetInventoryClothing(string assetPath, Color color, out ClothingInstance clothing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(assetPath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_TryGetInventoryClothing_Private_Boolean_String_Color_byref_ClothingInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			clothing = ((intPtr4 == 0) ? null : new ClothingInstance(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004FF5 RID: 20469 RVA: 0x0017E090 File Offset: 0x0017C290
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173821, RefRangeEnd = 173822, XrefRangeStart = 173797, XrefRangeEnd = 173821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsClothingApplied(AvatarSettings settings, ClothingInstance clothing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clothing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_IsClothingApplied_Private_Boolean_AvatarSettings_ClothingInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004FF6 RID: 20470 RVA: 0x0017E0F0 File Offset: 0x0017C2F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 173849, RefRangeEnd = 173850, XrefRangeStart = 173822, XrefRangeEnd = 173849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyClothing(AvatarSettings settings, ClothingInstance clothing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clothing);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_ApplyClothing_Private_Void_AvatarSettings_ClothingInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FF7 RID: 20471 RVA: 0x0017E144 File Offset: 0x0017C344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173850, XrefRangeEnd = 173877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_SetStoredInstance_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FF8 RID: 20472 RVA: 0x0017E1A8 File Offset: 0x0017C3A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 173902, RefRangeEnd = 173905, XrefRangeStart = 173877, XrefRangeEnd = 173902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_SetStoredInstance_Internal_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FF9 RID: 20473 RVA: 0x0017E20C File Offset: 0x0017C40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173905, XrefRangeEnd = 173930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_SetItemSlotQuantity_Public_Virtual_Final_New_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FFA RID: 20474 RVA: 0x0017E258 File Offset: 0x0017C458
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 173958, RefRangeEnd = 173961, XrefRangeStart = 173930, XrefRangeEnd = 173958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_SetItemSlotQuantity_Internal_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FFB RID: 20475 RVA: 0x0017E2A4 File Offset: 0x0017C4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 173961, XrefRangeEnd = 173990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_SetSlotLocked_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FFC RID: 20476 RVA: 0x0017E328 File Offset: 0x0017C528
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 174040, RefRangeEnd = 174043, XrefRangeStart = 173990, XrefRangeEnd = 174040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_SetSlotLocked_Internal_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FFD RID: 20477 RVA: 0x0017E3AC File Offset: 0x0017C5AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174043, XrefRangeEnd = 174065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerClothing() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerClothing>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FFE RID: 20478 RVA: 0x0017E3E8 File Offset: 0x0017C5E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174065, XrefRangeEnd = 174115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerClothing.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004FFF RID: 20479 RVA: 0x0017E424 File Offset: 0x0017C624
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerClothing.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005000 RID: 20480 RVA: 0x0017E460 File Offset: 0x0017C660
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerClothing.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005001 RID: 20481 RVA: 0x0017E49C File Offset: 0x0017C69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174115, XrefRangeEnd = 174128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_RpcWriter___Server_SetStoredInstance_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005002 RID: 20482 RVA: 0x0017E500 File Offset: 0x0017C700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174128, XrefRangeEnd = 174132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_2652194801_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005003 RID: 20483 RVA: 0x0017E564 File Offset: 0x0017C764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174132, XrefRangeEnd = 174140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_RpcReader___Server_SetStoredInstance_2652194801_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005004 RID: 20484 RVA: 0x0017E5C8 File Offset: 0x0017C7C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174140, XrefRangeEnd = 174161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_RpcWriter___Observers_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005005 RID: 20485 RVA: 0x0017E62C File Offset: 0x0017C82C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174161, XrefRangeEnd = 174167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_RpcLogic___SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005006 RID: 20486 RVA: 0x0017E690 File Offset: 0x0017C890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174167, XrefRangeEnd = 174175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_RpcReader___Observers_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005007 RID: 20487 RVA: 0x0017E6E0 File Offset: 0x0017C8E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174175, XrefRangeEnd = 174187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_RpcWriter___Target_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005008 RID: 20488 RVA: 0x0017E744 File Offset: 0x0017C944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174187, XrefRangeEnd = 174196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_RpcReader___Target_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005009 RID: 20489 RVA: 0x0017E794 File Offset: 0x0017C994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174196, XrefRangeEnd = 174218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_RpcWriter___Server_SetItemSlotQuantity_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600500A RID: 20490 RVA: 0x0017E7E0 File Offset: 0x0017C9E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174218, XrefRangeEnd = 174219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_1692629761_Public_Virtual_Final_New_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600500B RID: 20491 RVA: 0x0017E82C File Offset: 0x0017CA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174219, XrefRangeEnd = 174226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_RpcReader___Server_SetItemSlotQuantity_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600500C RID: 20492 RVA: 0x0017E890 File Offset: 0x0017CA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174226, XrefRangeEnd = 174248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600500D RID: 20493 RVA: 0x0017E8DC File Offset: 0x0017CADC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174253, RefRangeEnd = 174254, XrefRangeStart = 174248, XrefRangeEnd = 174253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600500E RID: 20494 RVA: 0x0017E928 File Offset: 0x0017CB28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174254, XrefRangeEnd = 174261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600500F RID: 20495 RVA: 0x0017E978 File Offset: 0x0017CB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174261, XrefRangeEnd = 174276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_RpcWriter___Server_SetSlotLocked_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005010 RID: 20496 RVA: 0x0017E9FC File Offset: 0x0017CBFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174276, XrefRangeEnd = 174280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_3170825843_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005011 RID: 20497 RVA: 0x0017EA80 File Offset: 0x0017CC80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174280, XrefRangeEnd = 174289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_RpcReader___Server_SetSlotLocked_3170825843_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005012 RID: 20498 RVA: 0x0017EAE4 File Offset: 0x0017CCE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174289, XrefRangeEnd = 174303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_RpcWriter___Target_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005013 RID: 20499 RVA: 0x0017EB68 File Offset: 0x0017CD68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 174311, RefRangeEnd = 174314, XrefRangeStart = 174303, XrefRangeEnd = 174311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_RpcLogic___SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005014 RID: 20500 RVA: 0x0017EBEC File Offset: 0x0017CDEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174314, XrefRangeEnd = 174322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_RpcReader___Target_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005015 RID: 20501 RVA: 0x0017EC3C File Offset: 0x0017CE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174322, XrefRangeEnd = 174345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref itemSlotIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref locked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockOwner);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockReason);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_RpcWriter___Observers_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005016 RID: 20502 RVA: 0x0017ECC0 File Offset: 0x0017CEC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 174345, XrefRangeEnd = 174352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerClothing.NativeMethodInfoPtr_RpcReader___Observers_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005017 RID: 20503 RVA: 0x0017ED10 File Offset: 0x0017CF10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 174404, RefRangeEnd = 174405, XrefRangeStart = 174352, XrefRangeEnd = 174404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerClothing.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005018 RID: 20504 RVA: 0x0002615A File Offset: 0x0002435A
		public PlayerClothing(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170017F1 RID: 6129
		// (get) Token: 0x06005019 RID: 20505 RVA: 0x0017ED4C File Offset: 0x0017CF4C
		// (set) Token: 0x0600501A RID: 20506 RVA: 0x00026163 File Offset: 0x00024363
		public unsafe Player Player
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerClothing.NativeFieldInfoPtr_Player);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerClothing.NativeFieldInfoPtr_Player), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017F2 RID: 6130
		// (get) Token: 0x0600501B RID: 20507 RVA: 0x0017ED7C File Offset: 0x0017CF7C
		// (set) Token: 0x0600501C RID: 20508 RVA: 0x00026182 File Offset: 0x00024382
		public unsafe List<ItemSlot> _ItemSlots_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerClothing.NativeFieldInfoPtr__ItemSlots_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerClothing.NativeFieldInfoPtr__ItemSlots_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017F3 RID: 6131
		// (get) Token: 0x0600501D RID: 20509 RVA: 0x0017EDAC File Offset: 0x0017CFAC
		// (set) Token: 0x0600501E RID: 20510 RVA: 0x000261A1 File Offset: 0x000243A1
		public unsafe Dictionary<EClothingSlot, ItemSlot> ClothingSlots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerClothing.NativeFieldInfoPtr_ClothingSlots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<EClothingSlot, ItemSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerClothing.NativeFieldInfoPtr_ClothingSlots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017F4 RID: 6132
		// (get) Token: 0x0600501F RID: 20511 RVA: 0x0017EDDC File Offset: 0x0017CFDC
		// (set) Token: 0x06005020 RID: 20512 RVA: 0x000261C0 File Offset: 0x000243C0
		public unsafe List<ClothingInstance> appliedClothing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerClothing.NativeFieldInfoPtr_appliedClothing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ClothingInstance>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerClothing.NativeFieldInfoPtr_appliedClothing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017F5 RID: 6133
		// (get) Token: 0x06005021 RID: 20513 RVA: 0x0017EE0C File Offset: 0x0017D00C
		// (set) Token: 0x06005022 RID: 20514 RVA: 0x000261DF File Offset: 0x000243DF
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerClothing.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerClothing.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170017F6 RID: 6134
		// (get) Token: 0x06005023 RID: 20515 RVA: 0x0017EE34 File Offset: 0x0017D034
		// (set) Token: 0x06005024 RID: 20516 RVA: 0x000261FA File Offset: 0x000243FA
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerClothing.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerClothing.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400362E RID: 13870
		private static readonly IntPtr NativeFieldInfoPtr_Player;

		// Token: 0x0400362F RID: 13871
		private static readonly IntPtr NativeFieldInfoPtr__ItemSlots_k__BackingField;

		// Token: 0x04003630 RID: 13872
		private static readonly IntPtr NativeFieldInfoPtr_ClothingSlots;

		// Token: 0x04003631 RID: 13873
		private static readonly IntPtr NativeFieldInfoPtr_appliedClothing;

		// Token: 0x04003632 RID: 13874
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003633 RID: 13875
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003634 RID: 13876
		private static readonly IntPtr NativeMethodInfoPtr_get_ItemSlots_Public_Virtual_Final_New_get_List_1_ItemSlot_0;

		// Token: 0x04003635 RID: 13877
		private static readonly IntPtr NativeMethodInfoPtr_set_ItemSlots_Public_Virtual_Final_New_set_Void_List_1_ItemSlot_0;

		// Token: 0x04003636 RID: 13878
		private static readonly IntPtr NativeMethodInfoPtr_get_appearanceSettings_Private_get_AvatarSettings_0;

		// Token: 0x04003637 RID: 13879
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04003638 RID: 13880
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003639 RID: 13881
		private static readonly IntPtr NativeMethodInfoPtr_InsertClothing_Public_Void_ClothingInstance_0;

		// Token: 0x0400363A RID: 13882
		private static readonly IntPtr NativeMethodInfoPtr_ClothingChanged_Protected_Virtual_New_Void_1;

		// Token: 0x0400363B RID: 13883
		private static readonly IntPtr NativeMethodInfoPtr_RefreshAppearance_Public_Virtual_New_Void_0;

		// Token: 0x0400363C RID: 13884
		private static readonly IntPtr NativeMethodInfoPtr_TryGetInventoryClothing_Private_Boolean_String_Color_byref_ClothingInstance_0;

		// Token: 0x0400363D RID: 13885
		private static readonly IntPtr NativeMethodInfoPtr_IsClothingApplied_Private_Boolean_AvatarSettings_ClothingInstance_0;

		// Token: 0x0400363E RID: 13886
		private static readonly IntPtr NativeMethodInfoPtr_ApplyClothing_Private_Void_AvatarSettings_ClothingInstance_0;

		// Token: 0x0400363F RID: 13887
		private static readonly IntPtr NativeMethodInfoPtr_SetStoredInstance_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04003640 RID: 13888
		private static readonly IntPtr NativeMethodInfoPtr_SetStoredInstance_Internal_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04003641 RID: 13889
		private static readonly IntPtr NativeMethodInfoPtr_SetItemSlotQuantity_Public_Virtual_Final_New_Void_Int32_Int32_0;

		// Token: 0x04003642 RID: 13890
		private static readonly IntPtr NativeMethodInfoPtr_SetItemSlotQuantity_Internal_Private_Void_Int32_Int32_0;

		// Token: 0x04003643 RID: 13891
		private static readonly IntPtr NativeMethodInfoPtr_SetSlotLocked_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04003644 RID: 13892
		private static readonly IntPtr NativeMethodInfoPtr_SetSlotLocked_Internal_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04003645 RID: 13893
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003646 RID: 13894
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003647 RID: 13895
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003648 RID: 13896
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003649 RID: 13897
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetStoredInstance_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x0400364A RID: 13898
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetStoredInstance_2652194801_Public_Virtual_Final_New_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x0400364B RID: 13899
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetStoredInstance_2652194801_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400364C RID: 13900
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x0400364D RID: 13901
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x0400364E RID: 13902
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400364F RID: 13903
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetStoredInstance_Internal_2652194801_Private_Void_NetworkConnection_Int32_ItemInstance_0;

		// Token: 0x04003650 RID: 13904
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetStoredInstance_Internal_2652194801_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003651 RID: 13905
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetItemSlotQuantity_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04003652 RID: 13906
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_1692629761_Public_Virtual_Final_New_Void_Int32_Int32_0;

		// Token: 0x04003653 RID: 13907
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetItemSlotQuantity_1692629761_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003654 RID: 13908
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04003655 RID: 13909
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetItemSlotQuantity_Internal_1692629761_Private_Void_Int32_Int32_0;

		// Token: 0x04003656 RID: 13910
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003657 RID: 13911
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SetSlotLocked_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04003658 RID: 13912
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSlotLocked_3170825843_Public_Virtual_Final_New_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x04003659 RID: 13913
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SetSlotLocked_3170825843_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400365A RID: 13914
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x0400365B RID: 13915
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x0400365C RID: 13916
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400365D RID: 13917
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetSlotLocked_Internal_3170825843_Private_Void_NetworkConnection_Int32_Boolean_NetworkObject_String_0;

		// Token: 0x0400365E RID: 13918
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetSlotLocked_Internal_3170825843_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400365F RID: 13919
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}
