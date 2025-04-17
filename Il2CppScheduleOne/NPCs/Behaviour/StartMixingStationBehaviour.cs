using System;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000354 RID: 852
	public class StartMixingStationBehaviour : Behaviour
	{
		// Token: 0x0600411D RID: 16669 RVA: 0x00146C98 File Offset: 0x00144E98
		// Note: this type is marked as 'beforefieldinit'.
		static StartMixingStationBehaviour()
		{
			Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "StartMixingStationBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr);
			StartMixingStationBehaviour.NativeFieldInfoPtr_INSERT_INGREDIENT_BASE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr, "INSERT_INGREDIENT_BASE_TIME");
			StartMixingStationBehaviour.NativeFieldInfoPtr__targetStation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr, "<targetStation>k__BackingField");
			StartMixingStationBehaviour.NativeFieldInfoPtr_chemist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr, "chemist");
			StartMixingStationBehaviour.NativeFieldInfoPtr_startRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr, "startRoutine");
			StartMixingStationBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StartMixingStationBehaviourAssembly-CSharp.dll_Excuted");
			StartMixingStationBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StartMixingStationBehaviourAssembly-CSharp.dll_Excuted");
			StartMixingStationBehaviour.NativeMethodInfoPtr_get_targetStation_Public_get_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr, 100671191);
			StartMixingStationBehaviour.NativeMethodInfoPtr_set_targetStation_Private_set_Void_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr, 100671192);
			StartMixingStationBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr, 100671193);
			StartMixingStationBehaviour.NativeMethodInfoPtr_AssignStation_Public_Void_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr, 100671194);
			StartMixingStationBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr, 100671195);
			StartMixingStationBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr, 100671196);
			StartMixingStationBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr, 100671197);
			StartMixingStationBehaviour.NativeMethodInfoPtr_StartCook_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr, 100671198);
			StartMixingStationBehaviour.NativeMethodInfoPtr_CanCookStart_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr, 100671199);
			StartMixingStationBehaviour.NativeMethodInfoPtr_StopCook_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr, 100671200);
			StartMixingStationBehaviour.NativeMethodInfoPtr_GetStationAccessPoint_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr, 100671201);
			StartMixingStationBehaviour.NativeMethodInfoPtr_IsAtStation_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr, 100671202);
			StartMixingStationBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr, 100671203);
			StartMixingStationBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr, 100671204);
			StartMixingStationBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr, 100671205);
			StartMixingStationBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr, 100671206);
			StartMixingStationBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr, 100671207);
			StartMixingStationBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_StartCook_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr, 100671208);
			StartMixingStationBehaviour.NativeMethodInfoPtr_RpcLogic___StartCook_2166136261_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr, 100671209);
			StartMixingStationBehaviour.NativeMethodInfoPtr_RpcReader___Observers_StartCook_2166136261_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr, 100671210);
			StartMixingStationBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr, 100671211);
		}

		// Token: 0x170013D8 RID: 5080
		// (get) Token: 0x0600411E RID: 16670 RVA: 0x00146EE4 File Offset: 0x001450E4
		// (set) Token: 0x0600411F RID: 16671 RVA: 0x00146F24 File Offset: 0x00145124
		public unsafe MixingStation targetStation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartMixingStationBehaviour.NativeMethodInfoPtr_get_targetStation_Public_get_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr3) : null;
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 115138, RefRangeEnd = 115149, XrefRangeStart = 115138, XrefRangeEnd = 115149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartMixingStationBehaviour.NativeMethodInfoPtr_set_targetStation_Private_set_Void_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004120 RID: 16672 RVA: 0x00146F68 File Offset: 0x00145168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150834, XrefRangeEnd = 150843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartMixingStationBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004121 RID: 16673 RVA: 0x00146FA4 File Offset: 0x001451A4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 115138, RefRangeEnd = 115149, XrefRangeStart = 115138, XrefRangeEnd = 115149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignStation(MixingStation station)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartMixingStationBehaviour.NativeMethodInfoPtr_AssignStation_Public_Void_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004122 RID: 16674 RVA: 0x00146FE8 File Offset: 0x001451E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150843, XrefRangeEnd = 150851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartMixingStationBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004123 RID: 16675 RVA: 0x00147024 File Offset: 0x00145224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150851, XrefRangeEnd = 150857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartMixingStationBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004124 RID: 16676 RVA: 0x00147060 File Offset: 0x00145260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150857, XrefRangeEnd = 150894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartMixingStationBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004125 RID: 16677 RVA: 0x0014709C File Offset: 0x0014529C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150894, XrefRangeEnd = 150915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartCook()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartMixingStationBehaviour.NativeMethodInfoPtr_StartCook_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004126 RID: 16678 RVA: 0x001470D0 File Offset: 0x001452D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 150934, RefRangeEnd = 150935, XrefRangeStart = 150915, XrefRangeEnd = 150934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanCookStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartMixingStationBehaviour.NativeMethodInfoPtr_CanCookStart_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004127 RID: 16679 RVA: 0x0014710C File Offset: 0x0014530C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 150946, RefRangeEnd = 150947, XrefRangeStart = 150935, XrefRangeEnd = 150946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopCook()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartMixingStationBehaviour.NativeMethodInfoPtr_StopCook_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004128 RID: 16680 RVA: 0x00147140 File Offset: 0x00145340
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150955, RefRangeEnd = 150957, XrefRangeStart = 150947, XrefRangeEnd = 150955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetStationAccessPoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartMixingStationBehaviour.NativeMethodInfoPtr_GetStationAccessPoint_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004129 RID: 16681 RVA: 0x0014717C File Offset: 0x0014537C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150957, XrefRangeEnd = 150970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtStation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartMixingStationBehaviour.NativeMethodInfoPtr_IsAtStation_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600412A RID: 16682 RVA: 0x001471B8 File Offset: 0x001453B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StartMixingStationBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartMixingStationBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600412B RID: 16683 RVA: 0x001471F4 File Offset: 0x001453F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150970, XrefRangeEnd = 150975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartMixingStationBehaviour.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600412C RID: 16684 RVA: 0x00147234 File Offset: 0x00145434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150975, XrefRangeEnd = 150983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartMixingStationBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600412D RID: 16685 RVA: 0x00147270 File Offset: 0x00145470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartMixingStationBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600412E RID: 16686 RVA: 0x001472AC File Offset: 0x001454AC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartMixingStationBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600412F RID: 16687 RVA: 0x001472E8 File Offset: 0x001454E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150983, XrefRangeEnd = 151001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartCook_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartMixingStationBehaviour.NativeMethodInfoPtr_RpcWriter___Observers_StartCook_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004130 RID: 16688 RVA: 0x0014731C File Offset: 0x0014551C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 151012, RefRangeEnd = 151015, XrefRangeStart = 151001, XrefRangeEnd = 151012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartCook_2166136261()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartMixingStationBehaviour.NativeMethodInfoPtr_RpcLogic___StartCook_2166136261_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004131 RID: 16689 RVA: 0x00147350 File Offset: 0x00145550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151015, XrefRangeEnd = 151018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartCook_2166136261(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartMixingStationBehaviour.NativeMethodInfoPtr_RpcReader___Observers_StartCook_2166136261_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004132 RID: 16690 RVA: 0x001473A0 File Offset: 0x001455A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151018, XrefRangeEnd = 151027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StartMixingStationBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004133 RID: 16691 RVA: 0x00020215 File Offset: 0x0001E415
		public StartMixingStationBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170013D2 RID: 5074
		// (get) Token: 0x06004134 RID: 16692 RVA: 0x001473DC File Offset: 0x001455DC
		// (set) Token: 0x06004135 RID: 16693 RVA: 0x0002021E File Offset: 0x0001E41E
		public unsafe static float INSERT_INGREDIENT_BASE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StartMixingStationBehaviour.NativeFieldInfoPtr_INSERT_INGREDIENT_BASE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StartMixingStationBehaviour.NativeFieldInfoPtr_INSERT_INGREDIENT_BASE_TIME, (void*)(&value));
			}
		}

		// Token: 0x170013D3 RID: 5075
		// (get) Token: 0x06004136 RID: 16694 RVA: 0x001473F8 File Offset: 0x001455F8
		// (set) Token: 0x06004137 RID: 16695 RVA: 0x0002022C File Offset: 0x0001E42C
		public unsafe MixingStation _targetStation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMixingStationBehaviour.NativeFieldInfoPtr__targetStation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMixingStationBehaviour.NativeFieldInfoPtr__targetStation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013D4 RID: 5076
		// (get) Token: 0x06004138 RID: 16696 RVA: 0x00147428 File Offset: 0x00145628
		// (set) Token: 0x06004139 RID: 16697 RVA: 0x0002024B File Offset: 0x0001E44B
		public unsafe Chemist chemist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMixingStationBehaviour.NativeFieldInfoPtr_chemist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Chemist>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMixingStationBehaviour.NativeFieldInfoPtr_chemist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013D5 RID: 5077
		// (get) Token: 0x0600413A RID: 16698 RVA: 0x00147458 File Offset: 0x00145658
		// (set) Token: 0x0600413B RID: 16699 RVA: 0x0002026A File Offset: 0x0001E46A
		public unsafe Coroutine startRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMixingStationBehaviour.NativeFieldInfoPtr_startRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMixingStationBehaviour.NativeFieldInfoPtr_startRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170013D6 RID: 5078
		// (get) Token: 0x0600413C RID: 16700 RVA: 0x00147488 File Offset: 0x00145688
		// (set) Token: 0x0600413D RID: 16701 RVA: 0x00020289 File Offset: 0x0001E489
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMixingStationBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMixingStationBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170013D7 RID: 5079
		// (get) Token: 0x0600413E RID: 16702 RVA: 0x001474B0 File Offset: 0x001456B0
		// (set) Token: 0x0600413F RID: 16703 RVA: 0x000202A4 File Offset: 0x0001E4A4
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMixingStationBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMixingStationBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002B72 RID: 11122
		private static readonly IntPtr NativeFieldInfoPtr_INSERT_INGREDIENT_BASE_TIME;

		// Token: 0x04002B73 RID: 11123
		private static readonly IntPtr NativeFieldInfoPtr__targetStation_k__BackingField;

		// Token: 0x04002B74 RID: 11124
		private static readonly IntPtr NativeFieldInfoPtr_chemist;

		// Token: 0x04002B75 RID: 11125
		private static readonly IntPtr NativeFieldInfoPtr_startRoutine;

		// Token: 0x04002B76 RID: 11126
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002B77 RID: 11127
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002B78 RID: 11128
		private static readonly IntPtr NativeMethodInfoPtr_get_targetStation_Public_get_MixingStation_0;

		// Token: 0x04002B79 RID: 11129
		private static readonly IntPtr NativeMethodInfoPtr_set_targetStation_Private_set_Void_MixingStation_0;

		// Token: 0x04002B7A RID: 11130
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04002B7B RID: 11131
		private static readonly IntPtr NativeMethodInfoPtr_AssignStation_Public_Void_MixingStation_0;

		// Token: 0x04002B7C RID: 11132
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_1;

		// Token: 0x04002B7D RID: 11133
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1;

		// Token: 0x04002B7E RID: 11134
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002B7F RID: 11135
		private static readonly IntPtr NativeMethodInfoPtr_StartCook_Private_Void_0;

		// Token: 0x04002B80 RID: 11136
		private static readonly IntPtr NativeMethodInfoPtr_CanCookStart_Private_Boolean_0;

		// Token: 0x04002B81 RID: 11137
		private static readonly IntPtr NativeMethodInfoPtr_StopCook_Private_Void_0;

		// Token: 0x04002B82 RID: 11138
		private static readonly IntPtr NativeMethodInfoPtr_GetStationAccessPoint_Private_Vector3_0;

		// Token: 0x04002B83 RID: 11139
		private static readonly IntPtr NativeMethodInfoPtr_IsAtStation_Private_Boolean_0;

		// Token: 0x04002B84 RID: 11140
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002B85 RID: 11141
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04002B86 RID: 11142
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002B87 RID: 11143
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002B88 RID: 11144
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002B89 RID: 11145
		private static readonly IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartCook_2166136261_Private_Void_0;

		// Token: 0x04002B8A RID: 11146
		private static readonly IntPtr NativeMethodInfoPtr_RpcLogic___StartCook_2166136261_Private_Void_0;

		// Token: 0x04002B8B RID: 11147
		private static readonly IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartCook_2166136261_Private_Void_PooledReader_Channel_0;

		// Token: 0x04002B8C RID: 11148
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x0200095A RID: 2394
		[ObfuscatedName("ScheduleOne.NPCs.Behaviour.StartMixingStationBehaviour+<<StartCook>g__CookRoutine|12_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C8BF RID: 51391 RVA: 0x0030A28C File Offset: 0x0030848C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique()
			{
				Il2CppClassPointerStore<StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<StartMixingStationBehaviour>.NativeClassPtr, "<<StartCook>g__CookRoutine|12_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique>.NativeClassPtr);
				StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique>.NativeClassPtr, "<>1__state");
				StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique>.NativeClassPtr, "<>2__current");
				StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique>.NativeClassPtr, "<>4__this");
				StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeFieldInfoPtr__product_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique>.NativeClassPtr, "<product>5__2");
				StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeFieldInfoPtr__mixer_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique>.NativeClassPtr, "<mixer>5__3");
				StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeFieldInfoPtr__mixQuantity_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique>.NativeClassPtr, "<mixQuantity>5__4");
				StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeFieldInfoPtr__i_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique>.NativeClassPtr, "<i>5__5");
				StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique>.NativeClassPtr, 100671212);
				StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique>.NativeClassPtr, 100671213);
				StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique>.NativeClassPtr, 100671214);
				StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique>.NativeClassPtr, 100671215);
				StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique>.NativeClassPtr, 100671216);
				StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique>.NativeClassPtr, 100671217);
			}

			// Token: 0x0600C8C0 RID: 51392 RVA: 0x0030A3BC File Offset: 0x003085BC
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C8C1 RID: 51393 RVA: 0x0030A404 File Offset: 0x00308604
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C8C2 RID: 51394 RVA: 0x0030A438 File Offset: 0x00308638
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150806, XrefRangeEnd = 150829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003EA6 RID: 16038
			// (get) Token: 0x0600C8C3 RID: 51395 RVA: 0x0030A474 File Offset: 0x00308674
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C8C4 RID: 51396 RVA: 0x0030A4B4 File Offset: 0x003086B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150829, XrefRangeEnd = 150834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003EA7 RID: 16039
			// (get) Token: 0x0600C8C5 RID: 51397 RVA: 0x0030A4E8 File Offset: 0x003086E8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C8C6 RID: 51398 RVA: 0x00061A4D File Offset: 0x0005FC4D
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003E9F RID: 16031
			// (get) Token: 0x0600C8C7 RID: 51399 RVA: 0x0030A528 File Offset: 0x00308728
			// (set) Token: 0x0600C8C8 RID: 51400 RVA: 0x00061A56 File Offset: 0x0005FC56
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003EA0 RID: 16032
			// (get) Token: 0x0600C8C9 RID: 51401 RVA: 0x0030A550 File Offset: 0x00308750
			// (set) Token: 0x0600C8CA RID: 51402 RVA: 0x00061A71 File Offset: 0x0005FC71
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EA1 RID: 16033
			// (get) Token: 0x0600C8CB RID: 51403 RVA: 0x0030A580 File Offset: 0x00308780
			// (set) Token: 0x0600C8CC RID: 51404 RVA: 0x00061A90 File Offset: 0x0005FC90
			public unsafe StartMixingStationBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StartMixingStationBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EA2 RID: 16034
			// (get) Token: 0x0600C8CD RID: 51405 RVA: 0x0030A5B0 File Offset: 0x003087B0
			// (set) Token: 0x0600C8CE RID: 51406 RVA: 0x00061AAF File Offset: 0x0005FCAF
			public unsafe QualityItemInstance _product_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeFieldInfoPtr__product_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<QualityItemInstance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeFieldInfoPtr__product_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EA3 RID: 16035
			// (get) Token: 0x0600C8CF RID: 51407 RVA: 0x0030A5E0 File Offset: 0x003087E0
			// (set) Token: 0x0600C8D0 RID: 51408 RVA: 0x00061ACE File Offset: 0x0005FCCE
			public unsafe ItemInstance _mixer_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeFieldInfoPtr__mixer_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeFieldInfoPtr__mixer_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EA4 RID: 16036
			// (get) Token: 0x0600C8D1 RID: 51409 RVA: 0x0030A610 File Offset: 0x00308810
			// (set) Token: 0x0600C8D2 RID: 51410 RVA: 0x00061AED File Offset: 0x0005FCED
			public unsafe int _mixQuantity_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeFieldInfoPtr__mixQuantity_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeFieldInfoPtr__mixQuantity_5__4)) = value;
				}
			}

			// Token: 0x17003EA5 RID: 16037
			// (get) Token: 0x0600C8D3 RID: 51411 RVA: 0x0030A638 File Offset: 0x00308838
			// (set) Token: 0x0600C8D4 RID: 51412 RVA: 0x00061B08 File Offset: 0x0005FD08
			public unsafe int _i_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeFieldInfoPtr__i_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StartMixingStationBehaviour.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStQuItInObInObUnique.NativeFieldInfoPtr__i_5__5)) = value;
				}
			}

			// Token: 0x040087E2 RID: 34786
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040087E3 RID: 34787
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040087E4 RID: 34788
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040087E5 RID: 34789
			private static readonly IntPtr NativeFieldInfoPtr__product_5__2;

			// Token: 0x040087E6 RID: 34790
			private static readonly IntPtr NativeFieldInfoPtr__mixer_5__3;

			// Token: 0x040087E7 RID: 34791
			private static readonly IntPtr NativeFieldInfoPtr__mixQuantity_5__4;

			// Token: 0x040087E8 RID: 34792
			private static readonly IntPtr NativeFieldInfoPtr__i_5__5;

			// Token: 0x040087E9 RID: 34793
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040087EA RID: 34794
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087EB RID: 34795
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040087EC RID: 34796
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040087ED RID: 34797
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087EE RID: 34798
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
