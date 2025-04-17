using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.UI.MainMenu
{
	// Token: 0x020006E9 RID: 1769
	public class MainMenuScreen : MonoBehaviour
	{
		// Token: 0x06009E5B RID: 40539 RVA: 0x00280254 File Offset: 0x0027E454
		// Note: this type is marked as 'beforefieldinit'.
		static MainMenuScreen()
		{
			Il2CppClassPointerStore<MainMenuScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.MainMenu", "MainMenuScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenuScreen>.NativeClassPtr);
			MainMenuScreen.NativeFieldInfoPtr_LERP_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuScreen>.NativeClassPtr, "LERP_TIME");
			MainMenuScreen.NativeFieldInfoPtr_LERP_SCALE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuScreen>.NativeClassPtr, "LERP_SCALE");
			MainMenuScreen.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuScreen>.NativeClassPtr, "<IsOpen>k__BackingField");
			MainMenuScreen.NativeFieldInfoPtr_ExitInputPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuScreen>.NativeClassPtr, "ExitInputPriority");
			MainMenuScreen.NativeFieldInfoPtr_OpenOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuScreen>.NativeClassPtr, "OpenOnStart");
			MainMenuScreen.NativeFieldInfoPtr_PreviousScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuScreen>.NativeClassPtr, "PreviousScreen");
			MainMenuScreen.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuScreen>.NativeClassPtr, "Group");
			MainMenuScreen.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuScreen>.NativeClassPtr, "Rect");
			MainMenuScreen.NativeFieldInfoPtr_lerpRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuScreen>.NativeClassPtr, "lerpRoutine");
			MainMenuScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuScreen>.NativeClassPtr, 100682724);
			MainMenuScreen.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuScreen>.NativeClassPtr, 100682725);
			MainMenuScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuScreen>.NativeClassPtr, 100682726);
			MainMenuScreen.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuScreen>.NativeClassPtr, 100682727);
			MainMenuScreen.NativeMethodInfoPtr_Exit_Protected_Virtual_New_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuScreen>.NativeClassPtr, 100682728);
			MainMenuScreen.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuScreen>.NativeClassPtr, 100682729);
			MainMenuScreen.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuScreen>.NativeClassPtr, 100682730);
			MainMenuScreen.NativeMethodInfoPtr_Lerp_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuScreen>.NativeClassPtr, 100682731);
			MainMenuScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuScreen>.NativeClassPtr, 100682732);
		}

		// Token: 0x170030C7 RID: 12487
		// (get) Token: 0x06009E5C RID: 40540 RVA: 0x002803EC File Offset: 0x0027E5EC
		// (set) Token: 0x06009E5D RID: 40541 RVA: 0x00280428 File Offset: 0x0027E628
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuScreen.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009E5E RID: 40542 RVA: 0x00280468 File Offset: 0x0027E668
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280033, RefRangeEnd = 280034, XrefRangeStart = 280006, XrefRangeEnd = 280033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MainMenuScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E5F RID: 40543 RVA: 0x002804A4 File Offset: 0x0027E6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280034, XrefRangeEnd = 280048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuScreen.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E60 RID: 40544 RVA: 0x002804D8 File Offset: 0x0027E6D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280048, XrefRangeEnd = 280052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MainMenuScreen.NativeMethodInfoPtr_Exit_Protected_Virtual_New_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E61 RID: 40545 RVA: 0x00280528 File Offset: 0x0027E728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280052, XrefRangeEnd = 280057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Open(bool closePrevious)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref closePrevious;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MainMenuScreen.NativeMethodInfoPtr_Open_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E62 RID: 40546 RVA: 0x00280574 File Offset: 0x0027E774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280057, XrefRangeEnd = 280062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close(bool openPrevious)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref openPrevious;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MainMenuScreen.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E63 RID: 40547 RVA: 0x002805C0 File Offset: 0x0027E7C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 280090, RefRangeEnd = 280092, XrefRangeStart = 280062, XrefRangeEnd = 280090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Lerp(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuScreen.NativeMethodInfoPtr_Lerp_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E64 RID: 40548 RVA: 0x00280600 File Offset: 0x0027E800
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MainMenuScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenuScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009E65 RID: 40549 RVA: 0x0004DAB0 File Offset: 0x0004BCB0
		public MainMenuScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030BE RID: 12478
		// (get) Token: 0x06009E66 RID: 40550 RVA: 0x0028063C File Offset: 0x0027E83C
		// (set) Token: 0x06009E67 RID: 40551 RVA: 0x0004DAB9 File Offset: 0x0004BCB9
		public unsafe static float LERP_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MainMenuScreen.NativeFieldInfoPtr_LERP_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MainMenuScreen.NativeFieldInfoPtr_LERP_TIME, (void*)(&value));
			}
		}

		// Token: 0x170030BF RID: 12479
		// (get) Token: 0x06009E68 RID: 40552 RVA: 0x00280658 File Offset: 0x0027E858
		// (set) Token: 0x06009E69 RID: 40553 RVA: 0x0004DAC7 File Offset: 0x0004BCC7
		public unsafe static float LERP_SCALE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MainMenuScreen.NativeFieldInfoPtr_LERP_SCALE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MainMenuScreen.NativeFieldInfoPtr_LERP_SCALE, (void*)(&value));
			}
		}

		// Token: 0x170030C0 RID: 12480
		// (get) Token: 0x06009E6A RID: 40554 RVA: 0x00280674 File Offset: 0x0027E874
		// (set) Token: 0x06009E6B RID: 40555 RVA: 0x0004DAD5 File Offset: 0x0004BCD5
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170030C1 RID: 12481
		// (get) Token: 0x06009E6C RID: 40556 RVA: 0x0028069C File Offset: 0x0027E89C
		// (set) Token: 0x06009E6D RID: 40557 RVA: 0x0004DAF0 File Offset: 0x0004BCF0
		public unsafe int ExitInputPriority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.NativeFieldInfoPtr_ExitInputPriority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.NativeFieldInfoPtr_ExitInputPriority)) = value;
			}
		}

		// Token: 0x170030C2 RID: 12482
		// (get) Token: 0x06009E6E RID: 40558 RVA: 0x002806C4 File Offset: 0x0027E8C4
		// (set) Token: 0x06009E6F RID: 40559 RVA: 0x0004DB0B File Offset: 0x0004BD0B
		public unsafe bool OpenOnStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.NativeFieldInfoPtr_OpenOnStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.NativeFieldInfoPtr_OpenOnStart)) = value;
			}
		}

		// Token: 0x170030C3 RID: 12483
		// (get) Token: 0x06009E70 RID: 40560 RVA: 0x002806EC File Offset: 0x0027E8EC
		// (set) Token: 0x06009E71 RID: 40561 RVA: 0x0004DB26 File Offset: 0x0004BD26
		public unsafe MainMenuScreen PreviousScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.NativeFieldInfoPtr_PreviousScreen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenuScreen>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.NativeFieldInfoPtr_PreviousScreen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030C4 RID: 12484
		// (get) Token: 0x06009E72 RID: 40562 RVA: 0x0028071C File Offset: 0x0027E91C
		// (set) Token: 0x06009E73 RID: 40563 RVA: 0x0004DB45 File Offset: 0x0004BD45
		public unsafe CanvasGroup Group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.NativeFieldInfoPtr_Group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030C5 RID: 12485
		// (get) Token: 0x06009E74 RID: 40564 RVA: 0x0028074C File Offset: 0x0027E94C
		// (set) Token: 0x06009E75 RID: 40565 RVA: 0x0004DB64 File Offset: 0x0004BD64
		public unsafe RectTransform Rect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.NativeFieldInfoPtr_Rect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030C6 RID: 12486
		// (get) Token: 0x06009E76 RID: 40566 RVA: 0x0028077C File Offset: 0x0027E97C
		// (set) Token: 0x06009E77 RID: 40567 RVA: 0x0004DB83 File Offset: 0x0004BD83
		public unsafe Coroutine lerpRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.NativeFieldInfoPtr_lerpRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.NativeFieldInfoPtr_lerpRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A49 RID: 27209
		private static readonly IntPtr NativeFieldInfoPtr_LERP_TIME;

		// Token: 0x04006A4A RID: 27210
		private static readonly IntPtr NativeFieldInfoPtr_LERP_SCALE;

		// Token: 0x04006A4B RID: 27211
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04006A4C RID: 27212
		private static readonly IntPtr NativeFieldInfoPtr_ExitInputPriority;

		// Token: 0x04006A4D RID: 27213
		private static readonly IntPtr NativeFieldInfoPtr_OpenOnStart;

		// Token: 0x04006A4E RID: 27214
		private static readonly IntPtr NativeFieldInfoPtr_PreviousScreen;

		// Token: 0x04006A4F RID: 27215
		private static readonly IntPtr NativeFieldInfoPtr_Group;

		// Token: 0x04006A50 RID: 27216
		private static readonly IntPtr NativeFieldInfoPtr_Rect;

		// Token: 0x04006A51 RID: 27217
		private static readonly IntPtr NativeFieldInfoPtr_lerpRoutine;

		// Token: 0x04006A52 RID: 27218
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04006A53 RID: 27219
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04006A54 RID: 27220
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04006A55 RID: 27221
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04006A56 RID: 27222
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Protected_Virtual_New_Void_ExitAction_0;

		// Token: 0x04006A57 RID: 27223
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04006A58 RID: 27224
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04006A59 RID: 27225
		private static readonly IntPtr NativeMethodInfoPtr_Lerp_Private_Void_Boolean_0;

		// Token: 0x04006A5A RID: 27226
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B9C RID: 2972
		[ObfuscatedName("ScheduleOne.UI.MainMenu.MainMenuScreen+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DC63 RID: 56419 RVA: 0x00341C9C File Offset: 0x0033FE9C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<MainMenuScreen.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainMenuScreen>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenuScreen.__c__DisplayClass17_0>.NativeClassPtr);
				MainMenuScreen.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuScreen.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				MainMenuScreen.__c__DisplayClass17_0.NativeFieldInfoPtr_open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuScreen.__c__DisplayClass17_0>.NativeClassPtr, "open");
				MainMenuScreen.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuScreen.__c__DisplayClass17_0>.NativeClassPtr, 100682733);
				MainMenuScreen.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuScreen.__c__DisplayClass17_0>.NativeClassPtr, 100682734);
			}

			// Token: 0x0600DC64 RID: 56420 RVA: 0x00341D18 File Offset: 0x0033FF18
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenuScreen.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuScreen.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC65 RID: 56421 RVA: 0x00341D54 File Offset: 0x0033FF54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280001, XrefRangeEnd = 280006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuScreen.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DC66 RID: 56422 RVA: 0x0006B5CF File Offset: 0x000697CF
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700444E RID: 17486
			// (get) Token: 0x0600DC67 RID: 56423 RVA: 0x00341D94 File Offset: 0x0033FF94
			// (set) Token: 0x0600DC68 RID: 56424 RVA: 0x0006B5D8 File Offset: 0x000697D8
			public unsafe MainMenuScreen __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenuScreen>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700444F RID: 17487
			// (get) Token: 0x0600DC69 RID: 56425 RVA: 0x00341DC4 File Offset: 0x0033FFC4
			// (set) Token: 0x0600DC6A RID: 56426 RVA: 0x0006B5F7 File Offset: 0x000697F7
			public unsafe bool open
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.__c__DisplayClass17_0.NativeFieldInfoPtr_open);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.__c__DisplayClass17_0.NativeFieldInfoPtr_open)) = value;
				}
			}

			// Token: 0x040093B0 RID: 37808
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040093B1 RID: 37809
			private static readonly IntPtr NativeFieldInfoPtr_open;

			// Token: 0x040093B2 RID: 37810
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040093B3 RID: 37811
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C81 RID: 3201
			[ObfuscatedName("ScheduleOne.UI.MainMenu.MainMenuScreen+<>c__DisplayClass17_0+<<Lerp>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E672 RID: 58994 RVA: 0x0035ECCC File Offset: 0x0035CECC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique()
				{
					Il2CppClassPointerStore<MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainMenuScreen.__c__DisplayClass17_0>.NativeClassPtr, "<<Lerp>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr);
					MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<>1__state");
					MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<>2__current");
					MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<>4__this");
					MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__startAlpha_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<startAlpha>5__2");
					MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__startScale_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<startScale>5__3");
					MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__endAlpha_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<endAlpha>5__4");
					MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__endScale_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<endScale>5__5");
					MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__lerpTime_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<lerpTime>5__6");
					MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__i_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, "<i>5__7");
					MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, 100682735);
					MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, 100682736);
					MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, 100682737);
					MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, 100682738);
					MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, 100682739);
					MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr, 100682740);
				}

				// Token: 0x0600E673 RID: 58995 RVA: 0x0035EE24 File Offset: 0x0035D024
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E674 RID: 58996 RVA: 0x0035EE6C File Offset: 0x0035D06C
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E675 RID: 58997 RVA: 0x0035EEA0 File Offset: 0x0035D0A0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279975, XrefRangeEnd = 279996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170047C7 RID: 18375
				// (get) Token: 0x0600E676 RID: 58998 RVA: 0x0035EEDC File Offset: 0x0035D0DC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E677 RID: 58999 RVA: 0x0035EF1C File Offset: 0x0035D11C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279996, XrefRangeEnd = 280001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170047C8 RID: 18376
				// (get) Token: 0x0600E678 RID: 59000 RVA: 0x0035EF50 File Offset: 0x0035D150
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E679 RID: 59001 RVA: 0x000707A7 File Offset: 0x0006E9A7
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047BE RID: 18366
				// (get) Token: 0x0600E67A RID: 59002 RVA: 0x0035EF90 File Offset: 0x0035D190
				// (set) Token: 0x0600E67B RID: 59003 RVA: 0x000707B0 File Offset: 0x0006E9B0
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047BF RID: 18367
				// (get) Token: 0x0600E67C RID: 59004 RVA: 0x0035EFB8 File Offset: 0x0035D1B8
				// (set) Token: 0x0600E67D RID: 59005 RVA: 0x000707CB File Offset: 0x0006E9CB
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047C0 RID: 18368
				// (get) Token: 0x0600E67E RID: 59006 RVA: 0x0035EFE8 File Offset: 0x0035D1E8
				// (set) Token: 0x0600E67F RID: 59007 RVA: 0x000707EA File Offset: 0x0006E9EA
				public unsafe MainMenuScreen.__c__DisplayClass17_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenuScreen.__c__DisplayClass17_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047C1 RID: 18369
				// (get) Token: 0x0600E680 RID: 59008 RVA: 0x0035F018 File Offset: 0x0035D218
				// (set) Token: 0x0600E681 RID: 59009 RVA: 0x00070809 File Offset: 0x0006EA09
				public unsafe float _startAlpha_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__startAlpha_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__startAlpha_5__2)) = value;
					}
				}

				// Token: 0x170047C2 RID: 18370
				// (get) Token: 0x0600E682 RID: 59010 RVA: 0x0035F040 File Offset: 0x0035D240
				// (set) Token: 0x0600E683 RID: 59011 RVA: 0x00070824 File Offset: 0x0006EA24
				public unsafe float _startScale_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__startScale_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__startScale_5__3)) = value;
					}
				}

				// Token: 0x170047C3 RID: 18371
				// (get) Token: 0x0600E684 RID: 59012 RVA: 0x0035F068 File Offset: 0x0035D268
				// (set) Token: 0x0600E685 RID: 59013 RVA: 0x0007083F File Offset: 0x0006EA3F
				public unsafe float _endAlpha_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__endAlpha_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__endAlpha_5__4)) = value;
					}
				}

				// Token: 0x170047C4 RID: 18372
				// (get) Token: 0x0600E686 RID: 59014 RVA: 0x0035F090 File Offset: 0x0035D290
				// (set) Token: 0x0600E687 RID: 59015 RVA: 0x0007085A File Offset: 0x0006EA5A
				public unsafe float _endScale_5__5
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__endScale_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__endScale_5__5)) = value;
					}
				}

				// Token: 0x170047C5 RID: 18373
				// (get) Token: 0x0600E688 RID: 59016 RVA: 0x0035F0B8 File Offset: 0x0035D2B8
				// (set) Token: 0x0600E689 RID: 59017 RVA: 0x00070875 File Offset: 0x0006EA75
				public unsafe float _lerpTime_5__6
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__lerpTime_5__6);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__lerpTime_5__6)) = value;
					}
				}

				// Token: 0x170047C6 RID: 18374
				// (get) Token: 0x0600E68A RID: 59018 RVA: 0x0035F0E0 File Offset: 0x0035D2E0
				// (set) Token: 0x0600E68B RID: 59019 RVA: 0x00070890 File Offset: 0x0006EA90
				public unsafe float _i_5__7
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__i_5__7);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuScreen.__c__DisplayClass17_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiSiUnique.NativeFieldInfoPtr__i_5__7)) = value;
					}
				}

				// Token: 0x04009A05 RID: 39429
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009A06 RID: 39430
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009A07 RID: 39431
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009A08 RID: 39432
				private static readonly IntPtr NativeFieldInfoPtr__startAlpha_5__2;

				// Token: 0x04009A09 RID: 39433
				private static readonly IntPtr NativeFieldInfoPtr__startScale_5__3;

				// Token: 0x04009A0A RID: 39434
				private static readonly IntPtr NativeFieldInfoPtr__endAlpha_5__4;

				// Token: 0x04009A0B RID: 39435
				private static readonly IntPtr NativeFieldInfoPtr__endScale_5__5;

				// Token: 0x04009A0C RID: 39436
				private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__6;

				// Token: 0x04009A0D RID: 39437
				private static readonly IntPtr NativeFieldInfoPtr__i_5__7;

				// Token: 0x04009A0E RID: 39438
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009A0F RID: 39439
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A10 RID: 39440
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009A11 RID: 39441
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009A12 RID: 39442
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009A13 RID: 39443
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
