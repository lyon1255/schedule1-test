using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Input
{
	// Token: 0x020006EF RID: 1775
	public class InputPromptsManager : Singleton<InputPromptsManager>
	{
		// Token: 0x06009ED7 RID: 40663 RVA: 0x00281998 File Offset: 0x0027FB98
		// Note: this type is marked as 'beforefieldinit'.
		static InputPromptsManager()
		{
			Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Input", "InputPromptsManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr);
			InputPromptsManager.NativeFieldInfoPtr_KeyPromptPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "KeyPromptPrefab");
			InputPromptsManager.NativeFieldInfoPtr_WideKeyPromptPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "WideKeyPromptPrefab");
			InputPromptsManager.NativeFieldInfoPtr_ExtraWideKeyPromptPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "ExtraWideKeyPromptPrefab");
			InputPromptsManager.NativeFieldInfoPtr_LeftClickPromptPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "LeftClickPromptPrefab");
			InputPromptsManager.NativeFieldInfoPtr_MiddleClickPromptPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "MiddleClickPromptPrefab");
			InputPromptsManager.NativeFieldInfoPtr_RightClickPromptPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, "RightClickPromptPrefab");
			InputPromptsManager.NativeMethodInfoPtr_GetPromptImage_Public_PromptImage_String_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100682778);
			InputPromptsManager.NativeMethodInfoPtr_IsControlPathMouseRelated_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100682779);
			InputPromptsManager.NativeMethodInfoPtr_IsControlPathWideKey_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100682780);
			InputPromptsManager.NativeMethodInfoPtr_IsControlPathExtraWideKey_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100682781);
			InputPromptsManager.NativeMethodInfoPtr_GetDisplayNameForControlPath_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100682782);
			InputPromptsManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr, 100682783);
		}

		// Token: 0x06009ED8 RID: 40664 RVA: 0x00281AB8 File Offset: 0x0027FCB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280622, RefRangeEnd = 280623, XrefRangeStart = 280585, XrefRangeEnd = 280622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PromptImage GetPromptImage(string controlPath, RectTransform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(controlPath);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_GetPromptImage_Public_PromptImage_String_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PromptImage>(intPtr3) : null;
		}

		// Token: 0x06009ED9 RID: 40665 RVA: 0x00281B1C File Offset: 0x0027FD1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280623, XrefRangeEnd = 280632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsControlPathMouseRelated(string controlPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(controlPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_IsControlPathMouseRelated_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009EDA RID: 40666 RVA: 0x00281B6C File Offset: 0x0027FD6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280671, RefRangeEnd = 280672, XrefRangeStart = 280632, XrefRangeEnd = 280671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsControlPathWideKey(string controlPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(controlPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_IsControlPathWideKey_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009EDB RID: 40667 RVA: 0x00281BBC File Offset: 0x0027FDBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280672, XrefRangeEnd = 280675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsControlPathExtraWideKey(string controlPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(controlPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_IsControlPathExtraWideKey_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06009EDC RID: 40668 RVA: 0x00281C0C File Offset: 0x0027FE0C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 280825, RefRangeEnd = 280830, XrefRangeStart = 280675, XrefRangeEnd = 280825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetDisplayNameForControlPath(string controlPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(controlPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr_GetDisplayNameForControlPath_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06009EDD RID: 40669 RVA: 0x00281C54 File Offset: 0x0027FE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280830, XrefRangeEnd = 280833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputPromptsManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPromptsManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EDE RID: 40670 RVA: 0x0004DEC3 File Offset: 0x0004C0C3
		public InputPromptsManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030E3 RID: 12515
		// (get) Token: 0x06009EDF RID: 40671 RVA: 0x00281C90 File Offset: 0x0027FE90
		// (set) Token: 0x06009EE0 RID: 40672 RVA: 0x0004DECC File Offset: 0x0004C0CC
		public unsafe GameObject KeyPromptPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_KeyPromptPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_KeyPromptPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030E4 RID: 12516
		// (get) Token: 0x06009EE1 RID: 40673 RVA: 0x00281CC0 File Offset: 0x0027FEC0
		// (set) Token: 0x06009EE2 RID: 40674 RVA: 0x0004DEEB File Offset: 0x0004C0EB
		public unsafe GameObject WideKeyPromptPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_WideKeyPromptPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_WideKeyPromptPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030E5 RID: 12517
		// (get) Token: 0x06009EE3 RID: 40675 RVA: 0x00281CF0 File Offset: 0x0027FEF0
		// (set) Token: 0x06009EE4 RID: 40676 RVA: 0x0004DF0A File Offset: 0x0004C10A
		public unsafe GameObject ExtraWideKeyPromptPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_ExtraWideKeyPromptPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_ExtraWideKeyPromptPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030E6 RID: 12518
		// (get) Token: 0x06009EE5 RID: 40677 RVA: 0x00281D20 File Offset: 0x0027FF20
		// (set) Token: 0x06009EE6 RID: 40678 RVA: 0x0004DF29 File Offset: 0x0004C129
		public unsafe GameObject LeftClickPromptPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_LeftClickPromptPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_LeftClickPromptPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030E7 RID: 12519
		// (get) Token: 0x06009EE7 RID: 40679 RVA: 0x00281D50 File Offset: 0x0027FF50
		// (set) Token: 0x06009EE8 RID: 40680 RVA: 0x0004DF48 File Offset: 0x0004C148
		public unsafe GameObject MiddleClickPromptPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_MiddleClickPromptPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_MiddleClickPromptPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030E8 RID: 12520
		// (get) Token: 0x06009EE9 RID: 40681 RVA: 0x00281D80 File Offset: 0x0027FF80
		// (set) Token: 0x06009EEA RID: 40682 RVA: 0x0004DF67 File Offset: 0x0004C167
		public unsafe GameObject RightClickPromptPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_RightClickPromptPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsManager.NativeFieldInfoPtr_RightClickPromptPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006A96 RID: 27286
		private static readonly IntPtr NativeFieldInfoPtr_KeyPromptPrefab;

		// Token: 0x04006A97 RID: 27287
		private static readonly IntPtr NativeFieldInfoPtr_WideKeyPromptPrefab;

		// Token: 0x04006A98 RID: 27288
		private static readonly IntPtr NativeFieldInfoPtr_ExtraWideKeyPromptPrefab;

		// Token: 0x04006A99 RID: 27289
		private static readonly IntPtr NativeFieldInfoPtr_LeftClickPromptPrefab;

		// Token: 0x04006A9A RID: 27290
		private static readonly IntPtr NativeFieldInfoPtr_MiddleClickPromptPrefab;

		// Token: 0x04006A9B RID: 27291
		private static readonly IntPtr NativeFieldInfoPtr_RightClickPromptPrefab;

		// Token: 0x04006A9C RID: 27292
		private static readonly IntPtr NativeMethodInfoPtr_GetPromptImage_Public_PromptImage_String_RectTransform_0;

		// Token: 0x04006A9D RID: 27293
		private static readonly IntPtr NativeMethodInfoPtr_IsControlPathMouseRelated_Private_Boolean_String_0;

		// Token: 0x04006A9E RID: 27294
		private static readonly IntPtr NativeMethodInfoPtr_IsControlPathWideKey_Private_Boolean_String_0;

		// Token: 0x04006A9F RID: 27295
		private static readonly IntPtr NativeMethodInfoPtr_IsControlPathExtraWideKey_Private_Boolean_String_0;

		// Token: 0x04006AA0 RID: 27296
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayNameForControlPath_Public_String_String_0;

		// Token: 0x04006AA1 RID: 27297
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
