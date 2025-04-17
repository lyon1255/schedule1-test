using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace UnityTemplateProjects
{
	// Token: 0x0200007A RID: 122
	public class SimpleCameraController : MonoBehaviour
	{
		// Token: 0x0600088D RID: 2189 RVA: 0x0008AB78 File Offset: 0x00088D78
		// Note: this type is marked as 'beforefieldinit'.
		static SimpleCameraController()
		{
			Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityTemplateProjects", "SimpleCameraController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr);
			SimpleCameraController.NativeFieldInfoPtr_m_TargetCameraState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, "m_TargetCameraState");
			SimpleCameraController.NativeFieldInfoPtr_m_InterpolatingCameraState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, "m_InterpolatingCameraState");
			SimpleCameraController.NativeFieldInfoPtr_boost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, "boost");
			SimpleCameraController.NativeFieldInfoPtr_positionLerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, "positionLerpTime");
			SimpleCameraController.NativeFieldInfoPtr_mouseSensitivityCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, "mouseSensitivityCurve");
			SimpleCameraController.NativeFieldInfoPtr_rotationLerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, "rotationLerpTime");
			SimpleCameraController.NativeFieldInfoPtr_invertY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, "invertY");
			SimpleCameraController.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, 100664206);
			SimpleCameraController.NativeMethodInfoPtr_GetInputTranslationDirection_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, 100664207);
			SimpleCameraController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, 100664208);
			SimpleCameraController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, 100664209);
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x0008AC84 File Offset: 0x00088E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79233, XrefRangeEnd = 79238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCameraController.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x0008ACB8 File Offset: 0x00088EB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 79256, RefRangeEnd = 79257, XrefRangeStart = 79238, XrefRangeEnd = 79256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetInputTranslationDirection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCameraController.NativeMethodInfoPtr_GetInputTranslationDirection_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x0008ACF4 File Offset: 0x00088EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79257, XrefRangeEnd = 79294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCameraController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x0008AD28 File Offset: 0x00088F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79294, XrefRangeEnd = 79314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleCameraController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCameraController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x000069F4 File Offset: 0x00004BF4
		public SimpleCameraController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x0008AD64 File Offset: 0x00088F64
		// (set) Token: 0x06000894 RID: 2196 RVA: 0x000069FD File Offset: 0x00004BFD
		public unsafe SimpleCameraController.CameraState m_TargetCameraState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.NativeFieldInfoPtr_m_TargetCameraState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleCameraController.CameraState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.NativeFieldInfoPtr_m_TargetCameraState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x0008AD94 File Offset: 0x00088F94
		// (set) Token: 0x06000896 RID: 2198 RVA: 0x00006A1C File Offset: 0x00004C1C
		public unsafe SimpleCameraController.CameraState m_InterpolatingCameraState
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.NativeFieldInfoPtr_m_InterpolatingCameraState);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SimpleCameraController.CameraState>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.NativeFieldInfoPtr_m_InterpolatingCameraState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x0008ADC4 File Offset: 0x00088FC4
		// (set) Token: 0x06000898 RID: 2200 RVA: 0x00006A3B File Offset: 0x00004C3B
		public unsafe float boost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.NativeFieldInfoPtr_boost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.NativeFieldInfoPtr_boost)) = value;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000899 RID: 2201 RVA: 0x0008ADEC File Offset: 0x00088FEC
		// (set) Token: 0x0600089A RID: 2202 RVA: 0x00006A56 File Offset: 0x00004C56
		public unsafe float positionLerpTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.NativeFieldInfoPtr_positionLerpTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.NativeFieldInfoPtr_positionLerpTime)) = value;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x0600089B RID: 2203 RVA: 0x0008AE14 File Offset: 0x00089014
		// (set) Token: 0x0600089C RID: 2204 RVA: 0x00006A71 File Offset: 0x00004C71
		public unsafe AnimationCurve mouseSensitivityCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.NativeFieldInfoPtr_mouseSensitivityCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.NativeFieldInfoPtr_mouseSensitivityCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x0600089D RID: 2205 RVA: 0x0008AE44 File Offset: 0x00089044
		// (set) Token: 0x0600089E RID: 2206 RVA: 0x00006A90 File Offset: 0x00004C90
		public unsafe float rotationLerpTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.NativeFieldInfoPtr_rotationLerpTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.NativeFieldInfoPtr_rotationLerpTime)) = value;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x0600089F RID: 2207 RVA: 0x0008AE6C File Offset: 0x0008906C
		// (set) Token: 0x060008A0 RID: 2208 RVA: 0x00006AAB File Offset: 0x00004CAB
		public unsafe bool invertY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.NativeFieldInfoPtr_invertY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.NativeFieldInfoPtr_invertY)) = value;
			}
		}

		// Token: 0x04000532 RID: 1330
		private static readonly IntPtr NativeFieldInfoPtr_m_TargetCameraState;

		// Token: 0x04000533 RID: 1331
		private static readonly IntPtr NativeFieldInfoPtr_m_InterpolatingCameraState;

		// Token: 0x04000534 RID: 1332
		private static readonly IntPtr NativeFieldInfoPtr_boost;

		// Token: 0x04000535 RID: 1333
		private static readonly IntPtr NativeFieldInfoPtr_positionLerpTime;

		// Token: 0x04000536 RID: 1334
		private static readonly IntPtr NativeFieldInfoPtr_mouseSensitivityCurve;

		// Token: 0x04000537 RID: 1335
		private static readonly IntPtr NativeFieldInfoPtr_rotationLerpTime;

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeFieldInfoPtr_invertY;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeMethodInfoPtr_GetInputTranslationDirection_Private_Vector3_0;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200080C RID: 2060
		public class CameraState : Il2CppSystem.Object
		{
			// Token: 0x0600BCF6 RID: 48374 RVA: 0x002E8E00 File Offset: 0x002E7000
			// Note: this type is marked as 'beforefieldinit'.
			static CameraState()
			{
				Il2CppClassPointerStore<SimpleCameraController.CameraState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SimpleCameraController>.NativeClassPtr, "CameraState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleCameraController.CameraState>.NativeClassPtr);
				SimpleCameraController.CameraState.NativeFieldInfoPtr_yaw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController.CameraState>.NativeClassPtr, "yaw");
				SimpleCameraController.CameraState.NativeFieldInfoPtr_pitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController.CameraState>.NativeClassPtr, "pitch");
				SimpleCameraController.CameraState.NativeFieldInfoPtr_roll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController.CameraState>.NativeClassPtr, "roll");
				SimpleCameraController.CameraState.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController.CameraState>.NativeClassPtr, "x");
				SimpleCameraController.CameraState.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController.CameraState>.NativeClassPtr, "y");
				SimpleCameraController.CameraState.NativeFieldInfoPtr_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleCameraController.CameraState>.NativeClassPtr, "z");
				SimpleCameraController.CameraState.NativeMethodInfoPtr_SetFromTransform_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCameraController.CameraState>.NativeClassPtr, 100664210);
				SimpleCameraController.CameraState.NativeMethodInfoPtr_Translate_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCameraController.CameraState>.NativeClassPtr, 100664211);
				SimpleCameraController.CameraState.NativeMethodInfoPtr_LerpTowards_Public_Void_CameraState_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCameraController.CameraState>.NativeClassPtr, 100664212);
				SimpleCameraController.CameraState.NativeMethodInfoPtr_UpdateTransform_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCameraController.CameraState>.NativeClassPtr, 100664213);
				SimpleCameraController.CameraState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleCameraController.CameraState>.NativeClassPtr, 100664214);
			}

			// Token: 0x0600BCF7 RID: 48375 RVA: 0x002E8F08 File Offset: 0x002E7108
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 79216, RefRangeEnd = 79218, XrefRangeStart = 79210, XrefRangeEnd = 79216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetFromTransform(Transform t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCameraController.CameraState.NativeMethodInfoPtr_SetFromTransform_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BCF8 RID: 48376 RVA: 0x002E8F4C File Offset: 0x002E714C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79218, XrefRangeEnd = 79220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Translate(Vector3 translation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref translation;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCameraController.CameraState.NativeMethodInfoPtr_Translate_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BCF9 RID: 48377 RVA: 0x002E8F8C File Offset: 0x002E718C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 79230, RefRangeEnd = 79231, XrefRangeStart = 79220, XrefRangeEnd = 79230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void LerpTowards(SimpleCameraController.CameraState target, float positionLerpPct, float rotationLerpPct)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref positionLerpPct;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotationLerpPct;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCameraController.CameraState.NativeMethodInfoPtr_LerpTowards_Public_Void_CameraState_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BCFA RID: 48378 RVA: 0x002E8FEC File Offset: 0x002E71EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79231, XrefRangeEnd = 79233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void UpdateTransform(Transform t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCameraController.CameraState.NativeMethodInfoPtr_UpdateTransform_Public_Void_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BCFB RID: 48379 RVA: 0x002E9030 File Offset: 0x002E7230
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CameraState() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleCameraController.CameraState>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleCameraController.CameraState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BCFC RID: 48380 RVA: 0x0005C7DB File Offset: 0x0005A9DB
			public CameraState(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003A95 RID: 14997
			// (get) Token: 0x0600BCFD RID: 48381 RVA: 0x002E906C File Offset: 0x002E726C
			// (set) Token: 0x0600BCFE RID: 48382 RVA: 0x0005C7E4 File Offset: 0x0005A9E4
			public unsafe float yaw
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.CameraState.NativeFieldInfoPtr_yaw);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.CameraState.NativeFieldInfoPtr_yaw)) = value;
				}
			}

			// Token: 0x17003A96 RID: 14998
			// (get) Token: 0x0600BCFF RID: 48383 RVA: 0x002E9094 File Offset: 0x002E7294
			// (set) Token: 0x0600BD00 RID: 48384 RVA: 0x0005C7FF File Offset: 0x0005A9FF
			public unsafe float pitch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.CameraState.NativeFieldInfoPtr_pitch);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.CameraState.NativeFieldInfoPtr_pitch)) = value;
				}
			}

			// Token: 0x17003A97 RID: 14999
			// (get) Token: 0x0600BD01 RID: 48385 RVA: 0x002E90BC File Offset: 0x002E72BC
			// (set) Token: 0x0600BD02 RID: 48386 RVA: 0x0005C81A File Offset: 0x0005AA1A
			public unsafe float roll
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.CameraState.NativeFieldInfoPtr_roll);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.CameraState.NativeFieldInfoPtr_roll)) = value;
				}
			}

			// Token: 0x17003A98 RID: 15000
			// (get) Token: 0x0600BD03 RID: 48387 RVA: 0x002E90E4 File Offset: 0x002E72E4
			// (set) Token: 0x0600BD04 RID: 48388 RVA: 0x0005C835 File Offset: 0x0005AA35
			public unsafe float x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.CameraState.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.CameraState.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x17003A99 RID: 15001
			// (get) Token: 0x0600BD05 RID: 48389 RVA: 0x002E910C File Offset: 0x002E730C
			// (set) Token: 0x0600BD06 RID: 48390 RVA: 0x0005C850 File Offset: 0x0005AA50
			public unsafe float y
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.CameraState.NativeFieldInfoPtr_y);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.CameraState.NativeFieldInfoPtr_y)) = value;
				}
			}

			// Token: 0x17003A9A RID: 15002
			// (get) Token: 0x0600BD07 RID: 48391 RVA: 0x002E9134 File Offset: 0x002E7334
			// (set) Token: 0x0600BD08 RID: 48392 RVA: 0x0005C86B File Offset: 0x0005AA6B
			public unsafe float z
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.CameraState.NativeFieldInfoPtr_z);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleCameraController.CameraState.NativeFieldInfoPtr_z)) = value;
				}
			}

			// Token: 0x0400800E RID: 32782
			private static readonly IntPtr NativeFieldInfoPtr_yaw;

			// Token: 0x0400800F RID: 32783
			private static readonly IntPtr NativeFieldInfoPtr_pitch;

			// Token: 0x04008010 RID: 32784
			private static readonly IntPtr NativeFieldInfoPtr_roll;

			// Token: 0x04008011 RID: 32785
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04008012 RID: 32786
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x04008013 RID: 32787
			private static readonly IntPtr NativeFieldInfoPtr_z;

			// Token: 0x04008014 RID: 32788
			private static readonly IntPtr NativeMethodInfoPtr_SetFromTransform_Public_Void_Transform_0;

			// Token: 0x04008015 RID: 32789
			private static readonly IntPtr NativeMethodInfoPtr_Translate_Public_Void_Vector3_0;

			// Token: 0x04008016 RID: 32790
			private static readonly IntPtr NativeMethodInfoPtr_LerpTowards_Public_Void_CameraState_Single_Single_0;

			// Token: 0x04008017 RID: 32791
			private static readonly IntPtr NativeMethodInfoPtr_UpdateTransform_Public_Void_Transform_0;

			// Token: 0x04008018 RID: 32792
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
