using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Messages
{
	// Token: 0x020006AF RID: 1711
	public class MessageBubble : MonoBehaviour
	{
		// Token: 0x060099D6 RID: 39382 RVA: 0x00272878 File Offset: 0x00270A78
		// Note: this type is marked as 'beforefieldinit'.
		static MessageBubble()
		{
			Il2CppClassPointerStore<MessageBubble>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Messages", "MessageBubble");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr);
			MessageBubble.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "text");
			MessageBubble.NativeFieldInfoPtr_alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "alignment");
			MessageBubble.NativeFieldInfoPtr_showTriangle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "showTriangle");
			MessageBubble.NativeFieldInfoPtr_bubble_MinWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "bubble_MinWidth");
			MessageBubble.NativeFieldInfoPtr_bubble_MaxWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "bubble_MaxWidth");
			MessageBubble.NativeFieldInfoPtr_alignTextCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "alignTextCenter");
			MessageBubble.NativeFieldInfoPtr_autosetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "autosetPosition");
			MessageBubble.NativeFieldInfoPtr_displayedText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "displayedText");
			MessageBubble.NativeFieldInfoPtr_triangleShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "triangleShown");
			MessageBubble.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "container");
			MessageBubble.NativeFieldInfoPtr_bubble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "bubble");
			MessageBubble.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "content");
			MessageBubble.NativeFieldInfoPtr_triangle_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "triangle_Left");
			MessageBubble.NativeFieldInfoPtr_triangle_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "triangle_Right");
			MessageBubble.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "button");
			MessageBubble.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "height");
			MessageBubble.NativeFieldInfoPtr_spacingAbove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "spacingAbove");
			MessageBubble.NativeFieldInfoPtr_backgroundColor_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "backgroundColor_Left");
			MessageBubble.NativeFieldInfoPtr_textColor_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "textColor_Left");
			MessageBubble.NativeFieldInfoPtr_backgroundColor_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "backgroundColor_Right");
			MessageBubble.NativeFieldInfoPtr_textColor_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "textColor_Right");
			MessageBubble.NativeFieldInfoPtr_baseBubbleSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, "baseBubbleSpacing");
			MessageBubble.NativeMethodInfoPtr_SetupBubble_Public_Void_String_Alignment_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, 100682258);
			MessageBubble.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, 100682259);
			MessageBubble.NativeMethodInfoPtr_RefreshDisplayedText_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, 100682260);
			MessageBubble.NativeMethodInfoPtr_RefreshTriangle_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, 100682261);
			MessageBubble.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr, 100682262);
		}

		// Token: 0x060099D7 RID: 39383 RVA: 0x00272AC4 File Offset: 0x00270CC4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 274047, RefRangeEnd = 274050, XrefRangeStart = 274023, XrefRangeEnd = 274047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupBubble(string _text, MessageBubble.Alignment _alignment, bool alignCenter = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _alignment;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignCenter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageBubble.NativeMethodInfoPtr_SetupBubble_Public_Void_String_Alignment_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099D8 RID: 39384 RVA: 0x00272B24 File Offset: 0x00270D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274050, XrefRangeEnd = 274051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageBubble.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099D9 RID: 39385 RVA: 0x00272B60 File Offset: 0x00270D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274051, XrefRangeEnd = 274064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshDisplayedText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageBubble.NativeMethodInfoPtr_RefreshDisplayedText_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099DA RID: 39386 RVA: 0x00272B9C File Offset: 0x00270D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274064, XrefRangeEnd = 274073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshTriangle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageBubble.NativeMethodInfoPtr_RefreshTriangle_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099DB RID: 39387 RVA: 0x00272BD8 File Offset: 0x00270DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274073, XrefRangeEnd = 274079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageBubble() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageBubble>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageBubble.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060099DC RID: 39388 RVA: 0x0004B146 File Offset: 0x00049346
		public MessageBubble(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F4B RID: 12107
		// (get) Token: 0x060099DD RID: 39389 RVA: 0x00272C14 File Offset: 0x00270E14
		// (set) Token: 0x060099DE RID: 39390 RVA: 0x0004B14F File Offset: 0x0004934F
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002F4C RID: 12108
		// (get) Token: 0x060099DF RID: 39391 RVA: 0x00272C3C File Offset: 0x00270E3C
		// (set) Token: 0x060099E0 RID: 39392 RVA: 0x0004B16E File Offset: 0x0004936E
		public unsafe MessageBubble.Alignment alignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_alignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_alignment)) = value;
			}
		}

		// Token: 0x17002F4D RID: 12109
		// (get) Token: 0x060099E1 RID: 39393 RVA: 0x00272C64 File Offset: 0x00270E64
		// (set) Token: 0x060099E2 RID: 39394 RVA: 0x0004B189 File Offset: 0x00049389
		public unsafe bool showTriangle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_showTriangle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_showTriangle)) = value;
			}
		}

		// Token: 0x17002F4E RID: 12110
		// (get) Token: 0x060099E3 RID: 39395 RVA: 0x00272C8C File Offset: 0x00270E8C
		// (set) Token: 0x060099E4 RID: 39396 RVA: 0x0004B1A4 File Offset: 0x000493A4
		public unsafe float bubble_MinWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_bubble_MinWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_bubble_MinWidth)) = value;
			}
		}

		// Token: 0x17002F4F RID: 12111
		// (get) Token: 0x060099E5 RID: 39397 RVA: 0x00272CB4 File Offset: 0x00270EB4
		// (set) Token: 0x060099E6 RID: 39398 RVA: 0x0004B1BF File Offset: 0x000493BF
		public unsafe float bubble_MaxWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_bubble_MaxWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_bubble_MaxWidth)) = value;
			}
		}

		// Token: 0x17002F50 RID: 12112
		// (get) Token: 0x060099E7 RID: 39399 RVA: 0x00272CDC File Offset: 0x00270EDC
		// (set) Token: 0x060099E8 RID: 39400 RVA: 0x0004B1DA File Offset: 0x000493DA
		public unsafe bool alignTextCenter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_alignTextCenter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_alignTextCenter)) = value;
			}
		}

		// Token: 0x17002F51 RID: 12113
		// (get) Token: 0x060099E9 RID: 39401 RVA: 0x00272D04 File Offset: 0x00270F04
		// (set) Token: 0x060099EA RID: 39402 RVA: 0x0004B1F5 File Offset: 0x000493F5
		public unsafe bool autosetPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_autosetPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_autosetPosition)) = value;
			}
		}

		// Token: 0x17002F52 RID: 12114
		// (get) Token: 0x060099EB RID: 39403 RVA: 0x00272D2C File Offset: 0x00270F2C
		// (set) Token: 0x060099EC RID: 39404 RVA: 0x0004B210 File Offset: 0x00049410
		public unsafe string displayedText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_displayedText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_displayedText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002F53 RID: 12115
		// (get) Token: 0x060099ED RID: 39405 RVA: 0x00272D54 File Offset: 0x00270F54
		// (set) Token: 0x060099EE RID: 39406 RVA: 0x0004B22F File Offset: 0x0004942F
		public unsafe bool triangleShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_triangleShown);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_triangleShown)) = value;
			}
		}

		// Token: 0x17002F54 RID: 12116
		// (get) Token: 0x060099EF RID: 39407 RVA: 0x00272D7C File Offset: 0x00270F7C
		// (set) Token: 0x060099F0 RID: 39408 RVA: 0x0004B24A File Offset: 0x0004944A
		public unsafe RectTransform container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F55 RID: 12117
		// (get) Token: 0x060099F1 RID: 39409 RVA: 0x00272DAC File Offset: 0x00270FAC
		// (set) Token: 0x060099F2 RID: 39410 RVA: 0x0004B269 File Offset: 0x00049469
		public unsafe Image bubble
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_bubble);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_bubble), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F56 RID: 12118
		// (get) Token: 0x060099F3 RID: 39411 RVA: 0x00272DDC File Offset: 0x00270FDC
		// (set) Token: 0x060099F4 RID: 39412 RVA: 0x0004B288 File Offset: 0x00049488
		public unsafe Text content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F57 RID: 12119
		// (get) Token: 0x060099F5 RID: 39413 RVA: 0x00272E0C File Offset: 0x0027100C
		// (set) Token: 0x060099F6 RID: 39414 RVA: 0x0004B2A7 File Offset: 0x000494A7
		public unsafe Image triangle_Left
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_triangle_Left);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_triangle_Left), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F58 RID: 12120
		// (get) Token: 0x060099F7 RID: 39415 RVA: 0x00272E3C File Offset: 0x0027103C
		// (set) Token: 0x060099F8 RID: 39416 RVA: 0x0004B2C6 File Offset: 0x000494C6
		public unsafe Image triangle_Right
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_triangle_Right);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_triangle_Right), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F59 RID: 12121
		// (get) Token: 0x060099F9 RID: 39417 RVA: 0x00272E6C File Offset: 0x0027106C
		// (set) Token: 0x060099FA RID: 39418 RVA: 0x0004B2E5 File Offset: 0x000494E5
		public unsafe Button button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F5A RID: 12122
		// (get) Token: 0x060099FB RID: 39419 RVA: 0x00272E9C File Offset: 0x0027109C
		// (set) Token: 0x060099FC RID: 39420 RVA: 0x0004B304 File Offset: 0x00049504
		public unsafe float height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_height)) = value;
			}
		}

		// Token: 0x17002F5B RID: 12123
		// (get) Token: 0x060099FD RID: 39421 RVA: 0x00272EC4 File Offset: 0x002710C4
		// (set) Token: 0x060099FE RID: 39422 RVA: 0x0004B31F File Offset: 0x0004951F
		public unsafe float spacingAbove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_spacingAbove);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageBubble.NativeFieldInfoPtr_spacingAbove)) = value;
			}
		}

		// Token: 0x17002F5C RID: 12124
		// (get) Token: 0x060099FF RID: 39423 RVA: 0x00272EEC File Offset: 0x002710EC
		// (set) Token: 0x06009A00 RID: 39424 RVA: 0x0004B33A File Offset: 0x0004953A
		public unsafe static Color32 backgroundColor_Left
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(MessageBubble.NativeFieldInfoPtr_backgroundColor_Left, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MessageBubble.NativeFieldInfoPtr_backgroundColor_Left, (void*)(&value));
			}
		}

		// Token: 0x17002F5D RID: 12125
		// (get) Token: 0x06009A01 RID: 39425 RVA: 0x00272F08 File Offset: 0x00271108
		// (set) Token: 0x06009A02 RID: 39426 RVA: 0x0004B348 File Offset: 0x00049548
		public unsafe static Color32 textColor_Left
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(MessageBubble.NativeFieldInfoPtr_textColor_Left, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MessageBubble.NativeFieldInfoPtr_textColor_Left, (void*)(&value));
			}
		}

		// Token: 0x17002F5E RID: 12126
		// (get) Token: 0x06009A03 RID: 39427 RVA: 0x00272F24 File Offset: 0x00271124
		// (set) Token: 0x06009A04 RID: 39428 RVA: 0x0004B356 File Offset: 0x00049556
		public unsafe static Color32 backgroundColor_Right
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(MessageBubble.NativeFieldInfoPtr_backgroundColor_Right, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MessageBubble.NativeFieldInfoPtr_backgroundColor_Right, (void*)(&value));
			}
		}

		// Token: 0x17002F5F RID: 12127
		// (get) Token: 0x06009A05 RID: 39429 RVA: 0x00272F40 File Offset: 0x00271140
		// (set) Token: 0x06009A06 RID: 39430 RVA: 0x0004B364 File Offset: 0x00049564
		public unsafe static Color32 textColor_Right
		{
			get
			{
				Color32 result;
				IL2CPP.il2cpp_field_static_get_value(MessageBubble.NativeFieldInfoPtr_textColor_Right, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MessageBubble.NativeFieldInfoPtr_textColor_Right, (void*)(&value));
			}
		}

		// Token: 0x17002F60 RID: 12128
		// (get) Token: 0x06009A07 RID: 39431 RVA: 0x00272F5C File Offset: 0x0027115C
		// (set) Token: 0x06009A08 RID: 39432 RVA: 0x0004B372 File Offset: 0x00049572
		public unsafe static float baseBubbleSpacing
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(MessageBubble.NativeFieldInfoPtr_baseBubbleSpacing, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MessageBubble.NativeFieldInfoPtr_baseBubbleSpacing, (void*)(&value));
			}
		}

		// Token: 0x0400678C RID: 26508
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x0400678D RID: 26509
		private static readonly IntPtr NativeFieldInfoPtr_alignment;

		// Token: 0x0400678E RID: 26510
		private static readonly IntPtr NativeFieldInfoPtr_showTriangle;

		// Token: 0x0400678F RID: 26511
		private static readonly IntPtr NativeFieldInfoPtr_bubble_MinWidth;

		// Token: 0x04006790 RID: 26512
		private static readonly IntPtr NativeFieldInfoPtr_bubble_MaxWidth;

		// Token: 0x04006791 RID: 26513
		private static readonly IntPtr NativeFieldInfoPtr_alignTextCenter;

		// Token: 0x04006792 RID: 26514
		private static readonly IntPtr NativeFieldInfoPtr_autosetPosition;

		// Token: 0x04006793 RID: 26515
		private static readonly IntPtr NativeFieldInfoPtr_displayedText;

		// Token: 0x04006794 RID: 26516
		private static readonly IntPtr NativeFieldInfoPtr_triangleShown;

		// Token: 0x04006795 RID: 26517
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x04006796 RID: 26518
		private static readonly IntPtr NativeFieldInfoPtr_bubble;

		// Token: 0x04006797 RID: 26519
		private static readonly IntPtr NativeFieldInfoPtr_content;

		// Token: 0x04006798 RID: 26520
		private static readonly IntPtr NativeFieldInfoPtr_triangle_Left;

		// Token: 0x04006799 RID: 26521
		private static readonly IntPtr NativeFieldInfoPtr_triangle_Right;

		// Token: 0x0400679A RID: 26522
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x0400679B RID: 26523
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x0400679C RID: 26524
		private static readonly IntPtr NativeFieldInfoPtr_spacingAbove;

		// Token: 0x0400679D RID: 26525
		private static readonly IntPtr NativeFieldInfoPtr_backgroundColor_Left;

		// Token: 0x0400679E RID: 26526
		private static readonly IntPtr NativeFieldInfoPtr_textColor_Left;

		// Token: 0x0400679F RID: 26527
		private static readonly IntPtr NativeFieldInfoPtr_backgroundColor_Right;

		// Token: 0x040067A0 RID: 26528
		private static readonly IntPtr NativeFieldInfoPtr_textColor_Right;

		// Token: 0x040067A1 RID: 26529
		private static readonly IntPtr NativeFieldInfoPtr_baseBubbleSpacing;

		// Token: 0x040067A2 RID: 26530
		private static readonly IntPtr NativeMethodInfoPtr_SetupBubble_Public_Void_String_Alignment_Boolean_0;

		// Token: 0x040067A3 RID: 26531
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040067A4 RID: 26532
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDisplayedText_Public_Virtual_New_Void_0;

		// Token: 0x040067A5 RID: 26533
		private static readonly IntPtr NativeMethodInfoPtr_RefreshTriangle_Protected_Virtual_New_Void_0;

		// Token: 0x040067A6 RID: 26534
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B7B RID: 2939
		[OriginalName("Assembly-CSharp.dll", "", "Alignment")]
		public enum Alignment
		{
			// Token: 0x0400931A RID: 37658
			Center,
			// Token: 0x0400931B RID: 37659
			Left,
			// Token: 0x0400931C RID: 37660
			Right
		}
	}
}
