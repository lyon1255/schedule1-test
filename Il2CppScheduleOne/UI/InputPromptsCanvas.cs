using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000641 RID: 1601
	public class InputPromptsCanvas : Singleton<InputPromptsCanvas>
	{
		// Token: 0x06008DE0 RID: 36320 RVA: 0x0024ECC0 File Offset: 0x0024CEC0
		// Note: this type is marked as 'beforefieldinit'.
		static InputPromptsCanvas()
		{
			Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "InputPromptsCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr);
			InputPromptsCanvas.NativeFieldInfoPtr_InputPromptsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, "InputPromptsContainer");
			InputPromptsCanvas.NativeFieldInfoPtr_Modules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, "Modules");
			InputPromptsCanvas.NativeFieldInfoPtr__currentModuleLabel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, "<currentModuleLabel>k__BackingField");
			InputPromptsCanvas.NativeFieldInfoPtr__currentModule_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, "<currentModule>k__BackingField");
			InputPromptsCanvas.NativeMethodInfoPtr_get_currentModuleLabel_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, 100680915);
			InputPromptsCanvas.NativeMethodInfoPtr_set_currentModuleLabel_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, 100680916);
			InputPromptsCanvas.NativeMethodInfoPtr_get_currentModule_Public_get_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, 100680917);
			InputPromptsCanvas.NativeMethodInfoPtr_set_currentModule_Private_set_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, 100680918);
			InputPromptsCanvas.NativeMethodInfoPtr_LoadModule_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, 100680919);
			InputPromptsCanvas.NativeMethodInfoPtr_UnloadModule_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, 100680920);
			InputPromptsCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, 100680921);
		}

		// Token: 0x17002B59 RID: 11097
		// (get) Token: 0x06008DE1 RID: 36321 RVA: 0x0024EDCC File Offset: 0x0024CFCC
		// (set) Token: 0x06008DE2 RID: 36322 RVA: 0x0024EE04 File Offset: 0x0024D004
		public unsafe string currentModuleLabel
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 19662, RefRangeEnd = 19669, XrefRangeStart = 19662, XrefRangeEnd = 19669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsCanvas.NativeMethodInfoPtr_get_currentModuleLabel_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsCanvas.NativeMethodInfoPtr_set_currentModuleLabel_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002B5A RID: 11098
		// (get) Token: 0x06008DE3 RID: 36323 RVA: 0x0024EE48 File Offset: 0x0024D048
		// (set) Token: 0x06008DE4 RID: 36324 RVA: 0x0024EE88 File Offset: 0x0024D088
		public unsafe RectTransform currentModule
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35354, RefRangeEnd = 35355, XrefRangeStart = 35354, XrefRangeEnd = 35355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsCanvas.NativeMethodInfoPtr_get_currentModule_Public_get_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsCanvas.NativeMethodInfoPtr_set_currentModule_Private_set_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008DE5 RID: 36325 RVA: 0x0024EECC File Offset: 0x0024D0CC
		[CallerCount(43)]
		[CachedScanResults(RefRangeStart = 258175, RefRangeEnd = 258218, XrefRangeStart = 258140, XrefRangeEnd = 258175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadModule(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsCanvas.NativeMethodInfoPtr_LoadModule_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DE6 RID: 36326 RVA: 0x0024EF10 File Offset: 0x0024D110
		[CallerCount(41)]
		[CachedScanResults(RefRangeStart = 258229, RefRangeEnd = 258270, XrefRangeStart = 258218, XrefRangeEnd = 258229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnloadModule()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsCanvas.NativeMethodInfoPtr_UnloadModule_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DE7 RID: 36327 RVA: 0x0024EF44 File Offset: 0x0024D144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258270, XrefRangeEnd = 258283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputPromptsCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008DE8 RID: 36328 RVA: 0x00044324 File Offset: 0x00042524
		public InputPromptsCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B55 RID: 11093
		// (get) Token: 0x06008DE9 RID: 36329 RVA: 0x0024EF80 File Offset: 0x0024D180
		// (set) Token: 0x06008DEA RID: 36330 RVA: 0x0004432D File Offset: 0x0004252D
		public unsafe RectTransform InputPromptsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.NativeFieldInfoPtr_InputPromptsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.NativeFieldInfoPtr_InputPromptsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B56 RID: 11094
		// (get) Token: 0x06008DEB RID: 36331 RVA: 0x0024EFB0 File Offset: 0x0024D1B0
		// (set) Token: 0x06008DEC RID: 36332 RVA: 0x0004434C File Offset: 0x0004254C
		public unsafe List<InputPromptsCanvas.Module> Modules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.NativeFieldInfoPtr_Modules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<InputPromptsCanvas.Module>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.NativeFieldInfoPtr_Modules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B57 RID: 11095
		// (get) Token: 0x06008DED RID: 36333 RVA: 0x0024EFE0 File Offset: 0x0024D1E0
		// (set) Token: 0x06008DEE RID: 36334 RVA: 0x0004436B File Offset: 0x0004256B
		public unsafe string _currentModuleLabel_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.NativeFieldInfoPtr__currentModuleLabel_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.NativeFieldInfoPtr__currentModuleLabel_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002B58 RID: 11096
		// (get) Token: 0x06008DEF RID: 36335 RVA: 0x0024F008 File Offset: 0x0024D208
		// (set) Token: 0x06008DF0 RID: 36336 RVA: 0x0004438A File Offset: 0x0004258A
		public unsafe RectTransform _currentModule_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.NativeFieldInfoPtr__currentModule_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.NativeFieldInfoPtr__currentModule_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006013 RID: 24595
		private static readonly IntPtr NativeFieldInfoPtr_InputPromptsContainer;

		// Token: 0x04006014 RID: 24596
		private static readonly IntPtr NativeFieldInfoPtr_Modules;

		// Token: 0x04006015 RID: 24597
		private static readonly IntPtr NativeFieldInfoPtr__currentModuleLabel_k__BackingField;

		// Token: 0x04006016 RID: 24598
		private static readonly IntPtr NativeFieldInfoPtr__currentModule_k__BackingField;

		// Token: 0x04006017 RID: 24599
		private static readonly IntPtr NativeMethodInfoPtr_get_currentModuleLabel_Public_get_String_0;

		// Token: 0x04006018 RID: 24600
		private static readonly IntPtr NativeMethodInfoPtr_set_currentModuleLabel_Protected_set_Void_String_0;

		// Token: 0x04006019 RID: 24601
		private static readonly IntPtr NativeMethodInfoPtr_get_currentModule_Public_get_RectTransform_0;

		// Token: 0x0400601A RID: 24602
		private static readonly IntPtr NativeMethodInfoPtr_set_currentModule_Private_set_Void_RectTransform_0;

		// Token: 0x0400601B RID: 24603
		private static readonly IntPtr NativeMethodInfoPtr_LoadModule_Public_Void_String_0;

		// Token: 0x0400601C RID: 24604
		private static readonly IntPtr NativeMethodInfoPtr_UnloadModule_Public_Void_0;

		// Token: 0x0400601D RID: 24605
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B29 RID: 2857
		[Serializable]
		public class Module : Il2CppSystem.Object
		{
			// Token: 0x0600D7C1 RID: 55233 RVA: 0x003346FC File Offset: 0x003328FC
			// Note: this type is marked as 'beforefieldinit'.
			static Module()
			{
				Il2CppClassPointerStore<InputPromptsCanvas.Module>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, "Module");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPromptsCanvas.Module>.NativeClassPtr);
				InputPromptsCanvas.Module.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsCanvas.Module>.NativeClassPtr, "key");
				InputPromptsCanvas.Module.NativeFieldInfoPtr_module = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsCanvas.Module>.NativeClassPtr, "module");
				InputPromptsCanvas.Module.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsCanvas.Module>.NativeClassPtr, 100680922);
			}

			// Token: 0x0600D7C2 RID: 55234 RVA: 0x00334764 File Offset: 0x00332964
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Module() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPromptsCanvas.Module>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsCanvas.Module.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7C3 RID: 55235 RVA: 0x000690ED File Offset: 0x000672ED
			public Module(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042E1 RID: 17121
			// (get) Token: 0x0600D7C4 RID: 55236 RVA: 0x003347A0 File Offset: 0x003329A0
			// (set) Token: 0x0600D7C5 RID: 55237 RVA: 0x000690F6 File Offset: 0x000672F6
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.Module.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.Module.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170042E2 RID: 17122
			// (get) Token: 0x0600D7C6 RID: 55238 RVA: 0x003347C8 File Offset: 0x003329C8
			// (set) Token: 0x0600D7C7 RID: 55239 RVA: 0x00069115 File Offset: 0x00067315
			public unsafe GameObject module
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.Module.NativeFieldInfoPtr_module);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.Module.NativeFieldInfoPtr_module), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009101 RID: 37121
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04009102 RID: 37122
			private static readonly IntPtr NativeFieldInfoPtr_module;

			// Token: 0x04009103 RID: 37123
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000B2A RID: 2858
		[ObfuscatedName("ScheduleOne.UI.InputPromptsCanvas+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D7C8 RID: 55240 RVA: 0x003347F8 File Offset: 0x003329F8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<InputPromptsCanvas.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InputPromptsCanvas>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPromptsCanvas.__c__DisplayClass11_0>.NativeClassPtr);
				InputPromptsCanvas.__c__DisplayClass11_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPromptsCanvas.__c__DisplayClass11_0>.NativeClassPtr, "key");
				InputPromptsCanvas.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsCanvas.__c__DisplayClass11_0>.NativeClassPtr, 100680923);
				InputPromptsCanvas.__c__DisplayClass11_0.NativeMethodInfoPtr__LoadModule_b__0_Internal_Boolean_Module_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPromptsCanvas.__c__DisplayClass11_0>.NativeClassPtr, 100680924);
			}

			// Token: 0x0600D7C9 RID: 55241 RVA: 0x00334860 File Offset: 0x00332A60
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPromptsCanvas.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsCanvas.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7CA RID: 55242 RVA: 0x0033489C File Offset: 0x00332A9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _LoadModule_b__0(InputPromptsCanvas.Module x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InputPromptsCanvas.__c__DisplayClass11_0.NativeMethodInfoPtr__LoadModule_b__0_Internal_Boolean_Module_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D7CB RID: 55243 RVA: 0x00069134 File Offset: 0x00067334
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042E3 RID: 17123
			// (get) Token: 0x0600D7CC RID: 55244 RVA: 0x003348EC File Offset: 0x00332AEC
			// (set) Token: 0x0600D7CD RID: 55245 RVA: 0x0006913D File Offset: 0x0006733D
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.__c__DisplayClass11_0.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InputPromptsCanvas.__c__DisplayClass11_0.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009104 RID: 37124
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04009105 RID: 37125
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009106 RID: 37126
			private static readonly IntPtr NativeMethodInfoPtr__LoadModule_b__0_Internal_Boolean_Module_0;
		}
	}
}
