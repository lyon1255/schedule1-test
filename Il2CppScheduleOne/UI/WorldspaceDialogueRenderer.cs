using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000674 RID: 1652
	public class WorldspaceDialogueRenderer : MonoBehaviour
	{
		// Token: 0x06009367 RID: 37735 RVA: 0x0025F094 File Offset: 0x0025D294
		// Note: this type is marked as 'beforefieldinit'.
		static WorldspaceDialogueRenderer()
		{
			Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "WorldspaceDialogueRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr);
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_FadeDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "FadeDist");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr__ShownText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "<ShownText>k__BackingField");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_MaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "MaxRange");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_BaseScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "BaseScale");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "Scale");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "Padding");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_WorldSpaceOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "WorldSpaceOffset");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "Canvas");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "CanvasGroup");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_Background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "Background");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "Text");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "Anim");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_localOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "localOffset");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_CurrentOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "CurrentOpacity");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_hideCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "hideCoroutine");
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_get_ShownText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681574);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_set_ShownText_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681575);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681576);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681577);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681578);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_UpdatePosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681579);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_ShowText_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681580);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_HideText_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681581);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_SetOpacity_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681582);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681583);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681584);
		}

		// Token: 0x17002D3F RID: 11583
		// (get) Token: 0x06009368 RID: 37736 RVA: 0x0025F2CC File Offset: 0x0025D4CC
		// (set) Token: 0x06009369 RID: 37737 RVA: 0x0025F304 File Offset: 0x0025D504
		public unsafe string ShownText
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 17402, RefRangeEnd = 17403, XrefRangeStart = 17402, XrefRangeEnd = 17403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_get_ShownText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_set_ShownText_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600936A RID: 37738 RVA: 0x0025F348 File Offset: 0x0025D548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265293, XrefRangeEnd = 265298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600936B RID: 37739 RVA: 0x0025F37C File Offset: 0x0025D57C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265298, XrefRangeEnd = 265329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600936C RID: 37740 RVA: 0x0025F3B0 File Offset: 0x0025D5B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265329, XrefRangeEnd = 265330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600936D RID: 37741 RVA: 0x0025F3E4 File Offset: 0x0025D5E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 265363, RefRangeEnd = 265365, XrefRangeStart = 265330, XrefRangeEnd = 265363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_UpdatePosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600936E RID: 37742 RVA: 0x0025F418 File Offset: 0x0025D618
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 265389, RefRangeEnd = 265393, XrefRangeStart = 265365, XrefRangeEnd = 265389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowText(string text, float duration = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_ShowText_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600936F RID: 37743 RVA: 0x0025F468 File Offset: 0x0025D668
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 265398, RefRangeEnd = 265400, XrefRangeStart = 265393, XrefRangeEnd = 265398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_HideText_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009370 RID: 37744 RVA: 0x0025F49C File Offset: 0x0025D69C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 265403, RefRangeEnd = 265404, XrefRangeStart = 265400, XrefRangeEnd = 265403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOpacity(float op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref op;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_SetOpacity_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009371 RID: 37745 RVA: 0x0025F4DC File Offset: 0x0025D6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265404, XrefRangeEnd = 265412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldspaceDialogueRenderer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009372 RID: 37746 RVA: 0x0025F518 File Offset: 0x0025D718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265412, XrefRangeEnd = 265417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_Single_PDM_0(float dur)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref dur;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06009373 RID: 37747 RVA: 0x000476BD File Offset: 0x000458BD
		public WorldspaceDialogueRenderer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D30 RID: 11568
		// (get) Token: 0x06009374 RID: 37748 RVA: 0x0025F564 File Offset: 0x0025D764
		// (set) Token: 0x06009375 RID: 37749 RVA: 0x000476C6 File Offset: 0x000458C6
		public unsafe static float FadeDist
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(WorldspaceDialogueRenderer.NativeFieldInfoPtr_FadeDist, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WorldspaceDialogueRenderer.NativeFieldInfoPtr_FadeDist, (void*)(&value));
			}
		}

		// Token: 0x17002D31 RID: 11569
		// (get) Token: 0x06009376 RID: 37750 RVA: 0x0025F580 File Offset: 0x0025D780
		// (set) Token: 0x06009377 RID: 37751 RVA: 0x000476D4 File Offset: 0x000458D4
		public unsafe string _ShownText_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr__ShownText_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr__ShownText_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002D32 RID: 11570
		// (get) Token: 0x06009378 RID: 37752 RVA: 0x0025F5A8 File Offset: 0x0025D7A8
		// (set) Token: 0x06009379 RID: 37753 RVA: 0x000476F3 File Offset: 0x000458F3
		public unsafe float MaxRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_MaxRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_MaxRange)) = value;
			}
		}

		// Token: 0x17002D33 RID: 11571
		// (get) Token: 0x0600937A RID: 37754 RVA: 0x0025F5D0 File Offset: 0x0025D7D0
		// (set) Token: 0x0600937B RID: 37755 RVA: 0x0004770E File Offset: 0x0004590E
		public unsafe float BaseScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_BaseScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_BaseScale)) = value;
			}
		}

		// Token: 0x17002D34 RID: 11572
		// (get) Token: 0x0600937C RID: 37756 RVA: 0x0025F5F8 File Offset: 0x0025D7F8
		// (set) Token: 0x0600937D RID: 37757 RVA: 0x00047729 File Offset: 0x00045929
		public unsafe AnimationCurve Scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Scale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Scale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D35 RID: 11573
		// (get) Token: 0x0600937E RID: 37758 RVA: 0x0025F628 File Offset: 0x0025D828
		// (set) Token: 0x0600937F RID: 37759 RVA: 0x00047748 File Offset: 0x00045948
		public unsafe Vector2 Padding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Padding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Padding)) = value;
			}
		}

		// Token: 0x17002D36 RID: 11574
		// (get) Token: 0x06009380 RID: 37760 RVA: 0x0025F650 File Offset: 0x0025D850
		// (set) Token: 0x06009381 RID: 37761 RVA: 0x00047763 File Offset: 0x00045963
		public unsafe Vector3 WorldSpaceOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_WorldSpaceOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_WorldSpaceOffset)) = value;
			}
		}

		// Token: 0x17002D37 RID: 11575
		// (get) Token: 0x06009382 RID: 37762 RVA: 0x0025F678 File Offset: 0x0025D878
		// (set) Token: 0x06009383 RID: 37763 RVA: 0x0004777E File Offset: 0x0004597E
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D38 RID: 11576
		// (get) Token: 0x06009384 RID: 37764 RVA: 0x0025F6A8 File Offset: 0x0025D8A8
		// (set) Token: 0x06009385 RID: 37765 RVA: 0x0004779D File Offset: 0x0004599D
		public unsafe CanvasGroup CanvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_CanvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D39 RID: 11577
		// (get) Token: 0x06009386 RID: 37766 RVA: 0x0025F6D8 File Offset: 0x0025D8D8
		// (set) Token: 0x06009387 RID: 37767 RVA: 0x000477BC File Offset: 0x000459BC
		public unsafe RectTransform Background
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Background);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Background), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D3A RID: 11578
		// (get) Token: 0x06009388 RID: 37768 RVA: 0x0025F708 File Offset: 0x0025D908
		// (set) Token: 0x06009389 RID: 37769 RVA: 0x000477DB File Offset: 0x000459DB
		public unsafe TextMeshProUGUI Text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D3B RID: 11579
		// (get) Token: 0x0600938A RID: 37770 RVA: 0x0025F738 File Offset: 0x0025D938
		// (set) Token: 0x0600938B RID: 37771 RVA: 0x000477FA File Offset: 0x000459FA
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D3C RID: 11580
		// (get) Token: 0x0600938C RID: 37772 RVA: 0x0025F768 File Offset: 0x0025D968
		// (set) Token: 0x0600938D RID: 37773 RVA: 0x00047819 File Offset: 0x00045A19
		public unsafe Vector3 localOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_localOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_localOffset)) = value;
			}
		}

		// Token: 0x17002D3D RID: 11581
		// (get) Token: 0x0600938E RID: 37774 RVA: 0x0025F790 File Offset: 0x0025D990
		// (set) Token: 0x0600938F RID: 37775 RVA: 0x00047834 File Offset: 0x00045A34
		public unsafe float CurrentOpacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_CurrentOpacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_CurrentOpacity)) = value;
			}
		}

		// Token: 0x17002D3E RID: 11582
		// (get) Token: 0x06009390 RID: 37776 RVA: 0x0025F7B8 File Offset: 0x0025D9B8
		// (set) Token: 0x06009391 RID: 37777 RVA: 0x0004784F File Offset: 0x00045A4F
		public unsafe Coroutine hideCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_hideCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_hideCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006381 RID: 25473
		private static readonly IntPtr NativeFieldInfoPtr_FadeDist;

		// Token: 0x04006382 RID: 25474
		private static readonly IntPtr NativeFieldInfoPtr__ShownText_k__BackingField;

		// Token: 0x04006383 RID: 25475
		private static readonly IntPtr NativeFieldInfoPtr_MaxRange;

		// Token: 0x04006384 RID: 25476
		private static readonly IntPtr NativeFieldInfoPtr_BaseScale;

		// Token: 0x04006385 RID: 25477
		private static readonly IntPtr NativeFieldInfoPtr_Scale;

		// Token: 0x04006386 RID: 25478
		private static readonly IntPtr NativeFieldInfoPtr_Padding;

		// Token: 0x04006387 RID: 25479
		private static readonly IntPtr NativeFieldInfoPtr_WorldSpaceOffset;

		// Token: 0x04006388 RID: 25480
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006389 RID: 25481
		private static readonly IntPtr NativeFieldInfoPtr_CanvasGroup;

		// Token: 0x0400638A RID: 25482
		private static readonly IntPtr NativeFieldInfoPtr_Background;

		// Token: 0x0400638B RID: 25483
		private static readonly IntPtr NativeFieldInfoPtr_Text;

		// Token: 0x0400638C RID: 25484
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x0400638D RID: 25485
		private static readonly IntPtr NativeFieldInfoPtr_localOffset;

		// Token: 0x0400638E RID: 25486
		private static readonly IntPtr NativeFieldInfoPtr_CurrentOpacity;

		// Token: 0x0400638F RID: 25487
		private static readonly IntPtr NativeFieldInfoPtr_hideCoroutine;

		// Token: 0x04006390 RID: 25488
		private static readonly IntPtr NativeMethodInfoPtr_get_ShownText_Public_get_String_0;

		// Token: 0x04006391 RID: 25489
		private static readonly IntPtr NativeMethodInfoPtr_set_ShownText_Protected_set_Void_String_0;

		// Token: 0x04006392 RID: 25490
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006393 RID: 25491
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04006394 RID: 25492
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04006395 RID: 25493
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePosition_Private_Void_0;

		// Token: 0x04006396 RID: 25494
		private static readonly IntPtr NativeMethodInfoPtr_ShowText_Public_Void_String_Single_0;

		// Token: 0x04006397 RID: 25495
		private static readonly IntPtr NativeMethodInfoPtr_HideText_Public_Void_0;

		// Token: 0x04006398 RID: 25496
		private static readonly IntPtr NativeMethodInfoPtr_SetOpacity_Private_Void_Single_0;

		// Token: 0x04006399 RID: 25497
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400639A RID: 25498
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_Single_PDM_0;

		// Token: 0x02000B55 RID: 2901
		[ObfuscatedName("ScheduleOne.UI.WorldspaceDialogueRenderer+<<ShowText>g__Wait|22_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D9D6 RID: 55766 RVA: 0x0033A8F4 File Offset: 0x00338AF4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique()
			{
				Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "<<ShowText>g__Wait|22_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr);
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, "<>1__state");
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, "<>2__current");
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr_dur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, "dur");
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, "<>4__this");
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, 100681585);
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, 100681586);
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, 100681587);
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, 100681588);
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, 100681589);
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, 100681590);
			}

			// Token: 0x0600D9D7 RID: 55767 RVA: 0x0033A9E8 File Offset: 0x00338BE8
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9D8 RID: 55768 RVA: 0x0033AA30 File Offset: 0x00338C30
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9D9 RID: 55769 RVA: 0x0033AA64 File Offset: 0x00338C64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265282, XrefRangeEnd = 265288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004399 RID: 17305
			// (get) Token: 0x0600D9DA RID: 55770 RVA: 0x0033AAA0 File Offset: 0x00338CA0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D9DB RID: 55771 RVA: 0x0033AAE0 File Offset: 0x00338CE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265288, XrefRangeEnd = 265293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700439A RID: 17306
			// (get) Token: 0x0600D9DC RID: 55772 RVA: 0x0033AB14 File Offset: 0x00338D14
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D9DD RID: 55773 RVA: 0x0006A174 File Offset: 0x00068374
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004395 RID: 17301
			// (get) Token: 0x0600D9DE RID: 55774 RVA: 0x0033AB54 File Offset: 0x00338D54
			// (set) Token: 0x0600D9DF RID: 55775 RVA: 0x0006A17D File Offset: 0x0006837D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004396 RID: 17302
			// (get) Token: 0x0600D9E0 RID: 55776 RVA: 0x0033AB7C File Offset: 0x00338D7C
			// (set) Token: 0x0600D9E1 RID: 55777 RVA: 0x0006A198 File Offset: 0x00068398
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004397 RID: 17303
			// (get) Token: 0x0600D9E2 RID: 55778 RVA: 0x0033ABAC File Offset: 0x00338DAC
			// (set) Token: 0x0600D9E3 RID: 55779 RVA: 0x0006A1B7 File Offset: 0x000683B7
			public unsafe float dur
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr_dur);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr_dur)) = value;
				}
			}

			// Token: 0x17004398 RID: 17304
			// (get) Token: 0x0600D9E4 RID: 55780 RVA: 0x0033ABD4 File Offset: 0x00338DD4
			// (set) Token: 0x0600D9E5 RID: 55781 RVA: 0x0006A1D2 File Offset: 0x000683D2
			public unsafe WorldspaceDialogueRenderer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceDialogueRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009249 RID: 37449
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400924A RID: 37450
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400924B RID: 37451
			private static readonly IntPtr NativeFieldInfoPtr_dur;

			// Token: 0x0400924C RID: 37452
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400924D RID: 37453
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400924E RID: 37454
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400924F RID: 37455
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009250 RID: 37456
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009251 RID: 37457
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009252 RID: 37458
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
