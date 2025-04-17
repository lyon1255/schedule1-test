using System;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000357 RID: 855
	public class FleeBehaviour : Behaviour
	{
		// Token: 0x06004187 RID: 16775 RVA: 0x00148714 File Offset: 0x00146914
		// Note: this type is marked as 'beforefieldinit'.
		static FleeBehaviour()
		{
			Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "FleeBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr);
			FleeBehaviour.NativeFieldInfoPtr_FLEE_DIST_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "FLEE_DIST_MIN");
			FleeBehaviour.NativeFieldInfoPtr_FLEE_DIST_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "FLEE_DIST_MAX");
			FleeBehaviour.NativeFieldInfoPtr_FLEE_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "FLEE_SPEED");
			FleeBehaviour.NativeFieldInfoPtr__EntityToFlee_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "<EntityToFlee>k__BackingField");
			FleeBehaviour.NativeFieldInfoPtr__FleeMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "<FleeMode>k__BackingField");
			FleeBehaviour.NativeFieldInfoPtr__FleeOrigin_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "<FleeOrigin>k__BackingField");
			FleeBehaviour.NativeFieldInfoPtr_currentFleeTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "currentFleeTarget");
			FleeBehaviour.NativeFieldInfoPtr_nextVO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "nextVO");
			FleeBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.FleeBehaviourAssembly-CSharp.dll_Excuted");
			FleeBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.FleeBehaviourAssembly-CSharp.dll_Excuted");
			FleeBehaviour.NativeMethodInfoPtr_get_EntityToFlee_Public_get_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671271);
			FleeBehaviour.NativeMethodInfoPtr_set_EntityToFlee_Private_set_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671272);
			FleeBehaviour.NativeMethodInfoPtr_get_PointToFlee_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671273);
			FleeBehaviour.NativeMethodInfoPtr_get_FleeMode_Public_get_EFleeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671274);
			FleeBehaviour.NativeMethodInfoPtr_set_FleeMode_Private_set_Void_EFleeMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671275);
			FleeBehaviour.NativeMethodInfoPtr_get_FleeOrigin_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671276);
			FleeBehaviour.NativeMethodInfoPtr_set_FleeOrigin_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671277);
			FleeBehaviour.NativeMethodInfoPtr_SetEntityToFlee_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671278);
			FleeBehaviour.NativeMethodInfoPtr_SetPointToFlee_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671279);
			FleeBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671280);
			FleeBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671281);
			FleeBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671282);
			FleeBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671283);
			FleeBehaviour.NativeMethodInfoPtr_StartFlee_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671284);
			FleeBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671285);
			FleeBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671286);
			FleeBehaviour.NativeMethodInfoPtr_Stop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671287);
			FleeBehaviour.NativeMethodInfoPtr_Flee_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671288);
			FleeBehaviour.NativeMethodInfoPtr_GetFleePosition_Public_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671289);
			FleeBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671290);
			FleeBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671291);
			FleeBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671292);
			FleeBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671293);
			FleeBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetEntityToFlee_3323014238_Private_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671294);
			FleeBehaviour.NativeMethodInfoPtr_RpcLogic___SetEntityToFlee_3323014238_Public_Void_NetworkObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671295);
			FleeBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetEntityToFlee_3323014238_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671296);
			FleeBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetPointToFlee_4276783012_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671297);
			FleeBehaviour.NativeMethodInfoPtr_RpcLogic___SetPointToFlee_4276783012_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671298);
			FleeBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetPointToFlee_4276783012_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671299);
			FleeBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr, 100671300);
		}

		// Token: 0x170013F1 RID: 5105
		// (get) Token: 0x06004188 RID: 16776 RVA: 0x00148A64 File Offset: 0x00146C64
		// (set) Token: 0x06004189 RID: 16777 RVA: 0x00148AA4 File Offset: 0x00146CA4
		public unsafe NetworkObject EntityToFlee
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_get_EntityToFlee_Public_get_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr3) : null;
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 115138, RefRangeEnd = 115149, XrefRangeStart = 115138, XrefRangeEnd = 115149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_set_EntityToFlee_Private_set_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170013F2 RID: 5106
		// (get) Token: 0x0600418A RID: 16778 RVA: 0x00148AE8 File Offset: 0x00146CE8
		public unsafe Vector3 PointToFlee
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_get_PointToFlee_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170013F3 RID: 5107
		// (get) Token: 0x0600418B RID: 16779 RVA: 0x00148B24 File Offset: 0x00146D24
		// (set) Token: 0x0600418C RID: 16780 RVA: 0x00148B60 File Offset: 0x00146D60
		public unsafe FleeBehaviour.EFleeMode FleeMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_get_FleeMode_Public_get_EFleeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_set_FleeMode_Private_set_Void_EFleeMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170013F4 RID: 5108
		// (get) Token: 0x0600418D RID: 16781 RVA: 0x00148BA0 File Offset: 0x00146DA0
		// (set) Token: 0x0600418E RID: 16782 RVA: 0x00148BDC File Offset: 0x00146DDC
		public unsafe Vector3 FleeOrigin
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_get_FleeOrigin_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_set_FleeOrigin_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600418F RID: 16783 RVA: 0x00148C1C File Offset: 0x00146E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151400, XrefRangeEnd = 151421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEntityToFlee(NetworkObject entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_SetEntityToFlee_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004190 RID: 16784 RVA: 0x00148C60 File Offset: 0x00146E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151421, XrefRangeEnd = 151443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPointToFlee(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_SetPointToFlee_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004191 RID: 16785 RVA: 0x00148CA0 File Offset: 0x00146EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151443, XrefRangeEnd = 151449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004192 RID: 16786 RVA: 0x00148CDC File Offset: 0x00146EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151449, XrefRangeEnd = 151451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004193 RID: 16787 RVA: 0x00148D18 File Offset: 0x00146F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151451, XrefRangeEnd = 151458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004194 RID: 16788 RVA: 0x00148D54 File Offset: 0x00146F54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151458, XrefRangeEnd = 151460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004195 RID: 16789 RVA: 0x00148D90 File Offset: 0x00146F90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151475, RefRangeEnd = 151477, XrefRangeStart = 151460, XrefRangeEnd = 151475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartFlee()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_StartFlee_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004196 RID: 16790 RVA: 0x00148DC4 File Offset: 0x00146FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151477, XrefRangeEnd = 151485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004197 RID: 16791 RVA: 0x00148E00 File Offset: 0x00147000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151485, XrefRangeEnd = 151492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BehaviourUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004198 RID: 16792 RVA: 0x00148E3C File Offset: 0x0014703C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 151499, RefRangeEnd = 151501, XrefRangeStart = 151492, XrefRangeEnd = 151499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_Stop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004199 RID: 16793 RVA: 0x00148E70 File Offset: 0x00147070
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151504, RefRangeEnd = 151505, XrefRangeStart = 151501, XrefRangeEnd = 151504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Flee()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_Flee_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600419A RID: 16794 RVA: 0x00148EA4 File Offset: 0x001470A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 151556, RefRangeEnd = 151557, XrefRangeStart = 151505, XrefRangeEnd = 151556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetFleePosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_GetFleePosition_Public_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600419B RID: 16795 RVA: 0x00148EE0 File Offset: 0x001470E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151557, XrefRangeEnd = 151562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FleeBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FleeBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600419C RID: 16796 RVA: 0x00148F1C File Offset: 0x0014711C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151562, XrefRangeEnd = 151576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600419D RID: 16797 RVA: 0x00148F58 File Offset: 0x00147158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600419E RID: 16798 RVA: 0x00148F94 File Offset: 0x00147194
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600419F RID: 16799 RVA: 0x00148FD0 File Offset: 0x001471D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151576, XrefRangeEnd = 151595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetEntityToFlee_3323014238(NetworkObject entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetEntityToFlee_3323014238_Private_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041A0 RID: 16800 RVA: 0x00149014 File Offset: 0x00147214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151595, XrefRangeEnd = 151596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetEntityToFlee_3323014238(NetworkObject entity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_RpcLogic___SetEntityToFlee_3323014238_Public_Void_NetworkObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041A1 RID: 16801 RVA: 0x00149058 File Offset: 0x00147258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151596, XrefRangeEnd = 151600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetEntityToFlee_3323014238(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetEntityToFlee_3323014238_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041A2 RID: 16802 RVA: 0x001490A8 File Offset: 0x001472A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151600, XrefRangeEnd = 151621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetPointToFlee_4276783012(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_SetPointToFlee_4276783012_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041A3 RID: 16803 RVA: 0x001490E8 File Offset: 0x001472E8
		[CallerCount(0)]
		public unsafe void RpcLogic___SetPointToFlee_4276783012(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_RpcLogic___SetPointToFlee_4276783012_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041A4 RID: 16804 RVA: 0x00149128 File Offset: 0x00147328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151621, XrefRangeEnd = 151626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetPointToFlee_4276783012(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FleeBehaviour.NativeMethodInfoPtr_RpcReader___Observers_SetPointToFlee_4276783012_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041A5 RID: 16805 RVA: 0x00149178 File Offset: 0x00147378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FleeBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041A6 RID: 16806 RVA: 0x000203DE File Offset: 0x0001E5DE
		public FleeBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170013E7 RID: 5095
		// (get) Token: 0x060041A7 RID: 16807 RVA: 0x001491B4 File Offset: 0x001473B4
		// (set) Token: 0x060041A8 RID: 16808 RVA: 0x000203E7 File Offset: 0x0001E5E7
		public unsafe static float FLEE_DIST_MIN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FleeBehaviour.NativeFieldInfoPtr_FLEE_DIST_MIN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FleeBehaviour.NativeFieldInfoPtr_FLEE_DIST_MIN, (void*)(&value));
			}
		}

		// Token: 0x170013E8 RID: 5096
		// (get) Token: 0x060041A9 RID: 16809 RVA: 0x001491D0 File Offset: 0x001473D0
		// (set) Token: 0x060041AA RID: 16810 RVA: 0x000203F5 File Offset: 0x0001E5F5
		public unsafe static float FLEE_DIST_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FleeBehaviour.NativeFieldInfoPtr_FLEE_DIST_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FleeBehaviour.NativeFieldInfoPtr_FLEE_DIST_MAX, (void*)(&value));
			}
		}

		// Token: 0x170013E9 RID: 5097
		// (get) Token: 0x060041AB RID: 16811 RVA: 0x001491EC File Offset: 0x001473EC
		// (set) Token: 0x060041AC RID: 16812 RVA: 0x00020403 File Offset: 0x0001E603
		public unsafe static float FLEE_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FleeBehaviour.NativeFieldInfoPtr_FLEE_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FleeBehaviour.NativeFieldInfoPtr_FLEE_SPEED, (void*)(&value));
			}
		}

		// Token: 0x170013EA RID: 5098
		// (get) Token: 0x060041AD RID: 16813 RVA: 0x00149208 File Offset: 0x00147408
		// (set) Token: 0x060041AE RID: 16814 RVA: 0x00020411 File Offset: 0x0001E611
		public unsafe NetworkObject _EntityToFlee_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr__EntityToFlee_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr__EntityToFlee_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013EB RID: 5099
		// (get) Token: 0x060041AF RID: 16815 RVA: 0x00149238 File Offset: 0x00147438
		// (set) Token: 0x060041B0 RID: 16816 RVA: 0x00020430 File Offset: 0x0001E630
		public unsafe FleeBehaviour.EFleeMode _FleeMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr__FleeMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr__FleeMode_k__BackingField)) = value;
			}
		}

		// Token: 0x170013EC RID: 5100
		// (get) Token: 0x060041B1 RID: 16817 RVA: 0x00149260 File Offset: 0x00147460
		// (set) Token: 0x060041B2 RID: 16818 RVA: 0x0002044B File Offset: 0x0001E64B
		public unsafe Vector3 _FleeOrigin_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr__FleeOrigin_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr__FleeOrigin_k__BackingField)) = value;
			}
		}

		// Token: 0x170013ED RID: 5101
		// (get) Token: 0x060041B3 RID: 16819 RVA: 0x00149288 File Offset: 0x00147488
		// (set) Token: 0x060041B4 RID: 16820 RVA: 0x00020466 File Offset: 0x0001E666
		public unsafe Vector3 currentFleeTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_currentFleeTarget);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_currentFleeTarget)) = value;
			}
		}

		// Token: 0x170013EE RID: 5102
		// (get) Token: 0x060041B5 RID: 16821 RVA: 0x001492B0 File Offset: 0x001474B0
		// (set) Token: 0x060041B6 RID: 16822 RVA: 0x00020481 File Offset: 0x0001E681
		public unsafe float nextVO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_nextVO);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_nextVO)) = value;
			}
		}

		// Token: 0x170013EF RID: 5103
		// (get) Token: 0x060041B7 RID: 16823 RVA: 0x001492D8 File Offset: 0x001474D8
		// (set) Token: 0x060041B8 RID: 16824 RVA: 0x0002049C File Offset: 0x0001E69C
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170013F0 RID: 5104
		// (get) Token: 0x060041B9 RID: 16825 RVA: 0x00149300 File Offset: 0x00147500
		// (set) Token: 0x060041BA RID: 16826 RVA: 0x000204B7 File Offset: 0x0001E6B7
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FleeBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002BC6 RID: 11206
		private static readonly IntPtr NativeFieldInfoPtr_FLEE_DIST_MIN;

		// Token: 0x04002BC7 RID: 11207
		private static readonly IntPtr NativeFieldInfoPtr_FLEE_DIST_MAX;

		// Token: 0x04002BC8 RID: 11208
		private static readonly IntPtr NativeFieldInfoPtr_FLEE_SPEED;

		// Token: 0x04002BC9 RID: 11209
		private static readonly IntPtr NativeFieldInfoPtr__EntityToFlee_k__BackingField;

		// Token: 0x04002BCA RID: 11210
		private static readonly IntPtr NativeFieldInfoPtr__FleeMode_k__BackingField;

		// Token: 0x04002BCB RID: 11211
		private static readonly IntPtr NativeFieldInfoPtr__FleeOrigin_k__BackingField;

		// Token: 0x04002BCC RID: 11212
		private static readonly IntPtr NativeFieldInfoPtr_currentFleeTarget;

		// Token: 0x04002BCD RID: 11213
		private static readonly IntPtr NativeFieldInfoPtr_nextVO;

		// Token: 0x04002BCE RID: 11214
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002BCF RID: 11215
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002BD0 RID: 11216
		private static readonly IntPtr NativeMethodInfoPtr_get_EntityToFlee_Public_get_NetworkObject_0;

		// Token: 0x04002BD1 RID: 11217
		private static readonly IntPtr NativeMethodInfoPtr_set_EntityToFlee_Private_set_Void_NetworkObject_0;

		// Token: 0x04002BD2 RID: 11218
		private static readonly IntPtr NativeMethodInfoPtr_get_PointToFlee_Public_get_Vector3_0;

		// Token: 0x04002BD3 RID: 11219
		private static readonly IntPtr NativeMethodInfoPtr_get_FleeMode_Public_get_EFleeMode_0;

		// Token: 0x04002BD4 RID: 11220
		private static readonly IntPtr NativeMethodInfoPtr_set_FleeMode_Private_set_Void_EFleeMode_0;

		// Token: 0x04002BD5 RID: 11221
		private static readonly IntPtr NativeMethodInfoPtr_get_FleeOrigin_Public_get_Vector3_0;

		// Token: 0x04002BD6 RID: 11222
		private static readonly IntPtr NativeMethodInfoPtr_set_FleeOrigin_Private_set_Void_Vector3_0;

		// Token: 0x04002BD7 RID: 11223
		private static readonly IntPtr NativeMethodInfoPtr_SetEntityToFlee_Public_Void_NetworkObject_0;

		// Token: 0x04002BD8 RID: 11224
		private static readonly IntPtr NativeMethodInfoPtr_SetPointToFlee_Public_Void_Vector3_0;

		// Token: 0x04002BD9 RID: 11225
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0;

		// Token: 0x04002BDA RID: 11226
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0;

		// Token: 0x04002BDB RID: 11227
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_0;

		// Token: 0x04002BDC RID: 11228
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0;

		// Token: 0x04002BDD RID: 11229
		private static readonly IntPtr NativeMethodInfoPtr_StartFlee_Private_Void_0;

		// Token: 0x04002BDE RID: 11230
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002BDF RID: 11231
		private static readonly IntPtr NativeMethodInfoPtr_BehaviourUpdate_Public_Virtual_Void_0;

		// Token: 0x04002BE0 RID: 11232
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Private_Void_0;

		// Token: 0x04002BE1 RID: 11233
		private static readonly IntPtr NativeMethodInfoPtr_Flee_Private_Void_0;

		// Token: 0x04002BE2 RID: 11234
		private static readonly IntPtr NativeMethodInfoPtr_GetFleePosition_Public_Vector3_0;

		// Token: 0x04002BE3 RID: 11235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002BE4 RID: 11236
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002BE5 RID: 11237
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002BE6 RID: 11238
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002BE7 RID: 11239
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetEntityToFlee_3323014238_Private_Void_NetworkObject_0;

		// Token: 0x04002BE8 RID: 11240
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetEntityToFlee_3323014238_Public_Void_NetworkObject_0;

		// Token: 0x04002BE9 RID: 11241
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetEntityToFlee_3323014238_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002BEA RID: 11242
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetPointToFlee_4276783012_Private_Void_Vector3_0;

		// Token: 0x04002BEB RID: 11243
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___SetPointToFlee_4276783012_Public_Void_Vector3_0;

		// Token: 0x04002BEC RID: 11244
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetPointToFlee_4276783012_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002BED RID: 11245
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0200095C RID: 2396
		[OriginalName("Assembly-CSharp.dll", "", "EFleeMode")]
		public enum EFleeMode
		{
			// Token: 0x040087F9 RID: 34809
			Entity,
			// Token: 0x040087FA RID: 34810
			Point
		}
	}
}
