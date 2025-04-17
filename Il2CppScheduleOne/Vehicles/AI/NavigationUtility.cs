using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppPathfinding;
using Il2CppScheduleOne.Math;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.AI
{
	// Token: 0x020004FE RID: 1278
	public class NavigationUtility : Il2CppSystem.Object
	{
		// Token: 0x060070CC RID: 28876 RVA: 0x001EF694 File Offset: 0x001ED894
		// Note: this type is marked as 'beforefieldinit'.
		static NavigationUtility()
		{
			Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.AI", "NavigationUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr);
			NavigationUtility.NativeFieldInfoPtr_ROAD_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "ROAD_MULTIPLIER");
			NavigationUtility.NativeFieldInfoPtr_OFFROAD_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "OFFROAD_MULTIPLIER");
			NavigationUtility.NativeMethodInfoPtr_CalculatePath_Public_Static_Coroutine_Vector3_Vector3_NavigationSettings_DriveFlags_Seeker_Seeker_NavigationCalculationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100677459);
			NavigationUtility.NativeMethodInfoPtr_AdjustExitPoint_Private_Static_Void_PathGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100677460);
			NavigationUtility.NativeMethodInfoPtr_AdjustEntryPoint_Private_Static_Void_PathGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100677461);
			NavigationUtility.NativeMethodInfoPtr_DoesCloseDistanceExist_Private_Static_Boolean_List_1_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100677462);
			NavigationUtility.NativeMethodInfoPtr_GenerateNavigationGroup_Private_Static_IEnumerator_Vector3_Vector3_NodeLink_Vector3_Vector3_Seeker_Seeker_PathGroupEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100677463);
			NavigationUtility.NativeMethodInfoPtr_DrawPath_Public_Static_Void_PathGroup_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100677464);
			NavigationUtility.NativeMethodInfoPtr_GetSmoothedPath_Private_Static_SmoothedPath_PathGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100677465);
			NavigationUtility.NativeMethodInfoPtr_SampleVehicleGraph_Public_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100677466);
			NavigationUtility.NativeMethodInfoPtr_GetClosestPointOnFiniteLine_Public_Static_Vector3_Vector3_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100677467);
			NavigationUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, 100677468);
		}

		// Token: 0x060070CD RID: 28877 RVA: 0x001EF7B4 File Offset: 0x001ED9B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221883, XrefRangeEnd = 221903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Coroutine CalculatePath(Vector3 startPosition, Vector3 destination, NavigationSettings navSettings, DriveFlags flags, Seeker generalSeeker, Seeker roadSeeker, NavigationUtility.NavigationCalculationCallback callback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startPosition;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(navSettings);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(flags);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generalSeeker);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(roadSeeker);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_CalculatePath_Public_Static_Coroutine_Vector3_Vector3_NavigationSettings_DriveFlags_Seeker_Seeker_NavigationCalculationCallback_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
		}

		// Token: 0x060070CE RID: 28878 RVA: 0x001EF860 File Offset: 0x001EDA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221903, XrefRangeEnd = 221939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AdjustExitPoint(PathGroup group)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_AdjustExitPoint_Private_Static_Void_PathGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070CF RID: 28879 RVA: 0x001EF898 File Offset: 0x001EDA98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221939, XrefRangeEnd = 221958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void AdjustEntryPoint(PathGroup group)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_AdjustEntryPoint_Private_Static_Void_PathGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070D0 RID: 28880 RVA: 0x001EF8D0 File Offset: 0x001EDAD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221958, XrefRangeEnd = 221973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool DoesCloseDistanceExist(List<Vector3> vectorList, Vector3 point, float thresholdDistance)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vectorList);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref point;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref thresholdDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_DoesCloseDistanceExist_Private_Static_Boolean_List_1_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060070D1 RID: 28881 RVA: 0x001EF930 File Offset: 0x001EDB30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221973, XrefRangeEnd = 221981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator GenerateNavigationGroup(Vector3 startPoint, Vector3 entryPoint, NodeLink exitLink, Vector3 exitPoint, Vector3 destination, Seeker generalSeeker, Seeker roadSeeker, NavigationUtility.PathGroupEvent callback)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref startPoint;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref entryPoint;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exitLink);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exitPoint;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref destination;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(generalSeeker);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(roadSeeker);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_GenerateNavigationGroup_Private_Static_IEnumerator_Vector3_Vector3_NodeLink_Vector3_Vector3_Seeker_Seeker_PathGroupEvent_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060070D2 RID: 28882 RVA: 0x001EF9E8 File Offset: 0x001EDBE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221981, XrefRangeEnd = 222015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawPath(PathGroup group, float duration = 10f)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_DrawPath_Public_Static_Void_PathGroup_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070D3 RID: 28883 RVA: 0x001EFA2C File Offset: 0x001EDC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222015, XrefRangeEnd = 222030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PathSmoothingUtility.SmoothedPath GetSmoothedPath(PathGroup group)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_GetSmoothedPath_Private_Static_SmoothedPath_PathGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PathSmoothingUtility.SmoothedPath>(intPtr3) : null;
		}

		// Token: 0x060070D4 RID: 28884 RVA: 0x001EFA70 File Offset: 0x001EDC70
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 222042, RefRangeEnd = 222044, XrefRangeStart = 222030, XrefRangeEnd = 222042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 SampleVehicleGraph(Vector3 destination)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref destination;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_SampleVehicleGraph_Public_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060070D5 RID: 28885 RVA: 0x001EFAB0 File Offset: 0x001EDCB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 222047, RefRangeEnd = 222048, XrefRangeStart = 222044, XrefRangeEnd = 222047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetClosestPointOnFiniteLine(Vector3 point, Vector3 line_start, Vector3 line_end)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line_start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line_end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr_GetClosestPointOnFiniteLine_Public_Static_Vector3_Vector3_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060070D6 RID: 28886 RVA: 0x001EFB0C File Offset: 0x001EDD0C
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NavigationUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070D7 RID: 28887 RVA: 0x00035930 File Offset: 0x00033B30
		public NavigationUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002219 RID: 8729
		// (get) Token: 0x060070D8 RID: 28888 RVA: 0x001EFB48 File Offset: 0x001EDD48
		// (set) Token: 0x060070D9 RID: 28889 RVA: 0x00035939 File Offset: 0x00033B39
		public unsafe static float ROAD_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NavigationUtility.NativeFieldInfoPtr_ROAD_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavigationUtility.NativeFieldInfoPtr_ROAD_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x1700221A RID: 8730
		// (get) Token: 0x060070DA RID: 28890 RVA: 0x001EFB64 File Offset: 0x001EDD64
		// (set) Token: 0x060070DB RID: 28891 RVA: 0x00035947 File Offset: 0x00033B47
		public unsafe static float OFFROAD_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NavigationUtility.NativeFieldInfoPtr_OFFROAD_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NavigationUtility.NativeFieldInfoPtr_OFFROAD_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x04004D0F RID: 19727
		private static readonly IntPtr NativeFieldInfoPtr_ROAD_MULTIPLIER;

		// Token: 0x04004D10 RID: 19728
		private static readonly IntPtr NativeFieldInfoPtr_OFFROAD_MULTIPLIER;

		// Token: 0x04004D11 RID: 19729
		private static readonly IntPtr NativeMethodInfoPtr_CalculatePath_Public_Static_Coroutine_Vector3_Vector3_NavigationSettings_DriveFlags_Seeker_Seeker_NavigationCalculationCallback_0;

		// Token: 0x04004D12 RID: 19730
		private static readonly IntPtr NativeMethodInfoPtr_AdjustExitPoint_Private_Static_Void_PathGroup_0;

		// Token: 0x04004D13 RID: 19731
		private static readonly IntPtr NativeMethodInfoPtr_AdjustEntryPoint_Private_Static_Void_PathGroup_0;

		// Token: 0x04004D14 RID: 19732
		private static readonly IntPtr NativeMethodInfoPtr_DoesCloseDistanceExist_Private_Static_Boolean_List_1_Vector3_Vector3_Single_0;

		// Token: 0x04004D15 RID: 19733
		private static readonly IntPtr NativeMethodInfoPtr_GenerateNavigationGroup_Private_Static_IEnumerator_Vector3_Vector3_NodeLink_Vector3_Vector3_Seeker_Seeker_PathGroupEvent_0;

		// Token: 0x04004D16 RID: 19734
		private static readonly IntPtr NativeMethodInfoPtr_DrawPath_Public_Static_Void_PathGroup_Single_0;

		// Token: 0x04004D17 RID: 19735
		private static readonly IntPtr NativeMethodInfoPtr_GetSmoothedPath_Private_Static_SmoothedPath_PathGroup_0;

		// Token: 0x04004D18 RID: 19736
		private static readonly IntPtr NativeMethodInfoPtr_SampleVehicleGraph_Public_Static_Vector3_Vector3_0;

		// Token: 0x04004D19 RID: 19737
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestPointOnFiniteLine_Public_Static_Vector3_Vector3_Vector3_Vector3_0;

		// Token: 0x04004D1A RID: 19738
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A71 RID: 2673
		[OriginalName("Assembly-CSharp.dll", "", "ENavigationCalculationResult")]
		public enum ENavigationCalculationResult
		{
			// Token: 0x04008D2E RID: 36142
			Success,
			// Token: 0x04008D2F RID: 36143
			Failed
		}

		// Token: 0x02000A72 RID: 2674
		public sealed class NavigationCalculationCallback : MulticastDelegate
		{
			// Token: 0x0600D140 RID: 53568 RVA: 0x00321FB0 File Offset: 0x003201B0
			// Note: this type is marked as 'beforefieldinit'.
			static NavigationCalculationCallback()
			{
				Il2CppClassPointerStore<NavigationUtility.NavigationCalculationCallback>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "NavigationCalculationCallback");
				NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.NavigationCalculationCallback>.NativeClassPtr, 100677469);
				NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ENavigationCalculationResult_SmoothedPath_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.NavigationCalculationCallback>.NativeClassPtr, 100677470);
				NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ENavigationCalculationResult_SmoothedPath_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.NavigationCalculationCallback>.NativeClassPtr, 100677471);
				NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.NavigationCalculationCallback>.NativeClassPtr, 100677472);
			}

			// Token: 0x0600D141 RID: 53569 RVA: 0x00322024 File Offset: 0x00320224
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 221716, RefRangeEnd = 221735, XrefRangeStart = 221713, XrefRangeEnd = 221716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NavigationCalculationCallback(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility.NavigationCalculationCallback>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D142 RID: 53570 RVA: 0x00322080 File Offset: 0x00320280
			[CallerCount(0)]
			public unsafe void Invoke(NavigationUtility.ENavigationCalculationResult result, PathSmoothingUtility.SmoothedPath path)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref result;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ENavigationCalculationResult_SmoothedPath_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D143 RID: 53571 RVA: 0x003220D0 File Offset: 0x003202D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221735, XrefRangeEnd = 221739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(NavigationUtility.ENavigationCalculationResult result, PathSmoothingUtility.SmoothedPath path, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref result;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(path);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ENavigationCalculationResult_SmoothedPath_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600D144 RID: 53572 RVA: 0x00322154 File Offset: 0x00320354
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22498, RefRangeEnd = 22499, XrefRangeStart = 22498, XrefRangeEnd = 22499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.NavigationCalculationCallback.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D145 RID: 53573 RVA: 0x00065DF8 File Offset: 0x00063FF8
			public NavigationCalculationCallback(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D146 RID: 53574 RVA: 0x00065E01 File Offset: 0x00064001
			public static implicit operator NavigationUtility.NavigationCalculationCallback(Action<NavigationUtility.ENavigationCalculationResult, PathSmoothingUtility.SmoothedPath> A_0)
			{
				return DelegateSupport.ConvertDelegate<NavigationUtility.NavigationCalculationCallback>(A_0);
			}

			// Token: 0x0600D147 RID: 53575 RVA: 0x00065E09 File Offset: 0x00064009
			public static NavigationUtility.NavigationCalculationCallback operator +(NavigationUtility.NavigationCalculationCallback A_0, NavigationUtility.NavigationCalculationCallback A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<NavigationUtility.NavigationCalculationCallback>();
			}

			// Token: 0x0600D148 RID: 53576 RVA: 0x00065E17 File Offset: 0x00064017
			public static NavigationUtility.NavigationCalculationCallback operator -(NavigationUtility.NavigationCalculationCallback A_0, NavigationUtility.NavigationCalculationCallback A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<NavigationUtility.NavigationCalculationCallback>();
				}
				return result;
			}

			// Token: 0x04008D30 RID: 36144
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008D31 RID: 36145
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ENavigationCalculationResult_SmoothedPath_0;

			// Token: 0x04008D32 RID: 36146
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ENavigationCalculationResult_SmoothedPath_AsyncCallback_Object_0;

			// Token: 0x04008D33 RID: 36147
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000A73 RID: 2675
		public sealed class PathGroupEvent : MulticastDelegate
		{
			// Token: 0x0600D149 RID: 53577 RVA: 0x00322198 File Offset: 0x00320398
			// Note: this type is marked as 'beforefieldinit'.
			static PathGroupEvent()
			{
				Il2CppClassPointerStore<NavigationUtility.PathGroupEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "PathGroupEvent");
				NavigationUtility.PathGroupEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.PathGroupEvent>.NativeClassPtr, 100677473);
				NavigationUtility.PathGroupEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PathGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.PathGroupEvent>.NativeClassPtr, 100677474);
				NavigationUtility.PathGroupEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PathGroup_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.PathGroupEvent>.NativeClassPtr, 100677475);
				NavigationUtility.PathGroupEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.PathGroupEvent>.NativeClassPtr, 100677476);
			}

			// Token: 0x0600D14A RID: 53578 RVA: 0x0032220C File Offset: 0x0032040C
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 106407, RefRangeEnd = 106486, XrefRangeStart = 106407, XrefRangeEnd = 106486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PathGroupEvent(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility.PathGroupEvent>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.PathGroupEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D14B RID: 53579 RVA: 0x00322268 File Offset: 0x00320468
			[CallerCount(0)]
			public unsafe void Invoke(PathGroup calculatedGroup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(calculatedGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.PathGroupEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PathGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D14C RID: 53580 RVA: 0x003222AC File Offset: 0x003204AC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74821, RefRangeEnd = 74822, XrefRangeStart = 74821, XrefRangeEnd = 74822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(PathGroup calculatedGroup, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(calculatedGroup);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.PathGroupEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PathGroup_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600D14D RID: 53581 RVA: 0x00322320 File Offset: 0x00320520
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22498, RefRangeEnd = 22499, XrefRangeStart = 22498, XrefRangeEnd = 22499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.PathGroupEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D14E RID: 53582 RVA: 0x00065E28 File Offset: 0x00064028
			public PathGroupEvent(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D14F RID: 53583 RVA: 0x00065E31 File Offset: 0x00064031
			public static implicit operator NavigationUtility.PathGroupEvent(Action<PathGroup> A_0)
			{
				return DelegateSupport.ConvertDelegate<NavigationUtility.PathGroupEvent>(A_0);
			}

			// Token: 0x0600D150 RID: 53584 RVA: 0x00065E39 File Offset: 0x00064039
			public static NavigationUtility.PathGroupEvent operator +(NavigationUtility.PathGroupEvent A_0, NavigationUtility.PathGroupEvent A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<NavigationUtility.PathGroupEvent>();
			}

			// Token: 0x0600D151 RID: 53585 RVA: 0x00065E47 File Offset: 0x00064047
			public static NavigationUtility.PathGroupEvent operator -(NavigationUtility.PathGroupEvent A_0, NavigationUtility.PathGroupEvent A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<NavigationUtility.PathGroupEvent>();
				}
				return result;
			}

			// Token: 0x04008D34 RID: 36148
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008D35 RID: 36149
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_PathGroup_0;

			// Token: 0x04008D36 RID: 36150
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_PathGroup_AsyncCallback_Object_0;

			// Token: 0x04008D37 RID: 36151
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000A74 RID: 2676
		[ObfuscatedName("ScheduleOne.Vehicles.AI.NavigationUtility+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D152 RID: 53586 RVA: 0x00322364 File Offset: 0x00320564
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NavigationUtility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationUtility.__c>.NativeClassPtr);
				NavigationUtility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c>.NativeClassPtr, "<>9");
				NavigationUtility.__c.NativeFieldInfoPtr___9__5_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c>.NativeClassPtr, "<>9__5_5");
				NavigationUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c>.NativeClassPtr, 100677478);
				NavigationUtility.__c.NativeMethodInfoPtr__CalculatePath_b__5_5_Internal_Single_PathGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c>.NativeClassPtr, 100677479);
			}

			// Token: 0x0600D153 RID: 53587 RVA: 0x003223E0 File Offset: 0x003205E0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D154 RID: 53588 RVA: 0x0032241C File Offset: 0x0032061C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221739, XrefRangeEnd = 221744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _CalculatePath_b__5_5(PathGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c.NativeMethodInfoPtr__CalculatePath_b__5_5_Internal_Single_PathGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D155 RID: 53589 RVA: 0x00065E58 File Offset: 0x00064058
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040F8 RID: 16632
			// (get) Token: 0x0600D156 RID: 53590 RVA: 0x0032246C File Offset: 0x0032066C
			// (set) Token: 0x0600D157 RID: 53591 RVA: 0x00065E61 File Offset: 0x00064061
			public unsafe static NavigationUtility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NavigationUtility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationUtility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NavigationUtility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040F9 RID: 16633
			// (get) Token: 0x0600D158 RID: 53592 RVA: 0x00322494 File Offset: 0x00320694
			// (set) Token: 0x0600D159 RID: 53593 RVA: 0x00065E73 File Offset: 0x00064073
			public unsafe static Func<PathGroup, float> __9__5_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NavigationUtility.__c.NativeFieldInfoPtr___9__5_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PathGroup, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NavigationUtility.__c.NativeFieldInfoPtr___9__5_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D38 RID: 36152
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008D39 RID: 36153
			private static readonly IntPtr NativeFieldInfoPtr___9__5_5;

			// Token: 0x04008D3A RID: 36154
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D3B RID: 36155
			private static readonly IntPtr NativeMethodInfoPtr__CalculatePath_b__5_5_Internal_Single_PathGroup_0;
		}

		// Token: 0x02000A75 RID: 2677
		[ObfuscatedName("ScheduleOne.Vehicles.AI.NavigationUtility+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D15A RID: 53594 RVA: 0x003224BC File Offset: 0x003206BC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr);
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_lastCalculatedPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "lastCalculatedPath");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_lastGeneratedPathGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "lastGeneratedPathGroup");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_pathGroupGenerated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "pathGroupGenerated");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "flags");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_startPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "startPosition");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "destination");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_generalSeeker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "generalSeeker");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_roadSeeker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "roadSeeker");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_navSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "navSettings");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "callback");
				NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "<>9__4");
				NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, 100677480);
				NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_Void_Path_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, 100677481);
				NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_Void_PathGroup_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, 100677482);
				NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, 100677483);
				NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__CalculatePath_b__4_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, 100677484);
				NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__CalculatePath_b__6_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, 100677485);
				NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__CalculatePath_b__3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, 100677486);
			}

			// Token: 0x0600D15B RID: 53595 RVA: 0x00322650 File Offset: 0x00320850
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D15C RID: 53596 RVA: 0x0032268C File Offset: 0x0032088C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29994, RefRangeEnd = 29996, XrefRangeStart = 29994, XrefRangeEnd = 29996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Path_0(Path p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_Void_Path_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D15D RID: 53597 RVA: 0x003226D0 File Offset: 0x003208D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221813, XrefRangeEnd = 221814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PathGroup_PDM_0(PathGroup pg)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_Void_PathGroup_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D15E RID: 53598 RVA: 0x00322714 File Offset: 0x00320914
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221814, XrefRangeEnd = 221819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D15F RID: 53599 RVA: 0x00322754 File Offset: 0x00320954
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CalculatePath_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__CalculatePath_b__4_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D160 RID: 53600 RVA: 0x00322790 File Offset: 0x00320990
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 221819, RefRangeEnd = 221836, XrefRangeStart = 221819, XrefRangeEnd = 221819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CalculatePath_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__CalculatePath_b__6_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D161 RID: 53601 RVA: 0x003227CC File Offset: 0x003209CC
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 221819, RefRangeEnd = 221836, XrefRangeStart = 221819, XrefRangeEnd = 221836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CalculatePath_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.NativeMethodInfoPtr__CalculatePath_b__3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D162 RID: 53602 RVA: 0x00065E85 File Offset: 0x00064085
			public __c__DisplayClass5_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040FA RID: 16634
			// (get) Token: 0x0600D163 RID: 53603 RVA: 0x00322808 File Offset: 0x00320A08
			// (set) Token: 0x0600D164 RID: 53604 RVA: 0x00065E8E File Offset: 0x0006408E
			public unsafe Path lastCalculatedPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_lastCalculatedPath);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_lastCalculatedPath), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040FB RID: 16635
			// (get) Token: 0x0600D165 RID: 53605 RVA: 0x00322838 File Offset: 0x00320A38
			// (set) Token: 0x0600D166 RID: 53606 RVA: 0x00065EAD File Offset: 0x000640AD
			public unsafe PathGroup lastGeneratedPathGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_lastGeneratedPathGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_lastGeneratedPathGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040FC RID: 16636
			// (get) Token: 0x0600D167 RID: 53607 RVA: 0x00322868 File Offset: 0x00320A68
			// (set) Token: 0x0600D168 RID: 53608 RVA: 0x00065ECC File Offset: 0x000640CC
			public unsafe bool pathGroupGenerated
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_pathGroupGenerated);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_pathGroupGenerated)) = value;
				}
			}

			// Token: 0x170040FD RID: 16637
			// (get) Token: 0x0600D169 RID: 53609 RVA: 0x00322890 File Offset: 0x00320A90
			// (set) Token: 0x0600D16A RID: 53610 RVA: 0x00065EE7 File Offset: 0x000640E7
			public unsafe DriveFlags flags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_flags);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DriveFlags>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_flags), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040FE RID: 16638
			// (get) Token: 0x0600D16B RID: 53611 RVA: 0x003228C0 File Offset: 0x00320AC0
			// (set) Token: 0x0600D16C RID: 53612 RVA: 0x00065F06 File Offset: 0x00064106
			public unsafe Vector3 startPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_startPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_startPosition)) = value;
				}
			}

			// Token: 0x170040FF RID: 16639
			// (get) Token: 0x0600D16D RID: 53613 RVA: 0x003228E8 File Offset: 0x00320AE8
			// (set) Token: 0x0600D16E RID: 53614 RVA: 0x00065F21 File Offset: 0x00064121
			public unsafe Vector3 destination
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_destination);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_destination)) = value;
				}
			}

			// Token: 0x17004100 RID: 16640
			// (get) Token: 0x0600D16F RID: 53615 RVA: 0x00322910 File Offset: 0x00320B10
			// (set) Token: 0x0600D170 RID: 53616 RVA: 0x00065F3C File Offset: 0x0006413C
			public unsafe Seeker generalSeeker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_generalSeeker);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Seeker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_generalSeeker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004101 RID: 16641
			// (get) Token: 0x0600D171 RID: 53617 RVA: 0x00322940 File Offset: 0x00320B40
			// (set) Token: 0x0600D172 RID: 53618 RVA: 0x00065F5B File Offset: 0x0006415B
			public unsafe Seeker roadSeeker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_roadSeeker);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Seeker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_roadSeeker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004102 RID: 16642
			// (get) Token: 0x0600D173 RID: 53619 RVA: 0x00322970 File Offset: 0x00320B70
			// (set) Token: 0x0600D174 RID: 53620 RVA: 0x00065F7A File Offset: 0x0006417A
			public unsafe NavigationSettings navSettings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_navSettings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_navSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004103 RID: 16643
			// (get) Token: 0x0600D175 RID: 53621 RVA: 0x003229A0 File Offset: 0x00320BA0
			// (set) Token: 0x0600D176 RID: 53622 RVA: 0x00065F99 File Offset: 0x00064199
			public unsafe NavigationUtility.NavigationCalculationCallback callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationUtility.NavigationCalculationCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004104 RID: 16644
			// (get) Token: 0x0600D177 RID: 53623 RVA: 0x003229D0 File Offset: 0x00320BD0
			// (set) Token: 0x0600D178 RID: 53624 RVA: 0x00065FB8 File Offset: 0x000641B8
			public unsafe Func<bool> __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D3C RID: 36156
			private static readonly IntPtr NativeFieldInfoPtr_lastCalculatedPath;

			// Token: 0x04008D3D RID: 36157
			private static readonly IntPtr NativeFieldInfoPtr_lastGeneratedPathGroup;

			// Token: 0x04008D3E RID: 36158
			private static readonly IntPtr NativeFieldInfoPtr_pathGroupGenerated;

			// Token: 0x04008D3F RID: 36159
			private static readonly IntPtr NativeFieldInfoPtr_flags;

			// Token: 0x04008D40 RID: 36160
			private static readonly IntPtr NativeFieldInfoPtr_startPosition;

			// Token: 0x04008D41 RID: 36161
			private static readonly IntPtr NativeFieldInfoPtr_destination;

			// Token: 0x04008D42 RID: 36162
			private static readonly IntPtr NativeFieldInfoPtr_generalSeeker;

			// Token: 0x04008D43 RID: 36163
			private static readonly IntPtr NativeFieldInfoPtr_roadSeeker;

			// Token: 0x04008D44 RID: 36164
			private static readonly IntPtr NativeFieldInfoPtr_navSettings;

			// Token: 0x04008D45 RID: 36165
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04008D46 RID: 36166
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x04008D47 RID: 36167
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D48 RID: 36168
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Path_0;

			// Token: 0x04008D49 RID: 36169
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PathGroup_PDM_0;

			// Token: 0x04008D4A RID: 36170
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008D4B RID: 36171
			private static readonly IntPtr NativeMethodInfoPtr__CalculatePath_b__4_Internal_Boolean_0;

			// Token: 0x04008D4C RID: 36172
			private static readonly IntPtr NativeMethodInfoPtr__CalculatePath_b__6_Internal_Boolean_0;

			// Token: 0x04008D4D RID: 36173
			private static readonly IntPtr NativeMethodInfoPtr__CalculatePath_b__3_Internal_Boolean_0;

			// Token: 0x02000C60 RID: 3168
			[ObfuscatedName("ScheduleOne.Vehicles.AI.NavigationUtility+<>c__DisplayClass5_0+<<CalculatePath>g__Routine|2>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E3FD RID: 58365 RVA: 0x00357B6C File Offset: 0x00355D6C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique()
				{
					Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0>.NativeClassPtr, "<<CalculatePath>g__Routine|2>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr);
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<>1__state");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<>2__current");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<>4__this");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__finalGroup_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<finalGroup>5__2");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__closestNodeLinks_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<closestNodeLinks>5__3");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__nodeLinksClosestToLocation_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<nodeLinksClosestToLocation>5__4");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__entryPointChecks_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<entryPointChecks>5__5");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__checkedEntryPoints_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<checkedEntryPoints>5__6");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__groups_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<groups>5__7");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__i_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<i>5__8");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__entryPoint_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<entryPoint>5__9");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__exitPointChecks_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<exitPointChecks>5__10");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__checkedExitPoints_5__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<checkedExitPoints>5__11");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__j_5__12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, "<j>5__12");
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, 100677487);
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, 100677488);
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, 100677489);
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, 100677490);
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, 100677491);
					NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr, 100677492);
				}

				// Token: 0x0600E3FE RID: 58366 RVA: 0x00357D28 File Offset: 0x00355F28
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E3FF RID: 58367 RVA: 0x00357D70 File Offset: 0x00355F70
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E400 RID: 58368 RVA: 0x00357DA4 File Offset: 0x00355FA4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221744, XrefRangeEnd = 221808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170046D4 RID: 18132
				// (get) Token: 0x0600E401 RID: 58369 RVA: 0x00357DE0 File Offset: 0x00355FE0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E402 RID: 58370 RVA: 0x00357E20 File Offset: 0x00356020
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221808, XrefRangeEnd = 221813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170046D5 RID: 18133
				// (get) Token: 0x0600E403 RID: 58371 RVA: 0x00357E54 File Offset: 0x00356054
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E404 RID: 58372 RVA: 0x0006F209 File Offset: 0x0006D409
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170046C6 RID: 18118
				// (get) Token: 0x0600E405 RID: 58373 RVA: 0x00357E94 File Offset: 0x00356094
				// (set) Token: 0x0600E406 RID: 58374 RVA: 0x0006F212 File Offset: 0x0006D412
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170046C7 RID: 18119
				// (get) Token: 0x0600E407 RID: 58375 RVA: 0x00357EBC File Offset: 0x003560BC
				// (set) Token: 0x0600E408 RID: 58376 RVA: 0x0006F22D File Offset: 0x0006D42D
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046C8 RID: 18120
				// (get) Token: 0x0600E409 RID: 58377 RVA: 0x00357EEC File Offset: 0x003560EC
				// (set) Token: 0x0600E40A RID: 58378 RVA: 0x0006F24C File Offset: 0x0006D44C
				public unsafe NavigationUtility.__c__DisplayClass5_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationUtility.__c__DisplayClass5_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046C9 RID: 18121
				// (get) Token: 0x0600E40B RID: 58379 RVA: 0x00357F1C File Offset: 0x0035611C
				// (set) Token: 0x0600E40C RID: 58380 RVA: 0x0006F26B File Offset: 0x0006D46B
				public unsafe PathGroup _finalGroup_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__finalGroup_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PathGroup>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__finalGroup_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046CA RID: 18122
				// (get) Token: 0x0600E40D RID: 58381 RVA: 0x00357F4C File Offset: 0x0035614C
				// (set) Token: 0x0600E40E RID: 58382 RVA: 0x0006F28A File Offset: 0x0006D48A
				public unsafe List<NodeLink> _closestNodeLinks_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__closestNodeLinks_5__3);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NodeLink>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__closestNodeLinks_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046CB RID: 18123
				// (get) Token: 0x0600E40F RID: 58383 RVA: 0x00357F7C File Offset: 0x0035617C
				// (set) Token: 0x0600E410 RID: 58384 RVA: 0x0006F2A9 File Offset: 0x0006D4A9
				public unsafe List<NodeLink> _nodeLinksClosestToLocation_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__nodeLinksClosestToLocation_5__4);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NodeLink>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__nodeLinksClosestToLocation_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046CC RID: 18124
				// (get) Token: 0x0600E411 RID: 58385 RVA: 0x00357FAC File Offset: 0x003561AC
				// (set) Token: 0x0600E412 RID: 58386 RVA: 0x0006F2C8 File Offset: 0x0006D4C8
				public unsafe int _entryPointChecks_5__5
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__entryPointChecks_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__entryPointChecks_5__5)) = value;
					}
				}

				// Token: 0x170046CD RID: 18125
				// (get) Token: 0x0600E413 RID: 58387 RVA: 0x00357FD4 File Offset: 0x003561D4
				// (set) Token: 0x0600E414 RID: 58388 RVA: 0x0006F2E3 File Offset: 0x0006D4E3
				public unsafe List<Vector3> _checkedEntryPoints_5__6
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__checkedEntryPoints_5__6);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__checkedEntryPoints_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046CE RID: 18126
				// (get) Token: 0x0600E415 RID: 58389 RVA: 0x00358004 File Offset: 0x00356204
				// (set) Token: 0x0600E416 RID: 58390 RVA: 0x0006F302 File Offset: 0x0006D502
				public unsafe List<PathGroup> _groups_5__7
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__groups_5__7);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PathGroup>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__groups_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046CF RID: 18127
				// (get) Token: 0x0600E417 RID: 58391 RVA: 0x00358034 File Offset: 0x00356234
				// (set) Token: 0x0600E418 RID: 58392 RVA: 0x0006F321 File Offset: 0x0006D521
				public unsafe int _i_5__8
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__i_5__8);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__i_5__8)) = value;
					}
				}

				// Token: 0x170046D0 RID: 18128
				// (get) Token: 0x0600E419 RID: 58393 RVA: 0x0035805C File Offset: 0x0035625C
				// (set) Token: 0x0600E41A RID: 58394 RVA: 0x0006F33C File Offset: 0x0006D53C
				public unsafe Vector3 _entryPoint_5__9
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__entryPoint_5__9);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__entryPoint_5__9)) = value;
					}
				}

				// Token: 0x170046D1 RID: 18129
				// (get) Token: 0x0600E41B RID: 58395 RVA: 0x00358084 File Offset: 0x00356284
				// (set) Token: 0x0600E41C RID: 58396 RVA: 0x0006F357 File Offset: 0x0006D557
				public unsafe int _exitPointChecks_5__10
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__exitPointChecks_5__10);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__exitPointChecks_5__10)) = value;
					}
				}

				// Token: 0x170046D2 RID: 18130
				// (get) Token: 0x0600E41D RID: 58397 RVA: 0x003580AC File Offset: 0x003562AC
				// (set) Token: 0x0600E41E RID: 58398 RVA: 0x0006F372 File Offset: 0x0006D572
				public unsafe List<Vector3> _checkedExitPoints_5__11
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__checkedExitPoints_5__11);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__checkedExitPoints_5__11), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170046D3 RID: 18131
				// (get) Token: 0x0600E41F RID: 58399 RVA: 0x003580DC File Offset: 0x003562DC
				// (set) Token: 0x0600E420 RID: 58400 RVA: 0x0006F391 File Offset: 0x0006D591
				public unsafe int _j_5__12
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__j_5__12);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPaLi1NoVeLi1NoUnique.NativeFieldInfoPtr__j_5__12)) = value;
					}
				}

				// Token: 0x04009888 RID: 39048
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009889 RID: 39049
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400988A RID: 39050
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400988B RID: 39051
				private static readonly IntPtr NativeFieldInfoPtr__finalGroup_5__2;

				// Token: 0x0400988C RID: 39052
				private static readonly IntPtr NativeFieldInfoPtr__closestNodeLinks_5__3;

				// Token: 0x0400988D RID: 39053
				private static readonly IntPtr NativeFieldInfoPtr__nodeLinksClosestToLocation_5__4;

				// Token: 0x0400988E RID: 39054
				private static readonly IntPtr NativeFieldInfoPtr__entryPointChecks_5__5;

				// Token: 0x0400988F RID: 39055
				private static readonly IntPtr NativeFieldInfoPtr__checkedEntryPoints_5__6;

				// Token: 0x04009890 RID: 39056
				private static readonly IntPtr NativeFieldInfoPtr__groups_5__7;

				// Token: 0x04009891 RID: 39057
				private static readonly IntPtr NativeFieldInfoPtr__i_5__8;

				// Token: 0x04009892 RID: 39058
				private static readonly IntPtr NativeFieldInfoPtr__entryPoint_5__9;

				// Token: 0x04009893 RID: 39059
				private static readonly IntPtr NativeFieldInfoPtr__exitPointChecks_5__10;

				// Token: 0x04009894 RID: 39060
				private static readonly IntPtr NativeFieldInfoPtr__checkedExitPoints_5__11;

				// Token: 0x04009895 RID: 39061
				private static readonly IntPtr NativeFieldInfoPtr__j_5__12;

				// Token: 0x04009896 RID: 39062
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009897 RID: 39063
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009898 RID: 39064
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009899 RID: 39065
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400989A RID: 39066
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400989B RID: 39067
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000A76 RID: 2678
		[ObfuscatedName("ScheduleOne.Vehicles.AI.NavigationUtility+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D179 RID: 53625 RVA: 0x00322A00 File Offset: 0x00320C00
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr);
				NavigationUtility.__c__DisplayClass9_0.NativeFieldInfoPtr_lastCalculatedPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr, "lastCalculatedPath");
				NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr, 100677493);
				NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_Void_Path_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr, 100677494);
				NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__GenerateNavigationGroup_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr, 100677495);
				NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__GenerateNavigationGroup_b__2_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr, 100677496);
				NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__GenerateNavigationGroup_b__3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr, 100677497);
			}

			// Token: 0x0600D17A RID: 53626 RVA: 0x00322AA4 File Offset: 0x00320CA4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D17B RID: 53627 RVA: 0x00322AE0 File Offset: 0x00320CE0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29994, RefRangeEnd = 29996, XrefRangeStart = 29994, XrefRangeEnd = 29996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Path_0(Path p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_Void_Path_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D17C RID: 53628 RVA: 0x00322B24 File Offset: 0x00320D24
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 221819, RefRangeEnd = 221836, XrefRangeStart = 221819, XrefRangeEnd = 221836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GenerateNavigationGroup_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__GenerateNavigationGroup_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D17D RID: 53629 RVA: 0x00322B60 File Offset: 0x00320D60
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 221819, RefRangeEnd = 221836, XrefRangeStart = 221819, XrefRangeEnd = 221836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GenerateNavigationGroup_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__GenerateNavigationGroup_b__2_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D17E RID: 53630 RVA: 0x00322B9C File Offset: 0x00320D9C
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 221819, RefRangeEnd = 221836, XrefRangeStart = 221819, XrefRangeEnd = 221836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GenerateNavigationGroup_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility.__c__DisplayClass9_0.NativeMethodInfoPtr__GenerateNavigationGroup_b__3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D17F RID: 53631 RVA: 0x00065FD7 File Offset: 0x000641D7
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004105 RID: 16645
			// (get) Token: 0x0600D180 RID: 53632 RVA: 0x00322BD8 File Offset: 0x00320DD8
			// (set) Token: 0x0600D181 RID: 53633 RVA: 0x00065FE0 File Offset: 0x000641E0
			public unsafe Path lastCalculatedPath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass9_0.NativeFieldInfoPtr_lastCalculatedPath);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility.__c__DisplayClass9_0.NativeFieldInfoPtr_lastCalculatedPath), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D4E RID: 36174
			private static readonly IntPtr NativeFieldInfoPtr_lastCalculatedPath;

			// Token: 0x04008D4F RID: 36175
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D50 RID: 36176
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Path_0;

			// Token: 0x04008D51 RID: 36177
			private static readonly IntPtr NativeMethodInfoPtr__GenerateNavigationGroup_b__1_Internal_Boolean_0;

			// Token: 0x04008D52 RID: 36178
			private static readonly IntPtr NativeMethodInfoPtr__GenerateNavigationGroup_b__2_Internal_Boolean_0;

			// Token: 0x04008D53 RID: 36179
			private static readonly IntPtr NativeMethodInfoPtr__GenerateNavigationGroup_b__3_Internal_Boolean_0;
		}

		// Token: 0x02000A77 RID: 2679
		[ObfuscatedName("ScheduleOne.Vehicles.AI.NavigationUtility+<GenerateNavigationGroup>d__9")]
		public sealed class _GenerateNavigationGroup_d__9 : Il2CppSystem.Object
		{
			// Token: 0x0600D182 RID: 53634 RVA: 0x00322C08 File Offset: 0x00320E08
			// Note: this type is marked as 'beforefieldinit'.
			static _GenerateNavigationGroup_d__9()
			{
				Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NavigationUtility>.NativeClassPtr, "<GenerateNavigationGroup>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr);
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "<>1__state");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "<>2__current");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_startPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "startPoint");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "destination");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_generalSeeker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "generalSeeker");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_entryPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "entryPoint");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "<>8__1");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "callback");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_roadSeeker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "roadSeeker");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_exitLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "exitLink");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_exitPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "exitPoint");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__destinationOnGraph_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "<destinationOnGraph>5__2");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__path_StartToEntry_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "<path_StartToEntry>5__3");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__path_EntryToExit_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, "<path_EntryToExit>5__4");
				NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, 100677498);
				NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, 100677499);
				NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, 100677500);
				NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, 100677501);
				NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, 100677502);
				NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr, 100677503);
			}

			// Token: 0x0600D183 RID: 53635 RVA: 0x00322DC4 File Offset: 0x00320FC4
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GenerateNavigationGroup_d__9(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NavigationUtility._GenerateNavigationGroup_d__9>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D184 RID: 53636 RVA: 0x00322E0C File Offset: 0x0032100C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D185 RID: 53637 RVA: 0x00322E40 File Offset: 0x00321040
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221836, XrefRangeEnd = 221878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004114 RID: 16660
			// (get) Token: 0x0600D186 RID: 53638 RVA: 0x00322E7C File Offset: 0x0032107C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D187 RID: 53639 RVA: 0x00322EBC File Offset: 0x003210BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221878, XrefRangeEnd = 221883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004115 RID: 16661
			// (get) Token: 0x0600D188 RID: 53640 RVA: 0x00322EF0 File Offset: 0x003210F0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NavigationUtility._GenerateNavigationGroup_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D189 RID: 53641 RVA: 0x00065FFF File Offset: 0x000641FF
			public _GenerateNavigationGroup_d__9(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004106 RID: 16646
			// (get) Token: 0x0600D18A RID: 53642 RVA: 0x00322F30 File Offset: 0x00321130
			// (set) Token: 0x0600D18B RID: 53643 RVA: 0x00066008 File Offset: 0x00064208
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004107 RID: 16647
			// (get) Token: 0x0600D18C RID: 53644 RVA: 0x00322F58 File Offset: 0x00321158
			// (set) Token: 0x0600D18D RID: 53645 RVA: 0x00066023 File Offset: 0x00064223
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004108 RID: 16648
			// (get) Token: 0x0600D18E RID: 53646 RVA: 0x00322F88 File Offset: 0x00321188
			// (set) Token: 0x0600D18F RID: 53647 RVA: 0x00066042 File Offset: 0x00064242
			public unsafe Vector3 startPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_startPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_startPoint)) = value;
				}
			}

			// Token: 0x17004109 RID: 16649
			// (get) Token: 0x0600D190 RID: 53648 RVA: 0x00322FB0 File Offset: 0x003211B0
			// (set) Token: 0x0600D191 RID: 53649 RVA: 0x0006605D File Offset: 0x0006425D
			public unsafe Vector3 destination
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_destination);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_destination)) = value;
				}
			}

			// Token: 0x1700410A RID: 16650
			// (get) Token: 0x0600D192 RID: 53650 RVA: 0x00322FD8 File Offset: 0x003211D8
			// (set) Token: 0x0600D193 RID: 53651 RVA: 0x00066078 File Offset: 0x00064278
			public unsafe Seeker generalSeeker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_generalSeeker);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Seeker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_generalSeeker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700410B RID: 16651
			// (get) Token: 0x0600D194 RID: 53652 RVA: 0x00323008 File Offset: 0x00321208
			// (set) Token: 0x0600D195 RID: 53653 RVA: 0x00066097 File Offset: 0x00064297
			public unsafe Vector3 entryPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_entryPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_entryPoint)) = value;
				}
			}

			// Token: 0x1700410C RID: 16652
			// (get) Token: 0x0600D196 RID: 53654 RVA: 0x00323030 File Offset: 0x00321230
			// (set) Token: 0x0600D197 RID: 53655 RVA: 0x000660B2 File Offset: 0x000642B2
			public unsafe NavigationUtility.__c__DisplayClass9_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationUtility.__c__DisplayClass9_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700410D RID: 16653
			// (get) Token: 0x0600D198 RID: 53656 RVA: 0x00323060 File Offset: 0x00321260
			// (set) Token: 0x0600D199 RID: 53657 RVA: 0x000660D1 File Offset: 0x000642D1
			public unsafe NavigationUtility.PathGroupEvent callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NavigationUtility.PathGroupEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700410E RID: 16654
			// (get) Token: 0x0600D19A RID: 53658 RVA: 0x00323090 File Offset: 0x00321290
			// (set) Token: 0x0600D19B RID: 53659 RVA: 0x000660F0 File Offset: 0x000642F0
			public unsafe Seeker roadSeeker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_roadSeeker);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Seeker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_roadSeeker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700410F RID: 16655
			// (get) Token: 0x0600D19C RID: 53660 RVA: 0x003230C0 File Offset: 0x003212C0
			// (set) Token: 0x0600D19D RID: 53661 RVA: 0x0006610F File Offset: 0x0006430F
			public unsafe NodeLink exitLink
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_exitLink);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NodeLink>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_exitLink), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004110 RID: 16656
			// (get) Token: 0x0600D19E RID: 53662 RVA: 0x003230F0 File Offset: 0x003212F0
			// (set) Token: 0x0600D19F RID: 53663 RVA: 0x0006612E File Offset: 0x0006432E
			public unsafe Vector3 exitPoint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_exitPoint);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr_exitPoint)) = value;
				}
			}

			// Token: 0x17004111 RID: 16657
			// (get) Token: 0x0600D1A0 RID: 53664 RVA: 0x00323118 File Offset: 0x00321318
			// (set) Token: 0x0600D1A1 RID: 53665 RVA: 0x00066149 File Offset: 0x00064349
			public unsafe Vector3 _destinationOnGraph_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__destinationOnGraph_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__destinationOnGraph_5__2)) = value;
				}
			}

			// Token: 0x17004112 RID: 16658
			// (get) Token: 0x0600D1A2 RID: 53666 RVA: 0x00323140 File Offset: 0x00321340
			// (set) Token: 0x0600D1A3 RID: 53667 RVA: 0x00066164 File Offset: 0x00064364
			public unsafe Path _path_StartToEntry_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__path_StartToEntry_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__path_StartToEntry_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004113 RID: 16659
			// (get) Token: 0x0600D1A4 RID: 53668 RVA: 0x00323170 File Offset: 0x00321370
			// (set) Token: 0x0600D1A5 RID: 53669 RVA: 0x00066183 File Offset: 0x00064383
			public unsafe Path _path_EntryToExit_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__path_EntryToExit_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Path>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NavigationUtility._GenerateNavigationGroup_d__9.NativeFieldInfoPtr__path_EntryToExit_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D54 RID: 36180
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008D55 RID: 36181
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008D56 RID: 36182
			private static readonly IntPtr NativeFieldInfoPtr_startPoint;

			// Token: 0x04008D57 RID: 36183
			private static readonly IntPtr NativeFieldInfoPtr_destination;

			// Token: 0x04008D58 RID: 36184
			private static readonly IntPtr NativeFieldInfoPtr_generalSeeker;

			// Token: 0x04008D59 RID: 36185
			private static readonly IntPtr NativeFieldInfoPtr_entryPoint;

			// Token: 0x04008D5A RID: 36186
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008D5B RID: 36187
			private static readonly IntPtr NativeFieldInfoPtr_callback;

			// Token: 0x04008D5C RID: 36188
			private static readonly IntPtr NativeFieldInfoPtr_roadSeeker;

			// Token: 0x04008D5D RID: 36189
			private static readonly IntPtr NativeFieldInfoPtr_exitLink;

			// Token: 0x04008D5E RID: 36190
			private static readonly IntPtr NativeFieldInfoPtr_exitPoint;

			// Token: 0x04008D5F RID: 36191
			private static readonly IntPtr NativeFieldInfoPtr__destinationOnGraph_5__2;

			// Token: 0x04008D60 RID: 36192
			private static readonly IntPtr NativeFieldInfoPtr__path_StartToEntry_5__3;

			// Token: 0x04008D61 RID: 36193
			private static readonly IntPtr NativeFieldInfoPtr__path_EntryToExit_5__4;

			// Token: 0x04008D62 RID: 36194
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008D63 RID: 36195
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D64 RID: 36196
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008D65 RID: 36197
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008D66 RID: 36198
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D67 RID: 36199
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
