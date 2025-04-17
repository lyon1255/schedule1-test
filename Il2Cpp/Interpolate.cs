using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Il2Cpp
{
	// Token: 0x02000042 RID: 66
	public class Interpolate : Il2CppSystem.Object
	{
		// Token: 0x06000560 RID: 1376 RVA: 0x0007FCBC File Offset: 0x0007DEBC
		// Note: this type is marked as 'beforefieldinit'.
		static Interpolate()
		{
			Il2CppClassPointerStore<Interpolate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "Interpolate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interpolate>.NativeClassPtr);
			Interpolate.NativeMethodInfoPtr_Identity_Private_Static_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663745);
			Interpolate.NativeMethodInfoPtr_TransformDotPosition_Private_Static_Vector3_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663746);
			Interpolate.NativeMethodInfoPtr_NewTimer_Private_Static_IEnumerable_1_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663747);
			Interpolate.NativeMethodInfoPtr_NewCounter_Private_Static_IEnumerable_1_Single_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663748);
			Interpolate.NativeMethodInfoPtr_NewEase_Public_Static_IEnumerator_Function_Vector3_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663749);
			Interpolate.NativeMethodInfoPtr_NewEase_Public_Static_IEnumerator_Function_Vector3_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663750);
			Interpolate.NativeMethodInfoPtr_NewEase_Private_Static_IEnumerator_Function_Vector3_Vector3_Single_IEnumerable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663751);
			Interpolate.NativeMethodInfoPtr_Ease_Private_Static_Vector3_Function_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663752);
			Interpolate.NativeMethodInfoPtr_Ease_Public_Static_Function_EaseType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663753);
			Interpolate.NativeMethodInfoPtr_NewBezier_Public_Static_IEnumerable_1_Vector3_Function_Il2CppReferenceArray_1_Transform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663754);
			Interpolate.NativeMethodInfoPtr_NewBezier_Public_Static_IEnumerable_1_Vector3_Function_Il2CppReferenceArray_1_Transform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663755);
			Interpolate.NativeMethodInfoPtr_NewBezier_Public_Static_IEnumerable_1_Vector3_Function_Il2CppStructArray_1_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663756);
			Interpolate.NativeMethodInfoPtr_NewBezier_Public_Static_IEnumerable_1_Vector3_Function_Il2CppStructArray_1_Vector3_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663757);
			Interpolate.NativeMethodInfoPtr_NewBezier_Private_Static_IEnumerable_1_Vector3_Function_IList_ToVector3_1_T_Single_IEnumerable_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663758);
			Interpolate.NativeMethodInfoPtr_Bezier_Private_Static_Vector3_Function_Il2CppStructArray_1_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663759);
			Interpolate.NativeMethodInfoPtr_NewCatmullRom_Public_Static_IEnumerable_1_Vector3_Il2CppReferenceArray_1_Transform_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663760);
			Interpolate.NativeMethodInfoPtr_NewCatmullRom_Public_Static_IEnumerable_1_Vector3_Il2CppStructArray_1_Vector3_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663761);
			Interpolate.NativeMethodInfoPtr_NewCatmullRom_Private_Static_IEnumerable_1_Vector3_IList_ToVector3_1_T_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663762);
			Interpolate.NativeMethodInfoPtr_CatmullRom_Private_Static_Vector3_Vector3_Vector3_Vector3_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663763);
			Interpolate.NativeMethodInfoPtr_Linear_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663764);
			Interpolate.NativeMethodInfoPtr_EaseInQuad_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663765);
			Interpolate.NativeMethodInfoPtr_EaseOutQuad_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663766);
			Interpolate.NativeMethodInfoPtr_EaseInOutQuad_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663767);
			Interpolate.NativeMethodInfoPtr_EaseInCubic_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663768);
			Interpolate.NativeMethodInfoPtr_EaseOutCubic_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663769);
			Interpolate.NativeMethodInfoPtr_EaseInOutCubic_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663770);
			Interpolate.NativeMethodInfoPtr_EaseInQuart_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663771);
			Interpolate.NativeMethodInfoPtr_EaseOutQuart_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663772);
			Interpolate.NativeMethodInfoPtr_EaseInOutQuart_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663773);
			Interpolate.NativeMethodInfoPtr_EaseInQuint_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663774);
			Interpolate.NativeMethodInfoPtr_EaseOutQuint_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663775);
			Interpolate.NativeMethodInfoPtr_EaseInOutQuint_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663776);
			Interpolate.NativeMethodInfoPtr_EaseInSine_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663777);
			Interpolate.NativeMethodInfoPtr_EaseOutSine_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663778);
			Interpolate.NativeMethodInfoPtr_EaseInOutSine_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663779);
			Interpolate.NativeMethodInfoPtr_EaseInExpo_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663780);
			Interpolate.NativeMethodInfoPtr_EaseOutExpo_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663781);
			Interpolate.NativeMethodInfoPtr_EaseInOutExpo_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663782);
			Interpolate.NativeMethodInfoPtr_EaseInCirc_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663783);
			Interpolate.NativeMethodInfoPtr_EaseOutCirc_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663784);
			Interpolate.NativeMethodInfoPtr_EaseInOutCirc_Private_Static_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663785);
			Interpolate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, 100663786);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00080034 File Offset: 0x0007E234
		[CallerCount(0)]
		public unsafe static Vector3 Identity(Vector3 v)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_Identity_Private_Static_Vector3_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00080074 File Offset: 0x0007E274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75040, XrefRangeEnd = 75041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 TransformDotPosition(Transform t)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_TransformDotPosition_Private_Static_Vector3_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x000800B8 File Offset: 0x0007E2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75041, XrefRangeEnd = 75046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<float> NewTimer(float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_NewTimer_Private_Static_IEnumerable_1_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<float>>(intPtr3) : null;
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x000800F8 File Offset: 0x0007E2F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75046, XrefRangeEnd = 75051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<float> NewCounter(int start, int end, int step)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref step;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_NewCounter_Private_Static_IEnumerable_1_Single_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<float>>(intPtr3) : null;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00080154 File Offset: 0x0007E354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75051, XrefRangeEnd = 75062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator NewEase(Interpolate.Function ease, Vector3 start, Vector3 end, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ease);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_NewEase_Public_Static_IEnumerator_Function_Vector3_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x000801C4 File Offset: 0x0007E3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75062, XrefRangeEnd = 75073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator NewEase(Interpolate.Function ease, Vector3 start, Vector3 end, int slices)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ease);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slices;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_NewEase_Public_Static_IEnumerator_Function_Vector3_Vector3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00080234 File Offset: 0x0007E434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75073, XrefRangeEnd = 75079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator NewEase(Interpolate.Function ease, Vector3 start, Vector3 end, float total, IEnumerable<float> driver)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ease);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref total;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(driver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_NewEase_Private_Static_IEnumerator_Function_Vector3_Vector3_Single_IEnumerable_1_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x000802B8 File Offset: 0x0007E4B8
		[CallerCount(0)]
		public unsafe static Vector3 Ease(Interpolate.Function ease, Vector3 start, Vector3 distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ease);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_Ease_Private_Static_Vector3_Function_Vector3_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00080334 File Offset: 0x0007E534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75079, XrefRangeEnd = 75190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Interpolate.Function Ease(Interpolate.EaseType type)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_Ease_Public_Static_Function_EaseType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Interpolate.Function>(intPtr3) : null;
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00080374 File Offset: 0x0007E574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75190, XrefRangeEnd = 75204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Vector3> NewBezier(Interpolate.Function ease, Il2CppReferenceArray<Transform> nodes, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ease);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nodes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_NewBezier_Public_Static_IEnumerable_1_Vector3_Function_Il2CppReferenceArray_1_Transform_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Vector3>>(intPtr3) : null;
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x000803D8 File Offset: 0x0007E5D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75204, XrefRangeEnd = 75218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Vector3> NewBezier(Interpolate.Function ease, Il2CppReferenceArray<Transform> nodes, int slices)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ease);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nodes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slices;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_NewBezier_Public_Static_IEnumerable_1_Vector3_Function_Il2CppReferenceArray_1_Transform_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Vector3>>(intPtr3) : null;
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0008043C File Offset: 0x0007E63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75218, XrefRangeEnd = 75232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Vector3> NewBezier(Interpolate.Function ease, Il2CppStructArray<Vector3> points, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ease);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(points);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_NewBezier_Public_Static_IEnumerable_1_Vector3_Function_Il2CppStructArray_1_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Vector3>>(intPtr3) : null;
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x000804A0 File Offset: 0x0007E6A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75232, XrefRangeEnd = 75246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Vector3> NewBezier(Interpolate.Function ease, Il2CppStructArray<Vector3> points, int slices)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ease);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(points);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slices;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_NewBezier_Public_Static_IEnumerable_1_Vector3_Function_Il2CppStructArray_1_Vector3_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Vector3>>(intPtr3) : null;
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00080504 File Offset: 0x0007E704
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 75254, RefRangeEnd = 75258, XrefRangeStart = 75246, XrefRangeEnd = 75254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Vector3> NewBezier<T>(Interpolate.Function ease, IList nodes, Interpolate.ToVector3<T> toVector3, float maxStep, IEnumerable<float> steps)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ease);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nodes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toVector3);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxStep;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(steps);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.MethodInfoStoreGeneric_NewBezier_Private_Static_IEnumerable_1_Vector3_Function_IList_ToVector3_1_T_Single_IEnumerable_1_Single_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Vector3>>(intPtr3) : null;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00080590 File Offset: 0x0007E790
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75258, RefRangeEnd = 75259, XrefRangeStart = 75258, XrefRangeEnd = 75258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Bezier(Interpolate.Function ease, Il2CppStructArray<Vector3> points, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ease);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(points);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_Bezier_Private_Static_Vector3_Function_Il2CppStructArray_1_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00080600 File Offset: 0x0007E800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75259, XrefRangeEnd = 75268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Vector3> NewCatmullRom(Il2CppReferenceArray<Transform> nodes, int slices, bool loop)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(nodes);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slices;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_NewCatmullRom_Public_Static_IEnumerable_1_Vector3_Il2CppReferenceArray_1_Transform_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00080660 File Offset: 0x0007E860
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 75277, RefRangeEnd = 75279, XrefRangeStart = 75268, XrefRangeEnd = 75277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Vector3> NewCatmullRom(Il2CppStructArray<Vector3> points, int slices, bool loop)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(points);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slices;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_NewCatmullRom_Public_Static_IEnumerable_1_Vector3_Il2CppStructArray_1_Vector3_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x000806C0 File Offset: 0x0007E8C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 75285, RefRangeEnd = 75287, XrefRangeStart = 75279, XrefRangeEnd = 75285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<Vector3> NewCatmullRom<T>(IList nodes, Interpolate.ToVector3<T> toVector3, int slices, bool loop)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(nodes);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toVector3);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slices;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loop;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.MethodInfoStoreGeneric_NewCatmullRom_Private_Static_IEnumerable_1_Vector3_IList_ToVector3_1_T_Int32_Boolean_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Vector3>>(intPtr3) : null;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00080734 File Offset: 0x0007E934
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75287, RefRangeEnd = 75288, XrefRangeStart = 75287, XrefRangeEnd = 75287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 CatmullRom(Vector3 previous, Vector3 start, Vector3 end, Vector3 next, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref previous;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref next;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_CatmullRom_Private_Static_Vector3_Vector3_Vector3_Vector3_Vector3_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x000807B8 File Offset: 0x0007E9B8
		[CallerCount(0)]
		public unsafe static float Linear(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_Linear_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00080820 File Offset: 0x0007EA20
		[CallerCount(0)]
		public unsafe static float EaseInQuad(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseInQuad_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00080888 File Offset: 0x0007EA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75288, XrefRangeEnd = 75289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseOutQuad(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseOutQuad_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x000808F0 File Offset: 0x0007EAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75289, XrefRangeEnd = 75290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseInOutQuad(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseInOutQuad_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00080958 File Offset: 0x0007EB58
		[CallerCount(0)]
		public unsafe static float EaseInCubic(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseInCubic_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x000809C0 File Offset: 0x0007EBC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75290, XrefRangeEnd = 75291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseOutCubic(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseOutCubic_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00080A28 File Offset: 0x0007EC28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75291, XrefRangeEnd = 75292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseInOutCubic(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseInOutCubic_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00080A90 File Offset: 0x0007EC90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75292, XrefRangeEnd = 75293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseInQuart(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseInQuart_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00080AF8 File Offset: 0x0007ECF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75293, XrefRangeEnd = 75294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseOutQuart(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseOutQuart_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00080B60 File Offset: 0x0007ED60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75294, XrefRangeEnd = 75295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseInOutQuart(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseInOutQuart_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00080BC8 File Offset: 0x0007EDC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75295, XrefRangeEnd = 75296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseInQuint(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseInQuint_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00080C30 File Offset: 0x0007EE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75296, XrefRangeEnd = 75297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseOutQuint(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseOutQuint_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00080C98 File Offset: 0x0007EE98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75297, XrefRangeEnd = 75298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseInOutQuint(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseInOutQuint_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00080D00 File Offset: 0x0007EF00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75298, XrefRangeEnd = 75299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseInSine(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseInSine_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00080D68 File Offset: 0x0007EF68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75299, XrefRangeEnd = 75300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseOutSine(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseOutSine_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00080DD0 File Offset: 0x0007EFD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75300, XrefRangeEnd = 75301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseInOutSine(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseInOutSine_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00080E38 File Offset: 0x0007F038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75301, XrefRangeEnd = 75302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseInExpo(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseInExpo_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00080EA0 File Offset: 0x0007F0A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75302, XrefRangeEnd = 75303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseOutExpo(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseOutExpo_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00080F08 File Offset: 0x0007F108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75303, XrefRangeEnd = 75307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseInOutExpo(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseInOutExpo_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00080F70 File Offset: 0x0007F170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75307, XrefRangeEnd = 75310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseInCirc(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseInCirc_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00080FD8 File Offset: 0x0007F1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75310, XrefRangeEnd = 75313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseOutCirc(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseOutCirc_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00081040 File Offset: 0x0007F240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75313, XrefRangeEnd = 75319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float EaseInOutCirc(float start, float distance, float elapsedTime, float duration)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref start;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elapsedTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr_EaseInOutCirc_Private_Static_Single_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x000810A8 File Offset: 0x0007F2A8
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Interpolate() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Interpolate>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0000539F File Offset: 0x0000359F
		public Interpolate(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeMethodInfoPtr_Identity_Private_Static_Vector3_Vector3_0;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeMethodInfoPtr_TransformDotPosition_Private_Static_Vector3_Transform_0;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeMethodInfoPtr_NewTimer_Private_Static_IEnumerable_1_Single_Single_0;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeMethodInfoPtr_NewCounter_Private_Static_IEnumerable_1_Single_Int32_Int32_Int32_0;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeMethodInfoPtr_NewEase_Public_Static_IEnumerator_Function_Vector3_Vector3_Single_0;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeMethodInfoPtr_NewEase_Public_Static_IEnumerator_Function_Vector3_Vector3_Int32_0;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr_NewEase_Private_Static_IEnumerator_Function_Vector3_Vector3_Single_IEnumerable_1_Single_0;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeMethodInfoPtr_Ease_Private_Static_Vector3_Function_Vector3_Vector3_Single_Single_0;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeMethodInfoPtr_Ease_Public_Static_Function_EaseType_0;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeMethodInfoPtr_NewBezier_Public_Static_IEnumerable_1_Vector3_Function_Il2CppReferenceArray_1_Transform_Single_0;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeMethodInfoPtr_NewBezier_Public_Static_IEnumerable_1_Vector3_Function_Il2CppReferenceArray_1_Transform_Int32_0;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeMethodInfoPtr_NewBezier_Public_Static_IEnumerable_1_Vector3_Function_Il2CppStructArray_1_Vector3_Single_0;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeMethodInfoPtr_NewBezier_Public_Static_IEnumerable_1_Vector3_Function_Il2CppStructArray_1_Vector3_Int32_0;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeMethodInfoPtr_NewBezier_Private_Static_IEnumerable_1_Vector3_Function_IList_ToVector3_1_T_Single_IEnumerable_1_Single_0;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr_Bezier_Private_Static_Vector3_Function_Il2CppStructArray_1_Vector3_Single_Single_0;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeMethodInfoPtr_NewCatmullRom_Public_Static_IEnumerable_1_Vector3_Il2CppReferenceArray_1_Transform_Int32_Boolean_0;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeMethodInfoPtr_NewCatmullRom_Public_Static_IEnumerable_1_Vector3_Il2CppStructArray_1_Vector3_Int32_Boolean_0;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeMethodInfoPtr_NewCatmullRom_Private_Static_IEnumerable_1_Vector3_IList_ToVector3_1_T_Int32_Boolean_0;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeMethodInfoPtr_CatmullRom_Private_Static_Vector3_Vector3_Vector3_Vector3_Vector3_Single_Single_0;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeMethodInfoPtr_Linear_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeMethodInfoPtr_EaseInQuad_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr_EaseOutQuad_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr_EaseInOutQuad_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr_EaseInCubic_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_EaseOutCubic_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr_EaseInOutCubic_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeMethodInfoPtr_EaseInQuart_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeMethodInfoPtr_EaseOutQuart_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr_EaseInOutQuart_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr_EaseInQuint_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeMethodInfoPtr_EaseOutQuint_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeMethodInfoPtr_EaseInOutQuint_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeMethodInfoPtr_EaseInSine_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeMethodInfoPtr_EaseOutSine_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr_EaseInOutSine_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_EaseInExpo_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr_EaseOutExpo_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr_EaseInOutExpo_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr_EaseInCirc_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeMethodInfoPtr_EaseOutCirc_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr_EaseInOutCirc_Private_Static_Single_Single_Single_Single_Single_0;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007B6 RID: 1974
		[OriginalName("Assembly-CSharp.dll", "", "EaseType")]
		public enum EaseType
		{
			// Token: 0x04007D66 RID: 32102
			Linear,
			// Token: 0x04007D67 RID: 32103
			EaseInQuad,
			// Token: 0x04007D68 RID: 32104
			EaseOutQuad,
			// Token: 0x04007D69 RID: 32105
			EaseInOutQuad,
			// Token: 0x04007D6A RID: 32106
			EaseInCubic,
			// Token: 0x04007D6B RID: 32107
			EaseOutCubic,
			// Token: 0x04007D6C RID: 32108
			EaseInOutCubic,
			// Token: 0x04007D6D RID: 32109
			EaseInQuart,
			// Token: 0x04007D6E RID: 32110
			EaseOutQuart,
			// Token: 0x04007D6F RID: 32111
			EaseInOutQuart,
			// Token: 0x04007D70 RID: 32112
			EaseInQuint,
			// Token: 0x04007D71 RID: 32113
			EaseOutQuint,
			// Token: 0x04007D72 RID: 32114
			EaseInOutQuint,
			// Token: 0x04007D73 RID: 32115
			EaseInSine,
			// Token: 0x04007D74 RID: 32116
			EaseOutSine,
			// Token: 0x04007D75 RID: 32117
			EaseInOutSine,
			// Token: 0x04007D76 RID: 32118
			EaseInExpo,
			// Token: 0x04007D77 RID: 32119
			EaseOutExpo,
			// Token: 0x04007D78 RID: 32120
			EaseInOutExpo,
			// Token: 0x04007D79 RID: 32121
			EaseInCirc,
			// Token: 0x04007D7A RID: 32122
			EaseOutCirc,
			// Token: 0x04007D7B RID: 32123
			EaseInOutCirc
		}

		// Token: 0x020007B7 RID: 1975
		public sealed class ToVector3<T> : MulticastDelegate
		{
			// Token: 0x0600B9ED RID: 47597 RVA: 0x002E2040 File Offset: 0x002E0240
			// Note: this type is marked as 'beforefieldinit'.
			static ToVector3()
			{
				Il2CppClassPointerStore<Interpolate.ToVector3<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, "ToVector3`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				Interpolate.ToVector3<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate.ToVector3<T>>.NativeClassPtr, 100663787);
				Interpolate.ToVector3<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Vector3_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate.ToVector3<T>>.NativeClassPtr, 100663788);
				Interpolate.ToVector3<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate.ToVector3<T>>.NativeClassPtr, 100663789);
				Interpolate.ToVector3<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Vector3_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate.ToVector3<T>>.NativeClassPtr, 100663790);
			}

			// Token: 0x0600B9EE RID: 47598 RVA: 0x002E20EC File Offset: 0x002E02EC
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 74816, RefRangeEnd = 74820, XrefRangeStart = 74807, XrefRangeEnd = 74816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ToVector3(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Interpolate.ToVector3<T>>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.ToVector3<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9EF RID: 47599 RVA: 0x002E2148 File Offset: 0x002E0348
			[CallerCount(0)]
			public unsafe Vector3 Invoke(T v)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				IntPtr* ptr2 = ptr;
				T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = v;
					if (!(t is string))
					{
						ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
						if (ref ptr3 != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref v;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.ToVector3<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Vector3_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B9F0 RID: 47600 RVA: 0x002E21E0 File Offset: 0x002E03E0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74821, RefRangeEnd = 74822, XrefRangeStart = 74820, XrefRangeEnd = 74821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(T v, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				IntPtr* ptr2 = ptr;
				T ptr4;
				if (!typeof(T).IsValueType)
				{
					T t = v;
					if (!(t is string))
					{
						ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
						if (ref ptr3 != null)
						{
							ptr4 = ref ptr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
							{
								ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
							}
						}
					}
					else
					{
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr4 = ref v;
				}
				*ptr2 = ref ptr4;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.ToVector3<T>.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600B9F1 RID: 47601 RVA: 0x002E22A0 File Offset: 0x002E04A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74822, XrefRangeEnd = 74824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.ToVector3<T>.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Vector3_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B9F2 RID: 47602 RVA: 0x0005AE64 File Offset: 0x00059064
			public ToVector3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600B9F3 RID: 47603 RVA: 0x0005AE6D File Offset: 0x0005906D
			public static implicit operator Interpolate.ToVector3<T>(Func<T, Vector3> A_0)
			{
				return DelegateSupport.ConvertDelegate<Interpolate.ToVector3<T>>(A_0);
			}

			// Token: 0x0600B9F4 RID: 47604 RVA: 0x0005AE75 File Offset: 0x00059075
			public static Interpolate.ToVector3<T>operator +(Interpolate.ToVector3<T> A_0, Interpolate.ToVector3<T> A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Interpolate.ToVector3<T>>();
			}

			// Token: 0x0600B9F5 RID: 47605 RVA: 0x0005AE83 File Offset: 0x00059083
			public static Interpolate.ToVector3<T>operator -(Interpolate.ToVector3<T> A_0, Interpolate.ToVector3<T> A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<Interpolate.ToVector3<T>>();
				}
				return result;
			}

			// Token: 0x04007D7C RID: 32124
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04007D7D RID: 32125
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Vector3_T_0;

			// Token: 0x04007D7E RID: 32126
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_T_AsyncCallback_Object_0;

			// Token: 0x04007D7F RID: 32127
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Vector3_IAsyncResult_0;
		}

		// Token: 0x020007B8 RID: 1976
		public sealed class Function : MulticastDelegate
		{
			// Token: 0x0600B9F6 RID: 47606 RVA: 0x002E22F0 File Offset: 0x002E04F0
			// Note: this type is marked as 'beforefieldinit'.
			static Function()
			{
				Il2CppClassPointerStore<Interpolate.Function>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, "Function");
				Interpolate.Function.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate.Function>.NativeClassPtr, 100663791);
				Interpolate.Function.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate.Function>.NativeClassPtr, 100663792);
				Interpolate.Function.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Single_Single_Single_Single_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate.Function>.NativeClassPtr, 100663793);
				Interpolate.Function.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Single_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate.Function>.NativeClassPtr, 100663794);
			}

			// Token: 0x0600B9F7 RID: 47607 RVA: 0x002E2364 File Offset: 0x002E0564
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74827, RefRangeEnd = 74828, XrefRangeStart = 74824, XrefRangeEnd = 74827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Function(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Interpolate.Function>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.Function.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600B9F8 RID: 47608 RVA: 0x002E23C0 File Offset: 0x002E05C0
			[CallerCount(0)]
			public unsafe float Invoke(float a, float b, float c, float d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.Function.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B9F9 RID: 47609 RVA: 0x002E2434 File Offset: 0x002E0634
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74828, XrefRangeEnd = 74838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(float a, float b, float c, float d, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref c;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.Function.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Single_Single_Single_Single_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600B9FA RID: 47610 RVA: 0x002E24D0 File Offset: 0x002E06D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74838, XrefRangeEnd = 74840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate.Function.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Single_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600B9FB RID: 47611 RVA: 0x0005AE94 File Offset: 0x00059094
			public Function(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600B9FC RID: 47612 RVA: 0x0005AE9D File Offset: 0x0005909D
			public static implicit operator Interpolate.Function(Func<float, float, float, float, float> A_0)
			{
				return DelegateSupport.ConvertDelegate<Interpolate.Function>(A_0);
			}

			// Token: 0x0600B9FD RID: 47613 RVA: 0x0005AEA5 File Offset: 0x000590A5
			public static Interpolate.Function operator +(Interpolate.Function A_0, Interpolate.Function A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Interpolate.Function>();
			}

			// Token: 0x0600B9FE RID: 47614 RVA: 0x0005AEB3 File Offset: 0x000590B3
			public static Interpolate.Function operator -(Interpolate.Function A_0, Interpolate.Function A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<Interpolate.Function>();
				}
				return result;
			}

			// Token: 0x04007D80 RID: 32128
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04007D81 RID: 32129
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Single_Single_Single_Single_Single_0;

			// Token: 0x04007D82 RID: 32130
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Single_Single_Single_Single_AsyncCallback_Object_0;

			// Token: 0x04007D83 RID: 32131
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Single_IAsyncResult_0;
		}

		// Token: 0x020007B9 RID: 1977
		[ObfuscatedName("Interpolate+<NewBezier>d__16`1")]
		public sealed class _NewBezier_d__16<T> : Il2CppSystem.Object
		{
			// Token: 0x0600B9FF RID: 47615 RVA: 0x002E2520 File Offset: 0x002E0720
			// Note: this type is marked as 'beforefieldinit'.
			static _NewBezier_d__16()
			{
				Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, "<NewBezier>d__16`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr);
				Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, "<>1__state");
				Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, "<>2__current");
				Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, "<>l__initialThreadId");
				Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, "nodes");
				Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___3__nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, "<>3__nodes");
				Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr_steps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, "steps");
				Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___3__steps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, "<>3__steps");
				Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr_toVector3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, "toVector3");
				Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___3__toVector3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, "<>3__toVector3");
				Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr_ease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, "ease");
				Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___3__ease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, "<>3__ease");
				Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr_maxStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, "maxStep");
				Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___3__maxStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, "<>3__maxStep");
				Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr__points_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, "<points>5__2");
				Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, "<>7__wrap2");
				Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, 100663795);
				Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, 100663796);
				Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, 100663797);
				Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, 100663798);
				Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Vector3__get_Current_Private_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, 100663799);
				Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, 100663800);
				Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, 100663801);
				Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Vector3__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, 100663802);
				Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr, 100663803);
			}

			// Token: 0x0600BA00 RID: 47616 RVA: 0x002E2768 File Offset: 0x002E0968
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 25613, RefRangeEnd = 25636, XrefRangeStart = 25613, XrefRangeEnd = 25636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _NewBezier_d__16(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Interpolate._NewBezier_d__16<T>>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA01 RID: 47617 RVA: 0x002E27B0 File Offset: 0x002E09B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74840, XrefRangeEnd = 74845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA02 RID: 47618 RVA: 0x002E27E4 File Offset: 0x002E09E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74845, XrefRangeEnd = 74883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BA03 RID: 47619 RVA: 0x002E2820 File Offset: 0x002E0A20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74883, XrefRangeEnd = 74886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003970 RID: 14704
			// (get) Token: 0x0600BA04 RID: 47620 RVA: 0x002E2854 File Offset: 0x002E0A54
			public unsafe Vector3 Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Vector3__get_Current_Private_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BA05 RID: 47621 RVA: 0x002E2890 File Offset: 0x002E0A90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003971 RID: 14705
			// (get) Token: 0x0600BA06 RID: 47622 RVA: 0x002E28C4 File Offset: 0x002E0AC4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74886, XrefRangeEnd = 74889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BA07 RID: 47623 RVA: 0x002E2904 File Offset: 0x002E0B04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74889, XrefRangeEnd = 74899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Vector3> System_Collections_Generic_IEnumerable_UnityEngine_Vector3__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Vector3__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Vector3>>(intPtr3) : null;
			}

			// Token: 0x0600BA08 RID: 47624 RVA: 0x002E2944 File Offset: 0x002E0B44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74899, XrefRangeEnd = 74909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewBezier_d__16<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600BA09 RID: 47625 RVA: 0x0005AEC4 File Offset: 0x000590C4
			public _NewBezier_d__16(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003961 RID: 14689
			// (get) Token: 0x0600BA0A RID: 47626 RVA: 0x002E2984 File Offset: 0x002E0B84
			// (set) Token: 0x0600BA0B RID: 47627 RVA: 0x0005AECD File Offset: 0x000590CD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003962 RID: 14690
			// (get) Token: 0x0600BA0C RID: 47628 RVA: 0x002E29AC File Offset: 0x002E0BAC
			// (set) Token: 0x0600BA0D RID: 47629 RVA: 0x0005AEE8 File Offset: 0x000590E8
			public unsafe Vector3 __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___2__current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___2__current)) = value;
				}
			}

			// Token: 0x17003963 RID: 14691
			// (get) Token: 0x0600BA0E RID: 47630 RVA: 0x002E29D4 File Offset: 0x002E0BD4
			// (set) Token: 0x0600BA0F RID: 47631 RVA: 0x0005AF03 File Offset: 0x00059103
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003964 RID: 14692
			// (get) Token: 0x0600BA10 RID: 47632 RVA: 0x002E29FC File Offset: 0x002E0BFC
			// (set) Token: 0x0600BA11 RID: 47633 RVA: 0x0005AF1E File Offset: 0x0005911E
			public unsafe IList nodes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr_nodes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr_nodes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003965 RID: 14693
			// (get) Token: 0x0600BA12 RID: 47634 RVA: 0x002E2A2C File Offset: 0x002E0C2C
			// (set) Token: 0x0600BA13 RID: 47635 RVA: 0x0005AF3D File Offset: 0x0005913D
			public unsafe IList __3__nodes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___3__nodes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___3__nodes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003966 RID: 14694
			// (get) Token: 0x0600BA14 RID: 47636 RVA: 0x002E2A5C File Offset: 0x002E0C5C
			// (set) Token: 0x0600BA15 RID: 47637 RVA: 0x0005AF5C File Offset: 0x0005915C
			public unsafe IEnumerable<float> steps
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr_steps);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr_steps), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003967 RID: 14695
			// (get) Token: 0x0600BA16 RID: 47638 RVA: 0x002E2A8C File Offset: 0x002E0C8C
			// (set) Token: 0x0600BA17 RID: 47639 RVA: 0x0005AF7B File Offset: 0x0005917B
			public unsafe IEnumerable<float> __3__steps
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___3__steps);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___3__steps), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003968 RID: 14696
			// (get) Token: 0x0600BA18 RID: 47640 RVA: 0x002E2ABC File Offset: 0x002E0CBC
			// (set) Token: 0x0600BA19 RID: 47641 RVA: 0x0005AF9A File Offset: 0x0005919A
			public unsafe Interpolate.ToVector3<T> toVector3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr_toVector3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Interpolate.ToVector3<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr_toVector3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003969 RID: 14697
			// (get) Token: 0x0600BA1A RID: 47642 RVA: 0x002E2AEC File Offset: 0x002E0CEC
			// (set) Token: 0x0600BA1B RID: 47643 RVA: 0x0005AFB9 File Offset: 0x000591B9
			public unsafe Interpolate.ToVector3<T> __3__toVector3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___3__toVector3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Interpolate.ToVector3<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___3__toVector3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700396A RID: 14698
			// (get) Token: 0x0600BA1C RID: 47644 RVA: 0x002E2B1C File Offset: 0x002E0D1C
			// (set) Token: 0x0600BA1D RID: 47645 RVA: 0x0005AFD8 File Offset: 0x000591D8
			public unsafe Interpolate.Function ease
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr_ease);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Interpolate.Function>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr_ease), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700396B RID: 14699
			// (get) Token: 0x0600BA1E RID: 47646 RVA: 0x002E2B4C File Offset: 0x002E0D4C
			// (set) Token: 0x0600BA1F RID: 47647 RVA: 0x0005AFF7 File Offset: 0x000591F7
			public unsafe Interpolate.Function __3__ease
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___3__ease);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Interpolate.Function>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___3__ease), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700396C RID: 14700
			// (get) Token: 0x0600BA20 RID: 47648 RVA: 0x002E2B7C File Offset: 0x002E0D7C
			// (set) Token: 0x0600BA21 RID: 47649 RVA: 0x0005B016 File Offset: 0x00059216
			public unsafe float maxStep
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr_maxStep);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr_maxStep)) = value;
				}
			}

			// Token: 0x1700396D RID: 14701
			// (get) Token: 0x0600BA22 RID: 47650 RVA: 0x002E2BA4 File Offset: 0x002E0DA4
			// (set) Token: 0x0600BA23 RID: 47651 RVA: 0x0005B031 File Offset: 0x00059231
			public unsafe float __3__maxStep
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___3__maxStep);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___3__maxStep)) = value;
				}
			}

			// Token: 0x1700396E RID: 14702
			// (get) Token: 0x0600BA24 RID: 47652 RVA: 0x002E2BCC File Offset: 0x002E0DCC
			// (set) Token: 0x0600BA25 RID: 47653 RVA: 0x0005B04C File Offset: 0x0005924C
			public unsafe Il2CppStructArray<Vector3> _points_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr__points_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr__points_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700396F RID: 14703
			// (get) Token: 0x0600BA26 RID: 47654 RVA: 0x002E2BFC File Offset: 0x002E0DFC
			// (set) Token: 0x0600BA27 RID: 47655 RVA: 0x0005B06B File Offset: 0x0005926B
			public unsafe IEnumerator<float> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewBezier_d__16<T>.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007D84 RID: 32132
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007D85 RID: 32133
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007D86 RID: 32134
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04007D87 RID: 32135
			private static readonly IntPtr NativeFieldInfoPtr_nodes;

			// Token: 0x04007D88 RID: 32136
			private static readonly IntPtr NativeFieldInfoPtr___3__nodes;

			// Token: 0x04007D89 RID: 32137
			private static readonly IntPtr NativeFieldInfoPtr_steps;

			// Token: 0x04007D8A RID: 32138
			private static readonly IntPtr NativeFieldInfoPtr___3__steps;

			// Token: 0x04007D8B RID: 32139
			private static readonly IntPtr NativeFieldInfoPtr_toVector3;

			// Token: 0x04007D8C RID: 32140
			private static readonly IntPtr NativeFieldInfoPtr___3__toVector3;

			// Token: 0x04007D8D RID: 32141
			private static readonly IntPtr NativeFieldInfoPtr_ease;

			// Token: 0x04007D8E RID: 32142
			private static readonly IntPtr NativeFieldInfoPtr___3__ease;

			// Token: 0x04007D8F RID: 32143
			private static readonly IntPtr NativeFieldInfoPtr_maxStep;

			// Token: 0x04007D90 RID: 32144
			private static readonly IntPtr NativeFieldInfoPtr___3__maxStep;

			// Token: 0x04007D91 RID: 32145
			private static readonly IntPtr NativeFieldInfoPtr__points_5__2;

			// Token: 0x04007D92 RID: 32146
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04007D93 RID: 32147
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007D94 RID: 32148
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007D95 RID: 32149
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007D96 RID: 32150
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04007D97 RID: 32151
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Vector3__get_Current_Private_Virtual_Final_New_get_Vector3_0;

			// Token: 0x04007D98 RID: 32152
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007D99 RID: 32153
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007D9A RID: 32154
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Vector3__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Vector3_0;

			// Token: 0x04007D9B RID: 32155
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020007BA RID: 1978
		[ObfuscatedName("Interpolate+<NewCatmullRom>d__20`1")]
		public sealed class _NewCatmullRom_d__20<T> : Il2CppSystem.Object
		{
			// Token: 0x0600BA28 RID: 47656 RVA: 0x002E2C2C File Offset: 0x002E0E2C
			// Note: this type is marked as 'beforefieldinit'.
			static _NewCatmullRom_d__20()
			{
				Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, "<NewCatmullRom>d__20`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr);
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "<>1__state");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "<>2__current");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "<>l__initialThreadId");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr_nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "nodes");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___3__nodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "<>3__nodes");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr_toVector3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "toVector3");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___3__toVector3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "<>3__toVector3");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr_loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "loop");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___3__loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "<>3__loop");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr_slices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "slices");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___3__slices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "<>3__slices");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__last_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "<last>5__2");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__current_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "<current>5__3");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__previous_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "<previous>5__4");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__start_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "<start>5__5");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__end_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "<end>5__6");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__next_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "<next>5__7");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__stepCount_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "<stepCount>5__8");
				Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__step_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, "<step>5__9");
				Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, 100663804);
				Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, 100663805);
				Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, 100663806);
				Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Vector3__get_Current_Private_Virtual_Final_New_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, 100663807);
				Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, 100663808);
				Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, 100663809);
				Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Vector3__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, 100663810);
				Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr, 100663811);
			}

			// Token: 0x0600BA29 RID: 47657 RVA: 0x002E2EB0 File Offset: 0x002E10B0
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 25613, RefRangeEnd = 25636, XrefRangeStart = 25613, XrefRangeEnd = 25636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _NewCatmullRom_d__20(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Interpolate._NewCatmullRom_d__20<T>>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA2A RID: 47658 RVA: 0x002E2EF8 File Offset: 0x002E10F8
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA2B RID: 47659 RVA: 0x002E2F2C File Offset: 0x002E112C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74909, XrefRangeEnd = 74942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003985 RID: 14725
			// (get) Token: 0x0600BA2C RID: 47660 RVA: 0x002E2F68 File Offset: 0x002E1168
			public unsafe Vector3 Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Vector3__get_Current_Private_Virtual_Final_New_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BA2D RID: 47661 RVA: 0x002E2FA4 File Offset: 0x002E11A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003986 RID: 14726
			// (get) Token: 0x0600BA2E RID: 47662 RVA: 0x002E2FD8 File Offset: 0x002E11D8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74942, XrefRangeEnd = 74945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BA2F RID: 47663 RVA: 0x002E3018 File Offset: 0x002E1218
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74945, XrefRangeEnd = 74953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Vector3> System_Collections_Generic_IEnumerable_UnityEngine_Vector3__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Vector3__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Vector3>>(intPtr3) : null;
			}

			// Token: 0x0600BA30 RID: 47664 RVA: 0x002E3058 File Offset: 0x002E1258
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74953, XrefRangeEnd = 74961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCatmullRom_d__20<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600BA31 RID: 47665 RVA: 0x0005B08A File Offset: 0x0005928A
			public _NewCatmullRom_d__20(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003972 RID: 14706
			// (get) Token: 0x0600BA32 RID: 47666 RVA: 0x002E3098 File Offset: 0x002E1298
			// (set) Token: 0x0600BA33 RID: 47667 RVA: 0x0005B093 File Offset: 0x00059293
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003973 RID: 14707
			// (get) Token: 0x0600BA34 RID: 47668 RVA: 0x002E30C0 File Offset: 0x002E12C0
			// (set) Token: 0x0600BA35 RID: 47669 RVA: 0x0005B0AE File Offset: 0x000592AE
			public unsafe Vector3 __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___2__current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___2__current)) = value;
				}
			}

			// Token: 0x17003974 RID: 14708
			// (get) Token: 0x0600BA36 RID: 47670 RVA: 0x002E30E8 File Offset: 0x002E12E8
			// (set) Token: 0x0600BA37 RID: 47671 RVA: 0x0005B0C9 File Offset: 0x000592C9
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17003975 RID: 14709
			// (get) Token: 0x0600BA38 RID: 47672 RVA: 0x002E3110 File Offset: 0x002E1310
			// (set) Token: 0x0600BA39 RID: 47673 RVA: 0x0005B0E4 File Offset: 0x000592E4
			public unsafe IList nodes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr_nodes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr_nodes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003976 RID: 14710
			// (get) Token: 0x0600BA3A RID: 47674 RVA: 0x002E3140 File Offset: 0x002E1340
			// (set) Token: 0x0600BA3B RID: 47675 RVA: 0x0005B103 File Offset: 0x00059303
			public unsafe IList __3__nodes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___3__nodes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___3__nodes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003977 RID: 14711
			// (get) Token: 0x0600BA3C RID: 47676 RVA: 0x002E3170 File Offset: 0x002E1370
			// (set) Token: 0x0600BA3D RID: 47677 RVA: 0x0005B122 File Offset: 0x00059322
			public unsafe Interpolate.ToVector3<T> toVector3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr_toVector3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Interpolate.ToVector3<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr_toVector3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003978 RID: 14712
			// (get) Token: 0x0600BA3E RID: 47678 RVA: 0x002E31A0 File Offset: 0x002E13A0
			// (set) Token: 0x0600BA3F RID: 47679 RVA: 0x0005B141 File Offset: 0x00059341
			public unsafe Interpolate.ToVector3<T> __3__toVector3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___3__toVector3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Interpolate.ToVector3<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___3__toVector3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003979 RID: 14713
			// (get) Token: 0x0600BA40 RID: 47680 RVA: 0x002E31D0 File Offset: 0x002E13D0
			// (set) Token: 0x0600BA41 RID: 47681 RVA: 0x0005B160 File Offset: 0x00059360
			public unsafe bool loop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr_loop);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr_loop)) = value;
				}
			}

			// Token: 0x1700397A RID: 14714
			// (get) Token: 0x0600BA42 RID: 47682 RVA: 0x002E31F8 File Offset: 0x002E13F8
			// (set) Token: 0x0600BA43 RID: 47683 RVA: 0x0005B17B File Offset: 0x0005937B
			public unsafe bool __3__loop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___3__loop);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___3__loop)) = value;
				}
			}

			// Token: 0x1700397B RID: 14715
			// (get) Token: 0x0600BA44 RID: 47684 RVA: 0x002E3220 File Offset: 0x002E1420
			// (set) Token: 0x0600BA45 RID: 47685 RVA: 0x0005B196 File Offset: 0x00059396
			public unsafe int slices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr_slices);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr_slices)) = value;
				}
			}

			// Token: 0x1700397C RID: 14716
			// (get) Token: 0x0600BA46 RID: 47686 RVA: 0x002E3248 File Offset: 0x002E1448
			// (set) Token: 0x0600BA47 RID: 47687 RVA: 0x0005B1B1 File Offset: 0x000593B1
			public unsafe int __3__slices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___3__slices);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr___3__slices)) = value;
				}
			}

			// Token: 0x1700397D RID: 14717
			// (get) Token: 0x0600BA48 RID: 47688 RVA: 0x002E3270 File Offset: 0x002E1470
			// (set) Token: 0x0600BA49 RID: 47689 RVA: 0x0005B1CC File Offset: 0x000593CC
			public unsafe int _last_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__last_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__last_5__2)) = value;
				}
			}

			// Token: 0x1700397E RID: 14718
			// (get) Token: 0x0600BA4A RID: 47690 RVA: 0x002E3298 File Offset: 0x002E1498
			// (set) Token: 0x0600BA4B RID: 47691 RVA: 0x0005B1E7 File Offset: 0x000593E7
			public unsafe int _current_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__current_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__current_5__3)) = value;
				}
			}

			// Token: 0x1700397F RID: 14719
			// (get) Token: 0x0600BA4C RID: 47692 RVA: 0x002E32C0 File Offset: 0x002E14C0
			// (set) Token: 0x0600BA4D RID: 47693 RVA: 0x0005B202 File Offset: 0x00059402
			public unsafe int _previous_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__previous_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__previous_5__4)) = value;
				}
			}

			// Token: 0x17003980 RID: 14720
			// (get) Token: 0x0600BA4E RID: 47694 RVA: 0x002E32E8 File Offset: 0x002E14E8
			// (set) Token: 0x0600BA4F RID: 47695 RVA: 0x0005B21D File Offset: 0x0005941D
			public unsafe int _start_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__start_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__start_5__5)) = value;
				}
			}

			// Token: 0x17003981 RID: 14721
			// (get) Token: 0x0600BA50 RID: 47696 RVA: 0x002E3310 File Offset: 0x002E1510
			// (set) Token: 0x0600BA51 RID: 47697 RVA: 0x0005B238 File Offset: 0x00059438
			public unsafe int _end_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__end_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__end_5__6)) = value;
				}
			}

			// Token: 0x17003982 RID: 14722
			// (get) Token: 0x0600BA52 RID: 47698 RVA: 0x002E3338 File Offset: 0x002E1538
			// (set) Token: 0x0600BA53 RID: 47699 RVA: 0x0005B253 File Offset: 0x00059453
			public unsafe int _next_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__next_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__next_5__7)) = value;
				}
			}

			// Token: 0x17003983 RID: 14723
			// (get) Token: 0x0600BA54 RID: 47700 RVA: 0x002E3360 File Offset: 0x002E1560
			// (set) Token: 0x0600BA55 RID: 47701 RVA: 0x0005B26E File Offset: 0x0005946E
			public unsafe int _stepCount_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__stepCount_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__stepCount_5__8)) = value;
				}
			}

			// Token: 0x17003984 RID: 14724
			// (get) Token: 0x0600BA56 RID: 47702 RVA: 0x002E3388 File Offset: 0x002E1588
			// (set) Token: 0x0600BA57 RID: 47703 RVA: 0x0005B289 File Offset: 0x00059489
			public unsafe int _step_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__step_5__9);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCatmullRom_d__20<T>.NativeFieldInfoPtr__step_5__9)) = value;
				}
			}

			// Token: 0x04007D9C RID: 32156
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007D9D RID: 32157
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007D9E RID: 32158
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04007D9F RID: 32159
			private static readonly IntPtr NativeFieldInfoPtr_nodes;

			// Token: 0x04007DA0 RID: 32160
			private static readonly IntPtr NativeFieldInfoPtr___3__nodes;

			// Token: 0x04007DA1 RID: 32161
			private static readonly IntPtr NativeFieldInfoPtr_toVector3;

			// Token: 0x04007DA2 RID: 32162
			private static readonly IntPtr NativeFieldInfoPtr___3__toVector3;

			// Token: 0x04007DA3 RID: 32163
			private static readonly IntPtr NativeFieldInfoPtr_loop;

			// Token: 0x04007DA4 RID: 32164
			private static readonly IntPtr NativeFieldInfoPtr___3__loop;

			// Token: 0x04007DA5 RID: 32165
			private static readonly IntPtr NativeFieldInfoPtr_slices;

			// Token: 0x04007DA6 RID: 32166
			private static readonly IntPtr NativeFieldInfoPtr___3__slices;

			// Token: 0x04007DA7 RID: 32167
			private static readonly IntPtr NativeFieldInfoPtr__last_5__2;

			// Token: 0x04007DA8 RID: 32168
			private static readonly IntPtr NativeFieldInfoPtr__current_5__3;

			// Token: 0x04007DA9 RID: 32169
			private static readonly IntPtr NativeFieldInfoPtr__previous_5__4;

			// Token: 0x04007DAA RID: 32170
			private static readonly IntPtr NativeFieldInfoPtr__start_5__5;

			// Token: 0x04007DAB RID: 32171
			private static readonly IntPtr NativeFieldInfoPtr__end_5__6;

			// Token: 0x04007DAC RID: 32172
			private static readonly IntPtr NativeFieldInfoPtr__next_5__7;

			// Token: 0x04007DAD RID: 32173
			private static readonly IntPtr NativeFieldInfoPtr__stepCount_5__8;

			// Token: 0x04007DAE RID: 32174
			private static readonly IntPtr NativeFieldInfoPtr__step_5__9;

			// Token: 0x04007DAF RID: 32175
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007DB0 RID: 32176
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007DB1 RID: 32177
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007DB2 RID: 32178
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_UnityEngine_Vector3__get_Current_Private_Virtual_Final_New_get_Vector3_0;

			// Token: 0x04007DB3 RID: 32179
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007DB4 RID: 32180
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007DB5 RID: 32181
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_UnityEngine_Vector3__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Vector3_0;

			// Token: 0x04007DB6 RID: 32182
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020007BB RID: 1979
		[ObfuscatedName("Interpolate+<NewCounter>d__6")]
		public sealed class _NewCounter_d__6 : Il2CppSystem.Object
		{
			// Token: 0x0600BA58 RID: 47704 RVA: 0x002E33B0 File Offset: 0x002E15B0
			// Note: this type is marked as 'beforefieldinit'.
			static _NewCounter_d__6()
			{
				Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, "<NewCounter>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr);
				Interpolate._NewCounter_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, "<>1__state");
				Interpolate._NewCounter_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, "<>2__current");
				Interpolate._NewCounter_d__6.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, "<>l__initialThreadId");
				Interpolate._NewCounter_d__6.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, "start");
				Interpolate._NewCounter_d__6.NativeFieldInfoPtr___3__start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, "<>3__start");
				Interpolate._NewCounter_d__6.NativeFieldInfoPtr_step = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, "step");
				Interpolate._NewCounter_d__6.NativeFieldInfoPtr___3__step = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, "<>3__step");
				Interpolate._NewCounter_d__6.NativeFieldInfoPtr_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, "end");
				Interpolate._NewCounter_d__6.NativeFieldInfoPtr___3__end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, "<>3__end");
				Interpolate._NewCounter_d__6.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, "<i>5__2");
				Interpolate._NewCounter_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, 100663812);
				Interpolate._NewCounter_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, 100663813);
				Interpolate._NewCounter_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, 100663814);
				Interpolate._NewCounter_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Single__get_Current_Private_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, 100663815);
				Interpolate._NewCounter_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, 100663816);
				Interpolate._NewCounter_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, 100663817);
				Interpolate._NewCounter_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Single__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, 100663818);
				Interpolate._NewCounter_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr, 100663819);
			}

			// Token: 0x0600BA59 RID: 47705 RVA: 0x002E3544 File Offset: 0x002E1744
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 74963, RefRangeEnd = 74971, XrefRangeStart = 74961, XrefRangeEnd = 74963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _NewCounter_d__6(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Interpolate._NewCounter_d__6>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCounter_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA5A RID: 47706 RVA: 0x002E358C File Offset: 0x002E178C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCounter_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA5B RID: 47707 RVA: 0x002E35C0 File Offset: 0x002E17C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74971, XrefRangeEnd = 74972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCounter_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003991 RID: 14737
			// (get) Token: 0x0600BA5C RID: 47708 RVA: 0x002E35FC File Offset: 0x002E17FC
			public unsafe float Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCounter_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Single__get_Current_Private_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BA5D RID: 47709 RVA: 0x002E3638 File Offset: 0x002E1838
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74972, XrefRangeEnd = 74977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCounter_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003992 RID: 14738
			// (get) Token: 0x0600BA5E RID: 47710 RVA: 0x002E366C File Offset: 0x002E186C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74977, XrefRangeEnd = 74980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCounter_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BA5F RID: 47711 RVA: 0x002E36AC File Offset: 0x002E18AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74980, XrefRangeEnd = 74987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<float> System_Collections_Generic_IEnumerable_System_Single__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCounter_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Single__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<float>>(intPtr3) : null;
			}

			// Token: 0x0600BA60 RID: 47712 RVA: 0x002E36EC File Offset: 0x002E18EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewCounter_d__6.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600BA61 RID: 47713 RVA: 0x0005B2A4 File Offset: 0x000594A4
			public _NewCounter_d__6(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003987 RID: 14727
			// (get) Token: 0x0600BA62 RID: 47714 RVA: 0x002E372C File Offset: 0x002E192C
			// (set) Token: 0x0600BA63 RID: 47715 RVA: 0x0005B2AD File Offset: 0x000594AD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003988 RID: 14728
			// (get) Token: 0x0600BA64 RID: 47716 RVA: 0x002E3754 File Offset: 0x002E1954
			// (set) Token: 0x0600BA65 RID: 47717 RVA: 0x0005B2C8 File Offset: 0x000594C8
			public unsafe float __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr___2__current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr___2__current)) = value;
				}
			}

			// Token: 0x17003989 RID: 14729
			// (get) Token: 0x0600BA66 RID: 47718 RVA: 0x002E377C File Offset: 0x002E197C
			// (set) Token: 0x0600BA67 RID: 47719 RVA: 0x0005B2E3 File Offset: 0x000594E3
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x1700398A RID: 14730
			// (get) Token: 0x0600BA68 RID: 47720 RVA: 0x002E37A4 File Offset: 0x002E19A4
			// (set) Token: 0x0600BA69 RID: 47721 RVA: 0x0005B2FE File Offset: 0x000594FE
			public unsafe int start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr_start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr_start)) = value;
				}
			}

			// Token: 0x1700398B RID: 14731
			// (get) Token: 0x0600BA6A RID: 47722 RVA: 0x002E37CC File Offset: 0x002E19CC
			// (set) Token: 0x0600BA6B RID: 47723 RVA: 0x0005B319 File Offset: 0x00059519
			public unsafe int __3__start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr___3__start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr___3__start)) = value;
				}
			}

			// Token: 0x1700398C RID: 14732
			// (get) Token: 0x0600BA6C RID: 47724 RVA: 0x002E37F4 File Offset: 0x002E19F4
			// (set) Token: 0x0600BA6D RID: 47725 RVA: 0x0005B334 File Offset: 0x00059534
			public unsafe int step
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr_step);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr_step)) = value;
				}
			}

			// Token: 0x1700398D RID: 14733
			// (get) Token: 0x0600BA6E RID: 47726 RVA: 0x002E381C File Offset: 0x002E1A1C
			// (set) Token: 0x0600BA6F RID: 47727 RVA: 0x0005B34F File Offset: 0x0005954F
			public unsafe int __3__step
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr___3__step);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr___3__step)) = value;
				}
			}

			// Token: 0x1700398E RID: 14734
			// (get) Token: 0x0600BA70 RID: 47728 RVA: 0x002E3844 File Offset: 0x002E1A44
			// (set) Token: 0x0600BA71 RID: 47729 RVA: 0x0005B36A File Offset: 0x0005956A
			public unsafe int end
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr_end);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr_end)) = value;
				}
			}

			// Token: 0x1700398F RID: 14735
			// (get) Token: 0x0600BA72 RID: 47730 RVA: 0x002E386C File Offset: 0x002E1A6C
			// (set) Token: 0x0600BA73 RID: 47731 RVA: 0x0005B385 File Offset: 0x00059585
			public unsafe int __3__end
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr___3__end);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr___3__end)) = value;
				}
			}

			// Token: 0x17003990 RID: 14736
			// (get) Token: 0x0600BA74 RID: 47732 RVA: 0x002E3894 File Offset: 0x002E1A94
			// (set) Token: 0x0600BA75 RID: 47733 RVA: 0x0005B3A0 File Offset: 0x000595A0
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewCounter_d__6.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x04007DB7 RID: 32183
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007DB8 RID: 32184
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007DB9 RID: 32185
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04007DBA RID: 32186
			private static readonly IntPtr NativeFieldInfoPtr_start;

			// Token: 0x04007DBB RID: 32187
			private static readonly IntPtr NativeFieldInfoPtr___3__start;

			// Token: 0x04007DBC RID: 32188
			private static readonly IntPtr NativeFieldInfoPtr_step;

			// Token: 0x04007DBD RID: 32189
			private static readonly IntPtr NativeFieldInfoPtr___3__step;

			// Token: 0x04007DBE RID: 32190
			private static readonly IntPtr NativeFieldInfoPtr_end;

			// Token: 0x04007DBF RID: 32191
			private static readonly IntPtr NativeFieldInfoPtr___3__end;

			// Token: 0x04007DC0 RID: 32192
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x04007DC1 RID: 32193
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007DC2 RID: 32194
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007DC3 RID: 32195
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007DC4 RID: 32196
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Single__get_Current_Private_Virtual_Final_New_get_Single_0;

			// Token: 0x04007DC5 RID: 32197
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007DC6 RID: 32198
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007DC7 RID: 32199
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Single__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Single_0;

			// Token: 0x04007DC8 RID: 32200
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020007BC RID: 1980
		[ObfuscatedName("Interpolate+<NewEase>d__9")]
		public sealed class _NewEase_d__9 : Il2CppSystem.Object
		{
			// Token: 0x0600BA76 RID: 47734 RVA: 0x002E38BC File Offset: 0x002E1ABC
			// Note: this type is marked as 'beforefieldinit'.
			static _NewEase_d__9()
			{
				Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, "<NewEase>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr);
				Interpolate._NewEase_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, "<>1__state");
				Interpolate._NewEase_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, "<>2__current");
				Interpolate._NewEase_d__9.NativeFieldInfoPtr_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, "end");
				Interpolate._NewEase_d__9.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, "start");
				Interpolate._NewEase_d__9.NativeFieldInfoPtr_driver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, "driver");
				Interpolate._NewEase_d__9.NativeFieldInfoPtr_ease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, "ease");
				Interpolate._NewEase_d__9.NativeFieldInfoPtr_total = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, "total");
				Interpolate._NewEase_d__9.NativeFieldInfoPtr__distance_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, "<distance>5__2");
				Interpolate._NewEase_d__9.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, "<>7__wrap2");
				Interpolate._NewEase_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, 100663820);
				Interpolate._NewEase_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, 100663821);
				Interpolate._NewEase_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, 100663822);
				Interpolate._NewEase_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, 100663823);
				Interpolate._NewEase_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, 100663824);
				Interpolate._NewEase_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, 100663825);
				Interpolate._NewEase_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr, 100663826);
			}

			// Token: 0x0600BA77 RID: 47735 RVA: 0x002E3A28 File Offset: 0x002E1C28
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _NewEase_d__9(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Interpolate._NewEase_d__9>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewEase_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA78 RID: 47736 RVA: 0x002E3A70 File Offset: 0x002E1C70
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74990, RefRangeEnd = 74991, XrefRangeStart = 74987, XrefRangeEnd = 74990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewEase_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA79 RID: 47737 RVA: 0x002E3AA4 File Offset: 0x002E1CA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74991, XrefRangeEnd = 75014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewEase_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BA7A RID: 47738 RVA: 0x002E3AE0 File Offset: 0x002E1CE0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 75017, RefRangeEnd = 75020, XrefRangeStart = 75014, XrefRangeEnd = 75017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewEase_d__9.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700399C RID: 14748
			// (get) Token: 0x0600BA7B RID: 47739 RVA: 0x002E3B14 File Offset: 0x002E1D14
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewEase_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BA7C RID: 47740 RVA: 0x002E3B54 File Offset: 0x002E1D54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75020, XrefRangeEnd = 75025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewEase_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700399D RID: 14749
			// (get) Token: 0x0600BA7D RID: 47741 RVA: 0x002E3B88 File Offset: 0x002E1D88
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewEase_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BA7E RID: 47742 RVA: 0x0005B3BB File Offset: 0x000595BB
			public _NewEase_d__9(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003993 RID: 14739
			// (get) Token: 0x0600BA7F RID: 47743 RVA: 0x002E3BC8 File Offset: 0x002E1DC8
			// (set) Token: 0x0600BA80 RID: 47744 RVA: 0x0005B3C4 File Offset: 0x000595C4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003994 RID: 14740
			// (get) Token: 0x0600BA81 RID: 47745 RVA: 0x002E3BF0 File Offset: 0x002E1DF0
			// (set) Token: 0x0600BA82 RID: 47746 RVA: 0x0005B3DF File Offset: 0x000595DF
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003995 RID: 14741
			// (get) Token: 0x0600BA83 RID: 47747 RVA: 0x002E3C20 File Offset: 0x002E1E20
			// (set) Token: 0x0600BA84 RID: 47748 RVA: 0x0005B3FE File Offset: 0x000595FE
			public unsafe Vector3 end
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr_end);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr_end)) = value;
				}
			}

			// Token: 0x17003996 RID: 14742
			// (get) Token: 0x0600BA85 RID: 47749 RVA: 0x002E3C48 File Offset: 0x002E1E48
			// (set) Token: 0x0600BA86 RID: 47750 RVA: 0x0005B419 File Offset: 0x00059619
			public unsafe Vector3 start
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr_start);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr_start)) = value;
				}
			}

			// Token: 0x17003997 RID: 14743
			// (get) Token: 0x0600BA87 RID: 47751 RVA: 0x002E3C70 File Offset: 0x002E1E70
			// (set) Token: 0x0600BA88 RID: 47752 RVA: 0x0005B434 File Offset: 0x00059634
			public unsafe IEnumerable<float> driver
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr_driver);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr_driver), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003998 RID: 14744
			// (get) Token: 0x0600BA89 RID: 47753 RVA: 0x002E3CA0 File Offset: 0x002E1EA0
			// (set) Token: 0x0600BA8A RID: 47754 RVA: 0x0005B453 File Offset: 0x00059653
			public unsafe Interpolate.Function ease
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr_ease);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Interpolate.Function>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr_ease), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003999 RID: 14745
			// (get) Token: 0x0600BA8B RID: 47755 RVA: 0x002E3CD0 File Offset: 0x002E1ED0
			// (set) Token: 0x0600BA8C RID: 47756 RVA: 0x0005B472 File Offset: 0x00059672
			public unsafe float total
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr_total);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr_total)) = value;
				}
			}

			// Token: 0x1700399A RID: 14746
			// (get) Token: 0x0600BA8D RID: 47757 RVA: 0x002E3CF8 File Offset: 0x002E1EF8
			// (set) Token: 0x0600BA8E RID: 47758 RVA: 0x0005B48D File Offset: 0x0005968D
			public unsafe Vector3 _distance_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr__distance_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr__distance_5__2)) = value;
				}
			}

			// Token: 0x1700399B RID: 14747
			// (get) Token: 0x0600BA8F RID: 47759 RVA: 0x002E3D20 File Offset: 0x002E1F20
			// (set) Token: 0x0600BA90 RID: 47760 RVA: 0x0005B4A8 File Offset: 0x000596A8
			public unsafe IEnumerator<float> __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr___7__wrap2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewEase_d__9.NativeFieldInfoPtr___7__wrap2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007DC9 RID: 32201
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007DCA RID: 32202
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007DCB RID: 32203
			private static readonly IntPtr NativeFieldInfoPtr_end;

			// Token: 0x04007DCC RID: 32204
			private static readonly IntPtr NativeFieldInfoPtr_start;

			// Token: 0x04007DCD RID: 32205
			private static readonly IntPtr NativeFieldInfoPtr_driver;

			// Token: 0x04007DCE RID: 32206
			private static readonly IntPtr NativeFieldInfoPtr_ease;

			// Token: 0x04007DCF RID: 32207
			private static readonly IntPtr NativeFieldInfoPtr_total;

			// Token: 0x04007DD0 RID: 32208
			private static readonly IntPtr NativeFieldInfoPtr__distance_5__2;

			// Token: 0x04007DD1 RID: 32209
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04007DD2 RID: 32210
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007DD3 RID: 32211
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007DD4 RID: 32212
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007DD5 RID: 32213
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04007DD6 RID: 32214
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007DD7 RID: 32215
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007DD8 RID: 32216
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020007BD RID: 1981
		[ObfuscatedName("Interpolate+<NewTimer>d__3")]
		public sealed class _NewTimer_d__3 : Il2CppSystem.Object
		{
			// Token: 0x0600BA91 RID: 47761 RVA: 0x002E3D50 File Offset: 0x002E1F50
			// Note: this type is marked as 'beforefieldinit'.
			static _NewTimer_d__3()
			{
				Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Interpolate>.NativeClassPtr, "<NewTimer>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr);
				Interpolate._NewTimer_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr, "<>1__state");
				Interpolate._NewTimer_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr, "<>2__current");
				Interpolate._NewTimer_d__3.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr, "<>l__initialThreadId");
				Interpolate._NewTimer_d__3.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr, "duration");
				Interpolate._NewTimer_d__3.NativeFieldInfoPtr___3__duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr, "<>3__duration");
				Interpolate._NewTimer_d__3.NativeFieldInfoPtr__elapsedTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr, "<elapsedTime>5__2");
				Interpolate._NewTimer_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr, 100663827);
				Interpolate._NewTimer_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr, 100663828);
				Interpolate._NewTimer_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr, 100663829);
				Interpolate._NewTimer_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Single__get_Current_Private_Virtual_Final_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr, 100663830);
				Interpolate._NewTimer_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr, 100663831);
				Interpolate._NewTimer_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr, 100663832);
				Interpolate._NewTimer_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Single__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr, 100663833);
				Interpolate._NewTimer_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr, 100663834);
			}

			// Token: 0x0600BA92 RID: 47762 RVA: 0x002E3E94 File Offset: 0x002E2094
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 74963, RefRangeEnd = 74971, XrefRangeStart = 74963, XrefRangeEnd = 74971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _NewTimer_d__3(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Interpolate._NewTimer_d__3>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewTimer_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA93 RID: 47763 RVA: 0x002E3EDC File Offset: 0x002E20DC
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewTimer_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA94 RID: 47764 RVA: 0x002E3F10 File Offset: 0x002E2110
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewTimer_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170039A4 RID: 14756
			// (get) Token: 0x0600BA95 RID: 47765 RVA: 0x002E3F4C File Offset: 0x002E214C
			public unsafe float Current
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewTimer_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Single__get_Current_Private_Virtual_Final_New_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600BA96 RID: 47766 RVA: 0x002E3F88 File Offset: 0x002E2188
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75025, XrefRangeEnd = 75030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewTimer_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170039A5 RID: 14757
			// (get) Token: 0x0600BA97 RID: 47767 RVA: 0x002E3FBC File Offset: 0x002E21BC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75030, XrefRangeEnd = 75033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewTimer_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BA98 RID: 47768 RVA: 0x002E3FFC File Offset: 0x002E21FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75033, XrefRangeEnd = 75040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<float> System_Collections_Generic_IEnumerable_System_Single__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewTimer_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Single__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<float>>(intPtr3) : null;
			}

			// Token: 0x0600BA99 RID: 47769 RVA: 0x002E403C File Offset: 0x002E223C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Interpolate._NewTimer_d__3.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600BA9A RID: 47770 RVA: 0x0005B4C7 File Offset: 0x000596C7
			public _NewTimer_d__3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700399E RID: 14750
			// (get) Token: 0x0600BA9B RID: 47771 RVA: 0x002E407C File Offset: 0x002E227C
			// (set) Token: 0x0600BA9C RID: 47772 RVA: 0x0005B4D0 File Offset: 0x000596D0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewTimer_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewTimer_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700399F RID: 14751
			// (get) Token: 0x0600BA9D RID: 47773 RVA: 0x002E40A4 File Offset: 0x002E22A4
			// (set) Token: 0x0600BA9E RID: 47774 RVA: 0x0005B4EB File Offset: 0x000596EB
			public unsafe float __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewTimer_d__3.NativeFieldInfoPtr___2__current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewTimer_d__3.NativeFieldInfoPtr___2__current)) = value;
				}
			}

			// Token: 0x170039A0 RID: 14752
			// (get) Token: 0x0600BA9F RID: 47775 RVA: 0x002E40CC File Offset: 0x002E22CC
			// (set) Token: 0x0600BAA0 RID: 47776 RVA: 0x0005B506 File Offset: 0x00059706
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewTimer_d__3.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewTimer_d__3.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x170039A1 RID: 14753
			// (get) Token: 0x0600BAA1 RID: 47777 RVA: 0x002E40F4 File Offset: 0x002E22F4
			// (set) Token: 0x0600BAA2 RID: 47778 RVA: 0x0005B521 File Offset: 0x00059721
			public unsafe float duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewTimer_d__3.NativeFieldInfoPtr_duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewTimer_d__3.NativeFieldInfoPtr_duration)) = value;
				}
			}

			// Token: 0x170039A2 RID: 14754
			// (get) Token: 0x0600BAA3 RID: 47779 RVA: 0x002E411C File Offset: 0x002E231C
			// (set) Token: 0x0600BAA4 RID: 47780 RVA: 0x0005B53C File Offset: 0x0005973C
			public unsafe float __3__duration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewTimer_d__3.NativeFieldInfoPtr___3__duration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewTimer_d__3.NativeFieldInfoPtr___3__duration)) = value;
				}
			}

			// Token: 0x170039A3 RID: 14755
			// (get) Token: 0x0600BAA5 RID: 47781 RVA: 0x002E4144 File Offset: 0x002E2344
			// (set) Token: 0x0600BAA6 RID: 47782 RVA: 0x0005B557 File Offset: 0x00059757
			public unsafe float _elapsedTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewTimer_d__3.NativeFieldInfoPtr__elapsedTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Interpolate._NewTimer_d__3.NativeFieldInfoPtr__elapsedTime_5__2)) = value;
				}
			}

			// Token: 0x04007DD9 RID: 32217
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04007DDA RID: 32218
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04007DDB RID: 32219
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04007DDC RID: 32220
			private static readonly IntPtr NativeFieldInfoPtr_duration;

			// Token: 0x04007DDD RID: 32221
			private static readonly IntPtr NativeFieldInfoPtr___3__duration;

			// Token: 0x04007DDE RID: 32222
			private static readonly IntPtr NativeFieldInfoPtr__elapsedTime_5__2;

			// Token: 0x04007DDF RID: 32223
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04007DE0 RID: 32224
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007DE1 RID: 32225
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04007DE2 RID: 32226
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Single__get_Current_Private_Virtual_Final_New_get_Single_0;

			// Token: 0x04007DE3 RID: 32227
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04007DE4 RID: 32228
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04007DE5 RID: 32229
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_System_Single__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Single_0;

			// Token: 0x04007DE6 RID: 32230
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x020007BE RID: 1982
		private sealed class MethodInfoStoreGeneric_NewBezier_Private_Static_IEnumerable_1_Vector3_Function_IList_ToVector3_1_T_Single_IEnumerable_1_Single_0<T>
		{
			// Token: 0x04007DE7 RID: 32231
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Interpolate.NativeMethodInfoPtr_NewBezier_Private_Static_IEnumerable_1_Vector3_Function_IList_ToVector3_1_T_Single_IEnumerable_1_Single_0, Il2CppClassPointerStore<Interpolate>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x020007BF RID: 1983
		private sealed class MethodInfoStoreGeneric_NewCatmullRom_Private_Static_IEnumerable_1_Vector3_IList_ToVector3_1_T_Int32_Boolean_0<T>
		{
			// Token: 0x04007DE8 RID: 32232
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Interpolate.NativeMethodInfoPtr_NewCatmullRom_Private_Static_IEnumerable_1_Vector3_IList_ToVector3_1_T_Int32_Boolean_0, Il2CppClassPointerStore<Interpolate>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
