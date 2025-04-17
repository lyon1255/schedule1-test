using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200066D RID: 1645
	public class TextInputScreen : Singleton<TextInputScreen>
	{
		// Token: 0x060092D6 RID: 37590 RVA: 0x0025D654 File Offset: 0x0025B854
		// Note: this type is marked as 'beforefieldinit'.
		static TextInputScreen()
		{
			Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "TextInputScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr);
			TextInputScreen.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, "Canvas");
			TextInputScreen.NativeFieldInfoPtr_HeaderLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, "HeaderLabel");
			TextInputScreen.NativeFieldInfoPtr_InputField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, "InputField");
			TextInputScreen.NativeFieldInfoPtr_onSubmit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, "onSubmit");
			TextInputScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, 100681510);
			TextInputScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, 100681511);
			TextInputScreen.NativeMethodInfoPtr_Submit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, 100681512);
			TextInputScreen.NativeMethodInfoPtr_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, 100681513);
			TextInputScreen.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, 100681514);
			TextInputScreen.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, 100681515);
			TextInputScreen.NativeMethodInfoPtr_Open_Public_Void_String_String_OnSubmit_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, 100681516);
			TextInputScreen.NativeMethodInfoPtr_Close_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, 100681517);
			TextInputScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, 100681518);
		}

		// Token: 0x17002D06 RID: 11526
		// (get) Token: 0x060092D7 RID: 37591 RVA: 0x0025D788 File Offset: 0x0025B988
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 259469, RefRangeEnd = 259470, XrefRangeStart = 259469, XrefRangeEnd = 259470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060092D8 RID: 37592 RVA: 0x0025D7C4 File Offset: 0x0025B9C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264749, XrefRangeEnd = 264762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextInputScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092D9 RID: 37593 RVA: 0x0025D800 File Offset: 0x0025BA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264762, XrefRangeEnd = 264763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Submit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.NativeMethodInfoPtr_Submit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092DA RID: 37594 RVA: 0x0025D834 File Offset: 0x0025BA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264763, XrefRangeEnd = 264764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.NativeMethodInfoPtr_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092DB RID: 37595 RVA: 0x0025D868 File Offset: 0x0025BA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264764, XrefRangeEnd = 264767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092DC RID: 37596 RVA: 0x0025D89C File Offset: 0x0025BA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264767, XrefRangeEnd = 264769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092DD RID: 37597 RVA: 0x0025D8E0 File Offset: 0x0025BAE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 264798, RefRangeEnd = 264799, XrefRangeStart = 264769, XrefRangeEnd = 264798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open(string header, string text, TextInputScreen.OnSubmit _onSubmit, int maxChars = 10000)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(header);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_onSubmit);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxChars;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.NativeMethodInfoPtr_Open_Public_Void_String_String_OnSubmit_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092DE RID: 37598 RVA: 0x0025D954 File Offset: 0x0025BB54
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 264824, RefRangeEnd = 264828, XrefRangeStart = 264799, XrefRangeEnd = 264824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool submit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref submit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.NativeMethodInfoPtr_Close_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092DF RID: 37599 RVA: 0x0025D994 File Offset: 0x0025BB94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 264828, XrefRangeEnd = 264831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextInputScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060092E0 RID: 37600 RVA: 0x00047192 File Offset: 0x00045392
		public TextInputScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D02 RID: 11522
		// (get) Token: 0x060092E1 RID: 37601 RVA: 0x0025D9D0 File Offset: 0x0025BBD0
		// (set) Token: 0x060092E2 RID: 37602 RVA: 0x0004719B File Offset: 0x0004539B
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputScreen.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputScreen.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D03 RID: 11523
		// (get) Token: 0x060092E3 RID: 37603 RVA: 0x0025DA00 File Offset: 0x0025BC00
		// (set) Token: 0x060092E4 RID: 37604 RVA: 0x000471BA File Offset: 0x000453BA
		public unsafe TextMeshProUGUI HeaderLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputScreen.NativeFieldInfoPtr_HeaderLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputScreen.NativeFieldInfoPtr_HeaderLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D04 RID: 11524
		// (get) Token: 0x060092E5 RID: 37605 RVA: 0x0025DA30 File Offset: 0x0025BC30
		// (set) Token: 0x060092E6 RID: 37606 RVA: 0x000471D9 File Offset: 0x000453D9
		public unsafe TMP_InputField InputField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputScreen.NativeFieldInfoPtr_InputField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputScreen.NativeFieldInfoPtr_InputField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D05 RID: 11525
		// (get) Token: 0x060092E7 RID: 37607 RVA: 0x0025DA60 File Offset: 0x0025BC60
		// (set) Token: 0x060092E8 RID: 37608 RVA: 0x000471F8 File Offset: 0x000453F8
		public unsafe TextInputScreen.OnSubmit onSubmit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputScreen.NativeFieldInfoPtr_onSubmit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextInputScreen.OnSubmit>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextInputScreen.NativeFieldInfoPtr_onSubmit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006329 RID: 25385
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x0400632A RID: 25386
		private static readonly IntPtr NativeFieldInfoPtr_HeaderLabel;

		// Token: 0x0400632B RID: 25387
		private static readonly IntPtr NativeFieldInfoPtr_InputField;

		// Token: 0x0400632C RID: 25388
		private static readonly IntPtr NativeFieldInfoPtr_onSubmit;

		// Token: 0x0400632D RID: 25389
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x0400632E RID: 25390
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400632F RID: 25391
		private static readonly IntPtr NativeMethodInfoPtr_Submit_Public_Void_0;

		// Token: 0x04006330 RID: 25392
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Public_Void_0;

		// Token: 0x04006331 RID: 25393
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04006332 RID: 25394
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Void_ExitAction_0;

		// Token: 0x04006333 RID: 25395
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_String_String_OnSubmit_Int32_0;

		// Token: 0x04006334 RID: 25396
		private static readonly IntPtr NativeMethodInfoPtr_Close_Private_Void_Boolean_0;

		// Token: 0x04006335 RID: 25397
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B51 RID: 2897
		public sealed class OnSubmit : MulticastDelegate
		{
			// Token: 0x0600D9A9 RID: 55721 RVA: 0x0033A03C File Offset: 0x0033823C
			// Note: this type is marked as 'beforefieldinit'.
			static OnSubmit()
			{
				Il2CppClassPointerStore<TextInputScreen.OnSubmit>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextInputScreen>.NativeClassPtr, "OnSubmit");
				TextInputScreen.OnSubmit.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen.OnSubmit>.NativeClassPtr, 100681519);
				TextInputScreen.OnSubmit.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen.OnSubmit>.NativeClassPtr, 100681520);
				TextInputScreen.OnSubmit.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen.OnSubmit>.NativeClassPtr, 100681521);
				TextInputScreen.OnSubmit.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextInputScreen.OnSubmit>.NativeClassPtr, 100681522);
			}

			// Token: 0x0600D9AA RID: 55722 RVA: 0x0033A0B0 File Offset: 0x003382B0
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 83960, RefRangeEnd = 83964, XrefRangeStart = 83960, XrefRangeEnd = 83964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OnSubmit(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextInputScreen.OnSubmit>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.OnSubmit.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9AB RID: 55723 RVA: 0x0033A10C File Offset: 0x0033830C
			[CallerCount(0)]
			public unsafe void Invoke(string text)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.OnSubmit.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9AC RID: 55724 RVA: 0x0033A150 File Offset: 0x00338350
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74821, RefRangeEnd = 74822, XrefRangeStart = 74821, XrefRangeEnd = 74822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string text, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.OnSubmit.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600D9AD RID: 55725 RVA: 0x0033A1C4 File Offset: 0x003383C4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22498, RefRangeEnd = 22499, XrefRangeStart = 22498, XrefRangeEnd = 22499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextInputScreen.OnSubmit.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D9AE RID: 55726 RVA: 0x0006A03D File Offset: 0x0006823D
			public OnSubmit(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D9AF RID: 55727 RVA: 0x0006A046 File Offset: 0x00068246
			public static implicit operator TextInputScreen.OnSubmit(Action<string> A_0)
			{
				return DelegateSupport.ConvertDelegate<TextInputScreen.OnSubmit>(A_0);
			}

			// Token: 0x0600D9B0 RID: 55728 RVA: 0x0006A04E File Offset: 0x0006824E
			public static TextInputScreen.OnSubmit operator +(TextInputScreen.OnSubmit A_0, TextInputScreen.OnSubmit A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<TextInputScreen.OnSubmit>();
			}

			// Token: 0x0600D9B1 RID: 55729 RVA: 0x0006A05C File Offset: 0x0006825C
			public static TextInputScreen.OnSubmit operator -(TextInputScreen.OnSubmit A_0, TextInputScreen.OnSubmit A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<TextInputScreen.OnSubmit>();
				}
				return result;
			}

			// Token: 0x0400922F RID: 37423
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04009230 RID: 37424
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0;

			// Token: 0x04009231 RID: 37425
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0;

			// Token: 0x04009232 RID: 37426
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
