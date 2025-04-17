using System;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x0200034B RID: 843
	public class FinishLabOvenBehaviour : Behaviour
	{
		// Token: 0x06003F6A RID: 16234 RVA: 0x001401E4 File Offset: 0x0013E3E4
		// Note: this type is marked as 'beforefieldinit'.
		static FinishLabOvenBehaviour()
		{
			Il2CppClassPointerStore<FinishLabOvenBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "FinishLabOvenBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinishLabOvenBehaviour>.NativeClassPtr);
			FinishLabOvenBehaviour.NativeFieldInfoPtr_HARVEST_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinishLabOvenBehaviour>.NativeClassPtr, "HARVEST_TIME");
			FinishLabOvenBehaviour.NativeFieldInfoPtr__targetOven_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinishLabOvenBehaviour>.NativeClassPtr, "<targetOven>k__BackingField");
			FinishLabOvenBehaviour.NativeFieldInfoPtr_chemist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinishLabOvenBehaviour>.NativeClassPtr, "chemist");
			FinishLabOvenBehaviour.NativeFieldInfoPtr_actionRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinishLabOvenBehaviour>.NativeClassPtr, "actionRoutine");
			FinishLabOvenBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinishLabOvenBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.FinishLabOvenBehaviourAssembly-CSharp.dll_Excuted");
			FinishLabOvenBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinishLabOvenBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.FinishLabOvenBehaviourAssembly-CSharp.dll_Excuted");
			FinishLabOvenBehaviour.NativeMethodInfoPtr_get_targetOven_Public_get_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishLabOvenBehaviour>.NativeClassPtr, 100670831);
			FinishLabOvenBehaviour.NativeMethodInfoPtr_set_targetOven_Private_set_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishLabOvenBehaviour>.NativeClassPtr, 100670832);
			FinishLabOvenBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishLabOvenBehaviour>.NativeClassPtr, 100670833);
			FinishLabOvenBehaviour.NativeMethodInfoPtr_SetTargetOven_Public_Void_LabOven_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishLabOvenBehaviour>.NativeClassPtr, 100670834);
			FinishLabOvenBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishLabOvenBehaviour>.NativeClassPtr, 100670835);
			FinishLabOvenBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishLabOvenBehaviour>.NativeClassPtr, 100670836);
			FinishLabOvenBehaviour.NativeMethodInfoPtr_StartAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishLabOvenBehaviour>.NativeClassPtr, 100670837);
			FinishLabOvenBehaviour.NativeMethodInfoPtr_CanActionStart_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishLabOvenBehaviour>.NativeClassPtr, 100670838);
			FinishLabOvenBehaviour.NativeMethodInfoPtr_StopAction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishLabOvenBehaviour>.NativeClassPtr, 100670839);
			FinishLabOvenBehaviour.NativeMethodInfoPtr_GetStationAccessPoint_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishLabOvenBehaviour>.NativeClassPtr, 100670840);
			FinishLabOvenBehaviour.NativeMethodInfoPtr_IsAtStation_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishLabOvenBehaviour>.NativeClassPtr, 100670841);
			FinishLabOvenBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishLabOvenBehaviour>.NativeClassPtr, 100670842);
			FinishLabOvenBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishLabOvenBehaviour>.NativeClassPtr, 100670843);
			FinishLabOvenBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishLabOvenBehaviour>.NativeClassPtr, 100670844);
			FinishLabOvenBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishLabOvenBehaviour>.NativeClassPtr, 100670845);
			FinishLabOvenBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishLabOvenBehaviour>.NativeClassPtr, 100670846);
			FinishLabOvenBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_StartAction_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishLabOvenBehaviour>.NativeClassPtr, 100670847);
			FinishLabOvenBehaviour.NativeMethodInfoPtr_RpcLogic___StartAction_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishLabOvenBehaviour>.NativeClassPtr, 100670848);
			FinishLabOvenBehaviour.NativeMethodInfoPtr_RpcReader___Observers_StartAction_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishLabOvenBehaviour>.NativeClassPtr, 100670849);
			FinishLabOvenBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishLabOvenBehaviour>.NativeClassPtr, 100670850);
		}

		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x06003F6B RID: 16235 RVA: 0x0014041C File Offset: 0x0013E61C
		// (set) Token: 0x06003F6C RID: 16236 RVA: 0x0014045C File Offset: 0x0013E65C
		public unsafe LabOven targetOven
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinishLabOvenBehaviour.NativeMethodInfoPtr_get_targetOven_Public_get_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr3) : null;
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 115138, RefRangeEnd = 115149, XrefRangeStart = 115138, XrefRangeEnd = 115149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinishLabOvenBehaviour.NativeMethodInfoPtr_set_targetOven_Private_set_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003F6D RID: 16237 RVA: 0x001404A0 File Offset: 0x0013E6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147921, XrefRangeEnd = 147930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FinishLabOvenBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F6E RID: 16238 RVA: 0x001404DC File Offset: 0x0013E6DC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 115138, RefRangeEnd = 115149, XrefRangeStart = 115138, XrefRangeEnd = 115149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTargetOven(LabOven oven)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(oven);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinishLabOvenBehaviour.NativeMethodInfoPtr_SetTargetOven_Public_Void_LabOven_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F6F RID: 16239 RVA: 0x00140520 File Offset: 0x0013E720
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147930, XrefRangeEnd = 147940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FinishLabOvenBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F70 RID: 16240 RVA: 0x0014055C File Offset: 0x0013E75C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147940, XrefRangeEnd = 147977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FinishLabOvenBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F71 RID: 16241 RVA: 0x00140598 File Offset: 0x0013E798
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147977, XrefRangeEnd = 147998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinishLabOvenBehaviour.NativeMethodInfoPtr_StartAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F72 RID: 16242 RVA: 0x001405CC File Offset: 0x0013E7CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 148013, RefRangeEnd = 148014, XrefRangeStart = 147998, XrefRangeEnd = 148013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanActionStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinishLabOvenBehaviour.NativeMethodInfoPtr_CanActionStart_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003F73 RID: 16243 RVA: 0x00140608 File Offset: 0x0013E808
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 148025, RefRangeEnd = 148026, XrefRangeStart = 148014, XrefRangeEnd = 148025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinishLabOvenBehaviour.NativeMethodInfoPtr_StopAction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F74 RID: 16244 RVA: 0x0014063C File Offset: 0x0013E83C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 148034, RefRangeEnd = 148036, XrefRangeStart = 148026, XrefRangeEnd = 148034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetStationAccessPoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinishLabOvenBehaviour.NativeMethodInfoPtr_GetStationAccessPoint_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003F75 RID: 16245 RVA: 0x00140678 File Offset: 0x0013E878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148036, XrefRangeEnd = 148049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtStation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinishLabOvenBehaviour.NativeMethodInfoPtr_IsAtStation_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003F76 RID: 16246 RVA: 0x001406B4 File Offset: 0x0013E8B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FinishLabOvenBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinishLabOvenBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinishLabOvenBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F77 RID: 16247 RVA: 0x001406F0 File Offset: 0x0013E8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148049, XrefRangeEnd = 148054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinishLabOvenBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003F78 RID: 16248 RVA: 0x00140730 File Offset: 0x0013E930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148054, XrefRangeEnd = 148062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FinishLabOvenBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F79 RID: 16249 RVA: 0x0014076C File Offset: 0x0013E96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FinishLabOvenBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F7A RID: 16250 RVA: 0x001407A8 File Offset: 0x0013E9A8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FinishLabOvenBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F7B RID: 16251 RVA: 0x001407E4 File Offset: 0x0013E9E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148062, XrefRangeEnd = 148080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartAction_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinishLabOvenBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_StartAction_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F7C RID: 16252 RVA: 0x00140818 File Offset: 0x0013EA18
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 148091, RefRangeEnd = 148094, XrefRangeStart = 148080, XrefRangeEnd = 148091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartAction_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinishLabOvenBehaviour.NativeMethodInfoPtr_RpcLogic___StartAction_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F7D RID: 16253 RVA: 0x0014084C File Offset: 0x0013EA4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148094, XrefRangeEnd = 148097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartAction_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinishLabOvenBehaviour.NativeMethodInfoPtr_RpcReader___Observers_StartAction_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F7E RID: 16254 RVA: 0x0014089C File Offset: 0x0013EA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148097, XrefRangeEnd = 148106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FinishLabOvenBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003F7F RID: 16255 RVA: 0x0001F9CD File Offset: 0x0001DBCD
		public FinishLabOvenBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001377 RID: 4983
		// (get) Token: 0x06003F80 RID: 16256 RVA: 0x001408D8 File Offset: 0x0013EAD8
		// (set) Token: 0x06003F81 RID: 16257 RVA: 0x0001F9D6 File Offset: 0x0001DBD6
		public unsafe static float HARVEST_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FinishLabOvenBehaviour.NativeFieldInfoPtr_HARVEST_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FinishLabOvenBehaviour.NativeFieldInfoPtr_HARVEST_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001378 RID: 4984
		// (get) Token: 0x06003F82 RID: 16258 RVA: 0x001408F4 File Offset: 0x0013EAF4
		// (set) Token: 0x06003F83 RID: 16259 RVA: 0x0001F9E4 File Offset: 0x0001DBE4
		public unsafe LabOven _targetOven_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinishLabOvenBehaviour.NativeFieldInfoPtr__targetOven_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabOven>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinishLabOvenBehaviour.NativeFieldInfoPtr__targetOven_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001379 RID: 4985
		// (get) Token: 0x06003F84 RID: 16260 RVA: 0x00140924 File Offset: 0x0013EB24
		// (set) Token: 0x06003F85 RID: 16261 RVA: 0x0001FA03 File Offset: 0x0001DC03
		public unsafe Chemist chemist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinishLabOvenBehaviour.NativeFieldInfoPtr_chemist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Chemist>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinishLabOvenBehaviour.NativeFieldInfoPtr_chemist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700137A RID: 4986
		// (get) Token: 0x06003F86 RID: 16262 RVA: 0x00140954 File Offset: 0x0013EB54
		// (set) Token: 0x06003F87 RID: 16263 RVA: 0x0001FA22 File Offset: 0x0001DC22
		public unsafe Coroutine actionRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinishLabOvenBehaviour.NativeFieldInfoPtr_actionRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinishLabOvenBehaviour.NativeFieldInfoPtr_actionRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700137B RID: 4987
		// (get) Token: 0x06003F88 RID: 16264 RVA: 0x00140984 File Offset: 0x0013EB84
		// (set) Token: 0x06003F89 RID: 16265 RVA: 0x0001FA41 File Offset: 0x0001DC41
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinishLabOvenBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinishLabOvenBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x06003F8A RID: 16266 RVA: 0x001409AC File Offset: 0x0013EBAC
		// (set) Token: 0x06003F8B RID: 16267 RVA: 0x0001FA5C File Offset: 0x0001DC5C
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinishLabOvenBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinishLabOvenBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002A1C RID: 10780
		private static readonly IntPtr NativeFieldInfoPtr_HARVEST_TIME;

		// Token: 0x04002A1D RID: 10781
		private static readonly IntPtr NativeFieldInfoPtr__targetOven_k__BackingField;

		// Token: 0x04002A1E RID: 10782
		private static readonly IntPtr NativeFieldInfoPtr_chemist;

		// Token: 0x04002A1F RID: 10783
		private static readonly IntPtr NativeFieldInfoPtr_actionRoutine;

		// Token: 0x04002A20 RID: 10784
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002A21 RID: 10785
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002A22 RID: 10786
		private static readonly IntPtr NativeMethodInfoPtr_get_targetOven_Public_get_LabOven_0;

		// Token: 0x04002A23 RID: 10787
		private static readonly IntPtr NativeMethodInfoPtr_set_targetOven_Private_set_Void_LabOven_0;

		// Token: 0x04002A24 RID: 10788
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04002A25 RID: 10789
		private static readonly IntPtr NativeMethodInfoPtr_SetTargetOven_Public_Void_LabOven_0;

		// Token: 0x04002A26 RID: 10790
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_1;

		// Token: 0x04002A27 RID: 10791
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002A28 RID: 10792
		private static readonly IntPtr NativeMethodInfoPtr_StartAction_Private_Void_0;

		// Token: 0x04002A29 RID: 10793
		private static readonly IntPtr NativeMethodInfoPtr_CanActionStart_Private_Boolean_0;

		// Token: 0x04002A2A RID: 10794
		private static readonly IntPtr NativeMethodInfoPtr_StopAction_Private_Void_0;

		// Token: 0x04002A2B RID: 10795
		private static readonly IntPtr NativeMethodInfoPtr_GetStationAccessPoint_Private_Vector3_0;

		// Token: 0x04002A2C RID: 10796
		private static readonly IntPtr NativeMethodInfoPtr_IsAtStation_Private_Boolean_0;

		// Token: 0x04002A2D RID: 10797
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002A2E RID: 10798
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04002A2F RID: 10799
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002A30 RID: 10800
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002A31 RID: 10801
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002A32 RID: 10802
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartAction_2166136261_Private_Void_0;

		// Token: 0x04002A33 RID: 10803
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartAction_2166136261_Private_Void_0;

		// Token: 0x04002A34 RID: 10804
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartAction_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002A35 RID: 10805
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000947 RID: 2375
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.FinishLabOvenBehaviour+<<StartAction>g__ActionRoutine|11_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C7D5 RID: 51157 RVA: 0x003074E8 File Offset: 0x003056E8
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique()
			{
				Il2CppClassPointerStore<FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FinishLabOvenBehaviour>.NativeClassPtr, "<<StartAction>g__ActionRoutine|11_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr);
				FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, "<>1__state");
				FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, "<>2__current");
				FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, "<>4__this");
				FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100670851);
				FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100670852);
				FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100670853);
				FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100670854);
				FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100670855);
				FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr, 100670856);
			}

			// Token: 0x0600C7D6 RID: 51158 RVA: 0x003075C8 File Offset: 0x003057C8
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C7D7 RID: 51159 RVA: 0x00307610 File Offset: 0x00305810
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C7D8 RID: 51160 RVA: 0x00307644 File Offset: 0x00305844
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147852, XrefRangeEnd = 147916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003E4D RID: 15949
			// (get) Token: 0x0600C7D9 RID: 51161 RVA: 0x00307680 File Offset: 0x00305880
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C7DA RID: 51162 RVA: 0x003076C0 File Offset: 0x003058C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147916, XrefRangeEnd = 147921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003E4E RID: 15950
			// (get) Token: 0x0600C7DB RID: 51163 RVA: 0x003076F4 File Offset: 0x003058F4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C7DC RID: 51164 RVA: 0x00061386 File Offset: 0x0005F586
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E4A RID: 15946
			// (get) Token: 0x0600C7DD RID: 51165 RVA: 0x00307734 File Offset: 0x00305934
			// (set) Token: 0x0600C7DE RID: 51166 RVA: 0x0006138F File Offset: 0x0005F58F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003E4B RID: 15947
			// (get) Token: 0x0600C7DF RID: 51167 RVA: 0x0030775C File Offset: 0x0030595C
			// (set) Token: 0x0600C7E0 RID: 51168 RVA: 0x000613AA File Offset: 0x0005F5AA
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003E4C RID: 15948
			// (get) Token: 0x0600C7E1 RID: 51169 RVA: 0x0030778C File Offset: 0x0030598C
			// (set) Token: 0x0600C7E2 RID: 51170 RVA: 0x000613C9 File Offset: 0x0005F5C9
			public unsafe FinishLabOvenBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FinishLabOvenBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FinishLabOvenBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400873B RID: 34619
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400873C RID: 34620
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400873D RID: 34621
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400873E RID: 34622
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400873F RID: 34623
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008740 RID: 34624
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008741 RID: 34625
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008742 RID: 34626
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008743 RID: 34627
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
