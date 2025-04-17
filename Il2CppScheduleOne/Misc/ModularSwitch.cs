using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Interaction;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Misc
{
	// Token: 0x0200076A RID: 1898
	public class ModularSwitch : NetworkBehaviour
	{
		// Token: 0x0600B417 RID: 46103 RVA: 0x002CDC40 File Offset: 0x002CBE40
		// Note: this type is marked as 'beforefieldinit'.
		static ModularSwitch()
		{
			Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Misc", "ModularSwitch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr);
			ModularSwitch.NativeFieldInfoPtr_isOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, "isOn");
			ModularSwitch.NativeFieldInfoPtr_intObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, "intObj");
			ModularSwitch.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, "button");
			ModularSwitch.NativeFieldInfoPtr_OnAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, "OnAudio");
			ModularSwitch.NativeFieldInfoPtr_OffAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, "OffAudio");
			ModularSwitch.NativeFieldInfoPtr_SwitchesToSyncWith = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, "SwitchesToSyncWith");
			ModularSwitch.NativeFieldInfoPtr_onToggled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, "onToggled");
			ModularSwitch.NativeFieldInfoPtr_switchedOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, "switchedOn");
			ModularSwitch.NativeFieldInfoPtr_switchedOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, "switchedOff");
			ModularSwitch.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Misc.ModularSwitchAssembly-CSharp.dll_Excuted");
			ModularSwitch.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Misc.ModularSwitchAssembly-CSharp.dll_Excuted");
			ModularSwitch.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100685475);
			ModularSwitch.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100685476);
			ModularSwitch.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100685477);
			ModularSwitch.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100685478);
			ModularSwitch.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100685479);
			ModularSwitch.NativeMethodInfoPtr_SendIsOn_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100685480);
			ModularSwitch.NativeMethodInfoPtr_SetIsOn_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100685481);
			ModularSwitch.NativeMethodInfoPtr_SwitchOn_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100685482);
			ModularSwitch.NativeMethodInfoPtr_SwitchOff_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100685483);
			ModularSwitch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100685484);
			ModularSwitch.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100685485);
			ModularSwitch.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100685486);
			ModularSwitch.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100685487);
			ModularSwitch.NativeMethodInfoPtr_RpcWriter___Server_SendIsOn_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100685488);
			ModularSwitch.NativeMethodInfoPtr_RpcLogic___SendIsOn_1140765316_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100685489);
			ModularSwitch.NativeMethodInfoPtr_RpcReader___Server_SendIsOn_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100685490);
			ModularSwitch.NativeMethodInfoPtr_RpcWriter___Observers_SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100685491);
			ModularSwitch.NativeMethodInfoPtr_RpcLogic___SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100685492);
			ModularSwitch.NativeMethodInfoPtr_RpcReader___Observers_SetIsOn_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100685493);
			ModularSwitch.NativeMethodInfoPtr_RpcWriter___Target_SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100685494);
			ModularSwitch.NativeMethodInfoPtr_RpcReader___Target_SetIsOn_214505783_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100685495);
			ModularSwitch.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, 100685496);
		}

		// Token: 0x0600B418 RID: 46104 RVA: 0x002CDF04 File Offset: 0x002CC104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308808, XrefRangeEnd = 308822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ModularSwitch.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B419 RID: 46105 RVA: 0x002CDF40 File Offset: 0x002CC140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308822, XrefRangeEnd = 308824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ModularSwitch.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B41A RID: 46106 RVA: 0x002CDF90 File Offset: 0x002CC190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308824, XrefRangeEnd = 308826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ModularSwitch.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B41B RID: 46107 RVA: 0x002CDFCC File Offset: 0x002CC1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308826, XrefRangeEnd = 308833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B41C RID: 46108 RVA: 0x002CE000 File Offset: 0x002CC200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308833, XrefRangeEnd = 308834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B41D RID: 46109 RVA: 0x002CE034 File Offset: 0x002CC234
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308856, RefRangeEnd = 308857, XrefRangeStart = 308834, XrefRangeEnd = 308856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendIsOn(bool isOn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.NativeMethodInfoPtr_SendIsOn_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B41E RID: 46110 RVA: 0x002CE074 File Offset: 0x002CC274
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 308901, RefRangeEnd = 308905, XrefRangeStart = 308857, XrefRangeEnd = 308901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOn(NetworkConnection conn, bool isOn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.NativeMethodInfoPtr_SetIsOn_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B41F RID: 46111 RVA: 0x002CE0C4 File Offset: 0x002CC2C4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 308912, RefRangeEnd = 308919, XrefRangeStart = 308905, XrefRangeEnd = 308912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchOn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.NativeMethodInfoPtr_SwitchOn_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B420 RID: 46112 RVA: 0x002CE0F8 File Offset: 0x002CC2F8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 308926, RefRangeEnd = 308930, XrefRangeStart = 308919, XrefRangeEnd = 308926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchOff()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.NativeMethodInfoPtr_SwitchOff_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B421 RID: 46113 RVA: 0x002CE12C File Offset: 0x002CC32C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308930, XrefRangeEnd = 308938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ModularSwitch() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B422 RID: 46114 RVA: 0x002CE168 File Offset: 0x002CC368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308938, XrefRangeEnd = 308958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ModularSwitch.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B423 RID: 46115 RVA: 0x002CE1A4 File Offset: 0x002CC3A4
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ModularSwitch.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B424 RID: 46116 RVA: 0x002CE1E0 File Offset: 0x002CC3E0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ModularSwitch.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B425 RID: 46117 RVA: 0x002CE21C File Offset: 0x002CC41C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308958, XrefRangeEnd = 308977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendIsOn_1140765316(bool isOn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.NativeMethodInfoPtr_RpcWriter___Server_SendIsOn_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B426 RID: 46118 RVA: 0x002CE25C File Offset: 0x002CC45C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308977, XrefRangeEnd = 308978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendIsOn_1140765316(bool isOn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.NativeMethodInfoPtr_RpcLogic___SendIsOn_1140765316_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B427 RID: 46119 RVA: 0x002CE29C File Offset: 0x002CC49C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308978, XrefRangeEnd = 308981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendIsOn_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.NativeMethodInfoPtr_RpcReader___Server_SendIsOn_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B428 RID: 46120 RVA: 0x002CE300 File Offset: 0x002CC500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308981, XrefRangeEnd = 309000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetIsOn_214505783(NetworkConnection conn, bool isOn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.NativeMethodInfoPtr_RpcWriter___Observers_SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B429 RID: 46121 RVA: 0x002CE350 File Offset: 0x002CC550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309000, XrefRangeEnd = 309001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetIsOn_214505783(NetworkConnection conn, bool isOn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.NativeMethodInfoPtr_RpcLogic___SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B42A RID: 46122 RVA: 0x002CE3A0 File Offset: 0x002CC5A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309001, XrefRangeEnd = 309004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.NativeMethodInfoPtr_RpcReader___Observers_SetIsOn_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B42B RID: 46123 RVA: 0x002CE3F0 File Offset: 0x002CC5F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309004, XrefRangeEnd = 309023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetIsOn_214505783(NetworkConnection conn, bool isOn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.NativeMethodInfoPtr_RpcWriter___Target_SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B42C RID: 46124 RVA: 0x002CE440 File Offset: 0x002CC640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309023, XrefRangeEnd = 309026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetIsOn_214505783(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.NativeMethodInfoPtr_RpcReader___Target_SetIsOn_214505783_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B42D RID: 46125 RVA: 0x002CE490 File Offset: 0x002CC690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 309026, XrefRangeEnd = 309039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ModularSwitch.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B42E RID: 46126 RVA: 0x000584C2 File Offset: 0x000566C2
		public ModularSwitch(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037D4 RID: 14292
		// (get) Token: 0x0600B42F RID: 46127 RVA: 0x002CE4CC File Offset: 0x002CC6CC
		// (set) Token: 0x0600B430 RID: 46128 RVA: 0x000584CB File Offset: 0x000566CB
		public unsafe bool isOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_isOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_isOn)) = value;
			}
		}

		// Token: 0x170037D5 RID: 14293
		// (get) Token: 0x0600B431 RID: 46129 RVA: 0x002CE4F4 File Offset: 0x002CC6F4
		// (set) Token: 0x0600B432 RID: 46130 RVA: 0x000584E6 File Offset: 0x000566E6
		public unsafe InteractableObject intObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_intObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_intObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037D6 RID: 14294
		// (get) Token: 0x0600B433 RID: 46131 RVA: 0x002CE524 File Offset: 0x002CC724
		// (set) Token: 0x0600B434 RID: 46132 RVA: 0x00058505 File Offset: 0x00056705
		public unsafe Transform button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037D7 RID: 14295
		// (get) Token: 0x0600B435 RID: 46133 RVA: 0x002CE554 File Offset: 0x002CC754
		// (set) Token: 0x0600B436 RID: 46134 RVA: 0x00058524 File Offset: 0x00056724
		public unsafe AudioSourceController OnAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_OnAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_OnAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037D8 RID: 14296
		// (get) Token: 0x0600B437 RID: 46135 RVA: 0x002CE584 File Offset: 0x002CC784
		// (set) Token: 0x0600B438 RID: 46136 RVA: 0x00058543 File Offset: 0x00056743
		public unsafe AudioSourceController OffAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_OffAudio);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_OffAudio), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037D9 RID: 14297
		// (get) Token: 0x0600B439 RID: 46137 RVA: 0x002CE5B4 File Offset: 0x002CC7B4
		// (set) Token: 0x0600B43A RID: 46138 RVA: 0x00058562 File Offset: 0x00056762
		public unsafe List<ModularSwitch> SwitchesToSyncWith
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_SwitchesToSyncWith);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ModularSwitch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_SwitchesToSyncWith), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037DA RID: 14298
		// (get) Token: 0x0600B43B RID: 46139 RVA: 0x002CE5E4 File Offset: 0x002CC7E4
		// (set) Token: 0x0600B43C RID: 46140 RVA: 0x00058581 File Offset: 0x00056781
		public unsafe ModularSwitch.ButtonChange onToggled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_onToggled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModularSwitch.ButtonChange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_onToggled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037DB RID: 14299
		// (get) Token: 0x0600B43D RID: 46141 RVA: 0x002CE614 File Offset: 0x002CC814
		// (set) Token: 0x0600B43E RID: 46142 RVA: 0x000585A0 File Offset: 0x000567A0
		public unsafe UnityEvent switchedOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_switchedOn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_switchedOn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037DC RID: 14300
		// (get) Token: 0x0600B43F RID: 46143 RVA: 0x002CE644 File Offset: 0x002CC844
		// (set) Token: 0x0600B440 RID: 46144 RVA: 0x000585BF File Offset: 0x000567BF
		public unsafe UnityEvent switchedOff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_switchedOff);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_switchedOff), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037DD RID: 14301
		// (get) Token: 0x0600B441 RID: 46145 RVA: 0x002CE674 File Offset: 0x002CC874
		// (set) Token: 0x0600B442 RID: 46146 RVA: 0x000585DE File Offset: 0x000567DE
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170037DE RID: 14302
		// (get) Token: 0x0600B443 RID: 46147 RVA: 0x002CE69C File Offset: 0x002CC89C
		// (set) Token: 0x0600B444 RID: 46148 RVA: 0x000585F9 File Offset: 0x000567F9
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ModularSwitch.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x0400796B RID: 31083
		private static readonly IntPtr NativeFieldInfoPtr_isOn;

		// Token: 0x0400796C RID: 31084
		private static readonly IntPtr NativeFieldInfoPtr_intObj;

		// Token: 0x0400796D RID: 31085
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x0400796E RID: 31086
		private static readonly IntPtr NativeFieldInfoPtr_OnAudio;

		// Token: 0x0400796F RID: 31087
		private static readonly IntPtr NativeFieldInfoPtr_OffAudio;

		// Token: 0x04007970 RID: 31088
		private static readonly IntPtr NativeFieldInfoPtr_SwitchesToSyncWith;

		// Token: 0x04007971 RID: 31089
		private static readonly IntPtr NativeFieldInfoPtr_onToggled;

		// Token: 0x04007972 RID: 31090
		private static readonly IntPtr NativeFieldInfoPtr_switchedOn;

		// Token: 0x04007973 RID: 31091
		private static readonly IntPtr NativeFieldInfoPtr_switchedOff;

		// Token: 0x04007974 RID: 31092
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04007975 RID: 31093
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04007976 RID: 31094
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04007977 RID: 31095
		private static readonly IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04007978 RID: 31096
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_1;

		// Token: 0x04007979 RID: 31097
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x0400797A RID: 31098
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x0400797B RID: 31099
		private static readonly IntPtr NativeMethodInfoPtr_SendIsOn_Private_Void_Boolean_0;

		// Token: 0x0400797C RID: 31100
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOn_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x0400797D RID: 31101
		private static readonly IntPtr NativeMethodInfoPtr_SwitchOn_Public_Void_0;

		// Token: 0x0400797E RID: 31102
		private static readonly IntPtr NativeMethodInfoPtr_SwitchOff_Public_Void_0;

		// Token: 0x0400797F RID: 31103
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007980 RID: 31104
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04007981 RID: 31105
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04007982 RID: 31106
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04007983 RID: 31107
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendIsOn_1140765316_Private_Void_Boolean_0;

		// Token: 0x04007984 RID: 31108
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendIsOn_1140765316_Private_Void_Boolean_0;

		// Token: 0x04007985 RID: 31109
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendIsOn_1140765316_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007986 RID: 31110
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04007987 RID: 31111
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x04007988 RID: 31112
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetIsOn_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007989 RID: 31113
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetIsOn_214505783_Private_Void_NetworkConnection_Boolean_0;

		// Token: 0x0400798A RID: 31114
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Target_SetIsOn_214505783_Private_Void_PooledReader_Channel_0;

		// Token: 0x0400798B RID: 31115
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;

		// Token: 0x02000BF7 RID: 3063
		public sealed class ButtonChange : MulticastDelegate
		{
			// Token: 0x0600DF9E RID: 57246 RVA: 0x0034AEA4 File Offset: 0x003490A4
			// Note: this type is marked as 'beforefieldinit'.
			static ButtonChange()
			{
				Il2CppClassPointerStore<ModularSwitch.ButtonChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ModularSwitch>.NativeClassPtr, "ButtonChange");
				ModularSwitch.ButtonChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch.ButtonChange>.NativeClassPtr, 100685497);
				ModularSwitch.ButtonChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch.ButtonChange>.NativeClassPtr, 100685498);
				ModularSwitch.ButtonChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch.ButtonChange>.NativeClassPtr, 100685499);
				ModularSwitch.ButtonChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModularSwitch.ButtonChange>.NativeClassPtr, 100685500);
			}

			// Token: 0x0600DF9F RID: 57247 RVA: 0x0034AF18 File Offset: 0x00349118
			[CallerCount(43)]
			[CachedScanResults(RefRangeStart = 165720, RefRangeEnd = 165763, XrefRangeStart = 165720, XrefRangeEnd = 165763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ButtonChange(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModularSwitch.ButtonChange>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.ButtonChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFA0 RID: 57248 RVA: 0x0034AF74 File Offset: 0x00349174
			[CallerCount(0)]
			public unsafe void Invoke(bool isOn)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref isOn;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.ButtonChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFA1 RID: 57249 RVA: 0x0034AFB4 File Offset: 0x003491B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308804, XrefRangeEnd = 308808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(bool isOn, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref isOn;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.ButtonChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600DFA2 RID: 57250 RVA: 0x0034B024 File Offset: 0x00349224
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22498, RefRangeEnd = 22499, XrefRangeStart = 22498, XrefRangeEnd = 22499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ModularSwitch.ButtonChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DFA3 RID: 57251 RVA: 0x0006D0B5 File Offset: 0x0006B2B5
			public ButtonChange(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600DFA4 RID: 57252 RVA: 0x0006D0BE File Offset: 0x0006B2BE
			public static implicit operator ModularSwitch.ButtonChange(Action<bool> A_0)
			{
				return DelegateSupport.ConvertDelegate<ModularSwitch.ButtonChange>(A_0);
			}

			// Token: 0x0600DFA5 RID: 57253 RVA: 0x0006D0C6 File Offset: 0x0006B2C6
			public static ModularSwitch.ButtonChange operator +(ModularSwitch.ButtonChange A_0, ModularSwitch.ButtonChange A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<ModularSwitch.ButtonChange>();
			}

			// Token: 0x0600DFA6 RID: 57254 RVA: 0x0006D0D4 File Offset: 0x0006B2D4
			public static ModularSwitch.ButtonChange operator -(ModularSwitch.ButtonChange A_0, ModularSwitch.ButtonChange A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<ModularSwitch.ButtonChange>();
				}
				return result;
			}

			// Token: 0x040095C9 RID: 38345
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040095CA RID: 38346
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Boolean_0;

			// Token: 0x040095CB RID: 38347
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0;

			// Token: 0x040095CC RID: 38348
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
