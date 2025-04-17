using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ScriptableObjects;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000648 RID: 1608
	public class LoadingScreen : PersistentSingleton<LoadingScreen>
	{
		// Token: 0x06008E79 RID: 36473 RVA: 0x00250A04 File Offset: 0x0024EC04
		// Note: this type is marked as 'beforefieldinit'.
		static LoadingScreen()
		{
			Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "LoadingScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr);
			LoadingScreen.NativeFieldInfoPtr_FADE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "FADE_TIME");
			LoadingScreen.NativeFieldInfoPtr_BACKGROUND_IMAGE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "BACKGROUND_IMAGE_TIME");
			LoadingScreen.NativeFieldInfoPtr_BACKGROUND_IMAGE_FADE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "BACKGROUND_IMAGE_FADE_TIME");
			LoadingScreen.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "<IsOpen>k__BackingField");
			LoadingScreen.NativeFieldInfoPtr_LoadingMessagesDatabase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "LoadingMessagesDatabase");
			LoadingScreen.NativeFieldInfoPtr_BackgroundImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "BackgroundImages");
			LoadingScreen.NativeFieldInfoPtr_TutorialBackgroundImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "TutorialBackgroundImages");
			LoadingScreen.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "Canvas");
			LoadingScreen.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "Group");
			LoadingScreen.NativeFieldInfoPtr_LoadStatusLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "LoadStatusLabel");
			LoadingScreen.NativeFieldInfoPtr_LoadingMessageLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "LoadingMessageLabel");
			LoadingScreen.NativeFieldInfoPtr_BackgroundImage1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "BackgroundImage1");
			LoadingScreen.NativeFieldInfoPtr_BackgroundImage2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "BackgroundImage2");
			LoadingScreen.NativeFieldInfoPtr_TutorialContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "TutorialContainer");
			LoadingScreen.NativeFieldInfoPtr_CoopTutorialHint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "CoopTutorialHint");
			LoadingScreen.NativeFieldInfoPtr_loadingMessages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "loadingMessages");
			LoadingScreen.NativeFieldInfoPtr_currentBackgroundImageIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "currentBackgroundImageIndex");
			LoadingScreen.NativeFieldInfoPtr_fadeRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "fadeRoutine");
			LoadingScreen.NativeFieldInfoPtr_animateBackgroundRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "animateBackgroundRoutine");
			LoadingScreen.NativeFieldInfoPtr_scaleBackgroundRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "scaleBackgroundRoutine");
			LoadingScreen.NativeFieldInfoPtr_isLoadingTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "isLoadingTutorial");
			LoadingScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, 100680978);
			LoadingScreen.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, 100680979);
			LoadingScreen.NativeMethodInfoPtr_get_ContextualBackgroundImages_Public_get_Il2CppReferenceArray_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, 100680980);
			LoadingScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, 100680981);
			LoadingScreen.NativeMethodInfoPtr_Update_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, 100680982);
			LoadingScreen.NativeMethodInfoPtr_Open_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, 100680983);
			LoadingScreen.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, 100680984);
			LoadingScreen.NativeMethodInfoPtr_AnimateBackground_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, 100680985);
			LoadingScreen.NativeMethodInfoPtr_Fade_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, 100680986);
			LoadingScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, 100680987);
			LoadingScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, 100680988);
		}

		// Token: 0x17002B9A RID: 11162
		// (get) Token: 0x06008E7A RID: 36474 RVA: 0x00250CB4 File Offset: 0x0024EEB4
		// (set) Token: 0x06008E7B RID: 36475 RVA: 0x00250CF0 File Offset: 0x0024EEF0
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37988, RefRangeEnd = 38011, XrefRangeStart = 37988, XrefRangeEnd = 38011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002B9B RID: 11163
		// (get) Token: 0x06008E7C RID: 36476 RVA: 0x00250D30 File Offset: 0x0024EF30
		public unsafe Il2CppReferenceArray<Sprite> ContextualBackgroundImages
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.NativeMethodInfoPtr_get_ContextualBackgroundImages_Public_get_Il2CppReferenceArray_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr3) : null;
			}
		}

		// Token: 0x06008E7D RID: 36477 RVA: 0x00250D70 File Offset: 0x0024EF70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259246, XrefRangeEnd = 259277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadingScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E7E RID: 36478 RVA: 0x00250DAC File Offset: 0x0024EFAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259277, XrefRangeEnd = 259282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.NativeMethodInfoPtr_Update_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E7F RID: 36479 RVA: 0x00250DE0 File Offset: 0x0024EFE0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 259313, RefRangeEnd = 259318, XrefRangeStart = 259282, XrefRangeEnd = 259313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(bool loadingTutorial = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref loadingTutorial;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.NativeMethodInfoPtr_Open_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E80 RID: 36480 RVA: 0x00250E20 File Offset: 0x0024F020
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 259331, RefRangeEnd = 259335, XrefRangeStart = 259318, XrefRangeEnd = 259331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E81 RID: 36481 RVA: 0x00250E54 File Offset: 0x0024F054
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259335, XrefRangeEnd = 259344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AnimateBackground()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.NativeMethodInfoPtr_AnimateBackground_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E82 RID: 36482 RVA: 0x00250E88 File Offset: 0x0024F088
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 259358, RefRangeEnd = 259360, XrefRangeStart = 259344, XrefRangeEnd = 259358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Fade(float endAlpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endAlpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.NativeMethodInfoPtr_Fade_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E83 RID: 36483 RVA: 0x00250EC8 File Offset: 0x0024F0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259360, XrefRangeEnd = 259363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadingScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008E84 RID: 36484 RVA: 0x00250F04 File Offset: 0x0024F104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259363, XrefRangeEnd = 259368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008E85 RID: 36485 RVA: 0x00044881 File Offset: 0x00042A81
		public LoadingScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B85 RID: 11141
		// (get) Token: 0x06008E86 RID: 36486 RVA: 0x00250F44 File Offset: 0x0024F144
		// (set) Token: 0x06008E87 RID: 36487 RVA: 0x0004488A File Offset: 0x00042A8A
		public unsafe static float FADE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LoadingScreen.NativeFieldInfoPtr_FADE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadingScreen.NativeFieldInfoPtr_FADE_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002B86 RID: 11142
		// (get) Token: 0x06008E88 RID: 36488 RVA: 0x00250F60 File Offset: 0x0024F160
		// (set) Token: 0x06008E89 RID: 36489 RVA: 0x00044898 File Offset: 0x00042A98
		public unsafe static float BACKGROUND_IMAGE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LoadingScreen.NativeFieldInfoPtr_BACKGROUND_IMAGE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadingScreen.NativeFieldInfoPtr_BACKGROUND_IMAGE_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002B87 RID: 11143
		// (get) Token: 0x06008E8A RID: 36490 RVA: 0x00250F7C File Offset: 0x0024F17C
		// (set) Token: 0x06008E8B RID: 36491 RVA: 0x000448A6 File Offset: 0x00042AA6
		public unsafe static float BACKGROUND_IMAGE_FADE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LoadingScreen.NativeFieldInfoPtr_BACKGROUND_IMAGE_FADE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoadingScreen.NativeFieldInfoPtr_BACKGROUND_IMAGE_FADE_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002B88 RID: 11144
		// (get) Token: 0x06008E8C RID: 36492 RVA: 0x00250F98 File Offset: 0x0024F198
		// (set) Token: 0x06008E8D RID: 36493 RVA: 0x000448B4 File Offset: 0x00042AB4
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002B89 RID: 11145
		// (get) Token: 0x06008E8E RID: 36494 RVA: 0x00250FC0 File Offset: 0x0024F1C0
		// (set) Token: 0x06008E8F RID: 36495 RVA: 0x000448CF File Offset: 0x00042ACF
		public unsafe StringDatabase LoadingMessagesDatabase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_LoadingMessagesDatabase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringDatabase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_LoadingMessagesDatabase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B8A RID: 11146
		// (get) Token: 0x06008E90 RID: 36496 RVA: 0x00250FF0 File Offset: 0x0024F1F0
		// (set) Token: 0x06008E91 RID: 36497 RVA: 0x000448EE File Offset: 0x00042AEE
		public unsafe Il2CppReferenceArray<Sprite> BackgroundImages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_BackgroundImages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_BackgroundImages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B8B RID: 11147
		// (get) Token: 0x06008E92 RID: 36498 RVA: 0x00251020 File Offset: 0x0024F220
		// (set) Token: 0x06008E93 RID: 36499 RVA: 0x0004490D File Offset: 0x00042B0D
		public unsafe Il2CppReferenceArray<Sprite> TutorialBackgroundImages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_TutorialBackgroundImages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_TutorialBackgroundImages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B8C RID: 11148
		// (get) Token: 0x06008E94 RID: 36500 RVA: 0x00251050 File Offset: 0x0024F250
		// (set) Token: 0x06008E95 RID: 36501 RVA: 0x0004492C File Offset: 0x00042B2C
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B8D RID: 11149
		// (get) Token: 0x06008E96 RID: 36502 RVA: 0x00251080 File Offset: 0x0024F280
		// (set) Token: 0x06008E97 RID: 36503 RVA: 0x0004494B File Offset: 0x00042B4B
		public unsafe CanvasGroup Group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_Group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B8E RID: 11150
		// (get) Token: 0x06008E98 RID: 36504 RVA: 0x002510B0 File Offset: 0x0024F2B0
		// (set) Token: 0x06008E99 RID: 36505 RVA: 0x0004496A File Offset: 0x00042B6A
		public unsafe TextMeshProUGUI LoadStatusLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_LoadStatusLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_LoadStatusLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B8F RID: 11151
		// (get) Token: 0x06008E9A RID: 36506 RVA: 0x002510E0 File Offset: 0x0024F2E0
		// (set) Token: 0x06008E9B RID: 36507 RVA: 0x00044989 File Offset: 0x00042B89
		public unsafe TextMeshProUGUI LoadingMessageLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_LoadingMessageLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_LoadingMessageLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B90 RID: 11152
		// (get) Token: 0x06008E9C RID: 36508 RVA: 0x00251110 File Offset: 0x0024F310
		// (set) Token: 0x06008E9D RID: 36509 RVA: 0x000449A8 File Offset: 0x00042BA8
		public unsafe Image BackgroundImage1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_BackgroundImage1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_BackgroundImage1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B91 RID: 11153
		// (get) Token: 0x06008E9E RID: 36510 RVA: 0x00251140 File Offset: 0x0024F340
		// (set) Token: 0x06008E9F RID: 36511 RVA: 0x000449C7 File Offset: 0x00042BC7
		public unsafe Image BackgroundImage2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_BackgroundImage2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_BackgroundImage2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B92 RID: 11154
		// (get) Token: 0x06008EA0 RID: 36512 RVA: 0x00251170 File Offset: 0x0024F370
		// (set) Token: 0x06008EA1 RID: 36513 RVA: 0x000449E6 File Offset: 0x00042BE6
		public unsafe RectTransform TutorialContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_TutorialContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_TutorialContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B93 RID: 11155
		// (get) Token: 0x06008EA2 RID: 36514 RVA: 0x002511A0 File Offset: 0x0024F3A0
		// (set) Token: 0x06008EA3 RID: 36515 RVA: 0x00044A05 File Offset: 0x00042C05
		public unsafe RectTransform CoopTutorialHint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_CoopTutorialHint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_CoopTutorialHint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B94 RID: 11156
		// (get) Token: 0x06008EA4 RID: 36516 RVA: 0x002511D0 File Offset: 0x0024F3D0
		// (set) Token: 0x06008EA5 RID: 36517 RVA: 0x00044A24 File Offset: 0x00042C24
		public unsafe Il2CppStringArray loadingMessages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_loadingMessages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_loadingMessages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B95 RID: 11157
		// (get) Token: 0x06008EA6 RID: 36518 RVA: 0x00251200 File Offset: 0x0024F400
		// (set) Token: 0x06008EA7 RID: 36519 RVA: 0x00044A43 File Offset: 0x00042C43
		public unsafe int currentBackgroundImageIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_currentBackgroundImageIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_currentBackgroundImageIndex)) = value;
			}
		}

		// Token: 0x17002B96 RID: 11158
		// (get) Token: 0x06008EA8 RID: 36520 RVA: 0x00251228 File Offset: 0x0024F428
		// (set) Token: 0x06008EA9 RID: 36521 RVA: 0x00044A5E File Offset: 0x00042C5E
		public unsafe Coroutine fadeRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_fadeRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_fadeRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B97 RID: 11159
		// (get) Token: 0x06008EAA RID: 36522 RVA: 0x00251258 File Offset: 0x0024F458
		// (set) Token: 0x06008EAB RID: 36523 RVA: 0x00044A7D File Offset: 0x00042C7D
		public unsafe Coroutine animateBackgroundRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_animateBackgroundRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_animateBackgroundRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B98 RID: 11160
		// (get) Token: 0x06008EAC RID: 36524 RVA: 0x00251288 File Offset: 0x0024F488
		// (set) Token: 0x06008EAD RID: 36525 RVA: 0x00044A9C File Offset: 0x00042C9C
		public unsafe Coroutine scaleBackgroundRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_scaleBackgroundRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_scaleBackgroundRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B99 RID: 11161
		// (get) Token: 0x06008EAE RID: 36526 RVA: 0x002512B8 File Offset: 0x0024F4B8
		// (set) Token: 0x06008EAF RID: 36527 RVA: 0x00044ABB File Offset: 0x00042CBB
		public unsafe bool isLoadingTutorial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_isLoadingTutorial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.NativeFieldInfoPtr_isLoadingTutorial)) = value;
			}
		}

		// Token: 0x04006075 RID: 24693
		private static readonly IntPtr NativeFieldInfoPtr_FADE_TIME;

		// Token: 0x04006076 RID: 24694
		private static readonly IntPtr NativeFieldInfoPtr_BACKGROUND_IMAGE_TIME;

		// Token: 0x04006077 RID: 24695
		private static readonly IntPtr NativeFieldInfoPtr_BACKGROUND_IMAGE_FADE_TIME;

		// Token: 0x04006078 RID: 24696
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006079 RID: 24697
		private static readonly IntPtr NativeFieldInfoPtr_LoadingMessagesDatabase;

		// Token: 0x0400607A RID: 24698
		private static readonly IntPtr NativeFieldInfoPtr_BackgroundImages;

		// Token: 0x0400607B RID: 24699
		private static readonly IntPtr NativeFieldInfoPtr_TutorialBackgroundImages;

		// Token: 0x0400607C RID: 24700
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x0400607D RID: 24701
		private static readonly IntPtr NativeFieldInfoPtr_Group;

		// Token: 0x0400607E RID: 24702
		private static readonly IntPtr NativeFieldInfoPtr_LoadStatusLabel;

		// Token: 0x0400607F RID: 24703
		private static readonly IntPtr NativeFieldInfoPtr_LoadingMessageLabel;

		// Token: 0x04006080 RID: 24704
		private static readonly IntPtr NativeFieldInfoPtr_BackgroundImage1;

		// Token: 0x04006081 RID: 24705
		private static readonly IntPtr NativeFieldInfoPtr_BackgroundImage2;

		// Token: 0x04006082 RID: 24706
		private static readonly IntPtr NativeFieldInfoPtr_TutorialContainer;

		// Token: 0x04006083 RID: 24707
		private static readonly IntPtr NativeFieldInfoPtr_CoopTutorialHint;

		// Token: 0x04006084 RID: 24708
		private static readonly IntPtr NativeFieldInfoPtr_loadingMessages;

		// Token: 0x04006085 RID: 24709
		private static readonly IntPtr NativeFieldInfoPtr_currentBackgroundImageIndex;

		// Token: 0x04006086 RID: 24710
		private static readonly IntPtr NativeFieldInfoPtr_fadeRoutine;

		// Token: 0x04006087 RID: 24711
		private static readonly IntPtr NativeFieldInfoPtr_animateBackgroundRoutine;

		// Token: 0x04006088 RID: 24712
		private static readonly IntPtr NativeFieldInfoPtr_scaleBackgroundRoutine;

		// Token: 0x04006089 RID: 24713
		private static readonly IntPtr NativeFieldInfoPtr_isLoadingTutorial;

		// Token: 0x0400608A RID: 24714
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400608B RID: 24715
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x0400608C RID: 24716
		private static readonly IntPtr NativeMethodInfoPtr_get_ContextualBackgroundImages_Public_get_Il2CppReferenceArray_1_Sprite_0;

		// Token: 0x0400608D RID: 24717
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400608E RID: 24718
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Void_0;

		// Token: 0x0400608F RID: 24719
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_Boolean_0;

		// Token: 0x04006090 RID: 24720
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006091 RID: 24721
		private static readonly IntPtr NativeMethodInfoPtr_AnimateBackground_Private_Void_0;

		// Token: 0x04006092 RID: 24722
		private static readonly IntPtr NativeMethodInfoPtr_Fade_Private_Void_Single_0;

		// Token: 0x04006093 RID: 24723
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006094 RID: 24724
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000B2C RID: 2860
		[ObfuscatedName("ScheduleOne.UI.LoadingScreen+<<AnimateBackground>g__Routine|30_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D7D6 RID: 55254 RVA: 0x00334A74 File Offset: 0x00332C74
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique()
			{
				Il2CppClassPointerStore<LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "<<AnimateBackground>g__Routine|30_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique>.NativeClassPtr);
				LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique>.NativeClassPtr, "<>1__state");
				LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique>.NativeClassPtr, "<>2__current");
				LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique>.NativeClassPtr, "<>4__this");
				LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique>.NativeClassPtr, "<>8__1");
				LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr__prevImage_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique>.NativeClassPtr, "<prevImage>5__2");
				LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique>.NativeClassPtr, "<i>5__3");
				LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique>.NativeClassPtr, 100680989);
				LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique>.NativeClassPtr, 100680990);
				LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique>.NativeClassPtr, 100680991);
				LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique>.NativeClassPtr, 100680992);
				LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique>.NativeClassPtr, 100680993);
				LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique>.NativeClassPtr, 100680994);
			}

			// Token: 0x0600D7D7 RID: 55255 RVA: 0x00334B90 File Offset: 0x00332D90
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7D8 RID: 55256 RVA: 0x00334BD8 File Offset: 0x00332DD8
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7D9 RID: 55257 RVA: 0x00334C0C File Offset: 0x00332E0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259149, XrefRangeEnd = 259194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170042EC RID: 17132
			// (get) Token: 0x0600D7DA RID: 55258 RVA: 0x00334C48 File Offset: 0x00332E48
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D7DB RID: 55259 RVA: 0x00334C88 File Offset: 0x00332E88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259194, XrefRangeEnd = 259199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170042ED RID: 17133
			// (get) Token: 0x0600D7DC RID: 55260 RVA: 0x00334CBC File Offset: 0x00332EBC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D7DD RID: 55261 RVA: 0x00069189 File Offset: 0x00067389
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042E6 RID: 17126
			// (get) Token: 0x0600D7DE RID: 55262 RVA: 0x00334CFC File Offset: 0x00332EFC
			// (set) Token: 0x0600D7DF RID: 55263 RVA: 0x00069192 File Offset: 0x00067392
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170042E7 RID: 17127
			// (get) Token: 0x0600D7E0 RID: 55264 RVA: 0x00334D24 File Offset: 0x00332F24
			// (set) Token: 0x0600D7E1 RID: 55265 RVA: 0x000691AD File Offset: 0x000673AD
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042E8 RID: 17128
			// (get) Token: 0x0600D7E2 RID: 55266 RVA: 0x00334D54 File Offset: 0x00332F54
			// (set) Token: 0x0600D7E3 RID: 55267 RVA: 0x000691CC File Offset: 0x000673CC
			public unsafe LoadingScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadingScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042E9 RID: 17129
			// (get) Token: 0x0600D7E4 RID: 55268 RVA: 0x00334D84 File Offset: 0x00332F84
			// (set) Token: 0x0600D7E5 RID: 55269 RVA: 0x000691EB File Offset: 0x000673EB
			public unsafe LoadingScreen.__c__DisplayClass30_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadingScreen.__c__DisplayClass30_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042EA RID: 17130
			// (get) Token: 0x0600D7E6 RID: 55270 RVA: 0x00334DB4 File Offset: 0x00332FB4
			// (set) Token: 0x0600D7E7 RID: 55271 RVA: 0x0006920A File Offset: 0x0006740A
			public unsafe Image _prevImage_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr__prevImage_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr__prevImage_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042EB RID: 17131
			// (get) Token: 0x0600D7E8 RID: 55272 RVA: 0x00334DE4 File Offset: 0x00332FE4
			// (set) Token: 0x0600D7E9 RID: 55273 RVA: 0x00069229 File Offset: 0x00067429
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObLoImSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x0400910B RID: 37131
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400910C RID: 37132
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400910D RID: 37133
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400910E RID: 37134
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400910F RID: 37135
			private static readonly IntPtr NativeFieldInfoPtr__prevImage_5__2;

			// Token: 0x04009110 RID: 37136
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04009111 RID: 37137
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009112 RID: 37138
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009113 RID: 37139
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009114 RID: 37140
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009115 RID: 37141
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009116 RID: 37142
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B2D RID: 2861
		[ObfuscatedName("ScheduleOne.UI.LoadingScreen+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D7EA RID: 55274 RVA: 0x00334E0C File Offset: 0x0033300C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0>.NativeClassPtr);
				LoadingScreen.__c__DisplayClass30_0.NativeFieldInfoPtr_nextImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0>.NativeClassPtr, "nextImage");
				LoadingScreen.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0>.NativeClassPtr, 100680995);
				LoadingScreen.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Transform_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0>.NativeClassPtr, 100680996);
			}

			// Token: 0x0600D7EB RID: 55275 RVA: 0x00334E74 File Offset: 0x00333074
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7EC RID: 55276 RVA: 0x00334EB0 File Offset: 0x003330B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259219, XrefRangeEnd = 259225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_Transform_Single_PDM_0(Transform trans, float lerpTime)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trans);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lerpTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Transform_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D7ED RID: 55277 RVA: 0x00069244 File Offset: 0x00067444
			public __c__DisplayClass30_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042EE RID: 17134
			// (get) Token: 0x0600D7EE RID: 55278 RVA: 0x00334F10 File Offset: 0x00333110
			// (set) Token: 0x0600D7EF RID: 55279 RVA: 0x0006924D File Offset: 0x0006744D
			public unsafe Image nextImage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass30_0.NativeFieldInfoPtr_nextImage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass30_0.NativeFieldInfoPtr_nextImage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009117 RID: 37143
			private static readonly IntPtr NativeFieldInfoPtr_nextImage;

			// Token: 0x04009118 RID: 37144
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009119 RID: 37145
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_Transform_Single_PDM_0;

			// Token: 0x02000C74 RID: 3188
			[ObfuscatedName("ScheduleOne.UI.LoadingScreen+<>c__DisplayClass30_0+<<AnimateBackground>g__ScaleRoutine|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E56B RID: 58731 RVA: 0x0035BE48 File Offset: 0x0035A048
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique()
				{
					Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0>.NativeClassPtr, "<<AnimateBackground>g__ScaleRoutine|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique>.NativeClassPtr);
					LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique>.NativeClassPtr, "<>1__state");
					LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique>.NativeClassPtr, "<>2__current");
					LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr_trans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique>.NativeClassPtr, "trans");
					LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr_lerpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique>.NativeClassPtr, "lerpTime");
					LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique>.NativeClassPtr, "<>4__this");
					LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique>.NativeClassPtr, "<i>5__2");
					LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique>.NativeClassPtr, 100680997);
					LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique>.NativeClassPtr, 100680998);
					LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique>.NativeClassPtr, 100680999);
					LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique>.NativeClassPtr, 100681000);
					LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique>.NativeClassPtr, 100681001);
					LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique>.NativeClassPtr, 100681002);
				}

				// Token: 0x0600E56C RID: 58732 RVA: 0x0035BF64 File Offset: 0x0035A164
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E56D RID: 58733 RVA: 0x0035BFAC File Offset: 0x0035A1AC
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E56E RID: 58734 RVA: 0x0035BFE0 File Offset: 0x0035A1E0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259199, XrefRangeEnd = 259214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700475B RID: 18267
				// (get) Token: 0x0600E56F RID: 58735 RVA: 0x0035C01C File Offset: 0x0035A21C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E570 RID: 58736 RVA: 0x0035C05C File Offset: 0x0035A25C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259214, XrefRangeEnd = 259219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700475C RID: 18268
				// (get) Token: 0x0600E571 RID: 58737 RVA: 0x0035C090 File Offset: 0x0035A290
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E572 RID: 58738 RVA: 0x0006FE56 File Offset: 0x0006E056
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004755 RID: 18261
				// (get) Token: 0x0600E573 RID: 58739 RVA: 0x0035C0D0 File Offset: 0x0035A2D0
				// (set) Token: 0x0600E574 RID: 58740 RVA: 0x0006FE5F File Offset: 0x0006E05F
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004756 RID: 18262
				// (get) Token: 0x0600E575 RID: 58741 RVA: 0x0035C0F8 File Offset: 0x0035A2F8
				// (set) Token: 0x0600E576 RID: 58742 RVA: 0x0006FE7A File Offset: 0x0006E07A
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004757 RID: 18263
				// (get) Token: 0x0600E577 RID: 58743 RVA: 0x0035C128 File Offset: 0x0035A328
				// (set) Token: 0x0600E578 RID: 58744 RVA: 0x0006FE99 File Offset: 0x0006E099
				public unsafe Transform trans
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr_trans);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr_trans), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004758 RID: 18264
				// (get) Token: 0x0600E579 RID: 58745 RVA: 0x0035C158 File Offset: 0x0035A358
				// (set) Token: 0x0600E57A RID: 58746 RVA: 0x0006FEB8 File Offset: 0x0006E0B8
				public unsafe float lerpTime
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr_lerpTime);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr_lerpTime)) = value;
					}
				}

				// Token: 0x17004759 RID: 18265
				// (get) Token: 0x0600E57B RID: 58747 RVA: 0x0035C180 File Offset: 0x0035A380
				// (set) Token: 0x0600E57C RID: 58748 RVA: 0x0006FED3 File Offset: 0x0006E0D3
				public unsafe LoadingScreen.__c__DisplayClass30_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadingScreen.__c__DisplayClass30_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700475A RID: 18266
				// (get) Token: 0x0600E57D RID: 58749 RVA: 0x0035C1B0 File Offset: 0x0035A3B0
				// (set) Token: 0x0600E57E RID: 58750 RVA: 0x0006FEF2 File Offset: 0x0006E0F2
				public unsafe float _i_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObTrtrSileSiObObUnique.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x04009967 RID: 39271
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009968 RID: 39272
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009969 RID: 39273
				private static readonly IntPtr NativeFieldInfoPtr_trans;

				// Token: 0x0400996A RID: 39274
				private static readonly IntPtr NativeFieldInfoPtr_lerpTime;

				// Token: 0x0400996B RID: 39275
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400996C RID: 39276
				private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x0400996D RID: 39277
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400996E RID: 39278
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400996F RID: 39279
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009970 RID: 39280
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009971 RID: 39281
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009972 RID: 39282
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B2E RID: 2862
		[ObfuscatedName("ScheduleOne.UI.LoadingScreen+<>c__DisplayClass31_0")]
		public sealed class __c__DisplayClass31_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D7F0 RID: 55280 RVA: 0x00334F40 File Offset: 0x00333140
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_0()
			{
				Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadingScreen>.NativeClassPtr, "<>c__DisplayClass31_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0>.NativeClassPtr);
				LoadingScreen.__c__DisplayClass31_0.NativeFieldInfoPtr_endAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0>.NativeClassPtr, "endAlpha");
				LoadingScreen.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0>.NativeClassPtr, "<>4__this");
				LoadingScreen.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0>.NativeClassPtr, 100681003);
				LoadingScreen.__c__DisplayClass31_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0>.NativeClassPtr, 100681004);
			}

			// Token: 0x0600D7F1 RID: 55281 RVA: 0x00334FBC File Offset: 0x003331BC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7F2 RID: 55282 RVA: 0x00334FF8 File Offset: 0x003331F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259241, XrefRangeEnd = 259246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass31_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D7F3 RID: 55283 RVA: 0x0006926C File Offset: 0x0006746C
			public __c__DisplayClass31_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042EF RID: 17135
			// (get) Token: 0x0600D7F4 RID: 55284 RVA: 0x00335038 File Offset: 0x00333238
			// (set) Token: 0x0600D7F5 RID: 55285 RVA: 0x00069275 File Offset: 0x00067475
			public unsafe float endAlpha
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass31_0.NativeFieldInfoPtr_endAlpha);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass31_0.NativeFieldInfoPtr_endAlpha)) = value;
				}
			}

			// Token: 0x170042F0 RID: 17136
			// (get) Token: 0x0600D7F6 RID: 55286 RVA: 0x00335060 File Offset: 0x00333260
			// (set) Token: 0x0600D7F7 RID: 55287 RVA: 0x00069290 File Offset: 0x00067490
			public unsafe LoadingScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadingScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400911A RID: 37146
			private static readonly IntPtr NativeFieldInfoPtr_endAlpha;

			// Token: 0x0400911B RID: 37147
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400911C RID: 37148
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400911D RID: 37149
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C75 RID: 3189
			[ObfuscatedName("ScheduleOne.UI.LoadingScreen+<>c__DisplayClass31_0+<<Fade>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E57F RID: 58751 RVA: 0x0035C1D8 File Offset: 0x0035A3D8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique()
				{
					Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0>.NativeClassPtr, "<<Fade>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr);
					LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>1__state");
					LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>2__current");
					LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>4__this");
					LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__startAlpha_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<startAlpha>5__2");
					LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<i>5__3");
					LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100681005);
					LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100681006);
					LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100681007);
					LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100681008);
					LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100681009);
					LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100681010);
				}

				// Token: 0x0600E580 RID: 58752 RVA: 0x0035C2E0 File Offset: 0x0035A4E0
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E581 RID: 58753 RVA: 0x0035C328 File Offset: 0x0035A528
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E582 RID: 58754 RVA: 0x0035C35C File Offset: 0x0035A55C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259225, XrefRangeEnd = 259236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004762 RID: 18274
				// (get) Token: 0x0600E583 RID: 58755 RVA: 0x0035C398 File Offset: 0x0035A598
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E584 RID: 58756 RVA: 0x0035C3D8 File Offset: 0x0035A5D8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259236, XrefRangeEnd = 259241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004763 RID: 18275
				// (get) Token: 0x0600E585 RID: 58757 RVA: 0x0035C40C File Offset: 0x0035A60C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E586 RID: 58758 RVA: 0x0006FF0D File Offset: 0x0006E10D
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700475D RID: 18269
				// (get) Token: 0x0600E587 RID: 58759 RVA: 0x0035C44C File Offset: 0x0035A64C
				// (set) Token: 0x0600E588 RID: 58760 RVA: 0x0006FF16 File Offset: 0x0006E116
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x1700475E RID: 18270
				// (get) Token: 0x0600E589 RID: 58761 RVA: 0x0035C474 File Offset: 0x0035A674
				// (set) Token: 0x0600E58A RID: 58762 RVA: 0x0006FF31 File Offset: 0x0006E131
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700475F RID: 18271
				// (get) Token: 0x0600E58B RID: 58763 RVA: 0x0035C4A4 File Offset: 0x0035A6A4
				// (set) Token: 0x0600E58C RID: 58764 RVA: 0x0006FF50 File Offset: 0x0006E150
				public unsafe LoadingScreen.__c__DisplayClass31_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoadingScreen.__c__DisplayClass31_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004760 RID: 18272
				// (get) Token: 0x0600E58D RID: 58765 RVA: 0x0035C4D4 File Offset: 0x0035A6D4
				// (set) Token: 0x0600E58E RID: 58766 RVA: 0x0006FF6F File Offset: 0x0006E16F
				public unsafe float _startAlpha_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__startAlpha_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__startAlpha_5__2)) = value;
					}
				}

				// Token: 0x17004761 RID: 18273
				// (get) Token: 0x0600E58F RID: 58767 RVA: 0x0035C4FC File Offset: 0x0035A6FC
				// (set) Token: 0x0600E590 RID: 58768 RVA: 0x0006FF8A File Offset: 0x0006E18A
				public unsafe float _i_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadingScreen.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
					}
				}

				// Token: 0x04009973 RID: 39283
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009974 RID: 39284
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009975 RID: 39285
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009976 RID: 39286
				private static readonly IntPtr NativeFieldInfoPtr__startAlpha_5__2;

				// Token: 0x04009977 RID: 39287
				private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

				// Token: 0x04009978 RID: 39288
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009979 RID: 39289
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400997A RID: 39290
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400997B RID: 39291
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400997C RID: 39292
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400997D RID: 39293
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
