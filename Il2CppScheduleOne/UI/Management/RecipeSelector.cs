using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.StationFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006D2 RID: 1746
	public class RecipeSelector : ClipboardScreen
	{
		// Token: 0x06009D16 RID: 40214 RVA: 0x0027C184 File Offset: 0x0027A384
		// Note: this type is marked as 'beforefieldinit'.
		static RecipeSelector()
		{
			Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "RecipeSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr);
			RecipeSelector.NativeFieldInfoPtr_OptionContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "OptionContainer");
			RecipeSelector.NativeFieldInfoPtr_TitleLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "TitleLabel");
			RecipeSelector.NativeFieldInfoPtr_OptionPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "OptionPrefab");
			RecipeSelector.NativeFieldInfoPtr_EmptyOptionSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "EmptyOptionSprite");
			RecipeSelector.NativeFieldInfoPtr_lerpRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "lerpRoutine");
			RecipeSelector.NativeFieldInfoPtr_options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "options");
			RecipeSelector.NativeFieldInfoPtr_selectedOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "selectedOption");
			RecipeSelector.NativeFieldInfoPtr_optionButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "optionButtons");
			RecipeSelector.NativeFieldInfoPtr_optionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "optionCallback");
			RecipeSelector.NativeMethodInfoPtr_Initialize_Public_Void_String_List_1_StationRecipe_StationRecipe_Action_1_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, 100682576);
			RecipeSelector.NativeMethodInfoPtr_Open_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, 100682577);
			RecipeSelector.NativeMethodInfoPtr_Close_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, 100682578);
			RecipeSelector.NativeMethodInfoPtr_ButtonClicked_Private_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, 100682579);
			RecipeSelector.NativeMethodInfoPtr_CreateOptions_Private_Void_List_1_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, 100682580);
			RecipeSelector.NativeMethodInfoPtr_DeleteOptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, 100682581);
			RecipeSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, 100682582);
		}

		// Token: 0x06009D17 RID: 40215 RVA: 0x0027C2F4 File Offset: 0x0027A4F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278781, RefRangeEnd = 278782, XrefRangeStart = 278755, XrefRangeEnd = 278781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(string selectionTitle, List<StationRecipe> _options, StationRecipe _selectedOption = null, Action<StationRecipe> _optionCallback = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(selectionTitle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_options);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_selectedOption);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_optionCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.NativeMethodInfoPtr_Initialize_Public_Void_String_List_1_StationRecipe_StationRecipe_Action_1_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D18 RID: 40216 RVA: 0x0027C370 File Offset: 0x0027A570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278782, XrefRangeEnd = 278802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RecipeSelector.NativeMethodInfoPtr_Open_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D19 RID: 40217 RVA: 0x0027C3AC File Offset: 0x0027A5AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278802, XrefRangeEnd = 278814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RecipeSelector.NativeMethodInfoPtr_Close_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D1A RID: 40218 RVA: 0x0027C3E8 File Offset: 0x0027A5E8
		[CallerCount(0)]
		public unsafe void ButtonClicked(StationRecipe option)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(option);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.NativeMethodInfoPtr_ButtonClicked_Private_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D1B RID: 40219 RVA: 0x0027C42C File Offset: 0x0027A62C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 278879, RefRangeEnd = 278880, XrefRangeStart = 278814, XrefRangeEnd = 278879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateOptions(List<StationRecipe> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.NativeMethodInfoPtr_CreateOptions_Private_Void_List_1_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D1C RID: 40220 RVA: 0x0027C470 File Offset: 0x0027A670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278880, XrefRangeEnd = 278892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeleteOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.NativeMethodInfoPtr_DeleteOptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D1D RID: 40221 RVA: 0x0027C4A4 File Offset: 0x0027A6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278892, XrefRangeEnd = 278907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RecipeSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009D1E RID: 40222 RVA: 0x0004D0AF File Offset: 0x0004B2AF
		public RecipeSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003060 RID: 12384
		// (get) Token: 0x06009D1F RID: 40223 RVA: 0x0027C4E0 File Offset: 0x0027A6E0
		// (set) Token: 0x06009D20 RID: 40224 RVA: 0x0004D0B8 File Offset: 0x0004B2B8
		public unsafe RectTransform OptionContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_OptionContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_OptionContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003061 RID: 12385
		// (get) Token: 0x06009D21 RID: 40225 RVA: 0x0027C510 File Offset: 0x0027A710
		// (set) Token: 0x06009D22 RID: 40226 RVA: 0x0004D0D7 File Offset: 0x0004B2D7
		public unsafe TextMeshProUGUI TitleLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_TitleLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_TitleLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003062 RID: 12386
		// (get) Token: 0x06009D23 RID: 40227 RVA: 0x0027C540 File Offset: 0x0027A740
		// (set) Token: 0x06009D24 RID: 40228 RVA: 0x0004D0F6 File Offset: 0x0004B2F6
		public unsafe GameObject OptionPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_OptionPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_OptionPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003063 RID: 12387
		// (get) Token: 0x06009D25 RID: 40229 RVA: 0x0027C570 File Offset: 0x0027A770
		// (set) Token: 0x06009D26 RID: 40230 RVA: 0x0004D115 File Offset: 0x0004B315
		public unsafe Sprite EmptyOptionSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_EmptyOptionSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_EmptyOptionSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003064 RID: 12388
		// (get) Token: 0x06009D27 RID: 40231 RVA: 0x0027C5A0 File Offset: 0x0027A7A0
		// (set) Token: 0x06009D28 RID: 40232 RVA: 0x0004D134 File Offset: 0x0004B334
		public new unsafe Coroutine lerpRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_lerpRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_lerpRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003065 RID: 12389
		// (get) Token: 0x06009D29 RID: 40233 RVA: 0x0027C5D0 File Offset: 0x0027A7D0
		// (set) Token: 0x06009D2A RID: 40234 RVA: 0x0004D153 File Offset: 0x0004B353
		public unsafe List<StationRecipe> options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<StationRecipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003066 RID: 12390
		// (get) Token: 0x06009D2B RID: 40235 RVA: 0x0027C600 File Offset: 0x0027A800
		// (set) Token: 0x06009D2C RID: 40236 RVA: 0x0004D172 File Offset: 0x0004B372
		public unsafe StationRecipe selectedOption
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_selectedOption);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_selectedOption), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003067 RID: 12391
		// (get) Token: 0x06009D2D RID: 40237 RVA: 0x0027C630 File Offset: 0x0027A830
		// (set) Token: 0x06009D2E RID: 40238 RVA: 0x0004D191 File Offset: 0x0004B391
		public unsafe List<RectTransform> optionButtons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_optionButtons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_optionButtons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003068 RID: 12392
		// (get) Token: 0x06009D2F RID: 40239 RVA: 0x0027C660 File Offset: 0x0027A860
		// (set) Token: 0x06009D30 RID: 40240 RVA: 0x0004D1B0 File Offset: 0x0004B3B0
		public unsafe Action<StationRecipe> optionCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_optionCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<StationRecipe>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.NativeFieldInfoPtr_optionCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006981 RID: 27009
		private static readonly IntPtr NativeFieldInfoPtr_OptionContainer;

		// Token: 0x04006982 RID: 27010
		private static readonly IntPtr NativeFieldInfoPtr_TitleLabel;

		// Token: 0x04006983 RID: 27011
		private static readonly IntPtr NativeFieldInfoPtr_OptionPrefab;

		// Token: 0x04006984 RID: 27012
		private static readonly IntPtr NativeFieldInfoPtr_EmptyOptionSprite;

		// Token: 0x04006985 RID: 27013
		private static readonly IntPtr NativeFieldInfoPtr_lerpRoutine;

		// Token: 0x04006986 RID: 27014
		private static readonly IntPtr NativeFieldInfoPtr_options;

		// Token: 0x04006987 RID: 27015
		private static readonly IntPtr NativeFieldInfoPtr_selectedOption;

		// Token: 0x04006988 RID: 27016
		private static readonly IntPtr NativeFieldInfoPtr_optionButtons;

		// Token: 0x04006989 RID: 27017
		private static readonly IntPtr NativeFieldInfoPtr_optionCallback;

		// Token: 0x0400698A RID: 27018
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_String_List_1_StationRecipe_StationRecipe_Action_1_StationRecipe_0;

		// Token: 0x0400698B RID: 27019
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_Void_0;

		// Token: 0x0400698C RID: 27020
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_Void_0;

		// Token: 0x0400698D RID: 27021
		private static readonly IntPtr NativeMethodInfoPtr_ButtonClicked_Private_Void_StationRecipe_0;

		// Token: 0x0400698E RID: 27022
		private static readonly IntPtr NativeMethodInfoPtr_CreateOptions_Private_Void_List_1_StationRecipe_0;

		// Token: 0x0400698F RID: 27023
		private static readonly IntPtr NativeMethodInfoPtr_DeleteOptions_Private_Void_0;

		// Token: 0x04006990 RID: 27024
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B95 RID: 2965
		[ObfuscatedName("ScheduleOne.UI.Management.RecipeSelector+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DC1D RID: 56349 RVA: 0x00340FA8 File Offset: 0x0033F1A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RecipeSelector.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeSelector.__c>.NativeClassPtr);
				RecipeSelector.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector.__c>.NativeClassPtr, "<>9");
				RecipeSelector.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector.__c>.NativeClassPtr, "<>9__13_0");
				RecipeSelector.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector.__c>.NativeClassPtr, 100682584);
				RecipeSelector.__c.NativeMethodInfoPtr__CreateOptions_b__13_0_Internal_Int32_StationRecipe_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector.__c>.NativeClassPtr, 100682585);
			}

			// Token: 0x0600DC1E RID: 56350 RVA: 0x00341024 File Offset: 0x0033F224
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecipeSelector.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC1F RID: 56351 RVA: 0x00341060 File Offset: 0x0033F260
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278752, XrefRangeEnd = 278754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CreateOptions_b__13_0(StationRecipe a, StationRecipe b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.__c.NativeMethodInfoPtr__CreateOptions_b__13_0_Internal_Int32_StationRecipe_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DC20 RID: 56352 RVA: 0x0006B394 File Offset: 0x00069594
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700443A RID: 17466
			// (get) Token: 0x0600DC21 RID: 56353 RVA: 0x003410C0 File Offset: 0x0033F2C0
			// (set) Token: 0x0600DC22 RID: 56354 RVA: 0x0006B39D File Offset: 0x0006959D
			public unsafe static RecipeSelector.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RecipeSelector.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RecipeSelector.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RecipeSelector.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700443B RID: 17467
			// (get) Token: 0x0600DC23 RID: 56355 RVA: 0x003410E8 File Offset: 0x0033F2E8
			// (set) Token: 0x0600DC24 RID: 56356 RVA: 0x0006B3AF File Offset: 0x000695AF
			public unsafe static Comparison<StationRecipe> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RecipeSelector.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<StationRecipe>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RecipeSelector.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400938A RID: 37770
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400938B RID: 37771
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x0400938C RID: 37772
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400938D RID: 37773
			private static readonly IntPtr NativeMethodInfoPtr__CreateOptions_b__13_0_Internal_Int32_StationRecipe_StationRecipe_0;
		}

		// Token: 0x02000B96 RID: 2966
		[ObfuscatedName("ScheduleOne.UI.Management.RecipeSelector+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DC25 RID: 56357 RVA: 0x00341110 File Offset: 0x0033F310
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<RecipeSelector.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RecipeSelector>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecipeSelector.__c__DisplayClass13_0>.NativeClassPtr);
				RecipeSelector.__c__DisplayClass13_0.NativeFieldInfoPtr_opt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector.__c__DisplayClass13_0>.NativeClassPtr, "opt");
				RecipeSelector.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RecipeSelector.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				RecipeSelector.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector.__c__DisplayClass13_0>.NativeClassPtr, 100682586);
				RecipeSelector.__c__DisplayClass13_0.NativeMethodInfoPtr__CreateOptions_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecipeSelector.__c__DisplayClass13_0>.NativeClassPtr, 100682587);
			}

			// Token: 0x0600DC26 RID: 56358 RVA: 0x0034118C File Offset: 0x0033F38C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RecipeSelector.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC27 RID: 56359 RVA: 0x003411C8 File Offset: 0x0033F3C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 278754, XrefRangeEnd = 278755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateOptions_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RecipeSelector.__c__DisplayClass13_0.NativeMethodInfoPtr__CreateOptions_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DC28 RID: 56360 RVA: 0x0006B3C1 File Offset: 0x000695C1
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700443C RID: 17468
			// (get) Token: 0x0600DC29 RID: 56361 RVA: 0x003411FC File Offset: 0x0033F3FC
			// (set) Token: 0x0600DC2A RID: 56362 RVA: 0x0006B3CA File Offset: 0x000695CA
			public unsafe StationRecipe opt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.__c__DisplayClass13_0.NativeFieldInfoPtr_opt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.__c__DisplayClass13_0.NativeFieldInfoPtr_opt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700443D RID: 17469
			// (get) Token: 0x0600DC2B RID: 56363 RVA: 0x0034122C File Offset: 0x0033F42C
			// (set) Token: 0x0600DC2C RID: 56364 RVA: 0x0006B3E9 File Offset: 0x000695E9
			public unsafe RecipeSelector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RecipeSelector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RecipeSelector.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400938E RID: 37774
			private static readonly IntPtr NativeFieldInfoPtr_opt;

			// Token: 0x0400938F RID: 37775
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009390 RID: 37776
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009391 RID: 37777
			private static readonly IntPtr NativeMethodInfoPtr__CreateOptions_b__1_Internal_Void_0;
		}
	}
}
