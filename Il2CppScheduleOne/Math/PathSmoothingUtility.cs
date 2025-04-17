using System;
using Il2CppFluffyUnderware.Curvy;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Math
{
	// Token: 0x02000378 RID: 888
	public class PathSmoothingUtility : MonoBehaviour
	{
		// Token: 0x060045BA RID: 17850 RVA: 0x00157560 File Offset: 0x00155760
		// Note: this type is marked as 'beforefieldinit'.
		static PathSmoothingUtility()
		{
			Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Math", "PathSmoothingUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr);
			PathSmoothingUtility.NativeFieldInfoPtr_MinControlPointDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, "MinControlPointDistance");
			PathSmoothingUtility.NativeFieldInfoPtr_spline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, "spline");
			PathSmoothingUtility.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, 100671874);
			PathSmoothingUtility.NativeMethodInfoPtr_CalculateSmoothedPath_Public_Static_SmoothedPath_List_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, 100671875);
			PathSmoothingUtility.NativeMethodInfoPtr_DrawPath_Public_Static_Void_SmoothedPath_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, 100671876);
			PathSmoothingUtility.NativeMethodInfoPtr_InsertIntermediatePoints_Private_Static_List_1_Vector3_List_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, 100671877);
			PathSmoothingUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, 100671878);
		}

		// Token: 0x060045BB RID: 17851 RVA: 0x0015761C File Offset: 0x0015581C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157570, XrefRangeEnd = 157588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathSmoothingUtility.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045BC RID: 17852 RVA: 0x00157650 File Offset: 0x00155850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157637, RefRangeEnd = 157638, XrefRangeStart = 157588, XrefRangeEnd = 157637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PathSmoothingUtility.SmoothedPath CalculateSmoothedPath(List<Vector3> controlPoints, float maxCPDistance = 5f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(controlPoints);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxCPDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathSmoothingUtility.NativeMethodInfoPtr_CalculateSmoothedPath_Public_Static_SmoothedPath_List_1_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PathSmoothingUtility.SmoothedPath>(intPtr3) : null;
		}

		// Token: 0x060045BD RID: 17853 RVA: 0x001576A4 File Offset: 0x001558A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157638, XrefRangeEnd = 157649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawPath(PathSmoothingUtility.SmoothedPath path, Color col, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(path);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathSmoothingUtility.NativeMethodInfoPtr_DrawPath_Public_Static_Void_SmoothedPath_Color_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045BE RID: 17854 RVA: 0x001576F8 File Offset: 0x001558F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157666, RefRangeEnd = 157667, XrefRangeStart = 157649, XrefRangeEnd = 157666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Vector3> InsertIntermediatePoints(List<Vector3> points, float maxDistance)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(points);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathSmoothingUtility.NativeMethodInfoPtr_InsertIntermediatePoints_Private_Static_List_1_Vector3_List_1_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr3) : null;
		}

		// Token: 0x060045BF RID: 17855 RVA: 0x0015774C File Offset: 0x0015594C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PathSmoothingUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathSmoothingUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045C0 RID: 17856 RVA: 0x00021F35 File Offset: 0x00020135
		public PathSmoothingUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700150A RID: 5386
		// (get) Token: 0x060045C1 RID: 17857 RVA: 0x00157788 File Offset: 0x00155988
		// (set) Token: 0x060045C2 RID: 17858 RVA: 0x00021F3E File Offset: 0x0002013E
		public unsafe static float MinControlPointDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PathSmoothingUtility.NativeFieldInfoPtr_MinControlPointDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PathSmoothingUtility.NativeFieldInfoPtr_MinControlPointDistance, (void*)(&value));
			}
		}

		// Token: 0x1700150B RID: 5387
		// (get) Token: 0x060045C3 RID: 17859 RVA: 0x001577A4 File Offset: 0x001559A4
		// (set) Token: 0x060045C4 RID: 17860 RVA: 0x00021F4C File Offset: 0x0002014C
		public unsafe static CurvySpline spline
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PathSmoothingUtility.NativeFieldInfoPtr_spline, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CurvySpline>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PathSmoothingUtility.NativeFieldInfoPtr_spline, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002EC6 RID: 11974
		private static readonly IntPtr NativeFieldInfoPtr_MinControlPointDistance;

		// Token: 0x04002EC7 RID: 11975
		private static readonly IntPtr NativeFieldInfoPtr_spline;

		// Token: 0x04002EC8 RID: 11976
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04002EC9 RID: 11977
		private static readonly IntPtr NativeMethodInfoPtr_CalculateSmoothedPath_Public_Static_SmoothedPath_List_1_Vector3_Single_0;

		// Token: 0x04002ECA RID: 11978
		private static readonly IntPtr NativeMethodInfoPtr_DrawPath_Public_Static_Void_SmoothedPath_Color_Single_0;

		// Token: 0x04002ECB RID: 11979
		private static readonly IntPtr NativeMethodInfoPtr_InsertIntermediatePoints_Private_Static_List_1_Vector3_List_1_Vector3_Single_0;

		// Token: 0x04002ECC RID: 11980
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000974 RID: 2420
		public class SmoothedPath : Il2CppSystem.Object
		{
			// Token: 0x0600C9A0 RID: 51616 RVA: 0x0030CD34 File Offset: 0x0030AF34
			// Note: this type is marked as 'beforefieldinit'.
			static SmoothedPath()
			{
				Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PathSmoothingUtility>.NativeClassPtr, "SmoothedPath");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr);
				PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_MARGIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr, "MARGIN");
				PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_vectorPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr, "vectorPath");
				PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_segmentBounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr, "segmentBounds");
				PathSmoothingUtility.SmoothedPath.NativeMethodInfoPtr_InitializePath_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr, 100671879);
				PathSmoothingUtility.SmoothedPath.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr, 100671880);
			}

			// Token: 0x0600C9A1 RID: 51617 RVA: 0x0030CDC4 File Offset: 0x0030AFC4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 157552, RefRangeEnd = 157553, XrefRangeStart = 157533, XrefRangeEnd = 157552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void InitializePath()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathSmoothingUtility.SmoothedPath.NativeMethodInfoPtr_InitializePath_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C9A2 RID: 51618 RVA: 0x0030CDF8 File Offset: 0x0030AFF8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 157568, RefRangeEnd = 157570, XrefRangeStart = 157553, XrefRangeEnd = 157568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SmoothedPath() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PathSmoothingUtility.SmoothedPath>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PathSmoothingUtility.SmoothedPath.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C9A3 RID: 51619 RVA: 0x000620C2 File Offset: 0x000602C2
			public SmoothedPath(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EDD RID: 16093
			// (get) Token: 0x0600C9A4 RID: 51620 RVA: 0x0030CE34 File Offset: 0x0030B034
			// (set) Token: 0x0600C9A5 RID: 51621 RVA: 0x000620CB File Offset: 0x000602CB
			public unsafe static float MARGIN
			{
				get
				{
					float result;
					IL2CPP.il2cpp_field_static_get_value(PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_MARGIN, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_MARGIN, (void*)(&value));
				}
			}

			// Token: 0x17003EDE RID: 16094
			// (get) Token: 0x0600C9A6 RID: 51622 RVA: 0x0030CE50 File Offset: 0x0030B050
			// (set) Token: 0x0600C9A7 RID: 51623 RVA: 0x000620D9 File Offset: 0x000602D9
			public unsafe List<Vector3> vectorPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_vectorPath);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_vectorPath), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EDF RID: 16095
			// (get) Token: 0x0600C9A8 RID: 51624 RVA: 0x0030CE80 File Offset: 0x0030B080
			// (set) Token: 0x0600C9A9 RID: 51625 RVA: 0x000620F8 File Offset: 0x000602F8
			public unsafe List<Bounds> segmentBounds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_segmentBounds);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Bounds>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PathSmoothingUtility.SmoothedPath.NativeFieldInfoPtr_segmentBounds), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008872 RID: 34930
			private static readonly IntPtr NativeFieldInfoPtr_MARGIN;

			// Token: 0x04008873 RID: 34931
			private static readonly IntPtr NativeFieldInfoPtr_vectorPath;

			// Token: 0x04008874 RID: 34932
			private static readonly IntPtr NativeFieldInfoPtr_segmentBounds;

			// Token: 0x04008875 RID: 34933
			private static readonly IntPtr NativeMethodInfoPtr_InitializePath_Public_Void_0;

			// Token: 0x04008876 RID: 34934
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
