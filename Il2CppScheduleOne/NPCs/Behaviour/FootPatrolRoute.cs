using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000359 RID: 857
	public class FootPatrolRoute : MonoBehaviour
	{
		// Token: 0x060041DF RID: 16863 RVA: 0x00149A74 File Offset: 0x00147C74
		// Note: this type is marked as 'beforefieldinit'.
		static FootPatrolRoute()
		{
			Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "FootPatrolRoute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr);
			FootPatrolRoute.NativeFieldInfoPtr_RouteName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, "RouteName");
			FootPatrolRoute.NativeFieldInfoPtr_PathColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, "PathColor");
			FootPatrolRoute.NativeFieldInfoPtr_Waypoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, "Waypoints");
			FootPatrolRoute.NativeFieldInfoPtr_StartWaypointIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, "StartWaypointIndex");
			FootPatrolRoute.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, 100671317);
			FootPatrolRoute.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, 100671318);
			FootPatrolRoute.NativeMethodInfoPtr_UpdateWaypoints_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, 100671319);
			FootPatrolRoute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr, 100671320);
		}

		// Token: 0x060041E0 RID: 16864 RVA: 0x00149B44 File Offset: 0x00147D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151805, XrefRangeEnd = 151833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolRoute.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041E1 RID: 16865 RVA: 0x00149B78 File Offset: 0x00147D78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151833, XrefRangeEnd = 151844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolRoute.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041E2 RID: 16866 RVA: 0x00149BAC File Offset: 0x00147DAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateWaypoints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolRoute.NativeMethodInfoPtr_UpdateWaypoints_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041E3 RID: 16867 RVA: 0x00149BE0 File Offset: 0x00147DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 151844, XrefRangeEnd = 151849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootPatrolRoute() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootPatrolRoute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolRoute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041E4 RID: 16868 RVA: 0x000205AF File Offset: 0x0001E7AF
		public FootPatrolRoute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170013FF RID: 5119
		// (get) Token: 0x060041E5 RID: 16869 RVA: 0x00149C1C File Offset: 0x00147E1C
		// (set) Token: 0x060041E6 RID: 16870 RVA: 0x000205B8 File Offset: 0x0001E7B8
		public unsafe string RouteName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_RouteName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_RouteName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001400 RID: 5120
		// (get) Token: 0x060041E7 RID: 16871 RVA: 0x00149C44 File Offset: 0x00147E44
		// (set) Token: 0x060041E8 RID: 16872 RVA: 0x000205D7 File Offset: 0x0001E7D7
		public unsafe Color PathColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_PathColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_PathColor)) = value;
			}
		}

		// Token: 0x17001401 RID: 5121
		// (get) Token: 0x060041E9 RID: 16873 RVA: 0x00149C6C File Offset: 0x00147E6C
		// (set) Token: 0x060041EA RID: 16874 RVA: 0x000205F2 File Offset: 0x0001E7F2
		public unsafe Il2CppReferenceArray<Transform> Waypoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_Waypoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_Waypoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001402 RID: 5122
		// (get) Token: 0x060041EB RID: 16875 RVA: 0x00149C9C File Offset: 0x00147E9C
		// (set) Token: 0x060041EC RID: 16876 RVA: 0x00020611 File Offset: 0x0001E811
		public unsafe int StartWaypointIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_StartWaypointIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolRoute.NativeFieldInfoPtr_StartWaypointIndex)) = value;
			}
		}

		// Token: 0x04002C07 RID: 11271
		private static readonly IntPtr NativeFieldInfoPtr_RouteName;

		// Token: 0x04002C08 RID: 11272
		private static readonly IntPtr NativeFieldInfoPtr_PathColor;

		// Token: 0x04002C09 RID: 11273
		private static readonly IntPtr NativeFieldInfoPtr_Waypoints;

		// Token: 0x04002C0A RID: 11274
		private static readonly IntPtr NativeFieldInfoPtr_StartWaypointIndex;

		// Token: 0x04002C0B RID: 11275
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04002C0C RID: 11276
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04002C0D RID: 11277
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWaypoints_Private_Void_0;

		// Token: 0x04002C0E RID: 11278
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
