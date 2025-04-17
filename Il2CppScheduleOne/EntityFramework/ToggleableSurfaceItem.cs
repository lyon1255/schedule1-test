using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;

namespace Il2CppScheduleOne.EntityFramework
{
	// Token: 0x02000403 RID: 1027
	public class ToggleableSurfaceItem : SurfaceItem
	{
		// Token: 0x0600565F RID: 22111 RVA: 0x00193C54 File Offset: 0x00191E54
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleableSurfaceItem()
		{
			Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.EntityFramework", "ToggleableSurfaceItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr);
			ToggleableSurfaceItem.NativeFieldInfoPtr__IsOn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, "<IsOn>k__BackingField");
			ToggleableSurfaceItem.NativeFieldInfoPtr_StartupAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, "StartupAction");
			ToggleableSurfaceItem.NativeFieldInfoPtr_onTurnedOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, "onTurnedOn");
			ToggleableSurfaceItem.NativeFieldInfoPtr_onTurnedOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, "onTurnedOff");
			ToggleableSurfaceItem.NativeFieldInfoPtr_onTurnOnOrOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, "onTurnOnOrOff");
			ToggleableSurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.EntityFramework.ToggleableSurfaceItemAssembly-CSharp.dll_Excuted");
			ToggleableSurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.EntityFramework.ToggleableSurfaceItemAssembly-CSharp.dll_Excuted");
			ToggleableSurfaceItem.NativeMethodInfoPtr_get_IsOn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100674130);
			ToggleableSurfaceItem.NativeMethodInfoPtr_set_IsOn_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100674131);
			ToggleableSurfaceItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100674132);
			ToggleableSurfaceItem.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100674133);
			ToggleableSurfaceItem.NativeMethodInfoPtr_Toggle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100674134);
			ToggleableSurfaceItem.NativeMethodInfoPtr_TurnOn_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100674135);
			ToggleableSurfaceItem.NativeMethodInfoPtr_TurnOff_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100674136);
			ToggleableSurfaceItem.NativeMethodInfoPtr_SendIsOn_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100674137);
			ToggleableSurfaceItem.NativeMethodInfoPtr_SetIsOn_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100674138);
			ToggleableSurfaceItem.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100674139);
			ToggleableSurfaceItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100674140);
			ToggleableSurfaceItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100674141);
			ToggleableSurfaceItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100674142);
			ToggleableSurfaceItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100674143);
			ToggleableSurfaceItem.NativeMethodInfoPtr_RpcWriter___Server_SendIsOn_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100674144);
			ToggleableSurfaceItem.NativeMethodInfoPtr_RpcLogic___SendIsOn_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100674145);
			ToggleableSurfaceItem.NativeMethodInfoPtr_RpcReader___Server_SendIsOn_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100674146);
			ToggleableSurfaceItem.NativeMethodInfoPtr_RpcWriter___Observers_SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100674147);
			ToggleableSurfaceItem.NativeMethodInfoPtr_RpcLogic___SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100674148);
			ToggleableSurfaceItem.NativeMethodInfoPtr_RpcReader___Observers_SetIsOn_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100674149);
			ToggleableSurfaceItem.NativeMethodInfoPtr_RpcWriter___Target_SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100674150);
			ToggleableSurfaceItem.NativeMethodInfoPtr_RpcReader___Target_SetIsOn_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100674151);
			ToggleableSurfaceItem.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr, 100674152);
		}

		// Token: 0x17001A17 RID: 6679
		// (get) Token: 0x06005660 RID: 22112 RVA: 0x00193EDC File Offset: 0x001920DC
		// (set) Token: 0x06005661 RID: 22113 RVA: 0x00193F18 File Offset: 0x00192118
		public unsafe bool IsOn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr_get_IsOn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr_set_IsOn_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005662 RID: 22114 RVA: 0x00193F58 File Offset: 0x00192158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183080, XrefRangeEnd = 183083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableSurfaceItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005663 RID: 22115 RVA: 0x00193F94 File Offset: 0x00192194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183083, XrefRangeEnd = 183086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableSurfaceItem.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005664 RID: 22116 RVA: 0x00193FE4 File Offset: 0x001921E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183086, XrefRangeEnd = 183089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Toggle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr_Toggle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005665 RID: 22117 RVA: 0x00194018 File Offset: 0x00192218
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 183092, RefRangeEnd = 183095, XrefRangeStart = 183089, XrefRangeEnd = 183092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TurnOn(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr_TurnOn_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005666 RID: 22118 RVA: 0x00194058 File Offset: 0x00192258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183095, XrefRangeEnd = 183099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TurnOff(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr_TurnOff_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005667 RID: 22119 RVA: 0x00194098 File Offset: 0x00192298
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 183121, RefRangeEnd = 183127, XrefRangeStart = 183099, XrefRangeEnd = 183121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendIsOn(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr_SendIsOn_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005668 RID: 22120 RVA: 0x001940D8 File Offset: 0x001922D8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 183172, RefRangeEnd = 183178, XrefRangeStart = 183127, XrefRangeEnd = 183172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOn(NetworkConnection conn, bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr_SetIsOn_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005669 RID: 22121 RVA: 0x00194128 File Offset: 0x00192328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183178, XrefRangeEnd = 183183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableSurfaceItem.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600566A RID: 22122 RVA: 0x0019416C File Offset: 0x0019236C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183183, XrefRangeEnd = 183184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleableSurfaceItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleableSurfaceItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600566B RID: 22123 RVA: 0x001941A8 File Offset: 0x001923A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183184, XrefRangeEnd = 183205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableSurfaceItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600566C RID: 22124 RVA: 0x001941E4 File Offset: 0x001923E4
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableSurfaceItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600566D RID: 22125 RVA: 0x00194220 File Offset: 0x00192420
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableSurfaceItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600566E RID: 22126 RVA: 0x0019425C File Offset: 0x0019245C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 183224, RefRangeEnd = 183226, XrefRangeStart = 183205, XrefRangeEnd = 183224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendIsOn_1140765316(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr_RpcWriter___Server_SendIsOn_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600566F RID: 22127 RVA: 0x0019429C File Offset: 0x0019249C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183226, XrefRangeEnd = 183227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendIsOn_1140765316(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr_RpcLogic___SendIsOn_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005670 RID: 22128 RVA: 0x001942DC File Offset: 0x001924DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183227, XrefRangeEnd = 183230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendIsOn_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr_RpcReader___Server_SendIsOn_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005671 RID: 22129 RVA: 0x00194340 File Offset: 0x00192540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183230, XrefRangeEnd = 183249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetIsOn_214505783(NetworkConnection conn, bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr_RpcWriter___Observers_SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005672 RID: 22130 RVA: 0x00194390 File Offset: 0x00192590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183249, XrefRangeEnd = 183252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetIsOn_214505783(NetworkConnection conn, bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr_RpcLogic___SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005673 RID: 22131 RVA: 0x001943E0 File Offset: 0x001925E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183252, XrefRangeEnd = 183256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr_RpcReader___Observers_SetIsOn_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005674 RID: 22132 RVA: 0x00194430 File Offset: 0x00192630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183256, XrefRangeEnd = 183275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetIsOn_214505783(NetworkConnection conn, bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr_RpcWriter___Target_SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005675 RID: 22133 RVA: 0x00194480 File Offset: 0x00192680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183275, XrefRangeEnd = 183279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableSurfaceItem.NativeMethodInfoPtr_RpcReader___Target_SetIsOn_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005676 RID: 22134 RVA: 0x001944D0 File Offset: 0x001926D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183279, XrefRangeEnd = 183282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableSurfaceItem.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005677 RID: 22135 RVA: 0x000293DD File Offset: 0x000275DD
		public ToggleableSurfaceItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A10 RID: 6672
		// (get) Token: 0x06005678 RID: 22136 RVA: 0x0019450C File Offset: 0x0019270C
		// (set) Token: 0x06005679 RID: 22137 RVA: 0x000293E6 File Offset: 0x000275E6
		public unsafe bool _IsOn_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableSurfaceItem.NativeFieldInfoPtr__IsOn_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableSurfaceItem.NativeFieldInfoPtr__IsOn_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A11 RID: 6673
		// (get) Token: 0x0600567A RID: 22138 RVA: 0x00194534 File Offset: 0x00192734
		// (set) Token: 0x0600567B RID: 22139 RVA: 0x00029401 File Offset: 0x00027601
		public unsafe ToggleableSurfaceItem.EStartupAction StartupAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableSurfaceItem.NativeFieldInfoPtr_StartupAction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableSurfaceItem.NativeFieldInfoPtr_StartupAction)) = value;
			}
		}

		// Token: 0x17001A12 RID: 6674
		// (get) Token: 0x0600567C RID: 22140 RVA: 0x0019455C File Offset: 0x0019275C
		// (set) Token: 0x0600567D RID: 22141 RVA: 0x0002941C File Offset: 0x0002761C
		public unsafe UnityEvent onTurnedOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableSurfaceItem.NativeFieldInfoPtr_onTurnedOn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableSurfaceItem.NativeFieldInfoPtr_onTurnedOn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A13 RID: 6675
		// (get) Token: 0x0600567E RID: 22142 RVA: 0x0019458C File Offset: 0x0019278C
		// (set) Token: 0x0600567F RID: 22143 RVA: 0x0002943B File Offset: 0x0002763B
		public unsafe UnityEvent onTurnedOff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableSurfaceItem.NativeFieldInfoPtr_onTurnedOff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableSurfaceItem.NativeFieldInfoPtr_onTurnedOff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A14 RID: 6676
		// (get) Token: 0x06005680 RID: 22144 RVA: 0x001945BC File Offset: 0x001927BC
		// (set) Token: 0x06005681 RID: 22145 RVA: 0x0002945A File Offset: 0x0002765A
		public unsafe UnityEvent onTurnOnOrOff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableSurfaceItem.NativeFieldInfoPtr_onTurnOnOrOff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableSurfaceItem.NativeFieldInfoPtr_onTurnOnOrOff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A15 RID: 6677
		// (get) Token: 0x06005682 RID: 22146 RVA: 0x001945EC File Offset: 0x001927EC
		// (set) Token: 0x06005683 RID: 22147 RVA: 0x00029479 File Offset: 0x00027679
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableSurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableSurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001A16 RID: 6678
		// (get) Token: 0x06005684 RID: 22148 RVA: 0x00194614 File Offset: 0x00192814
		// (set) Token: 0x06005685 RID: 22149 RVA: 0x00029494 File Offset: 0x00027694
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableSurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableSurfaceItem.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003A9C RID: 15004
		private static readonly IntPtr NativeFieldInfoPtr__IsOn_k__BackingField;

		// Token: 0x04003A9D RID: 15005
		private static readonly IntPtr NativeFieldInfoPtr_StartupAction;

		// Token: 0x04003A9E RID: 15006
		private static readonly IntPtr NativeFieldInfoPtr_onTurnedOn;

		// Token: 0x04003A9F RID: 15007
		private static readonly IntPtr NativeFieldInfoPtr_onTurnedOff;

		// Token: 0x04003AA0 RID: 15008
		private static readonly IntPtr NativeFieldInfoPtr_onTurnOnOrOff;

		// Token: 0x04003AA1 RID: 15009
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003AA2 RID: 15010
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003AA3 RID: 15011
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOn_Public_get_Boolean_0;

		// Token: 0x04003AA4 RID: 15012
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOn_Private_set_Void_Boolean_0;

		// Token: 0x04003AA5 RID: 15013
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04003AA6 RID: 15014
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003AA7 RID: 15015
		private static readonly IntPtr NativeMethodInfoPtr_Toggle_Public_Void_0;

		// Token: 0x04003AA8 RID: 15016
		private static readonly IntPtr NativeMethodInfoPtr_TurnOn_Public_Void_Boolean_0;

		// Token: 0x04003AA9 RID: 15017
		private static readonly IntPtr NativeMethodInfoPtr_TurnOff_Public_Void_Boolean_0;

		// Token: 0x04003AAA RID: 15018
		private static readonly IntPtr NativeMethodInfoPtr_SendIsOn_Private_Void_Boolean_0;

		// Token: 0x04003AAB RID: 15019
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOn_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04003AAC RID: 15020
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04003AAD RID: 15021
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003AAE RID: 15022
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003AAF RID: 15023
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003AB0 RID: 15024
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003AB1 RID: 15025
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendIsOn_1140765316_Private_Void_Boolean_0;

		// Token: 0x04003AB2 RID: 15026
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendIsOn_1140765316_Private_Void_Boolean_0;

		// Token: 0x04003AB3 RID: 15027
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendIsOn_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003AB4 RID: 15028
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04003AB5 RID: 15029
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04003AB6 RID: 15030
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetIsOn_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003AB7 RID: 15031
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04003AB8 RID: 15032
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetIsOn_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003AB9 RID: 15033
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x020009C7 RID: 2503
		[OriginalName("Assembly-CSharp.dll", "", "EStartupAction")]
		public enum EStartupAction
		{
			// Token: 0x04008A49 RID: 35401
			None,
			// Token: 0x04008A4A RID: 35402
			TurnOn,
			// Token: 0x04008A4B RID: 35403
			TurnOff,
			// Token: 0x04008A4C RID: 35404
			Toggle
		}
	}
}
