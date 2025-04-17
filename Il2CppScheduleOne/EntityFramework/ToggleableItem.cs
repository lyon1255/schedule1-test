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
	// Token: 0x02000402 RID: 1026
	public class ToggleableItem : GridItem
	{
		// Token: 0x06005638 RID: 22072 RVA: 0x0019326C File Offset: 0x0019146C
		// Note: this type is marked as 'beforefieldinit'.
		static ToggleableItem()
		{
			Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.EntityFramework", "ToggleableItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr);
			ToggleableItem.NativeFieldInfoPtr__IsOn_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr, "<IsOn>k__BackingField");
			ToggleableItem.NativeFieldInfoPtr_StartupAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr, "StartupAction");
			ToggleableItem.NativeFieldInfoPtr_onTurnedOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr, "onTurnedOn");
			ToggleableItem.NativeFieldInfoPtr_onTurnedOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr, "onTurnedOff");
			ToggleableItem.NativeFieldInfoPtr_onTurnOnOrOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr, "onTurnOnOrOff");
			ToggleableItem.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.EntityFramework.ToggleableItemAssembly-CSharp.dll_Excuted");
			ToggleableItem.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.EntityFramework.ToggleableItemAssembly-CSharp.dll_Excuted");
			ToggleableItem.NativeMethodInfoPtr_get_IsOn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr, 100674107);
			ToggleableItem.NativeMethodInfoPtr_set_IsOn_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr, 100674108);
			ToggleableItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr, 100674109);
			ToggleableItem.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr, 100674110);
			ToggleableItem.NativeMethodInfoPtr_Toggle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr, 100674111);
			ToggleableItem.NativeMethodInfoPtr_TurnOn_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr, 100674112);
			ToggleableItem.NativeMethodInfoPtr_TurnOff_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr, 100674113);
			ToggleableItem.NativeMethodInfoPtr_SendIsOn_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr, 100674114);
			ToggleableItem.NativeMethodInfoPtr_SetIsOn_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr, 100674115);
			ToggleableItem.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr, 100674116);
			ToggleableItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr, 100674117);
			ToggleableItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr, 100674118);
			ToggleableItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr, 100674119);
			ToggleableItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr, 100674120);
			ToggleableItem.NativeMethodInfoPtr_RpcWriter___Server_SendIsOn_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr, 100674121);
			ToggleableItem.NativeMethodInfoPtr_RpcLogic___SendIsOn_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr, 100674122);
			ToggleableItem.NativeMethodInfoPtr_RpcReader___Server_SendIsOn_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr, 100674123);
			ToggleableItem.NativeMethodInfoPtr_RpcWriter___Observers_SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr, 100674124);
			ToggleableItem.NativeMethodInfoPtr_RpcLogic___SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr, 100674125);
			ToggleableItem.NativeMethodInfoPtr_RpcReader___Observers_SetIsOn_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr, 100674126);
			ToggleableItem.NativeMethodInfoPtr_RpcWriter___Target_SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr, 100674127);
			ToggleableItem.NativeMethodInfoPtr_RpcReader___Target_SetIsOn_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr, 100674128);
			ToggleableItem.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr, 100674129);
		}

		// Token: 0x17001A0F RID: 6671
		// (get) Token: 0x06005639 RID: 22073 RVA: 0x001934F4 File Offset: 0x001916F4
		// (set) Token: 0x0600563A RID: 22074 RVA: 0x00193530 File Offset: 0x00191730
		public unsafe bool IsOn
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableItem.NativeMethodInfoPtr_get_IsOn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableItem.NativeMethodInfoPtr_set_IsOn_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600563B RID: 22075 RVA: 0x00193570 File Offset: 0x00191770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182849, XrefRangeEnd = 182850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableItem.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600563C RID: 22076 RVA: 0x001935AC File Offset: 0x001917AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182850, XrefRangeEnd = 182853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableItem.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600563D RID: 22077 RVA: 0x001935FC File Offset: 0x001917FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182853, XrefRangeEnd = 182856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Toggle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableItem.NativeMethodInfoPtr_Toggle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600563E RID: 22078 RVA: 0x00193630 File Offset: 0x00191830
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 182859, RefRangeEnd = 182862, XrefRangeStart = 182856, XrefRangeEnd = 182859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TurnOn(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableItem.NativeMethodInfoPtr_TurnOn_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600563F RID: 22079 RVA: 0x00193670 File Offset: 0x00191870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182862, XrefRangeEnd = 182866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TurnOff(bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableItem.NativeMethodInfoPtr_TurnOff_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005640 RID: 22080 RVA: 0x001936B0 File Offset: 0x001918B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 182888, RefRangeEnd = 182893, XrefRangeStart = 182866, XrefRangeEnd = 182888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendIsOn(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableItem.NativeMethodInfoPtr_SendIsOn_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005641 RID: 22081 RVA: 0x001936F0 File Offset: 0x001918F0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 182938, RefRangeEnd = 182944, XrefRangeStart = 182893, XrefRangeEnd = 182938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOn(NetworkConnection conn, bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableItem.NativeMethodInfoPtr_SetIsOn_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005642 RID: 22082 RVA: 0x00193740 File Offset: 0x00191940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182944, XrefRangeEnd = 182949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableItem.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005643 RID: 22083 RVA: 0x00193784 File Offset: 0x00191984
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 181726, RefRangeEnd = 181744, XrefRangeStart = 181726, XrefRangeEnd = 181744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ToggleableItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ToggleableItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005644 RID: 22084 RVA: 0x001937C0 File Offset: 0x001919C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 182949, XrefRangeEnd = 182990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableItem.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005645 RID: 22085 RVA: 0x001937FC File Offset: 0x001919FC
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableItem.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005646 RID: 22086 RVA: 0x00193838 File Offset: 0x00191A38
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableItem.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005647 RID: 22087 RVA: 0x00193874 File Offset: 0x00191A74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 183009, RefRangeEnd = 183011, XrefRangeStart = 182990, XrefRangeEnd = 183009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendIsOn_1140765316(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableItem.NativeMethodInfoPtr_RpcWriter___Server_SendIsOn_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005648 RID: 22088 RVA: 0x001938B4 File Offset: 0x00191AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183011, XrefRangeEnd = 183012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendIsOn_1140765316(bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableItem.NativeMethodInfoPtr_RpcLogic___SendIsOn_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005649 RID: 22089 RVA: 0x001938F4 File Offset: 0x00191AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183012, XrefRangeEnd = 183015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendIsOn_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableItem.NativeMethodInfoPtr_RpcReader___Server_SendIsOn_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600564A RID: 22090 RVA: 0x00193958 File Offset: 0x00191B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183015, XrefRangeEnd = 183034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetIsOn_214505783(NetworkConnection conn, bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableItem.NativeMethodInfoPtr_RpcWriter___Observers_SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600564B RID: 22091 RVA: 0x001939A8 File Offset: 0x00191BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183034, XrefRangeEnd = 183037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetIsOn_214505783(NetworkConnection conn, bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableItem.NativeMethodInfoPtr_RpcLogic___SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600564C RID: 22092 RVA: 0x001939F8 File Offset: 0x00191BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183037, XrefRangeEnd = 183041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableItem.NativeMethodInfoPtr_RpcReader___Observers_SetIsOn_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600564D RID: 22093 RVA: 0x00193A48 File Offset: 0x00191C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183041, XrefRangeEnd = 183060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetIsOn_214505783(NetworkConnection conn, bool on)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref on;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableItem.NativeMethodInfoPtr_RpcWriter___Target_SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600564E RID: 22094 RVA: 0x00193A98 File Offset: 0x00191C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183060, XrefRangeEnd = 183064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ToggleableItem.NativeMethodInfoPtr_RpcReader___Target_SetIsOn_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600564F RID: 22095 RVA: 0x00193AE8 File Offset: 0x00191CE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 183079, RefRangeEnd = 183080, XrefRangeStart = 183064, XrefRangeEnd = 183079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ToggleableItem.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005650 RID: 22096 RVA: 0x0002930B File Offset: 0x0002750B
		public ToggleableItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A08 RID: 6664
		// (get) Token: 0x06005651 RID: 22097 RVA: 0x00193B24 File Offset: 0x00191D24
		// (set) Token: 0x06005652 RID: 22098 RVA: 0x00029314 File Offset: 0x00027514
		public unsafe bool _IsOn_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableItem.NativeFieldInfoPtr__IsOn_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableItem.NativeFieldInfoPtr__IsOn_k__BackingField)) = value;
			}
		}

		// Token: 0x17001A09 RID: 6665
		// (get) Token: 0x06005653 RID: 22099 RVA: 0x00193B4C File Offset: 0x00191D4C
		// (set) Token: 0x06005654 RID: 22100 RVA: 0x0002932F File Offset: 0x0002752F
		public unsafe ToggleableItem.EStartupAction StartupAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableItem.NativeFieldInfoPtr_StartupAction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableItem.NativeFieldInfoPtr_StartupAction)) = value;
			}
		}

		// Token: 0x17001A0A RID: 6666
		// (get) Token: 0x06005655 RID: 22101 RVA: 0x00193B74 File Offset: 0x00191D74
		// (set) Token: 0x06005656 RID: 22102 RVA: 0x0002934A File Offset: 0x0002754A
		public unsafe UnityEvent onTurnedOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableItem.NativeFieldInfoPtr_onTurnedOn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableItem.NativeFieldInfoPtr_onTurnedOn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A0B RID: 6667
		// (get) Token: 0x06005657 RID: 22103 RVA: 0x00193BA4 File Offset: 0x00191DA4
		// (set) Token: 0x06005658 RID: 22104 RVA: 0x00029369 File Offset: 0x00027569
		public unsafe UnityEvent onTurnedOff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableItem.NativeFieldInfoPtr_onTurnedOff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableItem.NativeFieldInfoPtr_onTurnedOff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A0C RID: 6668
		// (get) Token: 0x06005659 RID: 22105 RVA: 0x00193BD4 File Offset: 0x00191DD4
		// (set) Token: 0x0600565A RID: 22106 RVA: 0x00029388 File Offset: 0x00027588
		public unsafe UnityEvent onTurnOnOrOff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableItem.NativeFieldInfoPtr_onTurnOnOrOff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableItem.NativeFieldInfoPtr_onTurnOnOrOff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A0D RID: 6669
		// (get) Token: 0x0600565B RID: 22107 RVA: 0x00193C04 File Offset: 0x00191E04
		// (set) Token: 0x0600565C RID: 22108 RVA: 0x000293A7 File Offset: 0x000275A7
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableItem.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableItem.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001A0E RID: 6670
		// (get) Token: 0x0600565D RID: 22109 RVA: 0x00193C2C File Offset: 0x00191E2C
		// (set) Token: 0x0600565E RID: 22110 RVA: 0x000293C2 File Offset: 0x000275C2
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableItem.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ToggleableItem.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04003A7E RID: 14974
		private static readonly IntPtr NativeFieldInfoPtr__IsOn_k__BackingField;

		// Token: 0x04003A7F RID: 14975
		private static readonly IntPtr NativeFieldInfoPtr_StartupAction;

		// Token: 0x04003A80 RID: 14976
		private static readonly IntPtr NativeFieldInfoPtr_onTurnedOn;

		// Token: 0x04003A81 RID: 14977
		private static readonly IntPtr NativeFieldInfoPtr_onTurnedOff;

		// Token: 0x04003A82 RID: 14978
		private static readonly IntPtr NativeFieldInfoPtr_onTurnOnOrOff;

		// Token: 0x04003A83 RID: 14979
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04003A84 RID: 14980
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04003A85 RID: 14981
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOn_Public_get_Boolean_0;

		// Token: 0x04003A86 RID: 14982
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOn_Private_set_Void_Boolean_0;

		// Token: 0x04003A87 RID: 14983
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04003A88 RID: 14984
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04003A89 RID: 14985
		private static readonly IntPtr NativeMethodInfoPtr_Toggle_Public_Void_0;

		// Token: 0x04003A8A RID: 14986
		private static readonly IntPtr NativeMethodInfoPtr_TurnOn_Public_Void_Boolean_0;

		// Token: 0x04003A8B RID: 14987
		private static readonly IntPtr NativeMethodInfoPtr_TurnOff_Public_Void_Boolean_0;

		// Token: 0x04003A8C RID: 14988
		private static readonly IntPtr NativeMethodInfoPtr_SendIsOn_Private_Void_Boolean_0;

		// Token: 0x04003A8D RID: 14989
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOn_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04003A8E RID: 14990
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04003A8F RID: 14991
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003A90 RID: 14992
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04003A91 RID: 14993
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04003A92 RID: 14994
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04003A93 RID: 14995
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendIsOn_1140765316_Private_Void_Boolean_0;

		// Token: 0x04003A94 RID: 14996
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendIsOn_1140765316_Private_Void_Boolean_0;

		// Token: 0x04003A95 RID: 14997
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendIsOn_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04003A96 RID: 14998
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04003A97 RID: 14999
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04003A98 RID: 15000
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetIsOn_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003A99 RID: 15001
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04003A9A RID: 15002
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetIsOn_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04003A9B RID: 15003
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x020009C6 RID: 2502
		[OriginalName("Assembly-CSharp.dll", "", "EStartupAction")]
		public enum EStartupAction
		{
			// Token: 0x04008A44 RID: 35396
			None,
			// Token: 0x04008A45 RID: 35397
			TurnOn,
			// Token: 0x04008A46 RID: 35398
			TurnOff,
			// Token: 0x04008A47 RID: 35399
			Toggle
		}
	}
}
