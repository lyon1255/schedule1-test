using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000F9 RID: 249
	[Serializable]
	public class KeyframeGroup<T> : Object
	{
		// Token: 0x060012F4 RID: 4852 RVA: 0x000AC8D4 File Offset: 0x000AAAD4
		// Note: this type is marked as 'beforefieldinit'.
		static KeyframeGroup()
		{
			Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "KeyframeGroup`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr);
			KeyframeGroup<T>.NativeFieldInfoPtr_keyframes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, "keyframes");
			KeyframeGroup<T>.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, "m_Name");
			KeyframeGroup<T>.NativeFieldInfoPtr_m_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, "m_Id");
			KeyframeGroup<T>.NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665471);
			KeyframeGroup<T>.NativeMethodInfoPtr_set_name_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665472);
			KeyframeGroup<T>.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665473);
			KeyframeGroup<T>.NativeMethodInfoPtr_set_id_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665474);
			KeyframeGroup<T>.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665475);
			KeyframeGroup<T>.NativeMethodInfoPtr_AddKeyFrame_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665476);
			KeyframeGroup<T>.NativeMethodInfoPtr_RemoveKeyFrame_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665477);
			KeyframeGroup<T>.NativeMethodInfoPtr_RemoveKeyFrame_Public_Virtual_Final_New_Void_IBaseKeyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665478);
			KeyframeGroup<T>.NativeMethodInfoPtr_GetKeyFrameCount_Public_Virtual_Final_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665479);
			KeyframeGroup<T>.NativeMethodInfoPtr_GetKeyframe_Public_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665480);
			KeyframeGroup<T>.NativeMethodInfoPtr_SortKeyframes_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665481);
			KeyframeGroup<T>.NativeMethodInfoPtr_CurveAdjustedBlendingTime_Public_Single_InterpolationCurve_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665482);
			KeyframeGroup<T>.NativeMethodInfoPtr_GetPreviousKeyFrame_Public_T_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665483);
			KeyframeGroup<T>.NativeMethodInfoPtr_GetSurroundingKeyFrames_Public_Boolean_Single_byref_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665484);
			KeyframeGroup<T>.NativeMethodInfoPtr_GetSurroundingKeyFrames_Public_Boolean_Single_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665485);
			KeyframeGroup<T>.NativeMethodInfoPtr_ProgressBetweenSurroundingKeyframes_Public_Static_Single_Single_BaseKeyframe_BaseKeyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665486);
			KeyframeGroup<T>.NativeMethodInfoPtr_ProgressBetweenSurroundingKeyframes_Public_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665487);
			KeyframeGroup<T>.NativeMethodInfoPtr_WidthBetweenCircularValues_Public_Static_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665488);
			KeyframeGroup<T>.NativeMethodInfoPtr_TrimToSingleKeyframe_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665489);
			KeyframeGroup<T>.NativeMethodInfoPtr_GetShortestInterpolationDirection_Public_InterpolationDirection_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665490);
			KeyframeGroup<T>.NativeMethodInfoPtr_CalculateCircularDistances_Public_Void_Single_Single_Single_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665491);
			KeyframeGroup<T>.NativeMethodInfoPtr_InterpolateFloat_Public_Single_InterpolationCurve_InterpolationDirection_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665492);
			KeyframeGroup<T>.NativeMethodInfoPtr_AutoInterpolation_Public_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665493);
			KeyframeGroup<T>.NativeMethodInfoPtr_ForwardInterpolation_Public_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665494);
			KeyframeGroup<T>.NativeMethodInfoPtr_ReverseInterpolation_Public_Single_Single_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr, 100665495);
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x000ACB70 File Offset: 0x000AAD70
		// (set) Token: 0x060012F6 RID: 4854 RVA: 0x000ACBA8 File Offset: 0x000AADA8
		public unsafe virtual string name
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_set_name_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x060012F7 RID: 4855 RVA: 0x000ACBEC File Offset: 0x000AADEC
		// (set) Token: 0x060012F8 RID: 4856 RVA: 0x000ACC24 File Offset: 0x000AAE24
		public unsafe virtual string id
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_set_id_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x000ACC68 File Offset: 0x000AAE68
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 90059, RefRangeEnd = 90073, XrefRangeStart = 90050, XrefRangeEnd = 90059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyframeGroup(string name) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyframeGroup<T>>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x000ACCB4 File Offset: 0x000AAEB4
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 90079, RefRangeEnd = 90089, XrefRangeStart = 90073, XrefRangeEnd = 90079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddKeyFrame(T keyFrame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = keyFrame;
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
				ptr4 = ref keyFrame;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_AddKeyFrame_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FB RID: 4859 RVA: 0x000ACD44 File Offset: 0x000AAF44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90089, XrefRangeEnd = 90098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveKeyFrame(T keyFrame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = keyFrame;
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
				ptr4 = ref keyFrame;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_RemoveKeyFrame_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FC RID: 4860 RVA: 0x000ACDD4 File Offset: 0x000AAFD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90098, XrefRangeEnd = 90105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveKeyFrame(IBaseKeyframe keyframe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(keyframe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_RemoveKeyFrame_Public_Virtual_Final_New_Void_IBaseKeyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012FD RID: 4861 RVA: 0x000ACE18 File Offset: 0x000AB018
		[CallerCount(58)]
		[CachedScanResults(RefRangeStart = 37215, RefRangeEnd = 37273, XrefRangeStart = 37215, XrefRangeEnd = 37273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int GetKeyFrameCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_GetKeyFrameCount_Public_Virtual_Final_New_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012FE RID: 4862 RVA: 0x000ACE54 File Offset: 0x000AB054
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 37185, RefRangeEnd = 37203, XrefRangeStart = 37185, XrefRangeEnd = 37203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetKeyframe(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_GetKeyframe_Public_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060012FF RID: 4863 RVA: 0x000ACE9C File Offset: 0x000AB09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90105, XrefRangeEnd = 90107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SortKeyframes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_SortKeyframes_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x000ACED0 File Offset: 0x000AB0D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90108, RefRangeEnd = 90110, XrefRangeStart = 90107, XrefRangeEnd = 90108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float CurveAdjustedBlendingTime(InterpolationCurve curve, float t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref curve;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_CurveAdjustedBlendingTime_Public_Single_InterpolationCurve_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x000ACF28 File Offset: 0x000AB128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90110, XrefRangeEnd = 90115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetPreviousKeyFrame(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_GetPreviousKeyFrame_Public_T_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x000ACF70 File Offset: 0x000AB170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90115, XrefRangeEnd = 90116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetSurroundingKeyFrames(float time, out T beforeKeyframe, out T afterKeyframe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref beforeKeyframe;
			}
			ptr2 = intPtr2;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			IntPtr intPtr4;
			if (!typeof(T).IsValueType)
			{
				intPtr3 = 0;
				intPtr4 = &intPtr3;
			}
			else
			{
				intPtr4 = ref afterKeyframe;
			}
			ptr3 = intPtr4;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_GetSurroundingKeyFrames_Public_Boolean_Single_byref_T_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr7 = intPtr;
				beforeKeyframe = ((intPtr7 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr7, false, false));
			}
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr8 = intPtr3;
				afterKeyframe = ((intPtr8 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr8, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr5);
		}

		// Token: 0x06001303 RID: 4867 RVA: 0x000AD058 File Offset: 0x000AB258
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 90126, RefRangeEnd = 90133, XrefRangeStart = 90116, XrefRangeEnd = 90126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetSurroundingKeyFrames(float time, out int beforeIndex, out int afterIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &beforeIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &afterIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_GetSurroundingKeyFrames_Public_Boolean_Single_byref_Int32_byref_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001304 RID: 4868 RVA: 0x000AD0C0 File Offset: 0x000AB2C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90143, RefRangeEnd = 90144, XrefRangeStart = 90133, XrefRangeEnd = 90143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ProgressBetweenSurroundingKeyframes(float time, BaseKeyframe beforeKey, BaseKeyframe afterKey)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beforeKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(afterKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_ProgressBetweenSurroundingKeyframes_Public_Static_Single_Single_BaseKeyframe_BaseKeyframe_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x000AD124 File Offset: 0x000AB324
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90150, RefRangeEnd = 90151, XrefRangeStart = 90144, XrefRangeEnd = 90150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ProgressBetweenSurroundingKeyframes(float time, float beforeKeyTime, float afterKeyTime)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beforeKeyTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref afterKeyTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_ProgressBetweenSurroundingKeyframes_Public_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x000AD180 File Offset: 0x000AB380
		[CallerCount(0)]
		public unsafe static float WidthBetweenCircularValues(float begin, float end)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref begin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_WidthBetweenCircularValues_Public_Static_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x000AD1CC File Offset: 0x000AB3CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90151, XrefRangeEnd = 90152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void TrimToSingleKeyframe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_TrimToSingleKeyframe_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x000AD200 File Offset: 0x000AB400
		[CallerCount(0)]
		public unsafe InterpolationDirection GetShortestInterpolationDirection(float previousKeyValue, float nextKeyValue, float minValue, float maxValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref previousKeyValue;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nextKeyValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_GetShortestInterpolationDirection_Public_InterpolationDirection_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x000AD274 File Offset: 0x000AB474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90152, XrefRangeEnd = 90153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalculateCircularDistances(float previousKeyValue, float nextKeyValue, float minValue, float maxValue, out float forwardDistance, out float reverseDistance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref previousKeyValue;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nextKeyValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValue;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &forwardDistance;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &reverseDistance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_CalculateCircularDistances_Public_Void_Single_Single_Single_Single_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x000AD2FC File Offset: 0x000AB4FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90170, RefRangeEnd = 90171, XrefRangeStart = 90153, XrefRangeEnd = 90170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float InterpolateFloat(InterpolationCurve curve, InterpolationDirection direction, float time, float beforeTime, float nextTime, float previousKeyValue, float nextKeyValue, float minValue, float maxValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref curve;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref direction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref beforeTime;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nextTime;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousKeyValue;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nextKeyValue;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minValue;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_InterpolateFloat_Public_Single_InterpolationCurve_InterpolationDirection_Single_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x000AD3B8 File Offset: 0x000AB5B8
		[CallerCount(0)]
		public unsafe float AutoInterpolation(float curvedTime, float previousValue, float nextValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref curvedTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nextValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_AutoInterpolation_Public_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x000AD420 File Offset: 0x000AB620
		[CallerCount(0)]
		public unsafe float ForwardInterpolation(float time, float previousKeyValue, float nextKeyValue, float minValue, float maxValue, float distance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousKeyValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nextKeyValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minValue;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValue;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_ForwardInterpolation_Public_Single_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x000AD4B0 File Offset: 0x000AB6B0
		[CallerCount(0)]
		public unsafe float ReverseInterpolation(float time, float previousKeyValue, float nextKeyValue, float minValue, float maxValue, float distance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref previousKeyValue;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nextKeyValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref minValue;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxValue;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref distance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroup<T>.NativeMethodInfoPtr_ReverseInterpolation_Public_Single_Single_Single_Single_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x0000B5D6 File Offset: 0x000097D6
		public KeyframeGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x0600130F RID: 4879 RVA: 0x000AD540 File Offset: 0x000AB740
		// (set) Token: 0x06001310 RID: 4880 RVA: 0x0000B5DF File Offset: 0x000097DF
		public unsafe List<T> keyframes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroup<T>.NativeFieldInfoPtr_keyframes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroup<T>.NativeFieldInfoPtr_keyframes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06001311 RID: 4881 RVA: 0x000AD570 File Offset: 0x000AB770
		// (set) Token: 0x06001312 RID: 4882 RVA: 0x0000B5FE File Offset: 0x000097FE
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroup<T>.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroup<T>.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001313 RID: 4883 RVA: 0x000AD598 File Offset: 0x000AB798
		// (set) Token: 0x06001314 RID: 4884 RVA: 0x0000B61D File Offset: 0x0000981D
		public unsafe string m_Id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroup<T>.NativeFieldInfoPtr_m_Id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroup<T>.NativeFieldInfoPtr_m_Id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000C97 RID: 3223
		private static readonly IntPtr NativeFieldInfoPtr_keyframes;

		// Token: 0x04000C98 RID: 3224
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x04000C99 RID: 3225
		private static readonly IntPtr NativeFieldInfoPtr_m_Id;

		// Token: 0x04000C9A RID: 3226
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000C9B RID: 3227
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Public_Virtual_Final_New_set_Void_String_0;

		// Token: 0x04000C9C RID: 3228
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000C9D RID: 3229
		private static readonly IntPtr NativeMethodInfoPtr_set_id_Public_set_Void_String_0;

		// Token: 0x04000C9E RID: 3230
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000C9F RID: 3231
		private static readonly IntPtr NativeMethodInfoPtr_AddKeyFrame_Public_Void_T_0;

		// Token: 0x04000CA0 RID: 3232
		private static readonly IntPtr NativeMethodInfoPtr_RemoveKeyFrame_Public_Void_T_0;

		// Token: 0x04000CA1 RID: 3233
		private static readonly IntPtr NativeMethodInfoPtr_RemoveKeyFrame_Public_Virtual_Final_New_Void_IBaseKeyframe_0;

		// Token: 0x04000CA2 RID: 3234
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyFrameCount_Public_Virtual_Final_New_Int32_0;

		// Token: 0x04000CA3 RID: 3235
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyframe_Public_T_Int32_0;

		// Token: 0x04000CA4 RID: 3236
		private static readonly IntPtr NativeMethodInfoPtr_SortKeyframes_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000CA5 RID: 3237
		private static readonly IntPtr NativeMethodInfoPtr_CurveAdjustedBlendingTime_Public_Single_InterpolationCurve_Single_0;

		// Token: 0x04000CA6 RID: 3238
		private static readonly IntPtr NativeMethodInfoPtr_GetPreviousKeyFrame_Public_T_Single_0;

		// Token: 0x04000CA7 RID: 3239
		private static readonly IntPtr NativeMethodInfoPtr_GetSurroundingKeyFrames_Public_Boolean_Single_byref_T_byref_T_0;

		// Token: 0x04000CA8 RID: 3240
		private static readonly IntPtr NativeMethodInfoPtr_GetSurroundingKeyFrames_Public_Boolean_Single_byref_Int32_byref_Int32_0;

		// Token: 0x04000CA9 RID: 3241
		private static readonly IntPtr NativeMethodInfoPtr_ProgressBetweenSurroundingKeyframes_Public_Static_Single_Single_BaseKeyframe_BaseKeyframe_0;

		// Token: 0x04000CAA RID: 3242
		private static readonly IntPtr NativeMethodInfoPtr_ProgressBetweenSurroundingKeyframes_Public_Static_Single_Single_Single_Single_0;

		// Token: 0x04000CAB RID: 3243
		private static readonly IntPtr NativeMethodInfoPtr_WidthBetweenCircularValues_Public_Static_Single_Single_Single_0;

		// Token: 0x04000CAC RID: 3244
		private static readonly IntPtr NativeMethodInfoPtr_TrimToSingleKeyframe_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000CAD RID: 3245
		private static readonly IntPtr NativeMethodInfoPtr_GetShortestInterpolationDirection_Public_InterpolationDirection_Single_Single_Single_Single_0;

		// Token: 0x04000CAE RID: 3246
		private static readonly IntPtr NativeMethodInfoPtr_CalculateCircularDistances_Public_Void_Single_Single_Single_Single_byref_Single_byref_Single_0;

		// Token: 0x04000CAF RID: 3247
		private static readonly IntPtr NativeMethodInfoPtr_InterpolateFloat_Public_Single_InterpolationCurve_InterpolationDirection_Single_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x04000CB0 RID: 3248
		private static readonly IntPtr NativeMethodInfoPtr_AutoInterpolation_Public_Single_Single_Single_Single_0;

		// Token: 0x04000CB1 RID: 3249
		private static readonly IntPtr NativeMethodInfoPtr_ForwardInterpolation_Public_Single_Single_Single_Single_Single_Single_Single_0;

		// Token: 0x04000CB2 RID: 3250
		private static readonly IntPtr NativeMethodInfoPtr_ReverseInterpolation_Public_Single_Single_Single_Single_Single_Single_Single_0;
	}
}
