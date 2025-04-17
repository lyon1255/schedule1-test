using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Interaction;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000753 RID: 1875
	public class Sprinkler : GridItem
	{
		// Token: 0x0600B22B RID: 45611 RVA: 0x002C74E8 File Offset: 0x002C56E8
		// Note: this type is marked as 'beforefieldinit'.
		static Sprinkler()
		{
			Il2CppClassPointerStore<Sprinkler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Sprinkler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr);
			Sprinkler.NativeFieldInfoPtr__IsSprinkling_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "<IsSprinkling>k__BackingField");
			Sprinkler.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "IntObj");
			Sprinkler.NativeFieldInfoPtr_WaterParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "WaterParticles");
			Sprinkler.NativeFieldInfoPtr_ClickSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "ClickSound");
			Sprinkler.NativeFieldInfoPtr_WaterSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "WaterSound");
			Sprinkler.NativeFieldInfoPtr_ApplyWaterDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "ApplyWaterDelay");
			Sprinkler.NativeFieldInfoPtr_ParticleStopDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "ParticleStopDelay");
			Sprinkler.NativeFieldInfoPtr_onSprinklerStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "onSprinklerStart");
			Sprinkler.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.SprinklerAssembly-CSharp.dll_Excuted");
			Sprinkler.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.SprinklerAssembly-CSharp.dll_Excuted");
			Sprinkler.NativeMethodInfoPtr_get_IsSprinkling_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685253);
			Sprinkler.NativeMethodInfoPtr_set_IsSprinkling_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685254);
			Sprinkler.NativeMethodInfoPtr_Hovered_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685255);
			Sprinkler.NativeMethodInfoPtr_Interacted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685256);
			Sprinkler.NativeMethodInfoPtr_CanWater_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685257);
			Sprinkler.NativeMethodInfoPtr_SendWater_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685258);
			Sprinkler.NativeMethodInfoPtr_Water_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685259);
			Sprinkler.NativeMethodInfoPtr_ApplyWater_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685260);
			Sprinkler.NativeMethodInfoPtr_GetPots_Protected_Virtual_New_List_1_Pot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685261);
			Sprinkler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685262);
			Sprinkler.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685263);
			Sprinkler.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685264);
			Sprinkler.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685265);
			Sprinkler.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685266);
			Sprinkler.NativeMethodInfoPtr_RpcWriter___Server_SendWater_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685267);
			Sprinkler.NativeMethodInfoPtr_RpcLogic___SendWater_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685268);
			Sprinkler.NativeMethodInfoPtr_RpcReader___Server_SendWater_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685269);
			Sprinkler.NativeMethodInfoPtr_RpcWriter___Observers_Water_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685270);
			Sprinkler.NativeMethodInfoPtr_RpcLogic___Water_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685271);
			Sprinkler.NativeMethodInfoPtr_RpcReader___Observers_Water_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685272);
			Sprinkler.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, 100685273);
		}

		// Token: 0x17003753 RID: 14163
		// (get) Token: 0x0600B22C RID: 45612 RVA: 0x002C7784 File Offset: 0x002C5984
		// (set) Token: 0x0600B22D RID: 45613 RVA: 0x002C77C0 File Offset: 0x002C59C0
		public unsafe bool IsSprinkling
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_get_IsSprinkling_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_set_IsSprinkling_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B22E RID: 45614 RVA: 0x002C7800 File Offset: 0x002C5A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307038, XrefRangeEnd = 307039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_Hovered_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B22F RID: 45615 RVA: 0x002C7834 File Offset: 0x002C5A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307039, XrefRangeEnd = 307059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_Interacted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B230 RID: 45616 RVA: 0x002C7868 File Offset: 0x002C5A68
		[CallerCount(0)]
		public unsafe bool CanWater()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_CanWater_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B231 RID: 45617 RVA: 0x002C78A4 File Offset: 0x002C5AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307059, XrefRangeEnd = 307080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendWater()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_SendWater_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B232 RID: 45618 RVA: 0x002C78D8 File Offset: 0x002C5AD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 307101, RefRangeEnd = 307104, XrefRangeStart = 307080, XrefRangeEnd = 307101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Water()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_Water_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B233 RID: 45619 RVA: 0x002C790C File Offset: 0x002C5B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307104, XrefRangeEnd = 307113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyWater(float normalizedAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref normalizedAmount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_ApplyWater_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B234 RID: 45620 RVA: 0x002C794C File Offset: 0x002C5B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307113, XrefRangeEnd = 307172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual List<Pot> GetPots()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sprinkler.NativeMethodInfoPtr_GetPots_Protected_Virtual_New_List_1_Pot_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Pot>>(intPtr3) : null;
		}

		// Token: 0x0600B235 RID: 45621 RVA: 0x002C7998 File Offset: 0x002C5B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307172, XrefRangeEnd = 307173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sprinkler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B236 RID: 45622 RVA: 0x002C79D4 File Offset: 0x002C5BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307173, XrefRangeEnd = 307178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600B237 RID: 45623 RVA: 0x002C7A14 File Offset: 0x002C5C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307178, XrefRangeEnd = 307193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sprinkler.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B238 RID: 45624 RVA: 0x002C7A50 File Offset: 0x002C5C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307193, XrefRangeEnd = 307194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sprinkler.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B239 RID: 45625 RVA: 0x002C7A8C File Offset: 0x002C5C8C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sprinkler.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B23A RID: 45626 RVA: 0x002C7AC8 File Offset: 0x002C5CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307194, XrefRangeEnd = 307212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendWater_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_RpcWriter___Server_SendWater_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B23B RID: 45627 RVA: 0x002C7AFC File Offset: 0x002C5CFC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 307101, RefRangeEnd = 307104, XrefRangeStart = 307101, XrefRangeEnd = 307104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendWater_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_RpcLogic___SendWater_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B23C RID: 45628 RVA: 0x002C7B30 File Offset: 0x002C5D30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307212, XrefRangeEnd = 307215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendWater_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_RpcReader___Server_SendWater_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B23D RID: 45629 RVA: 0x002C7B94 File Offset: 0x002C5D94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307215, XrefRangeEnd = 307233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_Water_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_RpcWriter___Observers_Water_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B23E RID: 45630 RVA: 0x002C7BC8 File Offset: 0x002C5DC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 307239, RefRangeEnd = 307242, XrefRangeStart = 307233, XrefRangeEnd = 307239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___Water_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_RpcLogic___Water_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B23F RID: 45631 RVA: 0x002C7BFC File Offset: 0x002C5DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307242, XrefRangeEnd = 307245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_Water_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.NativeMethodInfoPtr_RpcReader___Observers_Water_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B240 RID: 45632 RVA: 0x002C7C4C File Offset: 0x002C5E4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 290619, RefRangeEnd = 290620, XrefRangeStart = 290619, XrefRangeEnd = 290620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Sprinkler.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B241 RID: 45633 RVA: 0x00057647 File Offset: 0x00055847
		public Sprinkler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003749 RID: 14153
		// (get) Token: 0x0600B242 RID: 45634 RVA: 0x002C7C88 File Offset: 0x002C5E88
		// (set) Token: 0x0600B243 RID: 45635 RVA: 0x00057650 File Offset: 0x00055850
		public unsafe bool _IsSprinkling_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr__IsSprinkling_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr__IsSprinkling_k__BackingField)) = value;
			}
		}

		// Token: 0x1700374A RID: 14154
		// (get) Token: 0x0600B244 RID: 45636 RVA: 0x002C7CB0 File Offset: 0x002C5EB0
		// (set) Token: 0x0600B245 RID: 45637 RVA: 0x0005766B File Offset: 0x0005586B
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700374B RID: 14155
		// (get) Token: 0x0600B246 RID: 45638 RVA: 0x002C7CE0 File Offset: 0x002C5EE0
		// (set) Token: 0x0600B247 RID: 45639 RVA: 0x0005768A File Offset: 0x0005588A
		public unsafe Il2CppReferenceArray<ParticleSystem> WaterParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_WaterParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_WaterParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700374C RID: 14156
		// (get) Token: 0x0600B248 RID: 45640 RVA: 0x002C7D10 File Offset: 0x002C5F10
		// (set) Token: 0x0600B249 RID: 45641 RVA: 0x000576A9 File Offset: 0x000558A9
		public unsafe AudioSourceController ClickSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_ClickSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_ClickSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700374D RID: 14157
		// (get) Token: 0x0600B24A RID: 45642 RVA: 0x002C7D40 File Offset: 0x002C5F40
		// (set) Token: 0x0600B24B RID: 45643 RVA: 0x000576C8 File Offset: 0x000558C8
		public unsafe AudioSourceController WaterSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_WaterSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_WaterSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700374E RID: 14158
		// (get) Token: 0x0600B24C RID: 45644 RVA: 0x002C7D70 File Offset: 0x002C5F70
		// (set) Token: 0x0600B24D RID: 45645 RVA: 0x000576E7 File Offset: 0x000558E7
		public unsafe float ApplyWaterDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_ApplyWaterDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_ApplyWaterDelay)) = value;
			}
		}

		// Token: 0x1700374F RID: 14159
		// (get) Token: 0x0600B24E RID: 45646 RVA: 0x002C7D98 File Offset: 0x002C5F98
		// (set) Token: 0x0600B24F RID: 45647 RVA: 0x00057702 File Offset: 0x00055902
		public unsafe float ParticleStopDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_ParticleStopDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_ParticleStopDelay)) = value;
			}
		}

		// Token: 0x17003750 RID: 14160
		// (get) Token: 0x0600B250 RID: 45648 RVA: 0x002C7DC0 File Offset: 0x002C5FC0
		// (set) Token: 0x0600B251 RID: 45649 RVA: 0x0005771D File Offset: 0x0005591D
		public unsafe UnityEvent onSprinklerStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_onSprinklerStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_onSprinklerStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003751 RID: 14161
		// (get) Token: 0x0600B252 RID: 45650 RVA: 0x002C7DF0 File Offset: 0x002C5FF0
		// (set) Token: 0x0600B253 RID: 45651 RVA: 0x0005773C File Offset: 0x0005593C
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003752 RID: 14162
		// (get) Token: 0x0600B254 RID: 45652 RVA: 0x002C7E18 File Offset: 0x002C6018
		// (set) Token: 0x0600B255 RID: 45653 RVA: 0x00057757 File Offset: 0x00055957
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04007828 RID: 30760
		private static readonly IntPtr NativeFieldInfoPtr__IsSprinkling_k__BackingField;

		// Token: 0x04007829 RID: 30761
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x0400782A RID: 30762
		private static readonly IntPtr NativeFieldInfoPtr_WaterParticles;

		// Token: 0x0400782B RID: 30763
		private static readonly IntPtr NativeFieldInfoPtr_ClickSound;

		// Token: 0x0400782C RID: 30764
		private static readonly IntPtr NativeFieldInfoPtr_WaterSound;

		// Token: 0x0400782D RID: 30765
		private static readonly IntPtr NativeFieldInfoPtr_ApplyWaterDelay;

		// Token: 0x0400782E RID: 30766
		private static readonly IntPtr NativeFieldInfoPtr_ParticleStopDelay;

		// Token: 0x0400782F RID: 30767
		private static readonly IntPtr NativeFieldInfoPtr_onSprinklerStart;

		// Token: 0x04007830 RID: 30768
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04007831 RID: 30769
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04007832 RID: 30770
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSprinkling_Public_get_Boolean_0;

		// Token: 0x04007833 RID: 30771
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSprinkling_Private_set_Void_Boolean_0;

		// Token: 0x04007834 RID: 30772
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Void_0;

		// Token: 0x04007835 RID: 30773
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Void_0;

		// Token: 0x04007836 RID: 30774
		private static readonly IntPtr NativeMethodInfoPtr_CanWater_Private_Boolean_0;

		// Token: 0x04007837 RID: 30775
		private static readonly IntPtr NativeMethodInfoPtr_SendWater_Private_Void_0;

		// Token: 0x04007838 RID: 30776
		private static readonly IntPtr NativeMethodInfoPtr_Water_Private_Void_0;

		// Token: 0x04007839 RID: 30777
		private static readonly IntPtr NativeMethodInfoPtr_ApplyWater_Public_Void_Single_0;

		// Token: 0x0400783A RID: 30778
		private static readonly IntPtr NativeMethodInfoPtr_GetPots_Protected_Virtual_New_List_1_Pot_0;

		// Token: 0x0400783B RID: 30779
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400783C RID: 30780
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x0400783D RID: 30781
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400783E RID: 30782
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400783F RID: 30783
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04007840 RID: 30784
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendWater_2166136261_Private_Void_0;

		// Token: 0x04007841 RID: 30785
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SendWater_2166136261_Private_Void_0;

		// Token: 0x04007842 RID: 30786
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Server_SendWater_2166136261_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007843 RID: 30787
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_Water_2166136261_Private_Void_0;

		// Token: 0x04007844 RID: 30788
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___Water_2166136261_Private_Void_0;

		// Token: 0x04007845 RID: 30789
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_Water_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007846 RID: 30790
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x02000BF4 RID: 3060
		[ObfuscatedName("ScheduleOne.ObjectScripts.Sprinkler+<<Water>g__Routine|15_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DF70 RID: 57200 RVA: 0x0034A678 File Offset: 0x00348878
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique()
			{
				Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Sprinkler>.NativeClassPtr, "<<Water>g__Routine|15_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr);
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, "<>1__state");
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, "<>2__current");
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, "<>4__this");
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr__segments_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, "<segments>5__2");
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, "<i>5__3");
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, 100685274);
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, 100685275);
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, 100685276);
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, 100685277);
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, 100685278);
				Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr, 100685279);
			}

			// Token: 0x0600DF71 RID: 57201 RVA: 0x0034A780 File Offset: 0x00348980
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF72 RID: 57202 RVA: 0x0034A7C8 File Offset: 0x003489C8
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF73 RID: 57203 RVA: 0x0034A7FC File Offset: 0x003489FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307010, XrefRangeEnd = 307033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004542 RID: 17730
			// (get) Token: 0x0600DF74 RID: 57204 RVA: 0x0034A838 File Offset: 0x00348A38
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DF75 RID: 57205 RVA: 0x0034A878 File Offset: 0x00348A78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307033, XrefRangeEnd = 307038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004543 RID: 17731
			// (get) Token: 0x0600DF76 RID: 57206 RVA: 0x0034A8AC File Offset: 0x00348AAC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DF77 RID: 57207 RVA: 0x0006CF23 File Offset: 0x0006B123
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700453D RID: 17725
			// (get) Token: 0x0600DF78 RID: 57208 RVA: 0x0034A8EC File Offset: 0x00348AEC
			// (set) Token: 0x0600DF79 RID: 57209 RVA: 0x0006CF2C File Offset: 0x0006B12C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700453E RID: 17726
			// (get) Token: 0x0600DF7A RID: 57210 RVA: 0x0034A914 File Offset: 0x00348B14
			// (set) Token: 0x0600DF7B RID: 57211 RVA: 0x0006CF47 File Offset: 0x0006B147
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700453F RID: 17727
			// (get) Token: 0x0600DF7C RID: 57212 RVA: 0x0034A944 File Offset: 0x00348B44
			// (set) Token: 0x0600DF7D RID: 57213 RVA: 0x0006CF66 File Offset: 0x0006B166
			public unsafe Sprinkler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprinkler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004540 RID: 17728
			// (get) Token: 0x0600DF7E RID: 57214 RVA: 0x0034A974 File Offset: 0x00348B74
			// (set) Token: 0x0600DF7F RID: 57215 RVA: 0x0006CF85 File Offset: 0x0006B185
			public unsafe int _segments_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr__segments_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr__segments_5__2)) = value;
				}
			}

			// Token: 0x17004541 RID: 17729
			// (get) Token: 0x0600DF80 RID: 57216 RVA: 0x0034A99C File Offset: 0x00348B9C
			// (set) Token: 0x0600DF81 RID: 57217 RVA: 0x0006CFA0 File Offset: 0x0006B1A0
			public unsafe int _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Sprinkler.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpInObInObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x040095AE RID: 38318
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040095AF RID: 38319
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040095B0 RID: 38320
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040095B1 RID: 38321
			private static readonly IntPtr NativeFieldInfoPtr__segments_5__2;

			// Token: 0x040095B2 RID: 38322
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x040095B3 RID: 38323
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040095B4 RID: 38324
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040095B5 RID: 38325
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040095B6 RID: 38326
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040095B7 RID: 38327
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040095B8 RID: 38328
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
