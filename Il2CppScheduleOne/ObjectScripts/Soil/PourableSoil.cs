using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ObjectScripts.Soil
{
	// Token: 0x02000761 RID: 1889
	public class PourableSoil : Pourable
	{
		// Token: 0x0600B377 RID: 45943 RVA: 0x002CC0C0 File Offset: 0x002CA2C0
		// Note: this type is marked as 'beforefieldinit'.
		static PourableSoil()
		{
			Il2CppClassPointerStore<PourableSoil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.Soil", "PourableSoil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr);
			PourableSoil.NativeFieldInfoPtr_TEAR_ANGLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "TEAR_ANGLE");
			PourableSoil.NativeFieldInfoPtr_HIGHLIGHT_CYCLE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "HIGHLIGHT_CYCLE_TIME");
			PourableSoil.NativeFieldInfoPtr_IsOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "IsOpen");
			PourableSoil.NativeFieldInfoPtr_SoilDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "SoilDefinition");
			PourableSoil.NativeFieldInfoPtr_SoilBag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "SoilBag");
			PourableSoil.NativeFieldInfoPtr_Bones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "Bones");
			PourableSoil.NativeFieldInfoPtr_TopColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "TopColliders");
			PourableSoil.NativeFieldInfoPtr_Highlights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "Highlights");
			PourableSoil.NativeFieldInfoPtr_TopParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "TopParent");
			PourableSoil.NativeFieldInfoPtr_SnipSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "SnipSound");
			PourableSoil.NativeFieldInfoPtr_TopMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "TopMesh");
			PourableSoil.NativeFieldInfoPtr__currentCut_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "<currentCut>k__BackingField");
			PourableSoil.NativeFieldInfoPtr_onOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "onOpened");
			PourableSoil.NativeFieldInfoPtr_highlightScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "highlightScale");
			PourableSoil.NativeFieldInfoPtr_timeSinceStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "timeSinceStart");
			PourableSoil.NativeMethodInfoPtr_get_currentCut_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100685424);
			PourableSoil.NativeMethodInfoPtr_set_currentCut_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100685425);
			PourableSoil.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100685426);
			PourableSoil.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100685427);
			PourableSoil.NativeMethodInfoPtr_UpdateHighlights_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100685428);
			PourableSoil.NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100685429);
			PourableSoil.NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100685430);
			PourableSoil.NativeMethodInfoPtr_Cut_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100685431);
			PourableSoil.NativeMethodInfoPtr_FinishCut_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100685432);
			PourableSoil.NativeMethodInfoPtr_LerpCut_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100685433);
			PourableSoil.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100685434);
		}

		// Token: 0x170037B0 RID: 14256
		// (get) Token: 0x0600B378 RID: 45944 RVA: 0x002CC2F8 File Offset: 0x002CA4F8
		// (set) Token: 0x0600B379 RID: 45945 RVA: 0x002CC334 File Offset: 0x002CA534
		public unsafe int currentCut
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.NativeMethodInfoPtr_get_currentCut_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.NativeMethodInfoPtr_set_currentCut_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B37A RID: 45946 RVA: 0x002CC374 File Offset: 0x002CA574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308440, XrefRangeEnd = 308444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableSoil.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B37B RID: 45947 RVA: 0x002CC3B0 File Offset: 0x002CA5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308444, XrefRangeEnd = 308447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableSoil.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B37C RID: 45948 RVA: 0x002CC3EC File Offset: 0x002CA5EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 308460, RefRangeEnd = 308462, XrefRangeStart = 308447, XrefRangeEnd = 308460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHighlights()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.NativeMethodInfoPtr_UpdateHighlights_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B37D RID: 45949 RVA: 0x002CC420 File Offset: 0x002CA620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308462, XrefRangeEnd = 308474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PourAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref amount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableSoil.NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B37E RID: 45950 RVA: 0x002CC46C File Offset: 0x002CA66C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308474, XrefRangeEnd = 308475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanPour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableSoil.NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B37F RID: 45951 RVA: 0x002CC4B4 File Offset: 0x002CA6B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308482, RefRangeEnd = 308483, XrefRangeStart = 308475, XrefRangeEnd = 308482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.NativeMethodInfoPtr_Cut_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B380 RID: 45952 RVA: 0x002CC4E8 File Offset: 0x002CA6E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308508, RefRangeEnd = 308509, XrefRangeStart = 308483, XrefRangeEnd = 308508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishCut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.NativeMethodInfoPtr_FinishCut_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B381 RID: 45953 RVA: 0x002CC51C File Offset: 0x002CA71C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308525, RefRangeEnd = 308526, XrefRangeStart = 308509, XrefRangeEnd = 308525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LerpCut(int cutIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref cutIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.NativeMethodInfoPtr_LerpCut_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B382 RID: 45954 RVA: 0x002CC55C File Offset: 0x002CA75C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308526, XrefRangeEnd = 308529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PourableSoil() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B383 RID: 45955 RVA: 0x00057EF1 File Offset: 0x000560F1
		public PourableSoil(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037A1 RID: 14241
		// (get) Token: 0x0600B384 RID: 45956 RVA: 0x002CC598 File Offset: 0x002CA798
		// (set) Token: 0x0600B385 RID: 45957 RVA: 0x00057EFA File Offset: 0x000560FA
		public unsafe static float TEAR_ANGLE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PourableSoil.NativeFieldInfoPtr_TEAR_ANGLE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PourableSoil.NativeFieldInfoPtr_TEAR_ANGLE, (void*)(&value));
			}
		}

		// Token: 0x170037A2 RID: 14242
		// (get) Token: 0x0600B386 RID: 45958 RVA: 0x002CC5B4 File Offset: 0x002CA7B4
		// (set) Token: 0x0600B387 RID: 45959 RVA: 0x00057F08 File Offset: 0x00056108
		public unsafe static float HIGHLIGHT_CYCLE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PourableSoil.NativeFieldInfoPtr_HIGHLIGHT_CYCLE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PourableSoil.NativeFieldInfoPtr_HIGHLIGHT_CYCLE_TIME, (void*)(&value));
			}
		}

		// Token: 0x170037A3 RID: 14243
		// (get) Token: 0x0600B388 RID: 45960 RVA: 0x002CC5D0 File Offset: 0x002CA7D0
		// (set) Token: 0x0600B389 RID: 45961 RVA: 0x00057F16 File Offset: 0x00056116
		public unsafe bool IsOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_IsOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_IsOpen)) = value;
			}
		}

		// Token: 0x170037A4 RID: 14244
		// (get) Token: 0x0600B38A RID: 45962 RVA: 0x002CC5F8 File Offset: 0x002CA7F8
		// (set) Token: 0x0600B38B RID: 45963 RVA: 0x00057F31 File Offset: 0x00056131
		public unsafe SoilDefinition SoilDefinition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_SoilDefinition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SoilDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_SoilDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037A5 RID: 14245
		// (get) Token: 0x0600B38C RID: 45964 RVA: 0x002CC628 File Offset: 0x002CA828
		// (set) Token: 0x0600B38D RID: 45965 RVA: 0x00057F50 File Offset: 0x00056150
		public unsafe Transform SoilBag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_SoilBag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_SoilBag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037A6 RID: 14246
		// (get) Token: 0x0600B38E RID: 45966 RVA: 0x002CC658 File Offset: 0x002CA858
		// (set) Token: 0x0600B38F RID: 45967 RVA: 0x00057F6F File Offset: 0x0005616F
		public unsafe Il2CppReferenceArray<Transform> Bones
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_Bones);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_Bones), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037A7 RID: 14247
		// (get) Token: 0x0600B390 RID: 45968 RVA: 0x002CC688 File Offset: 0x002CA888
		// (set) Token: 0x0600B391 RID: 45969 RVA: 0x00057F8E File Offset: 0x0005618E
		public unsafe List<Collider> TopColliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_TopColliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_TopColliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037A8 RID: 14248
		// (get) Token: 0x0600B392 RID: 45970 RVA: 0x002CC6B8 File Offset: 0x002CA8B8
		// (set) Token: 0x0600B393 RID: 45971 RVA: 0x00057FAD File Offset: 0x000561AD
		public unsafe Il2CppReferenceArray<MeshRenderer> Highlights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_Highlights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_Highlights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037A9 RID: 14249
		// (get) Token: 0x0600B394 RID: 45972 RVA: 0x002CC6E8 File Offset: 0x002CA8E8
		// (set) Token: 0x0600B395 RID: 45973 RVA: 0x00057FCC File Offset: 0x000561CC
		public unsafe Transform TopParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_TopParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_TopParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037AA RID: 14250
		// (get) Token: 0x0600B396 RID: 45974 RVA: 0x002CC718 File Offset: 0x002CA918
		// (set) Token: 0x0600B397 RID: 45975 RVA: 0x00057FEB File Offset: 0x000561EB
		public unsafe AudioSourceController SnipSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_SnipSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_SnipSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037AB RID: 14251
		// (get) Token: 0x0600B398 RID: 45976 RVA: 0x002CC748 File Offset: 0x002CA948
		// (set) Token: 0x0600B399 RID: 45977 RVA: 0x0005800A File Offset: 0x0005620A
		public unsafe SkinnedMeshRenderer TopMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_TopMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkinnedMeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_TopMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037AC RID: 14252
		// (get) Token: 0x0600B39A RID: 45978 RVA: 0x002CC778 File Offset: 0x002CA978
		// (set) Token: 0x0600B39B RID: 45979 RVA: 0x00058029 File Offset: 0x00056229
		public unsafe int _currentCut_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr__currentCut_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr__currentCut_k__BackingField)) = value;
			}
		}

		// Token: 0x170037AD RID: 14253
		// (get) Token: 0x0600B39C RID: 45980 RVA: 0x002CC7A0 File Offset: 0x002CA9A0
		// (set) Token: 0x0600B39D RID: 45981 RVA: 0x00058044 File Offset: 0x00056244
		public unsafe UnityEvent onOpened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_onOpened);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_onOpened), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037AE RID: 14254
		// (get) Token: 0x0600B39E RID: 45982 RVA: 0x002CC7D0 File Offset: 0x002CA9D0
		// (set) Token: 0x0600B39F RID: 45983 RVA: 0x00058063 File Offset: 0x00056263
		public unsafe Vector3 highlightScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_highlightScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_highlightScale)) = value;
			}
		}

		// Token: 0x170037AF RID: 14255
		// (get) Token: 0x0600B3A0 RID: 45984 RVA: 0x002CC7F8 File Offset: 0x002CA9F8
		// (set) Token: 0x0600B3A1 RID: 45985 RVA: 0x0005807E File Offset: 0x0005627E
		public unsafe float timeSinceStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_timeSinceStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_timeSinceStart)) = value;
			}
		}

		// Token: 0x0400790F RID: 30991
		private static readonly IntPtr NativeFieldInfoPtr_TEAR_ANGLE;

		// Token: 0x04007910 RID: 30992
		private static readonly IntPtr NativeFieldInfoPtr_HIGHLIGHT_CYCLE_TIME;

		// Token: 0x04007911 RID: 30993
		private static readonly IntPtr NativeFieldInfoPtr_IsOpen;

		// Token: 0x04007912 RID: 30994
		private static readonly IntPtr NativeFieldInfoPtr_SoilDefinition;

		// Token: 0x04007913 RID: 30995
		private static readonly IntPtr NativeFieldInfoPtr_SoilBag;

		// Token: 0x04007914 RID: 30996
		private static readonly IntPtr NativeFieldInfoPtr_Bones;

		// Token: 0x04007915 RID: 30997
		private static readonly IntPtr NativeFieldInfoPtr_TopColliders;

		// Token: 0x04007916 RID: 30998
		private static readonly IntPtr NativeFieldInfoPtr_Highlights;

		// Token: 0x04007917 RID: 30999
		private static readonly IntPtr NativeFieldInfoPtr_TopParent;

		// Token: 0x04007918 RID: 31000
		private static readonly IntPtr NativeFieldInfoPtr_SnipSound;

		// Token: 0x04007919 RID: 31001
		private static readonly IntPtr NativeFieldInfoPtr_TopMesh;

		// Token: 0x0400791A RID: 31002
		private static readonly IntPtr NativeFieldInfoPtr__currentCut_k__BackingField;

		// Token: 0x0400791B RID: 31003
		private static readonly IntPtr NativeFieldInfoPtr_onOpened;

		// Token: 0x0400791C RID: 31004
		private static readonly IntPtr NativeFieldInfoPtr_highlightScale;

		// Token: 0x0400791D RID: 31005
		private static readonly IntPtr NativeFieldInfoPtr_timeSinceStart;

		// Token: 0x0400791E RID: 31006
		private static readonly IntPtr NativeMethodInfoPtr_get_currentCut_Public_get_Int32_0;

		// Token: 0x0400791F RID: 31007
		private static readonly IntPtr NativeMethodInfoPtr_set_currentCut_Protected_set_Void_Int32_0;

		// Token: 0x04007920 RID: 31008
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007921 RID: 31009
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04007922 RID: 31010
		private static readonly IntPtr NativeMethodInfoPtr_UpdateHighlights_Private_Void_0;

		// Token: 0x04007923 RID: 31011
		private static readonly IntPtr NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0;

		// Token: 0x04007924 RID: 31012
		private static readonly IntPtr NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_0;

		// Token: 0x04007925 RID: 31013
		private static readonly IntPtr NativeMethodInfoPtr_Cut_Public_Void_0;

		// Token: 0x04007926 RID: 31014
		private static readonly IntPtr NativeMethodInfoPtr_FinishCut_Private_Void_0;

		// Token: 0x04007927 RID: 31015
		private static readonly IntPtr NativeMethodInfoPtr_LerpCut_Private_Void_Int32_0;

		// Token: 0x04007928 RID: 31016
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BF6 RID: 3062
		[ObfuscatedName("ScheduleOne.ObjectScripts.Soil.PourableSoil+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DF94 RID: 57236 RVA: 0x0034AD18 File Offset: 0x00348F18
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr);
				PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_bone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr, "bone");
				PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_startRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr, "startRot");
				PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_endRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr, "endRot");
				PourableSoil.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr, 100685435);
				PourableSoil.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr, 100685436);
			}

			// Token: 0x0600DF95 RID: 57237 RVA: 0x0034ADA8 File Offset: 0x00348FA8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DF96 RID: 57238 RVA: 0x0034ADE4 File Offset: 0x00348FE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308435, XrefRangeEnd = 308440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DF97 RID: 57239 RVA: 0x0006D057 File Offset: 0x0006B257
			public __c__DisplayClass25_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700454B RID: 17739
			// (get) Token: 0x0600DF98 RID: 57240 RVA: 0x0034AE24 File Offset: 0x00349024
			// (set) Token: 0x0600DF99 RID: 57241 RVA: 0x0006D060 File Offset: 0x0006B260
			public unsafe Transform bone
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_bone);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_bone), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700454C RID: 17740
			// (get) Token: 0x0600DF9A RID: 57242 RVA: 0x0034AE54 File Offset: 0x00349054
			// (set) Token: 0x0600DF9B RID: 57243 RVA: 0x0006D07F File Offset: 0x0006B27F
			public unsafe Quaternion startRot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_startRot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_startRot)) = value;
				}
			}

			// Token: 0x1700454D RID: 17741
			// (get) Token: 0x0600DF9C RID: 57244 RVA: 0x0034AE7C File Offset: 0x0034907C
			// (set) Token: 0x0600DF9D RID: 57245 RVA: 0x0006D09A File Offset: 0x0006B29A
			public unsafe Quaternion endRot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_endRot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_endRot)) = value;
				}
			}

			// Token: 0x040095C4 RID: 38340
			private static readonly IntPtr NativeFieldInfoPtr_bone;

			// Token: 0x040095C5 RID: 38341
			private static readonly IntPtr NativeFieldInfoPtr_startRot;

			// Token: 0x040095C6 RID: 38342
			private static readonly IntPtr NativeFieldInfoPtr_endRot;

			// Token: 0x040095C7 RID: 38343
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095C8 RID: 38344
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C8F RID: 3215
			[ObfuscatedName("ScheduleOne.ObjectScripts.Soil.PourableSoil+<>c__DisplayClass25_0+<<LerpCut>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E758 RID: 59224 RVA: 0x00361870 File Offset: 0x0035FA70
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique()
				{
					Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr, "<<LerpCut>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr);
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>1__state");
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>2__current");
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>4__this");
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<lerpTime>5__2");
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<i>5__3");
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100685437);
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100685438);
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100685439);
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100685440);
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100685441);
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100685442);
				}

				// Token: 0x0600E759 RID: 59225 RVA: 0x00361978 File Offset: 0x0035FB78
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E75A RID: 59226 RVA: 0x003619C0 File Offset: 0x0035FBC0
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E75B RID: 59227 RVA: 0x003619F4 File Offset: 0x0035FBF4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308421, XrefRangeEnd = 308430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700481A RID: 18458
				// (get) Token: 0x0600E75C RID: 59228 RVA: 0x00361A30 File Offset: 0x0035FC30
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E75D RID: 59229 RVA: 0x00361A70 File Offset: 0x0035FC70
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308430, XrefRangeEnd = 308435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700481B RID: 18459
				// (get) Token: 0x0600E75E RID: 59230 RVA: 0x00361AA4 File Offset: 0x0035FCA4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E75F RID: 59231 RVA: 0x00070ED6 File Offset: 0x0006F0D6
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004815 RID: 18453
				// (get) Token: 0x0600E760 RID: 59232 RVA: 0x00361AE4 File Offset: 0x0035FCE4
				// (set) Token: 0x0600E761 RID: 59233 RVA: 0x00070EDF File Offset: 0x0006F0DF
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004816 RID: 18454
				// (get) Token: 0x0600E762 RID: 59234 RVA: 0x00361B0C File Offset: 0x0035FD0C
				// (set) Token: 0x0600E763 RID: 59235 RVA: 0x00070EFA File Offset: 0x0006F0FA
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004817 RID: 18455
				// (get) Token: 0x0600E764 RID: 59236 RVA: 0x00361B3C File Offset: 0x0035FD3C
				// (set) Token: 0x0600E765 RID: 59237 RVA: 0x00070F19 File Offset: 0x0006F119
				public unsafe PourableSoil.__c__DisplayClass25_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PourableSoil.__c__DisplayClass25_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004818 RID: 18456
				// (get) Token: 0x0600E766 RID: 59238 RVA: 0x00361B6C File Offset: 0x0035FD6C
				// (set) Token: 0x0600E767 RID: 59239 RVA: 0x00070F38 File Offset: 0x0006F138
				public unsafe float _lerpTime_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2)) = value;
					}
				}

				// Token: 0x17004819 RID: 18457
				// (get) Token: 0x0600E768 RID: 59240 RVA: 0x00361B94 File Offset: 0x0035FD94
				// (set) Token: 0x0600E769 RID: 59241 RVA: 0x00070F53 File Offset: 0x0006F153
				public unsafe float _i_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
					}
				}

				// Token: 0x04009A94 RID: 39572
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009A95 RID: 39573
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009A96 RID: 39574
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009A97 RID: 39575
				private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__2;

				// Token: 0x04009A98 RID: 39576
				private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

				// Token: 0x04009A99 RID: 39577
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009A9A RID: 39578
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A9B RID: 39579
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009A9C RID: 39580
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009A9D RID: 39581
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A9E RID: 39582
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
