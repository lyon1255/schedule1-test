using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000367 RID: 871
	public class VehiclePatrolRoute : MonoBehaviour
	{
		// Token: 0x060043F3 RID: 17395 RVA: 0x00150D34 File Offset: 0x0014EF34
		// Note: this type is marked as 'beforefieldinit'.
		static VehiclePatrolRoute()
		{
			Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "VehiclePatrolRoute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr);
			VehiclePatrolRoute.NativeFieldInfoPtr_RouteName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr, "RouteName");
			VehiclePatrolRoute.NativeFieldInfoPtr_Waypoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr, "Waypoints");
			VehiclePatrolRoute.NativeFieldInfoPtr_StartWaypointIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr, "StartWaypointIndex");
			VehiclePatrolRoute.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr, 100671607);
			VehiclePatrolRoute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr, 100671608);
		}

		// Token: 0x060043F4 RID: 17396 RVA: 0x00150DC8 File Offset: 0x0014EFC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154500, XrefRangeEnd = 154528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolRoute.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043F5 RID: 17397 RVA: 0x00150DFC File Offset: 0x0014EFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154528, XrefRangeEnd = 154533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehiclePatrolRoute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehiclePatrolRoute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclePatrolRoute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043F6 RID: 17398 RVA: 0x000212EE File Offset: 0x0001F4EE
		public VehiclePatrolRoute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001488 RID: 5256
		// (get) Token: 0x060043F7 RID: 17399 RVA: 0x00150E38 File Offset: 0x0014F038
		// (set) Token: 0x060043F8 RID: 17400 RVA: 0x000212F7 File Offset: 0x0001F4F7
		public unsafe string RouteName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolRoute.NativeFieldInfoPtr_RouteName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolRoute.NativeFieldInfoPtr_RouteName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001489 RID: 5257
		// (get) Token: 0x060043F9 RID: 17401 RVA: 0x00150E60 File Offset: 0x0014F060
		// (set) Token: 0x060043FA RID: 17402 RVA: 0x00021316 File Offset: 0x0001F516
		public unsafe Il2CppReferenceArray<Transform> Waypoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolRoute.NativeFieldInfoPtr_Waypoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolRoute.NativeFieldInfoPtr_Waypoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700148A RID: 5258
		// (get) Token: 0x060043FB RID: 17403 RVA: 0x00150E90 File Offset: 0x0014F090
		// (set) Token: 0x060043FC RID: 17404 RVA: 0x00021335 File Offset: 0x0001F535
		public unsafe int StartWaypointIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolRoute.NativeFieldInfoPtr_StartWaypointIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehiclePatrolRoute.NativeFieldInfoPtr_StartWaypointIndex)) = value;
			}
		}

		// Token: 0x04002D82 RID: 11650
		private static readonly IntPtr NativeFieldInfoPtr_RouteName;

		// Token: 0x04002D83 RID: 11651
		private static readonly IntPtr NativeFieldInfoPtr_Waypoints;

		// Token: 0x04002D84 RID: 11652
		private static readonly IntPtr NativeFieldInfoPtr_StartWaypointIndex;

		// Token: 0x04002D85 RID: 11653
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04002D86 RID: 11654
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
