using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Messages
{
	// Token: 0x020006B3 RID: 1715
	public class WindowSelectorButton : MonoBehaviour
	{
		// Token: 0x06009A7F RID: 39551 RVA: 0x00274434 File Offset: 0x00272634
		// Note: this type is marked as 'beforefieldinit'.
		static WindowSelectorButton()
		{
			Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Messages", "WindowSelectorButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr);
			WindowSelectorButton.NativeFieldInfoPtr_SELECTION_INDICATOR_SCALE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, "SELECTION_INDICATOR_SCALE");
			WindowSelectorButton.NativeFieldInfoPtr_INDICATOR_LERP_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, "INDICATOR_LERP_TIME");
			WindowSelectorButton.NativeFieldInfoPtr_OnSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, "OnSelected");
			WindowSelectorButton.NativeFieldInfoPtr_WindowType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, "WindowType");
			WindowSelectorButton.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, "Button");
			WindowSelectorButton.NativeFieldInfoPtr_InactiveOverlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, "InactiveOverlay");
			WindowSelectorButton.NativeFieldInfoPtr_HoverIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, "HoverIndicator");
			WindowSelectorButton.NativeFieldInfoPtr_hoverRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, "hoverRoutine");
			WindowSelectorButton.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, 100682301);
			WindowSelectorButton.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, 100682302);
			WindowSelectorButton.NativeMethodInfoPtr_HoverStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, 100682303);
			WindowSelectorButton.NativeMethodInfoPtr_HoverEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, 100682304);
			WindowSelectorButton.NativeMethodInfoPtr_Clicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, 100682305);
			WindowSelectorButton.NativeMethodInfoPtr_SetHoverIndicator_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, 100682306);
			WindowSelectorButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, 100682307);
		}

		// Token: 0x06009A80 RID: 39552 RVA: 0x00274590 File Offset: 0x00272790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274585, XrefRangeEnd = 274598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A81 RID: 39553 RVA: 0x002745C4 File Offset: 0x002727C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 274601, RefRangeEnd = 274602, XrefRangeStart = 274598, XrefRangeEnd = 274601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable(bool interactable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref interactable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A82 RID: 39554 RVA: 0x00274604 File Offset: 0x00272804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274602, XrefRangeEnd = 274603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HoverStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.NativeMethodInfoPtr_HoverStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A83 RID: 39555 RVA: 0x00274638 File Offset: 0x00272838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274603, XrefRangeEnd = 274604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HoverEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.NativeMethodInfoPtr_HoverEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A84 RID: 39556 RVA: 0x0027466C File Offset: 0x0027286C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.NativeMethodInfoPtr_Clicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A85 RID: 39557 RVA: 0x002746A0 File Offset: 0x002728A0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 274622, RefRangeEnd = 274629, XrefRangeStart = 274604, XrefRangeEnd = 274622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHoverIndicator(bool shown)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref shown;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.NativeMethodInfoPtr_SetHoverIndicator_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A86 RID: 39558 RVA: 0x002746E0 File Offset: 0x002728E0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WindowSelectorButton() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A87 RID: 39559 RVA: 0x0004B887 File Offset: 0x00049A87
		public WindowSelectorButton(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F8C RID: 12172
		// (get) Token: 0x06009A88 RID: 39560 RVA: 0x0027471C File Offset: 0x0027291C
		// (set) Token: 0x06009A89 RID: 39561 RVA: 0x0004B890 File Offset: 0x00049A90
		public unsafe static float SELECTION_INDICATOR_SCALE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(WindowSelectorButton.NativeFieldInfoPtr_SELECTION_INDICATOR_SCALE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WindowSelectorButton.NativeFieldInfoPtr_SELECTION_INDICATOR_SCALE, (void*)(&value));
			}
		}

		// Token: 0x17002F8D RID: 12173
		// (get) Token: 0x06009A8A RID: 39562 RVA: 0x00274738 File Offset: 0x00272938
		// (set) Token: 0x06009A8B RID: 39563 RVA: 0x0004B89E File Offset: 0x00049A9E
		public unsafe static float INDICATOR_LERP_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(WindowSelectorButton.NativeFieldInfoPtr_INDICATOR_LERP_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WindowSelectorButton.NativeFieldInfoPtr_INDICATOR_LERP_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002F8E RID: 12174
		// (get) Token: 0x06009A8C RID: 39564 RVA: 0x00274754 File Offset: 0x00272954
		// (set) Token: 0x06009A8D RID: 39565 RVA: 0x0004B8AC File Offset: 0x00049AAC
		public unsafe UnityEvent OnSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_OnSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_OnSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F8F RID: 12175
		// (get) Token: 0x06009A8E RID: 39566 RVA: 0x00274784 File Offset: 0x00272984
		// (set) Token: 0x06009A8F RID: 39567 RVA: 0x0004B8CB File Offset: 0x00049ACB
		public unsafe EDealWindow WindowType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_WindowType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_WindowType)) = value;
			}
		}

		// Token: 0x17002F90 RID: 12176
		// (get) Token: 0x06009A90 RID: 39568 RVA: 0x002747AC File Offset: 0x002729AC
		// (set) Token: 0x06009A91 RID: 39569 RVA: 0x0004B8E6 File Offset: 0x00049AE6
		public unsafe Button Button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_Button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F91 RID: 12177
		// (get) Token: 0x06009A92 RID: 39570 RVA: 0x002747DC File Offset: 0x002729DC
		// (set) Token: 0x06009A93 RID: 39571 RVA: 0x0004B905 File Offset: 0x00049B05
		public unsafe GameObject InactiveOverlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_InactiveOverlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_InactiveOverlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F92 RID: 12178
		// (get) Token: 0x06009A94 RID: 39572 RVA: 0x0027480C File Offset: 0x00272A0C
		// (set) Token: 0x06009A95 RID: 39573 RVA: 0x0004B924 File Offset: 0x00049B24
		public unsafe RectTransform HoverIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_HoverIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_HoverIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F93 RID: 12179
		// (get) Token: 0x06009A96 RID: 39574 RVA: 0x0027483C File Offset: 0x00272A3C
		// (set) Token: 0x06009A97 RID: 39575 RVA: 0x0004B943 File Offset: 0x00049B43
		public unsafe Coroutine hoverRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_hoverRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.NativeFieldInfoPtr_hoverRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040067ED RID: 26605
		private static readonly IntPtr NativeFieldInfoPtr_SELECTION_INDICATOR_SCALE;

		// Token: 0x040067EE RID: 26606
		private static readonly IntPtr NativeFieldInfoPtr_INDICATOR_LERP_TIME;

		// Token: 0x040067EF RID: 26607
		private static readonly IntPtr NativeFieldInfoPtr_OnSelected;

		// Token: 0x040067F0 RID: 26608
		private static readonly IntPtr NativeFieldInfoPtr_WindowType;

		// Token: 0x040067F1 RID: 26609
		private static readonly IntPtr NativeFieldInfoPtr_Button;

		// Token: 0x040067F2 RID: 26610
		private static readonly IntPtr NativeFieldInfoPtr_InactiveOverlay;

		// Token: 0x040067F3 RID: 26611
		private static readonly IntPtr NativeFieldInfoPtr_HoverIndicator;

		// Token: 0x040067F4 RID: 26612
		private static readonly IntPtr NativeFieldInfoPtr_hoverRoutine;

		// Token: 0x040067F5 RID: 26613
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040067F6 RID: 26614
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

		// Token: 0x040067F7 RID: 26615
		private static readonly IntPtr NativeMethodInfoPtr_HoverStart_Public_Void_0;

		// Token: 0x040067F8 RID: 26616
		private static readonly IntPtr NativeMethodInfoPtr_HoverEnd_Public_Void_0;

		// Token: 0x040067F9 RID: 26617
		private static readonly IntPtr NativeMethodInfoPtr_Clicked_Public_Void_0;

		// Token: 0x040067FA RID: 26618
		private static readonly IntPtr NativeMethodInfoPtr_SetHoverIndicator_Public_Void_Boolean_0;

		// Token: 0x040067FB RID: 26619
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B81 RID: 2945
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.WindowSelectorButton+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB6F RID: 56175 RVA: 0x0033F130 File Offset: 0x0033D330
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WindowSelectorButton>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0>.NativeClassPtr);
				WindowSelectorButton.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				WindowSelectorButton.__c__DisplayClass13_0.NativeFieldInfoPtr_shown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0>.NativeClassPtr, "shown");
				WindowSelectorButton.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0>.NativeClassPtr, 100682308);
				WindowSelectorButton.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0>.NativeClassPtr, 100682309);
			}

			// Token: 0x0600DB70 RID: 56176 RVA: 0x0033F1AC File Offset: 0x0033D3AC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB71 RID: 56177 RVA: 0x0033F1E8 File Offset: 0x0033D3E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274580, XrefRangeEnd = 274585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DB72 RID: 56178 RVA: 0x0006AE10 File Offset: 0x00069010
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700440D RID: 17421
			// (get) Token: 0x0600DB73 RID: 56179 RVA: 0x0033F228 File Offset: 0x0033D428
			// (set) Token: 0x0600DB74 RID: 56180 RVA: 0x0006AE19 File Offset: 0x00069019
			public unsafe WindowSelectorButton __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowSelectorButton>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700440E RID: 17422
			// (get) Token: 0x0600DB75 RID: 56181 RVA: 0x0033F258 File Offset: 0x0033D458
			// (set) Token: 0x0600DB76 RID: 56182 RVA: 0x0006AE38 File Offset: 0x00069038
			public unsafe bool shown
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.NativeFieldInfoPtr_shown);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.NativeFieldInfoPtr_shown)) = value;
				}
			}

			// Token: 0x04009330 RID: 37680
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009331 RID: 37681
			private static readonly IntPtr NativeFieldInfoPtr_shown;

			// Token: 0x04009332 RID: 37682
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009333 RID: 37683
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C7D RID: 3197
			[ObfuscatedName("ScheduleOne.UI.Phone.Messages.WindowSelectorButton+<>c__DisplayClass13_0+<<SetHoverIndicator>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E626 RID: 58918 RVA: 0x0035DF24 File Offset: 0x0035C124
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique()
				{
					Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0>.NativeClassPtr, "<<SetHoverIndicator>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr);
					WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>1__state");
					WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>2__current");
					WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<>4__this");
					WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__startScale_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<startScale>5__2");
					WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__targetScale_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<targetScale>5__3");
					WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, "<i>5__4");
					WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100682310);
					WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100682311);
					WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100682312);
					WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100682313);
					WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100682314);
					WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr, 100682315);
				}

				// Token: 0x0600E627 RID: 58919 RVA: 0x0035E040 File Offset: 0x0035C240
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E628 RID: 58920 RVA: 0x0035E088 File Offset: 0x0035C288
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E629 RID: 58921 RVA: 0x0035E0BC File Offset: 0x0035C2BC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274553, XrefRangeEnd = 274575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x170047A6 RID: 18342
				// (get) Token: 0x0600E62A RID: 58922 RVA: 0x0035E0F8 File Offset: 0x0035C2F8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E62B RID: 58923 RVA: 0x0035E138 File Offset: 0x0035C338
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274575, XrefRangeEnd = 274580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x170047A7 RID: 18343
				// (get) Token: 0x0600E62C RID: 58924 RVA: 0x0035E16C File Offset: 0x0035C36C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E62D RID: 58925 RVA: 0x00070511 File Offset: 0x0006E711
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047A0 RID: 18336
				// (get) Token: 0x0600E62E RID: 58926 RVA: 0x0035E1AC File Offset: 0x0035C3AC
				// (set) Token: 0x0600E62F RID: 58927 RVA: 0x0007051A File Offset: 0x0006E71A
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047A1 RID: 18337
				// (get) Token: 0x0600E630 RID: 58928 RVA: 0x0035E1D4 File Offset: 0x0035C3D4
				// (set) Token: 0x0600E631 RID: 58929 RVA: 0x00070535 File Offset: 0x0006E735
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047A2 RID: 18338
				// (get) Token: 0x0600E632 RID: 58930 RVA: 0x0035E204 File Offset: 0x0035C404
				// (set) Token: 0x0600E633 RID: 58931 RVA: 0x00070554 File Offset: 0x0006E754
				public unsafe WindowSelectorButton.__c__DisplayClass13_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WindowSelectorButton.__c__DisplayClass13_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047A3 RID: 18339
				// (get) Token: 0x0600E634 RID: 58932 RVA: 0x0035E234 File Offset: 0x0035C434
				// (set) Token: 0x0600E635 RID: 58933 RVA: 0x00070573 File Offset: 0x0006E773
				public unsafe float _startScale_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__startScale_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__startScale_5__2)) = value;
					}
				}

				// Token: 0x170047A4 RID: 18340
				// (get) Token: 0x0600E636 RID: 58934 RVA: 0x0035E25C File Offset: 0x0035C45C
				// (set) Token: 0x0600E637 RID: 58935 RVA: 0x0007058E File Offset: 0x0006E78E
				public unsafe float _targetScale_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__targetScale_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__targetScale_5__3)) = value;
					}
				}

				// Token: 0x170047A5 RID: 18341
				// (get) Token: 0x0600E638 RID: 58936 RVA: 0x0035E284 File Offset: 0x0035C484
				// (set) Token: 0x0600E639 RID: 58937 RVA: 0x000705A9 File Offset: 0x0006E7A9
				public unsafe float _i_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowSelectorButton.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x040099D7 RID: 39383
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040099D8 RID: 39384
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040099D9 RID: 39385
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040099DA RID: 39386
				private static readonly IntPtr NativeFieldInfoPtr__startScale_5__2;

				// Token: 0x040099DB RID: 39387
				private static readonly IntPtr NativeFieldInfoPtr__targetScale_5__3;

				// Token: 0x040099DC RID: 39388
				private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x040099DD RID: 39389
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040099DE RID: 39390
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040099DF RID: 39391
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040099E0 RID: 39392
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040099E1 RID: 39393
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040099E2 RID: 39394
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
