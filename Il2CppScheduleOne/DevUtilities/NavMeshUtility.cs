using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.NPCs;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200045C RID: 1116
	public static class NavMeshUtility : Il2CppSystem.Object
	{
		// Token: 0x060060E0 RID: 24800 RVA: 0x001BA860 File Offset: 0x001B8A60
		// Note: this type is marked as 'beforefieldinit'.
		static NavMeshUtility()
		{
			Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "NavMeshUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr);
			NavMeshUtility.NativeFieldInfoPtr_SAMPLE_MAX_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, "SAMPLE_MAX_DISTANCE");
			NavMeshUtility.NativeFieldInfoPtr_SampleCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, "SampleCache");
			NavMeshUtility.NativeFieldInfoPtr_sampleCacheKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, "sampleCacheKeys");
			NavMeshUtility.NativeFieldInfoPtr_SAMPLE_CACHE_MAX_SQR_DIST = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, "SAMPLE_CACHE_MAX_SQR_DIST");
			NavMeshUtility.NativeFieldInfoPtr_MAX_CACHE_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, "MAX_CACHE_SIZE");
			NavMeshUtility.NativeMethodInfoPtr_GetPathLength_Public_Static_Single_NavMeshPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, 100675621);
			NavMeshUtility.NativeMethodInfoPtr_GetAccessPoint_Public_Static_Transform_ITransitEntity_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, 100675622);
			NavMeshUtility.NativeMethodInfoPtr_IsAtTransitEntity_Public_Static_Boolean_ITransitEntity_NPC_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, 100675623);
			NavMeshUtility.NativeMethodInfoPtr_GetNavMeshAgentID_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, 100675624);
			NavMeshUtility.NativeMethodInfoPtr_SamplePosition_Public_Static_Boolean_Vector3_byref_NavMeshHit_Single_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, 100675625);
			NavMeshUtility.NativeMethodInfoPtr_Quantize_Private_Static_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, 100675626);
			NavMeshUtility.NativeMethodInfoPtr_ClearCache_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavMeshUtility>.NativeClassPtr, 100675627);
		}

		// Token: 0x060060E1 RID: 24801 RVA: 0x001BA980 File Offset: 0x001B8B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199489, XrefRangeEnd = 199498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetPathLength(NavMeshPath path)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavMeshUtility.NativeMethodInfoPtr_GetPathLength_Public_Static_Single_NavMeshPath_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060E2 RID: 24802 RVA: 0x001BA9C4 File Offset: 0x001B8BC4
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 199536, RefRangeEnd = 199561, XrefRangeStart = 199498, XrefRangeEnd = 199536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Transform GetAccessPoint(ITransitEntity entity, NPC npc)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavMeshUtility.NativeMethodInfoPtr_GetAccessPoint_Public_Static_Transform_ITransitEntity_NPC_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
		}

		// Token: 0x060060E3 RID: 24803 RVA: 0x001BAA1C File Offset: 0x001B8C1C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 199582, RefRangeEnd = 199587, XrefRangeStart = 199561, XrefRangeEnd = 199582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAtTransitEntity(ITransitEntity entity, NPC npc, float distanceThreshold = 0.4f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entity);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(npc);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distanceThreshold;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavMeshUtility.NativeMethodInfoPtr_IsAtTransitEntity_Public_Static_Boolean_ITransitEntity_NPC_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060E4 RID: 24804 RVA: 0x001BAA80 File Offset: 0x001B8C80
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 199593, RefRangeEnd = 199596, XrefRangeStart = 199587, XrefRangeEnd = 199593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetNavMeshAgentID(string name)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavMeshUtility.NativeMethodInfoPtr_GetNavMeshAgentID_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060E5 RID: 24805 RVA: 0x001BAAC4 File Offset: 0x001B8CC4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 199620, RefRangeEnd = 199628, XrefRangeStart = 199596, XrefRangeEnd = 199620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SamplePosition(Vector3 sourcePosition, out NavMeshHit hit, float maxDistance, int areaMask, bool useCache = true)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sourcePosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &hit;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref areaMask;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useCache;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavMeshUtility.NativeMethodInfoPtr_SamplePosition_Public_Static_Boolean_Vector3_byref_NavMeshHit_Single_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060E6 RID: 24806 RVA: 0x001BAB3C File Offset: 0x001B8D3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199628, XrefRangeEnd = 199631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Quantize(Vector3 position, float precision = 0.1f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref precision;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavMeshUtility.NativeMethodInfoPtr_Quantize_Private_Static_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060E7 RID: 24807 RVA: 0x001BAB88 File Offset: 0x001B8D88
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199640, RefRangeEnd = 199641, XrefRangeStart = 199631, XrefRangeEnd = 199640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearCache()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavMeshUtility.NativeMethodInfoPtr_ClearCache_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060E8 RID: 24808 RVA: 0x0002DCA9 File Offset: 0x0002BEA9
		public NavMeshUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D23 RID: 7459
		// (get) Token: 0x060060E9 RID: 24809 RVA: 0x001BABB0 File Offset: 0x001B8DB0
		// (set) Token: 0x060060EA RID: 24810 RVA: 0x0002DCB2 File Offset: 0x0002BEB2
		public unsafe static float SAMPLE_MAX_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NavMeshUtility.NativeFieldInfoPtr_SAMPLE_MAX_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavMeshUtility.NativeFieldInfoPtr_SAMPLE_MAX_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17001D24 RID: 7460
		// (get) Token: 0x060060EB RID: 24811 RVA: 0x001BABCC File Offset: 0x001B8DCC
		// (set) Token: 0x060060EC RID: 24812 RVA: 0x0002DCC0 File Offset: 0x0002BEC0
		public unsafe static Dictionary<Vector3, Vector3> SampleCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NavMeshUtility.NativeFieldInfoPtr_SampleCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Vector3, Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavMeshUtility.NativeFieldInfoPtr_SampleCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D25 RID: 7461
		// (get) Token: 0x060060ED RID: 24813 RVA: 0x001BABF4 File Offset: 0x001B8DF4
		// (set) Token: 0x060060EE RID: 24814 RVA: 0x0002DCD2 File Offset: 0x0002BED2
		public unsafe static List<Vector3> sampleCacheKeys
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NavMeshUtility.NativeFieldInfoPtr_sampleCacheKeys, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavMeshUtility.NativeFieldInfoPtr_sampleCacheKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D26 RID: 7462
		// (get) Token: 0x060060EF RID: 24815 RVA: 0x001BAC1C File Offset: 0x001B8E1C
		// (set) Token: 0x060060F0 RID: 24816 RVA: 0x0002DCE4 File Offset: 0x0002BEE4
		public unsafe static float SAMPLE_CACHE_MAX_SQR_DIST
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NavMeshUtility.NativeFieldInfoPtr_SAMPLE_CACHE_MAX_SQR_DIST, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavMeshUtility.NativeFieldInfoPtr_SAMPLE_CACHE_MAX_SQR_DIST, (void*)(&value));
			}
		}

		// Token: 0x17001D27 RID: 7463
		// (get) Token: 0x060060F1 RID: 24817 RVA: 0x001BAC38 File Offset: 0x001B8E38
		// (set) Token: 0x060060F2 RID: 24818 RVA: 0x0002DCF2 File Offset: 0x0002BEF2
		public unsafe static float MAX_CACHE_SIZE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NavMeshUtility.NativeFieldInfoPtr_MAX_CACHE_SIZE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavMeshUtility.NativeFieldInfoPtr_MAX_CACHE_SIZE, (void*)(&value));
			}
		}

		// Token: 0x0400421F RID: 16927
		private static readonly IntPtr NativeFieldInfoPtr_SAMPLE_MAX_DISTANCE;

		// Token: 0x04004220 RID: 16928
		private static readonly IntPtr NativeFieldInfoPtr_SampleCache;

		// Token: 0x04004221 RID: 16929
		private static readonly IntPtr NativeFieldInfoPtr_sampleCacheKeys;

		// Token: 0x04004222 RID: 16930
		private static readonly IntPtr NativeFieldInfoPtr_SAMPLE_CACHE_MAX_SQR_DIST;

		// Token: 0x04004223 RID: 16931
		private static readonly IntPtr NativeFieldInfoPtr_MAX_CACHE_SIZE;

		// Token: 0x04004224 RID: 16932
		private static readonly IntPtr NativeMethodInfoPtr_GetPathLength_Public_Static_Single_NavMeshPath_0;

		// Token: 0x04004225 RID: 16933
		private static readonly IntPtr NativeMethodInfoPtr_GetAccessPoint_Public_Static_Transform_ITransitEntity_NPC_0;

		// Token: 0x04004226 RID: 16934
		private static readonly IntPtr NativeMethodInfoPtr_IsAtTransitEntity_Public_Static_Boolean_ITransitEntity_NPC_Single_0;

		// Token: 0x04004227 RID: 16935
		private static readonly IntPtr NativeMethodInfoPtr_GetNavMeshAgentID_Public_Static_Int32_String_0;

		// Token: 0x04004228 RID: 16936
		private static readonly IntPtr NativeMethodInfoPtr_SamplePosition_Public_Static_Boolean_Vector3_byref_NavMeshHit_Single_Int32_Boolean_0;

		// Token: 0x04004229 RID: 16937
		private static readonly IntPtr NativeMethodInfoPtr_Quantize_Private_Static_Vector3_Vector3_Single_0;

		// Token: 0x0400422A RID: 16938
		private static readonly IntPtr NativeMethodInfoPtr_ClearCache_Public_Static_Void_0;
	}
}
