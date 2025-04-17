using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Il2CppScheduleOne.UI.Input
{
	// Token: 0x020006EE RID: 1774
	public class InputPrompt : MonoBehaviour
	{
		// Token: 0x06009EB3 RID: 40627 RVA: 0x002813CC File Offset: 0x0027F5CC
		// Note: this type is marked as 'beforefieldinit'.
		static InputPrompt()
		{
			Il2CppClassPointerStore<InputPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Input", "InputPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr);
			InputPrompt.NativeFieldInfoPtr_Spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "Spacing");
			InputPrompt.NativeFieldInfoPtr_Actions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "Actions");
			InputPrompt.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "Label");
			InputPrompt.NativeFieldInfoPtr_Alignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "Alignment");
			InputPrompt.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "Container");
			InputPrompt.NativeFieldInfoPtr_ImagesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "ImagesContainer");
			InputPrompt.NativeFieldInfoPtr_LabelComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "LabelComponent");
			InputPrompt.NativeFieldInfoPtr_Shade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "Shade");
			InputPrompt.NativeFieldInfoPtr_OverridePromptImageColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "OverridePromptImageColor");
			InputPrompt.NativeFieldInfoPtr_PromptImageColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "PromptImageColor");
			InputPrompt.NativeFieldInfoPtr_promptImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "promptImages");
			InputPrompt.NativeFieldInfoPtr_displayedActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "displayedActions");
			InputPrompt.NativeFieldInfoPtr_AppliedAlignment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, "AppliedAlignment");
			InputPrompt.NativeMethodInfoPtr_get_manager_Private_get_InputPromptsManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100682769);
			InputPrompt.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100682770);
			InputPrompt.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100682771);
			InputPrompt.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100682772);
			InputPrompt.NativeMethodInfoPtr_RefreshPromptImages_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100682773);
			InputPrompt.NativeMethodInfoPtr_SetLabel_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100682774);
			InputPrompt.NativeMethodInfoPtr_UpdateShade_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100682775);
			InputPrompt.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr, 100682776);
		}

		// Token: 0x170030E2 RID: 12514
		// (get) Token: 0x06009EB4 RID: 40628 RVA: 0x002815A0 File Offset: 0x0027F7A0
		public unsafe InputPromptsManager manager
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280434, XrefRangeEnd = 280443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr_get_manager_Private_get_InputPromptsManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InputPromptsManager>(intPtr3) : null;
			}
		}

		// Token: 0x06009EB5 RID: 40629 RVA: 0x002815E0 File Offset: 0x0027F7E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280443, XrefRangeEnd = 280447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EB6 RID: 40630 RVA: 0x00281614 File Offset: 0x0027F814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280447, XrefRangeEnd = 280450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EB7 RID: 40631 RVA: 0x00281648 File Offset: 0x0027F848
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EB8 RID: 40632 RVA: 0x0028167C File Offset: 0x0027F87C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 280548, RefRangeEnd = 280549, XrefRangeStart = 280450, XrefRangeEnd = 280548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPromptImages()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr_RefreshPromptImages_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EB9 RID: 40633 RVA: 0x002816B0 File Offset: 0x0027F8B0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 280552, RefRangeEnd = 280559, XrefRangeStart = 280549, XrefRangeEnd = 280552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLabel(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr_SetLabel_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EBA RID: 40634 RVA: 0x002816F4 File Offset: 0x0027F8F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 280562, RefRangeEnd = 280565, XrefRangeStart = 280559, XrefRangeEnd = 280562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateShade()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr_UpdateShade_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EBB RID: 40635 RVA: 0x00281728 File Offset: 0x0027F928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 280565, XrefRangeEnd = 280585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputPrompt() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPrompt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPrompt.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009EBC RID: 40636 RVA: 0x0004DD48 File Offset: 0x0004BF48
		public InputPrompt(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170030D5 RID: 12501
		// (get) Token: 0x06009EBD RID: 40637 RVA: 0x00281764 File Offset: 0x0027F964
		// (set) Token: 0x06009EBE RID: 40638 RVA: 0x0004DD51 File Offset: 0x0004BF51
		public unsafe static float Spacing
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(InputPrompt.NativeFieldInfoPtr_Spacing, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InputPrompt.NativeFieldInfoPtr_Spacing, (void*)(&value));
			}
		}

		// Token: 0x170030D6 RID: 12502
		// (get) Token: 0x06009EBF RID: 40639 RVA: 0x00281780 File Offset: 0x0027F980
		// (set) Token: 0x06009EC0 RID: 40640 RVA: 0x0004DD5F File Offset: 0x0004BF5F
		public unsafe List<InputActionReference> Actions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Actions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputActionReference>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Actions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030D7 RID: 12503
		// (get) Token: 0x06009EC1 RID: 40641 RVA: 0x002817B0 File Offset: 0x0027F9B0
		// (set) Token: 0x06009EC2 RID: 40642 RVA: 0x0004DD7E File Offset: 0x0004BF7E
		public unsafe string Label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170030D8 RID: 12504
		// (get) Token: 0x06009EC3 RID: 40643 RVA: 0x002817D8 File Offset: 0x0027F9D8
		// (set) Token: 0x06009EC4 RID: 40644 RVA: 0x0004DD9D File Offset: 0x0004BF9D
		public unsafe InputPrompt.EInputPromptAlignment Alignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Alignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Alignment)) = value;
			}
		}

		// Token: 0x170030D9 RID: 12505
		// (get) Token: 0x06009EC5 RID: 40645 RVA: 0x00281800 File Offset: 0x0027FA00
		// (set) Token: 0x06009EC6 RID: 40646 RVA: 0x0004DDB8 File Offset: 0x0004BFB8
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030DA RID: 12506
		// (get) Token: 0x06009EC7 RID: 40647 RVA: 0x00281830 File Offset: 0x0027FA30
		// (set) Token: 0x06009EC8 RID: 40648 RVA: 0x0004DDD7 File Offset: 0x0004BFD7
		public unsafe RectTransform ImagesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_ImagesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_ImagesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030DB RID: 12507
		// (get) Token: 0x06009EC9 RID: 40649 RVA: 0x00281860 File Offset: 0x0027FA60
		// (set) Token: 0x06009ECA RID: 40650 RVA: 0x0004DDF6 File Offset: 0x0004BFF6
		public unsafe TextMeshProUGUI LabelComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_LabelComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_LabelComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030DC RID: 12508
		// (get) Token: 0x06009ECB RID: 40651 RVA: 0x00281890 File Offset: 0x0027FA90
		// (set) Token: 0x06009ECC RID: 40652 RVA: 0x0004DE15 File Offset: 0x0004C015
		public unsafe RectTransform Shade
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Shade);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_Shade), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030DD RID: 12509
		// (get) Token: 0x06009ECD RID: 40653 RVA: 0x002818C0 File Offset: 0x0027FAC0
		// (set) Token: 0x06009ECE RID: 40654 RVA: 0x0004DE34 File Offset: 0x0004C034
		public unsafe bool OverridePromptImageColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_OverridePromptImageColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_OverridePromptImageColor)) = value;
			}
		}

		// Token: 0x170030DE RID: 12510
		// (get) Token: 0x06009ECF RID: 40655 RVA: 0x002818E8 File Offset: 0x0027FAE8
		// (set) Token: 0x06009ED0 RID: 40656 RVA: 0x0004DE4F File Offset: 0x0004C04F
		public unsafe Color PromptImageColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_PromptImageColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_PromptImageColor)) = value;
			}
		}

		// Token: 0x170030DF RID: 12511
		// (get) Token: 0x06009ED1 RID: 40657 RVA: 0x00281910 File Offset: 0x0027FB10
		// (set) Token: 0x06009ED2 RID: 40658 RVA: 0x0004DE6A File Offset: 0x0004C06A
		public unsafe List<PromptImage> promptImages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_promptImages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PromptImage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_promptImages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030E0 RID: 12512
		// (get) Token: 0x06009ED3 RID: 40659 RVA: 0x00281940 File Offset: 0x0027FB40
		// (set) Token: 0x06009ED4 RID: 40660 RVA: 0x0004DE89 File Offset: 0x0004C089
		public unsafe List<InputActionReference> displayedActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_displayedActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputActionReference>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_displayedActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170030E1 RID: 12513
		// (get) Token: 0x06009ED5 RID: 40661 RVA: 0x00281970 File Offset: 0x0027FB70
		// (set) Token: 0x06009ED6 RID: 40662 RVA: 0x0004DEA8 File Offset: 0x0004C0A8
		public unsafe InputPrompt.EInputPromptAlignment AppliedAlignment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_AppliedAlignment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPrompt.NativeFieldInfoPtr_AppliedAlignment)) = value;
			}
		}

		// Token: 0x04006A81 RID: 27265
		private static readonly IntPtr NativeFieldInfoPtr_Spacing;

		// Token: 0x04006A82 RID: 27266
		private static readonly IntPtr NativeFieldInfoPtr_Actions;

		// Token: 0x04006A83 RID: 27267
		private static readonly IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04006A84 RID: 27268
		private static readonly IntPtr NativeFieldInfoPtr_Alignment;

		// Token: 0x04006A85 RID: 27269
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006A86 RID: 27270
		private static readonly IntPtr NativeFieldInfoPtr_ImagesContainer;

		// Token: 0x04006A87 RID: 27271
		private static readonly IntPtr NativeFieldInfoPtr_LabelComponent;

		// Token: 0x04006A88 RID: 27272
		private static readonly IntPtr NativeFieldInfoPtr_Shade;

		// Token: 0x04006A89 RID: 27273
		private static readonly IntPtr NativeFieldInfoPtr_OverridePromptImageColor;

		// Token: 0x04006A8A RID: 27274
		private static readonly IntPtr NativeFieldInfoPtr_PromptImageColor;

		// Token: 0x04006A8B RID: 27275
		private static readonly IntPtr NativeFieldInfoPtr_promptImages;

		// Token: 0x04006A8C RID: 27276
		private static readonly IntPtr NativeFieldInfoPtr_displayedActions;

		// Token: 0x04006A8D RID: 27277
		private static readonly IntPtr NativeFieldInfoPtr_AppliedAlignment;

		// Token: 0x04006A8E RID: 27278
		private static readonly IntPtr NativeMethodInfoPtr_get_manager_Private_get_InputPromptsManager_0;

		// Token: 0x04006A8F RID: 27279
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04006A90 RID: 27280
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04006A91 RID: 27281
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006A92 RID: 27282
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPromptImages_Private_Void_0;

		// Token: 0x04006A93 RID: 27283
		private static readonly IntPtr NativeMethodInfoPtr_SetLabel_Public_Void_String_0;

		// Token: 0x04006A94 RID: 27284
		private static readonly IntPtr NativeMethodInfoPtr_UpdateShade_Private_Void_0;

		// Token: 0x04006A95 RID: 27285
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B9F RID: 2975
		[OriginalName("Assembly-CSharp.dll", "", "EInputPromptAlignment")]
		public enum EInputPromptAlignment
		{
			// Token: 0x040093BC RID: 37820
			Left,
			// Token: 0x040093BD RID: 37821
			Middle,
			// Token: 0x040093BE RID: 37822
			Right
		}
	}
}
