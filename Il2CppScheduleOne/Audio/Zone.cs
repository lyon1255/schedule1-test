using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004DB RID: 1243
	public class Zone : MonoBehaviour
	{
		// Token: 0x06006C96 RID: 27798 RVA: 0x001E1CEC File Offset: 0x001DFEEC
		// Note: this type is marked as 'beforefieldinit'.
		static Zone()
		{
			Il2CppClassPointerStore<Zone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "Zone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Zone>.NativeClassPtr);
			Zone.NativeFieldInfoPtr_UPDATE_INTERVAL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone>.NativeClassPtr, "UPDATE_INTERVAL");
			Zone.NativeFieldInfoPtr_PointContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone>.NativeClassPtr, "PointContainer");
			Zone.NativeFieldInfoPtr_IsClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone>.NativeClassPtr, "IsClosed");
			Zone.NativeFieldInfoPtr_VerticalSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone>.NativeClassPtr, "VerticalSize");
			Zone.NativeFieldInfoPtr__LocalPlayerDistance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone>.NativeClassPtr, "<LocalPlayerDistance>k__BackingField");
			Zone.NativeFieldInfoPtr_ZoneColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone>.NativeClassPtr, "ZoneColor");
			Zone.NativeFieldInfoPtr_points = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone>.NativeClassPtr, "points");
			Zone.NativeMethodInfoPtr_get_LocalPlayerDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677019);
			Zone.NativeMethodInfoPtr_set_LocalPlayerDistance_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677020);
			Zone.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677021);
			Zone.NativeMethodInfoPtr_Recalculate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677022);
			Zone.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677023);
			Zone.NativeMethodInfoPtr_GetPoints_Private_Il2CppStructArray_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677024);
			Zone.NativeMethodInfoPtr_DoBoundsContainPoint_Private_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677025);
			Zone.NativeMethodInfoPtr_GetBoundingPoints_Private_Tuple_2_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677026);
			Zone.NativeMethodInfoPtr_IsPointInsidePolygon_Private_Boolean_Il2CppStructArray_1_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677027);
			Zone.NativeMethodInfoPtr_CalculateWindingNumber_Private_Int32_Il2CppStructArray_1_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677028);
			Zone.NativeMethodInfoPtr_GetClosestPointOnPolygon_Private_Vector3_Il2CppStructArray_1_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677029);
			Zone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677030);
			Zone.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Vector2_Vector2_Vector2_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677031);
			Zone.NativeMethodInfoPtr_Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677032);
			Zone.NativeMethodInfoPtr_Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677033);
			Zone.NativeMethodInfoPtr_Method_Internal_Static_Int32_Vector2_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677034);
			Zone.NativeMethodInfoPtr_Method_Internal_Static_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone>.NativeClassPtr, 100677035);
		}

		// Token: 0x170020AA RID: 8362
		// (get) Token: 0x06006C97 RID: 27799 RVA: 0x001E1EFC File Offset: 0x001E00FC
		// (set) Token: 0x06006C98 RID: 27800 RVA: 0x001E1F38 File Offset: 0x001E0138
		public unsafe float LocalPlayerDistance
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30020, RefRangeEnd = 30021, XrefRangeStart = 30020, XrefRangeEnd = 30021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_get_LocalPlayerDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 30021, RefRangeEnd = 30023, XrefRangeStart = 30021, XrefRangeEnd = 30023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_set_LocalPlayerDistance_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006C99 RID: 27801 RVA: 0x001E1F78 File Offset: 0x001E0178
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217008, XrefRangeEnd = 217013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C9A RID: 27802 RVA: 0x001E1FAC File Offset: 0x001E01AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217013, XrefRangeEnd = 217044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Recalculate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_Recalculate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C9B RID: 27803 RVA: 0x001E1FE0 File Offset: 0x001E01E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217044, XrefRangeEnd = 217066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C9C RID: 27804 RVA: 0x001E2014 File Offset: 0x001E0214
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 217078, RefRangeEnd = 217081, XrefRangeStart = 217066, XrefRangeEnd = 217078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<Vector3> GetPoints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_GetPoints_Private_Il2CppStructArray_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06006C9D RID: 27805 RVA: 0x001E2054 File Offset: 0x001E0254
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217081, XrefRangeEnd = 217084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DoBoundsContainPoint(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_DoBoundsContainPoint_Private_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006C9E RID: 27806 RVA: 0x001E20A0 File Offset: 0x001E02A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217158, RefRangeEnd = 217160, XrefRangeStart = 217084, XrefRangeEnd = 217158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tuple<Vector3, Vector3> GetBoundingPoints()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_GetBoundingPoints_Private_Tuple_2_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tuple<Vector3, Vector3>>(intPtr3) : null;
		}

		// Token: 0x06006C9F RID: 27807 RVA: 0x001E20E0 File Offset: 0x001E02E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217160, XrefRangeEnd = 217165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPointInsidePolygon(Il2CppStructArray<Vector3> polyPoints, Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(polyPoints);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_IsPointInsidePolygon_Private_Boolean_Il2CppStructArray_1_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CA0 RID: 27808 RVA: 0x001E213C File Offset: 0x001E033C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217169, RefRangeEnd = 217171, XrefRangeStart = 217165, XrefRangeEnd = 217169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CalculateWindingNumber(Il2CppStructArray<Vector2> polygon, Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(polygon);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_CalculateWindingNumber_Private_Int32_Il2CppStructArray_1_Vector2_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CA1 RID: 27809 RVA: 0x001E2198 File Offset: 0x001E0398
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 217186, RefRangeEnd = 217187, XrefRangeStart = 217171, XrefRangeEnd = 217186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetClosestPointOnPolygon(Il2CppStructArray<Vector3> polyPoints, Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(polyPoints);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_GetClosestPointOnPolygon_Private_Vector3_Il2CppStructArray_1_Vector3_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CA2 RID: 27810 RVA: 0x001E21F4 File Offset: 0x001E03F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217187, XrefRangeEnd = 217190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Zone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Zone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CA3 RID: 27811 RVA: 0x001E2230 File Offset: 0x001E0430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 217190, XrefRangeEnd = 217191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Method_Internal_Static_Boolean_Vector2_Vector2_Vector2_PDM_0(Vector2 start, Vector2 end, Vector2 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Vector2_Vector2_Vector2_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CA4 RID: 27812 RVA: 0x001E228C File Offset: 0x001E048C
		[CallerCount(0)]
		public unsafe static float Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_0(Vector2 start, Vector2 end, Vector2 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CA5 RID: 27813 RVA: 0x001E22E8 File Offset: 0x001E04E8
		[CallerCount(0)]
		public unsafe static float Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_1(Vector2 start, Vector2 end, Vector2 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_1, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CA6 RID: 27814 RVA: 0x001E2344 File Offset: 0x001E0544
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217191, RefRangeEnd = 217193, XrefRangeStart = 217191, XrefRangeEnd = 217191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Method_Internal_Static_Int32_Vector2_Vector2_Vector2_0(Vector2 start, Vector2 end, Vector2 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_Method_Internal_Static_Int32_Vector2_Vector2_Vector2_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CA7 RID: 27815 RVA: 0x001E23A0 File Offset: 0x001E05A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 217203, RefRangeEnd = 217205, XrefRangeStart = 217193, XrefRangeEnd = 217203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Method_Internal_Static_Vector3_Vector3_Vector3_Vector3_0(Vector3 lineStart, Vector3 lineEnd, Vector3 point)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lineStart;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineEnd;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.NativeMethodInfoPtr_Method_Internal_Static_Vector3_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006CA8 RID: 27816 RVA: 0x0003369D File Offset: 0x0003189D
		public Zone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020A3 RID: 8355
		// (get) Token: 0x06006CA9 RID: 27817 RVA: 0x001E23FC File Offset: 0x001E05FC
		// (set) Token: 0x06006CAA RID: 27818 RVA: 0x000336A6 File Offset: 0x000318A6
		public unsafe static float UPDATE_INTERVAL
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Zone.NativeFieldInfoPtr_UPDATE_INTERVAL, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Zone.NativeFieldInfoPtr_UPDATE_INTERVAL, (void*)(&value));
			}
		}

		// Token: 0x170020A4 RID: 8356
		// (get) Token: 0x06006CAB RID: 27819 RVA: 0x001E2418 File Offset: 0x001E0618
		// (set) Token: 0x06006CAC RID: 27820 RVA: 0x000336B4 File Offset: 0x000318B4
		public unsafe Transform PointContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr_PointContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr_PointContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020A5 RID: 8357
		// (get) Token: 0x06006CAD RID: 27821 RVA: 0x001E2448 File Offset: 0x001E0648
		// (set) Token: 0x06006CAE RID: 27822 RVA: 0x000336D3 File Offset: 0x000318D3
		public unsafe bool IsClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr_IsClosed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr_IsClosed)) = value;
			}
		}

		// Token: 0x170020A6 RID: 8358
		// (get) Token: 0x06006CAF RID: 27823 RVA: 0x001E2470 File Offset: 0x001E0670
		// (set) Token: 0x06006CB0 RID: 27824 RVA: 0x000336EE File Offset: 0x000318EE
		public unsafe float VerticalSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr_VerticalSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr_VerticalSize)) = value;
			}
		}

		// Token: 0x170020A7 RID: 8359
		// (get) Token: 0x06006CB1 RID: 27825 RVA: 0x001E2498 File Offset: 0x001E0698
		// (set) Token: 0x06006CB2 RID: 27826 RVA: 0x00033709 File Offset: 0x00031909
		public unsafe float _LocalPlayerDistance_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr__LocalPlayerDistance_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr__LocalPlayerDistance_k__BackingField)) = value;
			}
		}

		// Token: 0x170020A8 RID: 8360
		// (get) Token: 0x06006CB3 RID: 27827 RVA: 0x001E24C0 File Offset: 0x001E06C0
		// (set) Token: 0x06006CB4 RID: 27828 RVA: 0x00033724 File Offset: 0x00031924
		public unsafe Color ZoneColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr_ZoneColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr_ZoneColor)) = value;
			}
		}

		// Token: 0x170020A9 RID: 8361
		// (get) Token: 0x06006CB5 RID: 27829 RVA: 0x001E24E8 File Offset: 0x001E06E8
		// (set) Token: 0x06006CB6 RID: 27830 RVA: 0x0003373F File Offset: 0x0003193F
		public unsafe Il2CppStructArray<Vector3> points
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr_points);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Zone.NativeFieldInfoPtr_points), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004A38 RID: 19000
		private static readonly IntPtr NativeFieldInfoPtr_UPDATE_INTERVAL;

		// Token: 0x04004A39 RID: 19001
		private static readonly IntPtr NativeFieldInfoPtr_PointContainer;

		// Token: 0x04004A3A RID: 19002
		private static readonly IntPtr NativeFieldInfoPtr_IsClosed;

		// Token: 0x04004A3B RID: 19003
		private static readonly IntPtr NativeFieldInfoPtr_VerticalSize;

		// Token: 0x04004A3C RID: 19004
		private static readonly IntPtr NativeFieldInfoPtr__LocalPlayerDistance_k__BackingField;

		// Token: 0x04004A3D RID: 19005
		private static readonly IntPtr NativeFieldInfoPtr_ZoneColor;

		// Token: 0x04004A3E RID: 19006
		private static readonly IntPtr NativeFieldInfoPtr_points;

		// Token: 0x04004A3F RID: 19007
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalPlayerDistance_Public_get_Single_0;

		// Token: 0x04004A40 RID: 19008
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalPlayerDistance_Protected_set_Void_Single_0;

		// Token: 0x04004A41 RID: 19009
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004A42 RID: 19010
		private static readonly IntPtr NativeMethodInfoPtr_Recalculate_Public_Void_0;

		// Token: 0x04004A43 RID: 19011
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x04004A44 RID: 19012
		private static readonly IntPtr NativeMethodInfoPtr_GetPoints_Private_Il2CppStructArray_1_Vector3_0;

		// Token: 0x04004A45 RID: 19013
		private static readonly IntPtr NativeMethodInfoPtr_DoBoundsContainPoint_Private_Boolean_Vector3_0;

		// Token: 0x04004A46 RID: 19014
		private static readonly IntPtr NativeMethodInfoPtr_GetBoundingPoints_Private_Tuple_2_Vector3_Vector3_0;

		// Token: 0x04004A47 RID: 19015
		private static readonly IntPtr NativeMethodInfoPtr_IsPointInsidePolygon_Private_Boolean_Il2CppStructArray_1_Vector3_Vector3_0;

		// Token: 0x04004A48 RID: 19016
		private static readonly IntPtr NativeMethodInfoPtr_CalculateWindingNumber_Private_Int32_Il2CppStructArray_1_Vector2_Vector2_0;

		// Token: 0x04004A49 RID: 19017
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestPointOnPolygon_Private_Vector3_Il2CppStructArray_1_Vector3_Vector3_0;

		// Token: 0x04004A4A RID: 19018
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004A4B RID: 19019
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_Vector2_Vector2_Vector2_PDM_0;

		// Token: 0x04004A4C RID: 19020
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_0;

		// Token: 0x04004A4D RID: 19021
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Single_Vector2_Vector2_Vector2_PDM_1;

		// Token: 0x04004A4E RID: 19022
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Int32_Vector2_Vector2_Vector2_0;

		// Token: 0x04004A4F RID: 19023
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Vector3_Vector3_Vector3_Vector3_0;

		// Token: 0x02000A64 RID: 2660
		[ObfuscatedName("ScheduleOne.Audio.Zone+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D0D5 RID: 53461 RVA: 0x00320D48 File Offset: 0x0031EF48
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Zone.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Zone>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr);
				Zone.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr, "<>9");
				Zone.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr, "<>9__15_0");
				Zone.__c.NativeFieldInfoPtr___9__15_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr, "<>9__15_1");
				Zone.__c.NativeFieldInfoPtr___9__15_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr, "<>9__15_2");
				Zone.__c.NativeFieldInfoPtr___9__15_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr, "<>9__15_3");
				Zone.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr, 100677037);
				Zone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__15_0_Internal_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr, 100677038);
				Zone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__15_1_Internal_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr, 100677039);
				Zone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__15_2_Internal_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr, 100677040);
				Zone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__15_3_Internal_Single_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr, 100677041);
			}

			// Token: 0x0600D0D6 RID: 53462 RVA: 0x00320E3C File Offset: 0x0031F03C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Zone.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0D7 RID: 53463 RVA: 0x00320E78 File Offset: 0x0031F078
			[CallerCount(0)]
			public unsafe float _GetBoundingPoints_b__15_0(Vector3 p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__15_0_Internal_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D0D8 RID: 53464 RVA: 0x00320EC4 File Offset: 0x0031F0C4
			[CallerCount(0)]
			public unsafe float _GetBoundingPoints_b__15_1(Vector3 p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__15_1_Internal_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D0D9 RID: 53465 RVA: 0x00320F10 File Offset: 0x0031F110
			[CallerCount(0)]
			public unsafe float _GetBoundingPoints_b__15_2(Vector3 p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__15_2_Internal_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D0DA RID: 53466 RVA: 0x00320F5C File Offset: 0x0031F15C
			[CallerCount(0)]
			public unsafe float _GetBoundingPoints_b__15_3(Vector3 p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Zone.__c.NativeMethodInfoPtr__GetBoundingPoints_b__15_3_Internal_Single_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D0DB RID: 53467 RVA: 0x00065AED File Offset: 0x00063CED
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040DD RID: 16605
			// (get) Token: 0x0600D0DC RID: 53468 RVA: 0x00320FA8 File Offset: 0x0031F1A8
			// (set) Token: 0x0600D0DD RID: 53469 RVA: 0x00065AF6 File Offset: 0x00063CF6
			public unsafe static Zone.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Zone.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Zone.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Zone.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040DE RID: 16606
			// (get) Token: 0x0600D0DE RID: 53470 RVA: 0x00320FD0 File Offset: 0x0031F1D0
			// (set) Token: 0x0600D0DF RID: 53471 RVA: 0x00065B08 File Offset: 0x00063D08
			public unsafe static Func<Vector3, float> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Zone.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Zone.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040DF RID: 16607
			// (get) Token: 0x0600D0E0 RID: 53472 RVA: 0x00320FF8 File Offset: 0x0031F1F8
			// (set) Token: 0x0600D0E1 RID: 53473 RVA: 0x00065B1A File Offset: 0x00063D1A
			public unsafe static Func<Vector3, float> __9__15_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Zone.__c.NativeFieldInfoPtr___9__15_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Zone.__c.NativeFieldInfoPtr___9__15_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040E0 RID: 16608
			// (get) Token: 0x0600D0E2 RID: 53474 RVA: 0x00321020 File Offset: 0x0031F220
			// (set) Token: 0x0600D0E3 RID: 53475 RVA: 0x00065B2C File Offset: 0x00063D2C
			public unsafe static Func<Vector3, float> __9__15_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Zone.__c.NativeFieldInfoPtr___9__15_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Zone.__c.NativeFieldInfoPtr___9__15_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040E1 RID: 16609
			// (get) Token: 0x0600D0E4 RID: 53476 RVA: 0x00321048 File Offset: 0x0031F248
			// (set) Token: 0x0600D0E5 RID: 53477 RVA: 0x00065B3E File Offset: 0x00063D3E
			public unsafe static Func<Vector3, float> __9__15_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Zone.__c.NativeFieldInfoPtr___9__15_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Zone.__c.NativeFieldInfoPtr___9__15_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008CEF RID: 36079
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008CF0 RID: 36080
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x04008CF1 RID: 36081
			private static readonly IntPtr NativeFieldInfoPtr___9__15_1;

			// Token: 0x04008CF2 RID: 36082
			private static readonly IntPtr NativeFieldInfoPtr___9__15_2;

			// Token: 0x04008CF3 RID: 36083
			private static readonly IntPtr NativeFieldInfoPtr___9__15_3;

			// Token: 0x04008CF4 RID: 36084
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008CF5 RID: 36085
			private static readonly IntPtr NativeMethodInfoPtr__GetBoundingPoints_b__15_0_Internal_Single_Vector3_0;

			// Token: 0x04008CF6 RID: 36086
			private static readonly IntPtr NativeMethodInfoPtr__GetBoundingPoints_b__15_1_Internal_Single_Vector3_0;

			// Token: 0x04008CF7 RID: 36087
			private static readonly IntPtr NativeMethodInfoPtr__GetBoundingPoints_b__15_2_Internal_Single_Vector3_0;

			// Token: 0x04008CF8 RID: 36088
			private static readonly IntPtr NativeMethodInfoPtr__GetBoundingPoints_b__15_3_Internal_Single_Vector3_0;
		}
	}
}
