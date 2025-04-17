using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Cutscenes
{
	// Token: 0x0200047D RID: 1149
	public class Cutscene : MonoBehaviour
	{
		// Token: 0x0600639C RID: 25500 RVA: 0x001C3A8C File Offset: 0x001C1C8C
		// Note: this type is marked as 'beforefieldinit'.
		static Cutscene()
		{
			Il2CppClassPointerStore<Cutscene>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Cutscenes", "Cutscene");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cutscene>.NativeClassPtr);
			Cutscene.NativeFieldInfoPtr__IsPlaying_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "<IsPlaying>k__BackingField");
			Cutscene.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "Name");
			Cutscene.NativeFieldInfoPtr_DisablePlayerControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "DisablePlayerControl");
			Cutscene.NativeFieldInfoPtr_OverrideFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "OverrideFOV");
			Cutscene.NativeFieldInfoPtr_CameraFOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "CameraFOV");
			Cutscene.NativeFieldInfoPtr_CameraControl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "CameraControl");
			Cutscene.NativeFieldInfoPtr_onPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "onPlay");
			Cutscene.NativeFieldInfoPtr_onEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "onEnd");
			Cutscene.NativeFieldInfoPtr_animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, "animation");
			Cutscene.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, 100675930);
			Cutscene.NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, 100675931);
			Cutscene.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, 100675932);
			Cutscene.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, 100675933);
			Cutscene.NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, 100675934);
			Cutscene.NativeMethodInfoPtr_InvokeEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, 100675935);
			Cutscene.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cutscene>.NativeClassPtr, 100675936);
		}

		// Token: 0x17001E12 RID: 7698
		// (get) Token: 0x0600639D RID: 25501 RVA: 0x001C3BFC File Offset: 0x001C1DFC
		// (set) Token: 0x0600639E RID: 25502 RVA: 0x001C3C38 File Offset: 0x001C1E38
		public unsafe bool IsPlaying
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cutscene.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cutscene.NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600639F RID: 25503 RVA: 0x001C3C78 File Offset: 0x001C1E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203487, XrefRangeEnd = 203491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cutscene.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063A0 RID: 25504 RVA: 0x001C3CB4 File Offset: 0x001C1EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203491, XrefRangeEnd = 203504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cutscene.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063A1 RID: 25505 RVA: 0x001C3CE8 File Offset: 0x001C1EE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 203547, RefRangeEnd = 203548, XrefRangeStart = 203504, XrefRangeEnd = 203547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Cutscene.NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063A2 RID: 25506 RVA: 0x001C3D24 File Offset: 0x001C1F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203548, XrefRangeEnd = 203594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cutscene.NativeMethodInfoPtr_InvokeEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063A3 RID: 25507 RVA: 0x001C3D58 File Offset: 0x001C1F58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203594, XrefRangeEnd = 203599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Cutscene() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Cutscene>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Cutscene.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063A4 RID: 25508 RVA: 0x0002F151 File Offset: 0x0002D351
		public Cutscene(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E09 RID: 7689
		// (get) Token: 0x060063A5 RID: 25509 RVA: 0x001C3D94 File Offset: 0x001C1F94
		// (set) Token: 0x060063A6 RID: 25510 RVA: 0x0002F15A File Offset: 0x0002D35A
		public unsafe bool _IsPlaying_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr__IsPlaying_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr__IsPlaying_k__BackingField)) = value;
			}
		}

		// Token: 0x17001E0A RID: 7690
		// (get) Token: 0x060063A7 RID: 25511 RVA: 0x001C3DBC File Offset: 0x001C1FBC
		// (set) Token: 0x060063A8 RID: 25512 RVA: 0x0002F175 File Offset: 0x0002D375
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001E0B RID: 7691
		// (get) Token: 0x060063A9 RID: 25513 RVA: 0x001C3DE4 File Offset: 0x001C1FE4
		// (set) Token: 0x060063AA RID: 25514 RVA: 0x0002F194 File Offset: 0x0002D394
		public unsafe bool DisablePlayerControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_DisablePlayerControl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_DisablePlayerControl)) = value;
			}
		}

		// Token: 0x17001E0C RID: 7692
		// (get) Token: 0x060063AB RID: 25515 RVA: 0x001C3E0C File Offset: 0x001C200C
		// (set) Token: 0x060063AC RID: 25516 RVA: 0x0002F1AF File Offset: 0x0002D3AF
		public unsafe bool OverrideFOV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_OverrideFOV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_OverrideFOV)) = value;
			}
		}

		// Token: 0x17001E0D RID: 7693
		// (get) Token: 0x060063AD RID: 25517 RVA: 0x001C3E34 File Offset: 0x001C2034
		// (set) Token: 0x060063AE RID: 25518 RVA: 0x0002F1CA File Offset: 0x0002D3CA
		public unsafe float CameraFOV
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_CameraFOV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_CameraFOV)) = value;
			}
		}

		// Token: 0x17001E0E RID: 7694
		// (get) Token: 0x060063AF RID: 25519 RVA: 0x001C3E5C File Offset: 0x001C205C
		// (set) Token: 0x060063B0 RID: 25520 RVA: 0x0002F1E5 File Offset: 0x0002D3E5
		public unsafe Transform CameraControl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_CameraControl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_CameraControl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E0F RID: 7695
		// (get) Token: 0x060063B1 RID: 25521 RVA: 0x001C3E8C File Offset: 0x001C208C
		// (set) Token: 0x060063B2 RID: 25522 RVA: 0x0002F204 File Offset: 0x0002D404
		public unsafe UnityEvent onPlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_onPlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_onPlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E10 RID: 7696
		// (get) Token: 0x060063B3 RID: 25523 RVA: 0x001C3EBC File Offset: 0x001C20BC
		// (set) Token: 0x060063B4 RID: 25524 RVA: 0x0002F223 File Offset: 0x0002D423
		public unsafe UnityEvent onEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_onEnd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_onEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E11 RID: 7697
		// (get) Token: 0x060063B5 RID: 25525 RVA: 0x001C3EEC File Offset: 0x001C20EC
		// (set) Token: 0x060063B6 RID: 25526 RVA: 0x0002F242 File Offset: 0x0002D442
		public unsafe Animation animation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_animation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Cutscene.NativeFieldInfoPtr_animation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040043FE RID: 17406
		private static readonly IntPtr NativeFieldInfoPtr__IsPlaying_k__BackingField;

		// Token: 0x040043FF RID: 17407
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x04004400 RID: 17408
		private static readonly IntPtr NativeFieldInfoPtr_DisablePlayerControl;

		// Token: 0x04004401 RID: 17409
		private static readonly IntPtr NativeFieldInfoPtr_OverrideFOV;

		// Token: 0x04004402 RID: 17410
		private static readonly IntPtr NativeFieldInfoPtr_CameraFOV;

		// Token: 0x04004403 RID: 17411
		private static readonly IntPtr NativeFieldInfoPtr_CameraControl;

		// Token: 0x04004404 RID: 17412
		private static readonly IntPtr NativeFieldInfoPtr_onPlay;

		// Token: 0x04004405 RID: 17413
		private static readonly IntPtr NativeFieldInfoPtr_onEnd;

		// Token: 0x04004406 RID: 17414
		private static readonly IntPtr NativeFieldInfoPtr_animation;

		// Token: 0x04004407 RID: 17415
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x04004408 RID: 17416
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0;

		// Token: 0x04004409 RID: 17417
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400440A RID: 17418
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400440B RID: 17419
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Virtual_New_Void_0;

		// Token: 0x0400440C RID: 17420
		private static readonly IntPtr NativeMethodInfoPtr_InvokeEnd_Public_Void_0;

		// Token: 0x0400440D RID: 17421
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
