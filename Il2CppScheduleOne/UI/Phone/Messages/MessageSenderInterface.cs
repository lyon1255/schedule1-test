using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Messaging;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone.Messages
{
	// Token: 0x020006B2 RID: 1714
	public class MessageSenderInterface : MonoBehaviour
	{
		// Token: 0x06009A5D RID: 39517 RVA: 0x00273E10 File Offset: 0x00272010
		// Note: this type is marked as 'beforefieldinit'.
		static MessageSenderInterface()
		{
			Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone.Messages", "MessageSenderInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr);
			MessageSenderInterface.NativeFieldInfoPtr_Visibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "Visibility");
			MessageSenderInterface.NativeFieldInfoPtr_DockedMenuYPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "DockedMenuYPos");
			MessageSenderInterface.NativeFieldInfoPtr_ExpandedMenuYPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "ExpandedMenuYPos");
			MessageSenderInterface.NativeFieldInfoPtr_Menu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "Menu");
			MessageSenderInterface.NativeFieldInfoPtr_SendablesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "SendablesContainer");
			MessageSenderInterface.NativeFieldInfoPtr_DockedUIElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "DockedUIElements");
			MessageSenderInterface.NativeFieldInfoPtr_ExpandedUIElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "ExpandedUIElements");
			MessageSenderInterface.NativeFieldInfoPtr_ComposeButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "ComposeButton");
			MessageSenderInterface.NativeFieldInfoPtr_CancelButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "CancelButtons");
			MessageSenderInterface.NativeFieldInfoPtr_sendableBubbles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "sendableBubbles");
			MessageSenderInterface.NativeFieldInfoPtr_sendableMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "sendableMap");
			MessageSenderInterface.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100682289);
			MessageSenderInterface.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100682290);
			MessageSenderInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100682291);
			MessageSenderInterface.NativeMethodInfoPtr_SetVisibility_Public_Void_EVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100682292);
			MessageSenderInterface.NativeMethodInfoPtr_UpdateSendables_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100682293);
			MessageSenderInterface.NativeMethodInfoPtr_AddSendable_Public_Void_SendableMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100682294);
			MessageSenderInterface.NativeMethodInfoPtr_SendableSelected_Protected_Virtual_New_Void_SendableMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100682295);
			MessageSenderInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100682296);
			MessageSenderInterface.NativeMethodInfoPtr__Awake_b__12_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100682297);
			MessageSenderInterface.NativeMethodInfoPtr__Awake_b__12_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, 100682298);
		}

		// Token: 0x06009A5E RID: 39518 RVA: 0x00273FE4 File Offset: 0x002721E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274420, XrefRangeEnd = 274435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A5F RID: 39519 RVA: 0x00274018 File Offset: 0x00272218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274435, XrefRangeEnd = 274445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A60 RID: 39520 RVA: 0x0027404C File Offset: 0x0027224C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274445, XrefRangeEnd = 274446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A61 RID: 39521 RVA: 0x00274090 File Offset: 0x00272290
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 274464, RefRangeEnd = 274470, XrefRangeStart = 274446, XrefRangeEnd = 274464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisibility(MessageSenderInterface.EVisibility visibility)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visibility;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr_SetVisibility_Public_Void_EVisibility_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A62 RID: 39522 RVA: 0x002740D0 File Offset: 0x002722D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 274492, RefRangeEnd = 274494, XrefRangeStart = 274470, XrefRangeEnd = 274492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSendables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr_UpdateSendables_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A63 RID: 39523 RVA: 0x00274104 File Offset: 0x00272304
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 274532, RefRangeEnd = 274534, XrefRangeStart = 274494, XrefRangeEnd = 274532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSendable(SendableMessage sendable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sendable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr_AddSendable_Public_Void_SendableMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A64 RID: 39524 RVA: 0x00274148 File Offset: 0x00272348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274534, XrefRangeEnd = 274536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SendableSelected(SendableMessage sendable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sendable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MessageSenderInterface.NativeMethodInfoPtr_SendableSelected_Protected_Virtual_New_Void_SendableMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A65 RID: 39525 RVA: 0x00274198 File Offset: 0x00272398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274536, XrefRangeEnd = 274551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MessageSenderInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A66 RID: 39526 RVA: 0x002741D4 File Offset: 0x002723D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274551, XrefRangeEnd = 274552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__12_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr__Awake_b__12_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A67 RID: 39527 RVA: 0x00274208 File Offset: 0x00272408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274552, XrefRangeEnd = 274553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Awake_b__12_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.NativeMethodInfoPtr__Awake_b__12_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009A68 RID: 39528 RVA: 0x0004B735 File Offset: 0x00049935
		public MessageSenderInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F81 RID: 12161
		// (get) Token: 0x06009A69 RID: 39529 RVA: 0x0027423C File Offset: 0x0027243C
		// (set) Token: 0x06009A6A RID: 39530 RVA: 0x0004B73E File Offset: 0x0004993E
		public unsafe MessageSenderInterface.EVisibility Visibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_Visibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_Visibility)) = value;
			}
		}

		// Token: 0x17002F82 RID: 12162
		// (get) Token: 0x06009A6B RID: 39531 RVA: 0x00274264 File Offset: 0x00272464
		// (set) Token: 0x06009A6C RID: 39532 RVA: 0x0004B759 File Offset: 0x00049959
		public unsafe float DockedMenuYPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_DockedMenuYPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_DockedMenuYPos)) = value;
			}
		}

		// Token: 0x17002F83 RID: 12163
		// (get) Token: 0x06009A6D RID: 39533 RVA: 0x0027428C File Offset: 0x0027248C
		// (set) Token: 0x06009A6E RID: 39534 RVA: 0x0004B774 File Offset: 0x00049974
		public unsafe float ExpandedMenuYPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_ExpandedMenuYPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_ExpandedMenuYPos)) = value;
			}
		}

		// Token: 0x17002F84 RID: 12164
		// (get) Token: 0x06009A6F RID: 39535 RVA: 0x002742B4 File Offset: 0x002724B4
		// (set) Token: 0x06009A70 RID: 39536 RVA: 0x0004B78F File Offset: 0x0004998F
		public unsafe RectTransform Menu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_Menu);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_Menu), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F85 RID: 12165
		// (get) Token: 0x06009A71 RID: 39537 RVA: 0x002742E4 File Offset: 0x002724E4
		// (set) Token: 0x06009A72 RID: 39538 RVA: 0x0004B7AE File Offset: 0x000499AE
		public unsafe RectTransform SendablesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_SendablesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_SendablesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F86 RID: 12166
		// (get) Token: 0x06009A73 RID: 39539 RVA: 0x00274314 File Offset: 0x00272514
		// (set) Token: 0x06009A74 RID: 39540 RVA: 0x0004B7CD File Offset: 0x000499CD
		public unsafe Il2CppReferenceArray<RectTransform> DockedUIElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_DockedUIElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_DockedUIElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F87 RID: 12167
		// (get) Token: 0x06009A75 RID: 39541 RVA: 0x00274344 File Offset: 0x00272544
		// (set) Token: 0x06009A76 RID: 39542 RVA: 0x0004B7EC File Offset: 0x000499EC
		public unsafe Il2CppReferenceArray<RectTransform> ExpandedUIElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_ExpandedUIElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_ExpandedUIElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F88 RID: 12168
		// (get) Token: 0x06009A77 RID: 39543 RVA: 0x00274374 File Offset: 0x00272574
		// (set) Token: 0x06009A78 RID: 39544 RVA: 0x0004B80B File Offset: 0x00049A0B
		public unsafe Button ComposeButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_ComposeButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_ComposeButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F89 RID: 12169
		// (get) Token: 0x06009A79 RID: 39545 RVA: 0x002743A4 File Offset: 0x002725A4
		// (set) Token: 0x06009A7A RID: 39546 RVA: 0x0004B82A File Offset: 0x00049A2A
		public unsafe Il2CppReferenceArray<Button> CancelButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_CancelButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Button>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_CancelButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F8A RID: 12170
		// (get) Token: 0x06009A7B RID: 39547 RVA: 0x002743D4 File Offset: 0x002725D4
		// (set) Token: 0x06009A7C RID: 39548 RVA: 0x0004B849 File Offset: 0x00049A49
		public unsafe List<MessageBubble> sendableBubbles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_sendableBubbles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MessageBubble>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_sendableBubbles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F8B RID: 12171
		// (get) Token: 0x06009A7D RID: 39549 RVA: 0x00274404 File Offset: 0x00272604
		// (set) Token: 0x06009A7E RID: 39550 RVA: 0x0004B868 File Offset: 0x00049A68
		public unsafe Dictionary<MessageBubble, SendableMessage> sendableMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_sendableMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<MessageBubble, SendableMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.NativeFieldInfoPtr_sendableMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040067D8 RID: 26584
		private static readonly IntPtr NativeFieldInfoPtr_Visibility;

		// Token: 0x040067D9 RID: 26585
		private static readonly IntPtr NativeFieldInfoPtr_DockedMenuYPos;

		// Token: 0x040067DA RID: 26586
		private static readonly IntPtr NativeFieldInfoPtr_ExpandedMenuYPos;

		// Token: 0x040067DB RID: 26587
		private static readonly IntPtr NativeFieldInfoPtr_Menu;

		// Token: 0x040067DC RID: 26588
		private static readonly IntPtr NativeFieldInfoPtr_SendablesContainer;

		// Token: 0x040067DD RID: 26589
		private static readonly IntPtr NativeFieldInfoPtr_DockedUIElements;

		// Token: 0x040067DE RID: 26590
		private static readonly IntPtr NativeFieldInfoPtr_ExpandedUIElements;

		// Token: 0x040067DF RID: 26591
		private static readonly IntPtr NativeFieldInfoPtr_ComposeButton;

		// Token: 0x040067E0 RID: 26592
		private static readonly IntPtr NativeFieldInfoPtr_CancelButtons;

		// Token: 0x040067E1 RID: 26593
		private static readonly IntPtr NativeFieldInfoPtr_sendableBubbles;

		// Token: 0x040067E2 RID: 26594
		private static readonly IntPtr NativeFieldInfoPtr_sendableMap;

		// Token: 0x040067E3 RID: 26595
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x040067E4 RID: 26596
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040067E5 RID: 26597
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x040067E6 RID: 26598
		private static readonly IntPtr NativeMethodInfoPtr_SetVisibility_Public_Void_EVisibility_0;

		// Token: 0x040067E7 RID: 26599
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSendables_Public_Void_0;

		// Token: 0x040067E8 RID: 26600
		private static readonly IntPtr NativeMethodInfoPtr_AddSendable_Public_Void_SendableMessage_0;

		// Token: 0x040067E9 RID: 26601
		private static readonly IntPtr NativeMethodInfoPtr_SendableSelected_Protected_Virtual_New_Void_SendableMessage_0;

		// Token: 0x040067EA RID: 26602
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040067EB RID: 26603
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__12_0_Private_Void_0;

		// Token: 0x040067EC RID: 26604
		private static readonly IntPtr NativeMethodInfoPtr__Awake_b__12_1_Private_Void_0;

		// Token: 0x02000B7F RID: 2943
		[OriginalName("Assembly-CSharp.dll", "", "EVisibility")]
		public enum EVisibility
		{
			// Token: 0x04009329 RID: 37673
			Hidden,
			// Token: 0x0400932A RID: 37674
			Docked,
			// Token: 0x0400932B RID: 37675
			Expanded
		}

		// Token: 0x02000B80 RID: 2944
		[ObfuscatedName("ScheduleOne.UI.Phone.Messages.MessageSenderInterface+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB67 RID: 56167 RVA: 0x0033EFE4 File Offset: 0x0033D1E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<MessageSenderInterface.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MessageSenderInterface>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageSenderInterface.__c__DisplayClass17_0>.NativeClassPtr);
				MessageSenderInterface.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				MessageSenderInterface.__c__DisplayClass17_0.NativeFieldInfoPtr_sendable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageSenderInterface.__c__DisplayClass17_0>.NativeClassPtr, "sendable");
				MessageSenderInterface.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface.__c__DisplayClass17_0>.NativeClassPtr, 100682299);
				MessageSenderInterface.__c__DisplayClass17_0.NativeMethodInfoPtr__AddSendable_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageSenderInterface.__c__DisplayClass17_0>.NativeClassPtr, 100682300);
			}

			// Token: 0x0600DB68 RID: 56168 RVA: 0x0033F060 File Offset: 0x0033D260
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageSenderInterface.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB69 RID: 56169 RVA: 0x0033F09C File Offset: 0x0033D29C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 274419, XrefRangeEnd = 274420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AddSendable_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MessageSenderInterface.__c__DisplayClass17_0.NativeMethodInfoPtr__AddSendable_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DB6A RID: 56170 RVA: 0x0006ADC9 File Offset: 0x00068FC9
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700440B RID: 17419
			// (get) Token: 0x0600DB6B RID: 56171 RVA: 0x0033F0D0 File Offset: 0x0033D2D0
			// (set) Token: 0x0600DB6C RID: 56172 RVA: 0x0006ADD2 File Offset: 0x00068FD2
			public unsafe MessageSenderInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageSenderInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700440C RID: 17420
			// (get) Token: 0x0600DB6D RID: 56173 RVA: 0x0033F100 File Offset: 0x0033D300
			// (set) Token: 0x0600DB6E RID: 56174 RVA: 0x0006ADF1 File Offset: 0x00068FF1
			public unsafe SendableMessage sendable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.__c__DisplayClass17_0.NativeFieldInfoPtr_sendable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendableMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MessageSenderInterface.__c__DisplayClass17_0.NativeFieldInfoPtr_sendable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400932C RID: 37676
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400932D RID: 37677
			private static readonly IntPtr NativeFieldInfoPtr_sendable;

			// Token: 0x0400932E RID: 37678
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400932F RID: 37679
			private static readonly IntPtr NativeMethodInfoPtr__AddSendable_b__0_Internal_Void_0;
		}
	}
}
