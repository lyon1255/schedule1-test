using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Property;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000661 RID: 1633
	public class PropertySelector : MonoBehaviour
	{
		// Token: 0x060091CA RID: 37322 RVA: 0x0025A32C File Offset: 0x0025852C
		// Note: this type is marked as 'beforefieldinit'.
		static PropertySelector()
		{
			Il2CppClassPointerStore<PropertySelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "PropertySelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr);
			PropertySelector.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, "container");
			PropertySelector.NativeFieldInfoPtr_buttonContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, "buttonContainer");
			PropertySelector.NativeFieldInfoPtr_buttonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, "buttonPrefab");
			PropertySelector.NativeFieldInfoPtr_pCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, "pCallback");
			PropertySelector.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, 100681363);
			PropertySelector.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, 100681364);
			PropertySelector.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, 100681365);
			PropertySelector.NativeMethodInfoPtr_Exit_Public_Virtual_New_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, 100681366);
			PropertySelector.NativeMethodInfoPtr_OpenSelector_Public_Void_PropertySelected_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, 100681367);
			PropertySelector.NativeMethodInfoPtr_PropertyAcquired_Private_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, 100681368);
			PropertySelector.NativeMethodInfoPtr_SelectProperty_Private_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, 100681369);
			PropertySelector.NativeMethodInfoPtr_Close_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, 100681370);
			PropertySelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, 100681371);
		}

		// Token: 0x17002CB1 RID: 11441
		// (get) Token: 0x060091CB RID: 37323 RVA: 0x0025A460 File Offset: 0x00258660
		public unsafe bool isOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 263446, RefRangeEnd = 263447, XrefRangeStart = 263444, XrefRangeEnd = 263446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySelector.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060091CC RID: 37324 RVA: 0x0025A49C File Offset: 0x0025869C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263447, XrefRangeEnd = 263469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertySelector.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091CD RID: 37325 RVA: 0x0025A4D8 File Offset: 0x002586D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263469, XrefRangeEnd = 263478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertySelector.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091CE RID: 37326 RVA: 0x0025A514 File Offset: 0x00258714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263478, XrefRangeEnd = 263480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertySelector.NativeMethodInfoPtr_Exit_Public_Virtual_New_Void_ExitAction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091CF RID: 37327 RVA: 0x0025A564 File Offset: 0x00258764
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 263511, RefRangeEnd = 263512, XrefRangeStart = 263480, XrefRangeEnd = 263511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenSelector(PropertySelector.PropertySelected p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySelector.NativeMethodInfoPtr_OpenSelector_Public_Void_PropertySelected_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091D0 RID: 37328 RVA: 0x0025A5A8 File Offset: 0x002587A8
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PropertyAcquired(Property p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySelector.NativeMethodInfoPtr_PropertyAcquired_Private_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091D1 RID: 37329 RVA: 0x0025A5EC File Offset: 0x002587EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 263512, XrefRangeEnd = 263514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectProperty(Property p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySelector.NativeMethodInfoPtr_SelectProperty_Private_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091D2 RID: 37330 RVA: 0x0025A630 File Offset: 0x00258830
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 263543, RefRangeEnd = 263545, XrefRangeStart = 263514, XrefRangeEnd = 263543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close(bool reenableShit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref reenableShit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySelector.NativeMethodInfoPtr_Close_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091D3 RID: 37331 RVA: 0x0025A670 File Offset: 0x00258870
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertySelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060091D4 RID: 37332 RVA: 0x00046832 File Offset: 0x00044A32
		public PropertySelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002CAD RID: 11437
		// (get) Token: 0x060091D5 RID: 37333 RVA: 0x0025A6AC File Offset: 0x002588AC
		// (set) Token: 0x060091D6 RID: 37334 RVA: 0x0004683B File Offset: 0x00044A3B
		public unsafe GameObject container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertySelector.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertySelector.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CAE RID: 11438
		// (get) Token: 0x060091D7 RID: 37335 RVA: 0x0025A6DC File Offset: 0x002588DC
		// (set) Token: 0x060091D8 RID: 37336 RVA: 0x0004685A File Offset: 0x00044A5A
		public unsafe RectTransform buttonContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertySelector.NativeFieldInfoPtr_buttonContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertySelector.NativeFieldInfoPtr_buttonContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CAF RID: 11439
		// (get) Token: 0x060091D9 RID: 37337 RVA: 0x0025A70C File Offset: 0x0025890C
		// (set) Token: 0x060091DA RID: 37338 RVA: 0x00046879 File Offset: 0x00044A79
		public unsafe GameObject buttonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertySelector.NativeFieldInfoPtr_buttonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertySelector.NativeFieldInfoPtr_buttonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002CB0 RID: 11440
		// (get) Token: 0x060091DB RID: 37339 RVA: 0x0025A73C File Offset: 0x0025893C
		// (set) Token: 0x060091DC RID: 37340 RVA: 0x00046898 File Offset: 0x00044A98
		public unsafe PropertySelector.PropertySelected pCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertySelector.NativeFieldInfoPtr_pCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertySelector.PropertySelected>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertySelector.NativeFieldInfoPtr_pCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006281 RID: 25217
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x04006282 RID: 25218
		private static readonly IntPtr NativeFieldInfoPtr_buttonContainer;

		// Token: 0x04006283 RID: 25219
		private static readonly IntPtr NativeFieldInfoPtr_buttonPrefab;

		// Token: 0x04006284 RID: 25220
		private static readonly IntPtr NativeFieldInfoPtr_pCallback;

		// Token: 0x04006285 RID: 25221
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04006286 RID: 25222
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04006287 RID: 25223
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04006288 RID: 25224
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Public_Virtual_New_Void_ExitAction_0;

		// Token: 0x04006289 RID: 25225
		private static readonly IntPtr NativeMethodInfoPtr_OpenSelector_Public_Void_PropertySelected_0;

		// Token: 0x0400628A RID: 25226
		private static readonly IntPtr NativeMethodInfoPtr_PropertyAcquired_Private_Void_Property_0;

		// Token: 0x0400628B RID: 25227
		private static readonly IntPtr NativeMethodInfoPtr_SelectProperty_Private_Void_Property_0;

		// Token: 0x0400628C RID: 25228
		private static readonly IntPtr NativeMethodInfoPtr_Close_Private_Void_Boolean_0;

		// Token: 0x0400628D RID: 25229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B47 RID: 2887
		public sealed class PropertySelected : MulticastDelegate
		{
			// Token: 0x0600D92F RID: 55599 RVA: 0x00338884 File Offset: 0x00336A84
			// Note: this type is marked as 'beforefieldinit'.
			static PropertySelected()
			{
				Il2CppClassPointerStore<PropertySelector.PropertySelected>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertySelector>.NativeClassPtr, "PropertySelected");
				PropertySelector.PropertySelected.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector.PropertySelected>.NativeClassPtr, 100681372);
				PropertySelector.PropertySelected.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector.PropertySelected>.NativeClassPtr, 100681373);
				PropertySelector.PropertySelected.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Property_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector.PropertySelected>.NativeClassPtr, 100681374);
				PropertySelector.PropertySelected.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertySelector.PropertySelected>.NativeClassPtr, 100681375);
			}

			// Token: 0x0600D930 RID: 55600 RVA: 0x003388F8 File Offset: 0x00336AF8
			[CallerCount(257)]
			[CachedScanResults(RefRangeStart = 104784, RefRangeEnd = 105041, XrefRangeStart = 104784, XrefRangeEnd = 105041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PropertySelected(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertySelector.PropertySelected>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySelector.PropertySelected.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D931 RID: 55601 RVA: 0x00338954 File Offset: 0x00336B54
			[CallerCount(0)]
			public unsafe void Invoke(Property p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySelector.PropertySelected.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D932 RID: 55602 RVA: 0x00338998 File Offset: 0x00336B98
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74821, RefRangeEnd = 74822, XrefRangeStart = 74821, XrefRangeEnd = 74822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Property p, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySelector.PropertySelected.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Property_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600D933 RID: 55603 RVA: 0x00338A0C File Offset: 0x00336C0C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22498, RefRangeEnd = 22499, XrefRangeStart = 22498, XrefRangeEnd = 22499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertySelector.PropertySelected.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D934 RID: 55604 RVA: 0x00069CE2 File Offset: 0x00067EE2
			public PropertySelected(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600D935 RID: 55605 RVA: 0x00069CEB File Offset: 0x00067EEB
			public static implicit operator PropertySelector.PropertySelected(Action<Property> A_0)
			{
				return DelegateSupport.ConvertDelegate<PropertySelector.PropertySelected>(A_0);
			}

			// Token: 0x0600D936 RID: 55606 RVA: 0x00069CF3 File Offset: 0x00067EF3
			public static PropertySelector.PropertySelected operator +(PropertySelector.PropertySelected A_0, PropertySelector.PropertySelected A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PropertySelector.PropertySelected>();
			}

			// Token: 0x0600D937 RID: 55607 RVA: 0x00069D01 File Offset: 0x00067F01
			public static PropertySelector.PropertySelected operator -(PropertySelector.PropertySelected A_0, PropertySelector.PropertySelected A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<PropertySelector.PropertySelected>();
				}
				return result;
			}

			// Token: 0x040091E6 RID: 37350
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040091E7 RID: 37351
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Property_0;

			// Token: 0x040091E8 RID: 37352
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Property_AsyncCallback_Object_0;

			// Token: 0x040091E9 RID: 37353
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
