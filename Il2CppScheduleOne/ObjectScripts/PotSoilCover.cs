using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000733 RID: 1843
	public class PotSoilCover : MonoBehaviour
	{
		// Token: 0x0600A8B5 RID: 43189 RVA: 0x002A261C File Offset: 0x002A081C
		// Note: this type is marked as 'beforefieldinit'.
		static PotSoilCover()
		{
			Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "PotSoilCover");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr);
			PotSoilCover.NativeFieldInfoPtr_TEXTURE_SIZE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "TEXTURE_SIZE");
			PotSoilCover.NativeFieldInfoPtr_POUR_RADIUS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "POUR_RADIUS");
			PotSoilCover.NativeFieldInfoPtr_UPDATES_PER_SECOND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "UPDATES_PER_SECOND");
			PotSoilCover.NativeFieldInfoPtr_COVERAGE_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "COVERAGE_THRESHOLD");
			PotSoilCover.NativeFieldInfoPtr_BASE_COVERAGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "BASE_COVERAGE");
			PotSoilCover.NativeFieldInfoPtr_SUCCESS_COVERAGE_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "SUCCESS_COVERAGE_THRESHOLD");
			PotSoilCover.NativeFieldInfoPtr_DELAY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "DELAY");
			PotSoilCover.NativeFieldInfoPtr_CurrentCoverage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "CurrentCoverage");
			PotSoilCover.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "Radius");
			PotSoilCover.NativeFieldInfoPtr_MeshRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "MeshRenderer");
			PotSoilCover.NativeFieldInfoPtr_PourMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "PourMask");
			PotSoilCover.NativeFieldInfoPtr_onSufficientCoverage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "onSufficientCoverage");
			PotSoilCover.NativeFieldInfoPtr_queued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "queued");
			PotSoilCover.NativeFieldInfoPtr_queuedWorldPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "queuedWorldPos");
			PotSoilCover.NativeFieldInfoPtr_mainTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "mainTex");
			PotSoilCover.NativeFieldInfoPtr_relative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "relative");
			PotSoilCover.NativeFieldInfoPtr_vector2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "vector2");
			PotSoilCover.NativeFieldInfoPtr_normalizedOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "normalizedOffset");
			PotSoilCover.NativeFieldInfoPtr_originPixel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "originPixel");
			PotSoilCover.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100683965);
			PotSoilCover.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100683966);
			PotSoilCover.NativeMethodInfoPtr_ConfigureAppearance_Public_Void_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100683967);
			PotSoilCover.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100683968);
			PotSoilCover.NativeMethodInfoPtr_QueuePour_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100683969);
			PotSoilCover.NativeMethodInfoPtr_GetNormalizedProgress_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100683970);
			PotSoilCover.NativeMethodInfoPtr_CheckQueue_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100683971);
			PotSoilCover.NativeMethodInfoPtr_Blank_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100683972);
			PotSoilCover.NativeMethodInfoPtr_DelayedApplyPour_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100683973);
			PotSoilCover.NativeMethodInfoPtr_ApplyPour_Private_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100683974);
			PotSoilCover.NativeMethodInfoPtr_GetPourMaskValue_Private_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100683975);
			PotSoilCover.NativeMethodInfoPtr_GetCoverage_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100683976);
			PotSoilCover.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, 100683977);
		}

		// Token: 0x0600A8B6 RID: 43190 RVA: 0x002A28CC File Offset: 0x002A0ACC
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8B7 RID: 43191 RVA: 0x002A2900 File Offset: 0x002A0B00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293562, XrefRangeEnd = 293568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8B8 RID: 43192 RVA: 0x002A2934 File Offset: 0x002A0B34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 293577, RefRangeEnd = 293579, XrefRangeStart = 293568, XrefRangeEnd = 293577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureAppearance(Color col, float transparency)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref col;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transparency;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_ConfigureAppearance_Public_Void_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8B9 RID: 43193 RVA: 0x002A2980 File Offset: 0x002A0B80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 293592, RefRangeEnd = 293593, XrefRangeStart = 293579, XrefRangeEnd = 293592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8BA RID: 43194 RVA: 0x002A29B4 File Offset: 0x002A0BB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 293593, RefRangeEnd = 293594, XrefRangeStart = 293593, XrefRangeEnd = 293593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueuePour(Vector3 worldSpacePosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldSpacePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_QueuePour_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8BB RID: 43195 RVA: 0x002A29F4 File Offset: 0x002A0BF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 293594, RefRangeEnd = 293595, XrefRangeStart = 293594, XrefRangeEnd = 293594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetNormalizedProgress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_GetNormalizedProgress_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A8BC RID: 43196 RVA: 0x002A2A30 File Offset: 0x002A0C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293595, XrefRangeEnd = 293600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CheckQueue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_CheckQueue_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600A8BD RID: 43197 RVA: 0x002A2A70 File Offset: 0x002A0C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293600, XrefRangeEnd = 293615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Blank()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_Blank_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8BE RID: 43198 RVA: 0x002A2AA4 File Offset: 0x002A0CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293615, XrefRangeEnd = 293627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DelayedApplyPour(Vector3 worldSpace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldSpace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_DelayedApplyPour_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8BF RID: 43199 RVA: 0x002A2AE4 File Offset: 0x002A0CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293627, XrefRangeEnd = 293641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyPour(Vector3 worldSpace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref worldSpace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_ApplyPour_Private_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8C0 RID: 43200 RVA: 0x002A2B24 File Offset: 0x002A0D24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 293642, RefRangeEnd = 293643, XrefRangeStart = 293641, XrefRangeEnd = 293642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetPourMaskValue(int x, int y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_GetPourMaskValue_Private_Single_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A8C1 RID: 43201 RVA: 0x002A2B7C File Offset: 0x002A0D7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293643, XrefRangeEnd = 293644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetCoverage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr_GetCoverage_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600A8C2 RID: 43202 RVA: 0x002A2BB8 File Offset: 0x002A0DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293644, XrefRangeEnd = 293647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotSoilCover() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A8C3 RID: 43203 RVA: 0x0005312D File Offset: 0x0005132D
		public PotSoilCover(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700341C RID: 13340
		// (get) Token: 0x0600A8C4 RID: 43204 RVA: 0x002A2BF4 File Offset: 0x002A0DF4
		// (set) Token: 0x0600A8C5 RID: 43205 RVA: 0x00053136 File Offset: 0x00051336
		public unsafe static int TEXTURE_SIZE
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PotSoilCover.NativeFieldInfoPtr_TEXTURE_SIZE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PotSoilCover.NativeFieldInfoPtr_TEXTURE_SIZE, (void*)(&value));
			}
		}

		// Token: 0x1700341D RID: 13341
		// (get) Token: 0x0600A8C6 RID: 43206 RVA: 0x002A2C10 File Offset: 0x002A0E10
		// (set) Token: 0x0600A8C7 RID: 43207 RVA: 0x00053144 File Offset: 0x00051344
		public unsafe static int POUR_RADIUS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PotSoilCover.NativeFieldInfoPtr_POUR_RADIUS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PotSoilCover.NativeFieldInfoPtr_POUR_RADIUS, (void*)(&value));
			}
		}

		// Token: 0x1700341E RID: 13342
		// (get) Token: 0x0600A8C8 RID: 43208 RVA: 0x002A2C2C File Offset: 0x002A0E2C
		// (set) Token: 0x0600A8C9 RID: 43209 RVA: 0x00053152 File Offset: 0x00051352
		public unsafe static int UPDATES_PER_SECOND
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PotSoilCover.NativeFieldInfoPtr_UPDATES_PER_SECOND, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PotSoilCover.NativeFieldInfoPtr_UPDATES_PER_SECOND, (void*)(&value));
			}
		}

		// Token: 0x1700341F RID: 13343
		// (get) Token: 0x0600A8CA RID: 43210 RVA: 0x002A2C48 File Offset: 0x002A0E48
		// (set) Token: 0x0600A8CB RID: 43211 RVA: 0x00053160 File Offset: 0x00051360
		public unsafe static float COVERAGE_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PotSoilCover.NativeFieldInfoPtr_COVERAGE_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PotSoilCover.NativeFieldInfoPtr_COVERAGE_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17003420 RID: 13344
		// (get) Token: 0x0600A8CC RID: 43212 RVA: 0x002A2C64 File Offset: 0x002A0E64
		// (set) Token: 0x0600A8CD RID: 43213 RVA: 0x0005316E File Offset: 0x0005136E
		public unsafe static float BASE_COVERAGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PotSoilCover.NativeFieldInfoPtr_BASE_COVERAGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PotSoilCover.NativeFieldInfoPtr_BASE_COVERAGE, (void*)(&value));
			}
		}

		// Token: 0x17003421 RID: 13345
		// (get) Token: 0x0600A8CE RID: 43214 RVA: 0x002A2C80 File Offset: 0x002A0E80
		// (set) Token: 0x0600A8CF RID: 43215 RVA: 0x0005317C File Offset: 0x0005137C
		public unsafe static float SUCCESS_COVERAGE_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PotSoilCover.NativeFieldInfoPtr_SUCCESS_COVERAGE_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PotSoilCover.NativeFieldInfoPtr_SUCCESS_COVERAGE_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17003422 RID: 13346
		// (get) Token: 0x0600A8D0 RID: 43216 RVA: 0x002A2C9C File Offset: 0x002A0E9C
		// (set) Token: 0x0600A8D1 RID: 43217 RVA: 0x0005318A File Offset: 0x0005138A
		public unsafe static float DELAY
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PotSoilCover.NativeFieldInfoPtr_DELAY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PotSoilCover.NativeFieldInfoPtr_DELAY, (void*)(&value));
			}
		}

		// Token: 0x17003423 RID: 13347
		// (get) Token: 0x0600A8D2 RID: 43218 RVA: 0x002A2CB8 File Offset: 0x002A0EB8
		// (set) Token: 0x0600A8D3 RID: 43219 RVA: 0x00053198 File Offset: 0x00051398
		public unsafe float CurrentCoverage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_CurrentCoverage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_CurrentCoverage)) = value;
			}
		}

		// Token: 0x17003424 RID: 13348
		// (get) Token: 0x0600A8D4 RID: 43220 RVA: 0x002A2CE0 File Offset: 0x002A0EE0
		// (set) Token: 0x0600A8D5 RID: 43221 RVA: 0x000531B3 File Offset: 0x000513B3
		public unsafe float Radius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_Radius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_Radius)) = value;
			}
		}

		// Token: 0x17003425 RID: 13349
		// (get) Token: 0x0600A8D6 RID: 43222 RVA: 0x002A2D08 File Offset: 0x002A0F08
		// (set) Token: 0x0600A8D7 RID: 43223 RVA: 0x000531CE File Offset: 0x000513CE
		public unsafe MeshRenderer MeshRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_MeshRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_MeshRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003426 RID: 13350
		// (get) Token: 0x0600A8D8 RID: 43224 RVA: 0x002A2D38 File Offset: 0x002A0F38
		// (set) Token: 0x0600A8D9 RID: 43225 RVA: 0x000531ED File Offset: 0x000513ED
		public unsafe Texture2D PourMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_PourMask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_PourMask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003427 RID: 13351
		// (get) Token: 0x0600A8DA RID: 43226 RVA: 0x002A2D68 File Offset: 0x002A0F68
		// (set) Token: 0x0600A8DB RID: 43227 RVA: 0x0005320C File Offset: 0x0005140C
		public unsafe UnityEvent onSufficientCoverage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_onSufficientCoverage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_onSufficientCoverage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003428 RID: 13352
		// (get) Token: 0x0600A8DC RID: 43228 RVA: 0x002A2D98 File Offset: 0x002A0F98
		// (set) Token: 0x0600A8DD RID: 43229 RVA: 0x0005322B File Offset: 0x0005142B
		public unsafe bool queued
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_queued);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_queued)) = value;
			}
		}

		// Token: 0x17003429 RID: 13353
		// (get) Token: 0x0600A8DE RID: 43230 RVA: 0x002A2DC0 File Offset: 0x002A0FC0
		// (set) Token: 0x0600A8DF RID: 43231 RVA: 0x00053246 File Offset: 0x00051446
		public unsafe Vector3 queuedWorldPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_queuedWorldPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_queuedWorldPos)) = value;
			}
		}

		// Token: 0x1700342A RID: 13354
		// (get) Token: 0x0600A8E0 RID: 43232 RVA: 0x002A2DE8 File Offset: 0x002A0FE8
		// (set) Token: 0x0600A8E1 RID: 43233 RVA: 0x00053261 File Offset: 0x00051461
		public unsafe Texture2D mainTex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_mainTex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_mainTex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700342B RID: 13355
		// (get) Token: 0x0600A8E2 RID: 43234 RVA: 0x002A2E18 File Offset: 0x002A1018
		// (set) Token: 0x0600A8E3 RID: 43235 RVA: 0x00053280 File Offset: 0x00051480
		public unsafe Vector3 relative
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_relative);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_relative)) = value;
			}
		}

		// Token: 0x1700342C RID: 13356
		// (get) Token: 0x0600A8E4 RID: 43236 RVA: 0x002A2E40 File Offset: 0x002A1040
		// (set) Token: 0x0600A8E5 RID: 43237 RVA: 0x0005329B File Offset: 0x0005149B
		public unsafe Vector2 vector2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_vector2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_vector2)) = value;
			}
		}

		// Token: 0x1700342D RID: 13357
		// (get) Token: 0x0600A8E6 RID: 43238 RVA: 0x002A2E68 File Offset: 0x002A1068
		// (set) Token: 0x0600A8E7 RID: 43239 RVA: 0x000532B6 File Offset: 0x000514B6
		public unsafe Vector2 normalizedOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_normalizedOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_normalizedOffset)) = value;
			}
		}

		// Token: 0x1700342E RID: 13358
		// (get) Token: 0x0600A8E8 RID: 43240 RVA: 0x002A2E90 File Offset: 0x002A1090
		// (set) Token: 0x0600A8E9 RID: 43241 RVA: 0x000532D1 File Offset: 0x000514D1
		public unsafe Vector2 originPixel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_originPixel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.NativeFieldInfoPtr_originPixel)) = value;
			}
		}

		// Token: 0x04007141 RID: 28993
		private static readonly IntPtr NativeFieldInfoPtr_TEXTURE_SIZE;

		// Token: 0x04007142 RID: 28994
		private static readonly IntPtr NativeFieldInfoPtr_POUR_RADIUS;

		// Token: 0x04007143 RID: 28995
		private static readonly IntPtr NativeFieldInfoPtr_UPDATES_PER_SECOND;

		// Token: 0x04007144 RID: 28996
		private static readonly IntPtr NativeFieldInfoPtr_COVERAGE_THRESHOLD;

		// Token: 0x04007145 RID: 28997
		private static readonly IntPtr NativeFieldInfoPtr_BASE_COVERAGE;

		// Token: 0x04007146 RID: 28998
		private static readonly IntPtr NativeFieldInfoPtr_SUCCESS_COVERAGE_THRESHOLD;

		// Token: 0x04007147 RID: 28999
		private static readonly IntPtr NativeFieldInfoPtr_DELAY;

		// Token: 0x04007148 RID: 29000
		private static readonly IntPtr NativeFieldInfoPtr_CurrentCoverage;

		// Token: 0x04007149 RID: 29001
		private static readonly IntPtr NativeFieldInfoPtr_Radius;

		// Token: 0x0400714A RID: 29002
		private static readonly IntPtr NativeFieldInfoPtr_MeshRenderer;

		// Token: 0x0400714B RID: 29003
		private static readonly IntPtr NativeFieldInfoPtr_PourMask;

		// Token: 0x0400714C RID: 29004
		private static readonly IntPtr NativeFieldInfoPtr_onSufficientCoverage;

		// Token: 0x0400714D RID: 29005
		private static readonly IntPtr NativeFieldInfoPtr_queued;

		// Token: 0x0400714E RID: 29006
		private static readonly IntPtr NativeFieldInfoPtr_queuedWorldPos;

		// Token: 0x0400714F RID: 29007
		private static readonly IntPtr NativeFieldInfoPtr_mainTex;

		// Token: 0x04007150 RID: 29008
		private static readonly IntPtr NativeFieldInfoPtr_relative;

		// Token: 0x04007151 RID: 29009
		private static readonly IntPtr NativeFieldInfoPtr_vector2;

		// Token: 0x04007152 RID: 29010
		private static readonly IntPtr NativeFieldInfoPtr_normalizedOffset;

		// Token: 0x04007153 RID: 29011
		private static readonly IntPtr NativeFieldInfoPtr_originPixel;

		// Token: 0x04007154 RID: 29012
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007155 RID: 29013
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04007156 RID: 29014
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureAppearance_Public_Void_Color_Single_0;

		// Token: 0x04007157 RID: 29015
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04007158 RID: 29016
		private static readonly IntPtr NativeMethodInfoPtr_QueuePour_Public_Void_Vector3_0;

		// Token: 0x04007159 RID: 29017
		private static readonly IntPtr NativeMethodInfoPtr_GetNormalizedProgress_Public_Single_0;

		// Token: 0x0400715A RID: 29018
		private static readonly IntPtr NativeMethodInfoPtr_CheckQueue_Private_IEnumerator_0;

		// Token: 0x0400715B RID: 29019
		private static readonly IntPtr NativeMethodInfoPtr_Blank_Private_Void_0;

		// Token: 0x0400715C RID: 29020
		private static readonly IntPtr NativeMethodInfoPtr_DelayedApplyPour_Private_Void_Vector3_0;

		// Token: 0x0400715D RID: 29021
		private static readonly IntPtr NativeMethodInfoPtr_ApplyPour_Private_Void_Vector3_0;

		// Token: 0x0400715E RID: 29022
		private static readonly IntPtr NativeMethodInfoPtr_GetPourMaskValue_Private_Single_Int32_Int32_0;

		// Token: 0x0400715F RID: 29023
		private static readonly IntPtr NativeMethodInfoPtr_GetCoverage_Private_Single_0;

		// Token: 0x04007160 RID: 29024
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BDB RID: 3035
		[ObfuscatedName("ScheduleOne.ObjectScripts.PotSoilCover+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DEB9 RID: 57017 RVA: 0x0034854C File Offset: 0x0034674C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0>.NativeClassPtr);
				PotSoilCover.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0>.NativeClassPtr, "<>4__this");
				PotSoilCover.__c__DisplayClass27_0.NativeFieldInfoPtr_worldSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0>.NativeClassPtr, "worldSpace");
				PotSoilCover.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0>.NativeClassPtr, 100683978);
				PotSoilCover.__c__DisplayClass27_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0>.NativeClassPtr, 100683979);
			}

			// Token: 0x0600DEBA RID: 57018 RVA: 0x003485C8 File Offset: 0x003467C8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEBB RID: 57019 RVA: 0x00348604 File Offset: 0x00346804
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293530, XrefRangeEnd = 293535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.__c__DisplayClass27_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DEBC RID: 57020 RVA: 0x0006C972 File Offset: 0x0006AB72
			public __c__DisplayClass27_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700450A RID: 17674
			// (get) Token: 0x0600DEBD RID: 57021 RVA: 0x00348644 File Offset: 0x00346844
			// (set) Token: 0x0600DEBE RID: 57022 RVA: 0x0006C97B File Offset: 0x0006AB7B
			public unsafe PotSoilCover __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotSoilCover>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700450B RID: 17675
			// (get) Token: 0x0600DEBF RID: 57023 RVA: 0x00348674 File Offset: 0x00346874
			// (set) Token: 0x0600DEC0 RID: 57024 RVA: 0x0006C99A File Offset: 0x0006AB9A
			public unsafe Vector3 worldSpace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.__c__DisplayClass27_0.NativeFieldInfoPtr_worldSpace);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.__c__DisplayClass27_0.NativeFieldInfoPtr_worldSpace)) = value;
				}
			}

			// Token: 0x04009521 RID: 38177
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009522 RID: 38178
			private static readonly IntPtr NativeFieldInfoPtr_worldSpace;

			// Token: 0x04009523 RID: 38179
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009524 RID: 38180
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C86 RID: 3206
			[ObfuscatedName("ScheduleOne.ObjectScripts.PotSoilCover+<>c__DisplayClass27_0+<<DelayedApplyPour>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E6D4 RID: 59092 RVA: 0x0035FE48 File Offset: 0x0035E048
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0>.NativeClassPtr, "<<DelayedApplyPour>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683980);
					PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683981);
					PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683982);
					PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683983);
					PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683984);
					PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100683985);
				}

				// Token: 0x0600E6D5 RID: 59093 RVA: 0x0035FF28 File Offset: 0x0035E128
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E6D6 RID: 59094 RVA: 0x0035FF70 File Offset: 0x0035E170
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E6D7 RID: 59095 RVA: 0x0035FFA4 File Offset: 0x0035E1A4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293520, XrefRangeEnd = 293525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170047E8 RID: 18408
				// (get) Token: 0x0600E6D8 RID: 59096 RVA: 0x0035FFE0 File Offset: 0x0035E1E0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E6D9 RID: 59097 RVA: 0x00360020 File Offset: 0x0035E220
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293525, XrefRangeEnd = 293530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170047E9 RID: 18409
				// (get) Token: 0x0600E6DA RID: 59098 RVA: 0x00360054 File Offset: 0x0035E254
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E6DB RID: 59099 RVA: 0x00070B13 File Offset: 0x0006ED13
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047E5 RID: 18405
				// (get) Token: 0x0600E6DC RID: 59100 RVA: 0x00360094 File Offset: 0x0035E294
				// (set) Token: 0x0600E6DD RID: 59101 RVA: 0x00070B1C File Offset: 0x0006ED1C
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047E6 RID: 18406
				// (get) Token: 0x0600E6DE RID: 59102 RVA: 0x003600BC File Offset: 0x0035E2BC
				// (set) Token: 0x0600E6DF RID: 59103 RVA: 0x00070B37 File Offset: 0x0006ED37
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047E7 RID: 18407
				// (get) Token: 0x0600E6E0 RID: 59104 RVA: 0x003600EC File Offset: 0x0035E2EC
				// (set) Token: 0x0600E6E1 RID: 59105 RVA: 0x00070B56 File Offset: 0x0006ED56
				public unsafe PotSoilCover.__c__DisplayClass27_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotSoilCover.__c__DisplayClass27_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover.__c__DisplayClass27_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009A40 RID: 39488
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009A41 RID: 39489
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009A42 RID: 39490
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009A43 RID: 39491
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009A44 RID: 39492
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A45 RID: 39493
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009A46 RID: 39494
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009A47 RID: 39495
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A48 RID: 39496
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000BDC RID: 3036
		[ObfuscatedName("ScheduleOne.ObjectScripts.PotSoilCover+<CheckQueue>d__25")]
		public sealed class _CheckQueue_d__25 : Il2CppSystem.Object
		{
			// Token: 0x0600DEC1 RID: 57025 RVA: 0x0034869C File Offset: 0x0034689C
			// Note: this type is marked as 'beforefieldinit'.
			static _CheckQueue_d__25()
			{
				Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PotSoilCover>.NativeClassPtr, "<CheckQueue>d__25");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr);
				PotSoilCover._CheckQueue_d__25.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr, "<>1__state");
				PotSoilCover._CheckQueue_d__25.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr, "<>2__current");
				PotSoilCover._CheckQueue_d__25.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr, "<>4__this");
				PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr, 100683986);
				PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr, 100683987);
				PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr, 100683988);
				PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr, 100683989);
				PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr, 100683990);
				PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr, 100683991);
			}

			// Token: 0x0600DEC2 RID: 57026 RVA: 0x0034877C File Offset: 0x0034697C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CheckQueue_d__25(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotSoilCover._CheckQueue_d__25>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEC3 RID: 57027 RVA: 0x003487C4 File Offset: 0x003469C4
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEC4 RID: 57028 RVA: 0x003487F8 File Offset: 0x003469F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293535, XrefRangeEnd = 293557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700450F RID: 17679
			// (get) Token: 0x0600DEC5 RID: 57029 RVA: 0x00348834 File Offset: 0x00346A34
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DEC6 RID: 57030 RVA: 0x00348874 File Offset: 0x00346A74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293557, XrefRangeEnd = 293562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004510 RID: 17680
			// (get) Token: 0x0600DEC7 RID: 57031 RVA: 0x003488A8 File Offset: 0x00346AA8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotSoilCover._CheckQueue_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DEC8 RID: 57032 RVA: 0x0006C9B5 File Offset: 0x0006ABB5
			public _CheckQueue_d__25(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700450C RID: 17676
			// (get) Token: 0x0600DEC9 RID: 57033 RVA: 0x003488E8 File Offset: 0x00346AE8
			// (set) Token: 0x0600DECA RID: 57034 RVA: 0x0006C9BE File Offset: 0x0006ABBE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover._CheckQueue_d__25.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover._CheckQueue_d__25.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700450D RID: 17677
			// (get) Token: 0x0600DECB RID: 57035 RVA: 0x00348910 File Offset: 0x00346B10
			// (set) Token: 0x0600DECC RID: 57036 RVA: 0x0006C9D9 File Offset: 0x0006ABD9
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover._CheckQueue_d__25.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover._CheckQueue_d__25.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700450E RID: 17678
			// (get) Token: 0x0600DECD RID: 57037 RVA: 0x00348940 File Offset: 0x00346B40
			// (set) Token: 0x0600DECE RID: 57038 RVA: 0x0006C9F8 File Offset: 0x0006ABF8
			public unsafe PotSoilCover __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover._CheckQueue_d__25.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotSoilCover>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotSoilCover._CheckQueue_d__25.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009525 RID: 38181
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009526 RID: 38182
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009527 RID: 38183
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009528 RID: 38184
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009529 RID: 38185
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400952A RID: 38186
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400952B RID: 38187
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400952C RID: 38188
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400952D RID: 38189
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
