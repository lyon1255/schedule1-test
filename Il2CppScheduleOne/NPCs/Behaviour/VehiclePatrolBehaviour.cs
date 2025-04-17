using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Vehicles;
using Il2CppScheduleOne.Vehicles.AI;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000366 RID: 870
	public class VehiclePatrolBehaviour : Behaviour
	{
		// Token: 0x060043CD RID: 17357 RVA: 0x00150528 File Offset: 0x0014E728
		// Note: this type is marked as 'beforefieldinit'.
		static VehiclePatrolBehaviour()
		{
			Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "VehiclePatrolBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr);
			VehiclePatrolBehaviour.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, "MAX_CONSECUTIVE_PATHING_FAILURES");
			VehiclePatrolBehaviour.NativeFieldInfoPtr_PROGRESSION_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, "PROGRESSION_THRESHOLD");
			VehiclePatrolBehaviour.NativeFieldInfoPtr_CurrentWaypoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, "CurrentWaypoint");
			VehiclePatrolBehaviour.NativeFieldInfoPtr_Route = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, "Route");
			VehiclePatrolBehaviour.NativeFieldInfoPtr_Vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, "Vehicle");
			VehiclePatrolBehaviour.NativeFieldInfoPtr_aggressiveDrivingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, "aggressiveDrivingEnabled");
			VehiclePatrolBehaviour.NativeFieldInfoPtr_consecutivePathingFailures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, "consecutivePathingFailures");
			VehiclePatrolBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.VehiclePatrolBehaviourAssembly-CSharp.dll_Excuted");
			VehiclePatrolBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.VehiclePatrolBehaviourAssembly-CSharp.dll_Excuted");
			VehiclePatrolBehaviour.NativeMethodInfoPtr_get_isDriving_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671589);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_get_Agent_Private_get_VehicleAgent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671590);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671591);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671592);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671593);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671594);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671595);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_SetRoute_Public_Void_VehiclePatrolRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671596);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_StartPatrol_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671597);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671598);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_DriveTo_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671599);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_NavigationCallback_Private_Void_ENavigationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671600);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_IsAsCloseAsPossible_Private_Boolean_Vector3_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671601);
			VehiclePatrolBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671602);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671603);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671604);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671605);
			VehiclePatrolBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr, 100671606);
		}

		// Token: 0x17001486 RID: 5254
		// (get) Token: 0x060043CE RID: 17358 RVA: 0x00150774 File Offset: 0x0014E974
		public unsafe bool isDriving
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154407, XrefRangeEnd = 154414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolBehaviour.NativeMethodInfoPtr_get_isDriving_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001487 RID: 5255
		// (get) Token: 0x060043CF RID: 17359 RVA: 0x001507B0 File Offset: 0x0014E9B0
		public unsafe VehicleAgent Agent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolBehaviour.NativeMethodInfoPtr_get_Agent_Private_get_VehicleAgent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VehicleAgent>(intPtr3) : null;
			}
		}

		// Token: 0x060043D0 RID: 17360 RVA: 0x001507F0 File Offset: 0x0014E9F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePatrolBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043D1 RID: 17361 RVA: 0x0015082C File Offset: 0x0014EA2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154414, XrefRangeEnd = 154416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePatrolBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043D2 RID: 17362 RVA: 0x00150868 File Offset: 0x0014EA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154416, XrefRangeEnd = 154418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePatrolBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043D3 RID: 17363 RVA: 0x001508A4 File Offset: 0x0014EAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154418, XrefRangeEnd = 154429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePatrolBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043D4 RID: 17364 RVA: 0x001508E0 File Offset: 0x0014EAE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154429, XrefRangeEnd = 154440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePatrolBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_1), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043D5 RID: 17365 RVA: 0x0015091C File Offset: 0x0014EB1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 115150, RefRangeEnd = 115151, XrefRangeStart = 115150, XrefRangeEnd = 115151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRoute(VehiclePatrolRoute route)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(route);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolBehaviour.NativeMethodInfoPtr_SetRoute_Public_Void_VehiclePatrolRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043D6 RID: 17366 RVA: 0x00150960 File Offset: 0x0014EB60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 154464, RefRangeEnd = 154466, XrefRangeStart = 154440, XrefRangeEnd = 154464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartPatrol()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolBehaviour.NativeMethodInfoPtr_StartPatrol_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043D7 RID: 17367 RVA: 0x00150994 File Offset: 0x0014EB94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154466, XrefRangeEnd = 154475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePatrolBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043D8 RID: 17368 RVA: 0x001509D0 File Offset: 0x0014EBD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 154483, RefRangeEnd = 154484, XrefRangeStart = 154475, XrefRangeEnd = 154483, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DriveTo(Vector3 location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref location;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolBehaviour.NativeMethodInfoPtr_DriveTo_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043D9 RID: 17369 RVA: 0x00150A10 File Offset: 0x0014EC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154484, XrefRangeEnd = 154487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NavigationCallback(VehicleAgent.ENavigationResult status)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref status;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolBehaviour.NativeMethodInfoPtr_NavigationCallback_Private_Void_ENavigationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043DA RID: 17370 RVA: 0x00150A50 File Offset: 0x0014EC50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 154495, RefRangeEnd = 154498, XrefRangeStart = 154487, XrefRangeEnd = 154495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAsCloseAsPossible(Vector3 pos, out Vector3 closestPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &closestPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolBehaviour.NativeMethodInfoPtr_IsAsCloseAsPossible_Private_Boolean_Vector3_byref_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043DB RID: 17371 RVA: 0x00150AA8 File Offset: 0x0014ECA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154498, XrefRangeEnd = 154499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehiclePatrolBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehiclePatrolBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043DC RID: 17372 RVA: 0x00150AE4 File Offset: 0x0014ECE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154499, XrefRangeEnd = 154500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePatrolBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043DD RID: 17373 RVA: 0x00150B20 File Offset: 0x0014ED20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePatrolBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043DE RID: 17374 RVA: 0x00150B5C File Offset: 0x0014ED5C
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePatrolBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043DF RID: 17375 RVA: 0x00150B98 File Offset: 0x0014ED98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclePatrolBehaviour.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043E0 RID: 17376 RVA: 0x00021204 File Offset: 0x0001F404
		public VehiclePatrolBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700147D RID: 5245
		// (get) Token: 0x060043E1 RID: 17377 RVA: 0x00150BD4 File Offset: 0x0014EDD4
		// (set) Token: 0x060043E2 RID: 17378 RVA: 0x0002120D File Offset: 0x0001F40D
		public new unsafe static float MAX_CONSECUTIVE_PATHING_FAILURES
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehiclePatrolBehaviour.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehiclePatrolBehaviour.NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES, (void*)(&value));
			}
		}

		// Token: 0x1700147E RID: 5246
		// (get) Token: 0x060043E3 RID: 17379 RVA: 0x00150BF0 File Offset: 0x0014EDF0
		// (set) Token: 0x060043E4 RID: 17380 RVA: 0x0002121B File Offset: 0x0001F41B
		public unsafe static float PROGRESSION_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(VehiclePatrolBehaviour.NativeFieldInfoPtr_PROGRESSION_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VehiclePatrolBehaviour.NativeFieldInfoPtr_PROGRESSION_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x1700147F RID: 5247
		// (get) Token: 0x060043E5 RID: 17381 RVA: 0x00150C0C File Offset: 0x0014EE0C
		// (set) Token: 0x060043E6 RID: 17382 RVA: 0x00021229 File Offset: 0x0001F429
		public unsafe int CurrentWaypoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolBehaviour.NativeFieldInfoPtr_CurrentWaypoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolBehaviour.NativeFieldInfoPtr_CurrentWaypoint)) = value;
			}
		}

		// Token: 0x17001480 RID: 5248
		// (get) Token: 0x060043E7 RID: 17383 RVA: 0x00150C34 File Offset: 0x0014EE34
		// (set) Token: 0x060043E8 RID: 17384 RVA: 0x00021244 File Offset: 0x0001F444
		public unsafe VehiclePatrolRoute Route
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolBehaviour.NativeFieldInfoPtr_Route);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehiclePatrolRoute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolBehaviour.NativeFieldInfoPtr_Route), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001481 RID: 5249
		// (get) Token: 0x060043E9 RID: 17385 RVA: 0x00150C64 File Offset: 0x0014EE64
		// (set) Token: 0x060043EA RID: 17386 RVA: 0x00021263 File Offset: 0x0001F463
		public unsafe LandVehicle Vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolBehaviour.NativeFieldInfoPtr_Vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolBehaviour.NativeFieldInfoPtr_Vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001482 RID: 5250
		// (get) Token: 0x060043EB RID: 17387 RVA: 0x00150C94 File Offset: 0x0014EE94
		// (set) Token: 0x060043EC RID: 17388 RVA: 0x00021282 File Offset: 0x0001F482
		public unsafe bool aggressiveDrivingEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolBehaviour.NativeFieldInfoPtr_aggressiveDrivingEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolBehaviour.NativeFieldInfoPtr_aggressiveDrivingEnabled)) = value;
			}
		}

		// Token: 0x17001483 RID: 5251
		// (get) Token: 0x060043ED RID: 17389 RVA: 0x00150CBC File Offset: 0x0014EEBC
		// (set) Token: 0x060043EE RID: 17390 RVA: 0x0002129D File Offset: 0x0001F49D
		public new unsafe int consecutivePathingFailures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolBehaviour.NativeFieldInfoPtr_consecutivePathingFailures);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolBehaviour.NativeFieldInfoPtr_consecutivePathingFailures)) = value;
			}
		}

		// Token: 0x17001484 RID: 5252
		// (get) Token: 0x060043EF RID: 17391 RVA: 0x00150CE4 File Offset: 0x0014EEE4
		// (set) Token: 0x060043F0 RID: 17392 RVA: 0x000212B8 File Offset: 0x0001F4B8
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001485 RID: 5253
		// (get) Token: 0x060043F1 RID: 17393 RVA: 0x00150D0C File Offset: 0x0014EF0C
		// (set) Token: 0x060043F2 RID: 17394 RVA: 0x000212D3 File Offset: 0x0001F4D3
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002D67 RID: 11623
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CONSECUTIVE_PATHING_FAILURES;

		// Token: 0x04002D68 RID: 11624
		private static readonly IntPtr NativeFieldInfoPtr_PROGRESSION_THRESHOLD;

		// Token: 0x04002D69 RID: 11625
		private static readonly IntPtr NativeFieldInfoPtr_CurrentWaypoint;

		// Token: 0x04002D6A RID: 11626
		private static readonly IntPtr NativeFieldInfoPtr_Route;

		// Token: 0x04002D6B RID: 11627
		private static readonly IntPtr NativeFieldInfoPtr_Vehicle;

		// Token: 0x04002D6C RID: 11628
		private static readonly IntPtr NativeFieldInfoPtr_aggressiveDrivingEnabled;

		// Token: 0x04002D6D RID: 11629
		private static readonly IntPtr NativeFieldInfoPtr_consecutivePathingFailures;

		// Token: 0x04002D6E RID: 11630
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002D6F RID: 11631
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002D70 RID: 11632
		private static readonly IntPtr NativeMethodInfoPtr_get_isDriving_Private_get_Boolean_0;

		// Token: 0x04002D71 RID: 11633
		private static readonly IntPtr NativeMethodInfoPtr_get_Agent_Private_get_VehicleAgent_0;

		// Token: 0x04002D72 RID: 11634
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04002D73 RID: 11635
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_1;

		// Token: 0x04002D74 RID: 11636
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_1;

		// Token: 0x04002D75 RID: 11637
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_1;

		// Token: 0x04002D76 RID: 11638
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_1;

		// Token: 0x04002D77 RID: 11639
		private static readonly IntPtr NativeMethodInfoPtr_SetRoute_Public_Void_VehiclePatrolRoute_0;

		// Token: 0x04002D78 RID: 11640
		private static readonly IntPtr NativeMethodInfoPtr_StartPatrol_Private_Void_0;

		// Token: 0x04002D79 RID: 11641
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002D7A RID: 11642
		private static readonly IntPtr NativeMethodInfoPtr_DriveTo_Private_Void_Vector3_0;

		// Token: 0x04002D7B RID: 11643
		private static readonly IntPtr NativeMethodInfoPtr_NavigationCallback_Private_Void_ENavigationResult_0;

		// Token: 0x04002D7C RID: 11644
		private static readonly IntPtr NativeMethodInfoPtr_IsAsCloseAsPossible_Private_Boolean_Vector3_byref_Vector3_0;

		// Token: 0x04002D7D RID: 11645
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002D7E RID: 11646
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002D7F RID: 11647
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002D80 RID: 11648
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002D81 RID: 11649
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;
	}
}
