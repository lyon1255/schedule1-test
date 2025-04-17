using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Economy;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200064A RID: 1610
	public class NewCustomerPopup : Singleton<NewCustomerPopup>
	{
		// Token: 0x06008ECC RID: 36556 RVA: 0x0025172C File Offset: 0x0024F92C
		// Note: this type is marked as 'beforefieldinit'.
		static NewCustomerPopup()
		{
			Il2CppClassPointerStore<NewCustomerPopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "NewCustomerPopup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewCustomerPopup>.NativeClassPtr);
			NewCustomerPopup.NativeFieldInfoPtr__IsPlaying_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCustomerPopup>.NativeClassPtr, "<IsPlaying>k__BackingField");
			NewCustomerPopup.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCustomerPopup>.NativeClassPtr, "Canvas");
			NewCustomerPopup.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCustomerPopup>.NativeClassPtr, "Container");
			NewCustomerPopup.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCustomerPopup>.NativeClassPtr, "Group");
			NewCustomerPopup.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCustomerPopup>.NativeClassPtr, "Anim");
			NewCustomerPopup.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCustomerPopup>.NativeClassPtr, "Title");
			NewCustomerPopup.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCustomerPopup>.NativeClassPtr, "Entries");
			NewCustomerPopup.NativeFieldInfoPtr_SoundEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCustomerPopup>.NativeClassPtr, "SoundEffect");
			NewCustomerPopup.NativeFieldInfoPtr_routine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCustomerPopup>.NativeClassPtr, "routine");
			NewCustomerPopup.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewCustomerPopup>.NativeClassPtr, 100681015);
			NewCustomerPopup.NativeMethodInfoPtr_set_IsPlaying_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewCustomerPopup>.NativeClassPtr, 100681016);
			NewCustomerPopup.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewCustomerPopup>.NativeClassPtr, 100681017);
			NewCustomerPopup.NativeMethodInfoPtr_PlayPopup_Public_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewCustomerPopup>.NativeClassPtr, 100681018);
			NewCustomerPopup.NativeMethodInfoPtr_DisableEntries_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewCustomerPopup>.NativeClassPtr, 100681019);
			NewCustomerPopup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewCustomerPopup>.NativeClassPtr, 100681020);
			NewCustomerPopup.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewCustomerPopup>.NativeClassPtr, 100681021);
			NewCustomerPopup.NativeMethodInfoPtr__PlayPopup_b__13_2_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewCustomerPopup>.NativeClassPtr, 100681022);
		}

		// Token: 0x17002BB0 RID: 11184
		// (get) Token: 0x06008ECD RID: 36557 RVA: 0x002518B0 File Offset: 0x0024FAB0
		// (set) Token: 0x06008ECE RID: 36558 RVA: 0x002518EC File Offset: 0x0024FAEC
		public unsafe bool IsPlaying
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewCustomerPopup.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37988, RefRangeEnd = 38011, XrefRangeStart = 37988, XrefRangeEnd = 38011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewCustomerPopup.NativeMethodInfoPtr_set_IsPlaying_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008ECF RID: 36559 RVA: 0x0025192C File Offset: 0x0024FB2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259404, XrefRangeEnd = 259412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NewCustomerPopup.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008ED0 RID: 36560 RVA: 0x00251968 File Offset: 0x0024FB68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 259452, RefRangeEnd = 259453, XrefRangeStart = 259412, XrefRangeEnd = 259452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayPopup(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewCustomerPopup.NativeMethodInfoPtr_PlayPopup_Public_Void_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008ED1 RID: 36561 RVA: 0x002519AC File Offset: 0x0024FBAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 259456, RefRangeEnd = 259458, XrefRangeStart = 259453, XrefRangeEnd = 259456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisableEntries()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewCustomerPopup.NativeMethodInfoPtr_DisableEntries_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008ED2 RID: 36562 RVA: 0x002519E0 File Offset: 0x0024FBE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259458, XrefRangeEnd = 259461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewCustomerPopup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewCustomerPopup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewCustomerPopup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008ED3 RID: 36563 RVA: 0x00251A1C File Offset: 0x0024FC1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259461, XrefRangeEnd = 259466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewCustomerPopup.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008ED4 RID: 36564 RVA: 0x00251A5C File Offset: 0x0024FC5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259466, XrefRangeEnd = 259467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _PlayPopup_b__13_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewCustomerPopup.NativeMethodInfoPtr__PlayPopup_b__13_2_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008ED5 RID: 36565 RVA: 0x00044C1C File Offset: 0x00042E1C
		public NewCustomerPopup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002BA7 RID: 11175
		// (get) Token: 0x06008ED6 RID: 36566 RVA: 0x00251A98 File Offset: 0x0024FC98
		// (set) Token: 0x06008ED7 RID: 36567 RVA: 0x00044C25 File Offset: 0x00042E25
		public unsafe bool _IsPlaying_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewCustomerPopup.NativeFieldInfoPtr__IsPlaying_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewCustomerPopup.NativeFieldInfoPtr__IsPlaying_k__BackingField)) = value;
			}
		}

		// Token: 0x17002BA8 RID: 11176
		// (get) Token: 0x06008ED8 RID: 36568 RVA: 0x00251AC0 File Offset: 0x0024FCC0
		// (set) Token: 0x06008ED9 RID: 36569 RVA: 0x00044C40 File Offset: 0x00042E40
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewCustomerPopup.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewCustomerPopup.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BA9 RID: 11177
		// (get) Token: 0x06008EDA RID: 36570 RVA: 0x00251AF0 File Offset: 0x0024FCF0
		// (set) Token: 0x06008EDB RID: 36571 RVA: 0x00044C5F File Offset: 0x00042E5F
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewCustomerPopup.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewCustomerPopup.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BAA RID: 11178
		// (get) Token: 0x06008EDC RID: 36572 RVA: 0x00251B20 File Offset: 0x0024FD20
		// (set) Token: 0x06008EDD RID: 36573 RVA: 0x00044C7E File Offset: 0x00042E7E
		public unsafe CanvasGroup Group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewCustomerPopup.NativeFieldInfoPtr_Group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewCustomerPopup.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BAB RID: 11179
		// (get) Token: 0x06008EDE RID: 36574 RVA: 0x00251B50 File Offset: 0x0024FD50
		// (set) Token: 0x06008EDF RID: 36575 RVA: 0x00044C9D File Offset: 0x00042E9D
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewCustomerPopup.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewCustomerPopup.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BAC RID: 11180
		// (get) Token: 0x06008EE0 RID: 36576 RVA: 0x00251B80 File Offset: 0x0024FD80
		// (set) Token: 0x06008EE1 RID: 36577 RVA: 0x00044CBC File Offset: 0x00042EBC
		public unsafe TextMeshProUGUI Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewCustomerPopup.NativeFieldInfoPtr_Title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewCustomerPopup.NativeFieldInfoPtr_Title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BAD RID: 11181
		// (get) Token: 0x06008EE2 RID: 36578 RVA: 0x00251BB0 File Offset: 0x0024FDB0
		// (set) Token: 0x06008EE3 RID: 36579 RVA: 0x00044CDB File Offset: 0x00042EDB
		public unsafe Il2CppReferenceArray<RectTransform> Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewCustomerPopup.NativeFieldInfoPtr_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewCustomerPopup.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BAE RID: 11182
		// (get) Token: 0x06008EE4 RID: 36580 RVA: 0x00251BE0 File Offset: 0x0024FDE0
		// (set) Token: 0x06008EE5 RID: 36581 RVA: 0x00044CFA File Offset: 0x00042EFA
		public unsafe AudioSourceController SoundEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewCustomerPopup.NativeFieldInfoPtr_SoundEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewCustomerPopup.NativeFieldInfoPtr_SoundEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002BAF RID: 11183
		// (get) Token: 0x06008EE6 RID: 36582 RVA: 0x00251C10 File Offset: 0x0024FE10
		// (set) Token: 0x06008EE7 RID: 36583 RVA: 0x00044D19 File Offset: 0x00042F19
		public unsafe Coroutine routine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewCustomerPopup.NativeFieldInfoPtr_routine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewCustomerPopup.NativeFieldInfoPtr_routine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040060A4 RID: 24740
		private static readonly IntPtr NativeFieldInfoPtr__IsPlaying_k__BackingField;

		// Token: 0x040060A5 RID: 24741
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040060A6 RID: 24742
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040060A7 RID: 24743
		private static readonly IntPtr NativeFieldInfoPtr_Group;

		// Token: 0x040060A8 RID: 24744
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x040060A9 RID: 24745
		private static readonly IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x040060AA RID: 24746
		private static readonly IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x040060AB RID: 24747
		private static readonly IntPtr NativeFieldInfoPtr_SoundEffect;

		// Token: 0x040060AC RID: 24748
		private static readonly IntPtr NativeFieldInfoPtr_routine;

		// Token: 0x040060AD RID: 24749
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x040060AE RID: 24750
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPlaying_Protected_set_Void_Boolean_0;

		// Token: 0x040060AF RID: 24751
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040060B0 RID: 24752
		private static readonly IntPtr NativeMethodInfoPtr_PlayPopup_Public_Void_Customer_0;

		// Token: 0x040060B1 RID: 24753
		private static readonly IntPtr NativeMethodInfoPtr_DisableEntries_Private_Void_0;

		// Token: 0x040060B2 RID: 24754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040060B3 RID: 24755
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x040060B4 RID: 24756
		private static readonly IntPtr NativeMethodInfoPtr__PlayPopup_b__13_2_Private_Boolean_0;

		// Token: 0x02000B2F RID: 2863
		[ObfuscatedName("ScheduleOne.UI.NewCustomerPopup+<<PlayPopup>g__Routine|13_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D7F8 RID: 55288 RVA: 0x00335090 File Offset: 0x00333290
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique()
			{
				Il2CppClassPointerStore<NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewCustomerPopup>.NativeClassPtr, "<<PlayPopup>g__Routine|13_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique>.NativeClassPtr);
				NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique>.NativeClassPtr, "<>1__state");
				NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique>.NativeClassPtr, "<>2__current");
				NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique>.NativeClassPtr, "<>4__this");
				NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique>.NativeClassPtr, 100681023);
				NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique>.NativeClassPtr, 100681024);
				NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique>.NativeClassPtr, 100681025);
				NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique>.NativeClassPtr, 100681026);
				NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique>.NativeClassPtr, 100681027);
				NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique>.NativeClassPtr, 100681028);
			}

			// Token: 0x0600D7F9 RID: 55289 RVA: 0x00335170 File Offset: 0x00333370
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7FA RID: 55290 RVA: 0x003351B8 File Offset: 0x003333B8
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D7FB RID: 55291 RVA: 0x003351EC File Offset: 0x003333EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259384, XrefRangeEnd = 259395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170042F4 RID: 17140
			// (get) Token: 0x0600D7FC RID: 55292 RVA: 0x00335228 File Offset: 0x00333428
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D7FD RID: 55293 RVA: 0x00335268 File Offset: 0x00333468
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259395, XrefRangeEnd = 259400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170042F5 RID: 17141
			// (get) Token: 0x0600D7FE RID: 55294 RVA: 0x0033529C File Offset: 0x0033349C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D7FF RID: 55295 RVA: 0x000692AF File Offset: 0x000674AF
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042F1 RID: 17137
			// (get) Token: 0x0600D800 RID: 55296 RVA: 0x003352DC File Offset: 0x003334DC
			// (set) Token: 0x0600D801 RID: 55297 RVA: 0x000692B8 File Offset: 0x000674B8
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170042F2 RID: 17138
			// (get) Token: 0x0600D802 RID: 55298 RVA: 0x00335304 File Offset: 0x00333504
			// (set) Token: 0x0600D803 RID: 55299 RVA: 0x000692D3 File Offset: 0x000674D3
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042F3 RID: 17139
			// (get) Token: 0x0600D804 RID: 55300 RVA: 0x00335334 File Offset: 0x00333534
			// (set) Token: 0x0600D805 RID: 55301 RVA: 0x000692F2 File Offset: 0x000674F2
			public unsafe NewCustomerPopup __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NewCustomerPopup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewCustomerPopup.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObNeObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400911E RID: 37150
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400911F RID: 37151
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009120 RID: 37152
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009121 RID: 37153
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009122 RID: 37154
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009123 RID: 37155
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009124 RID: 37156
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009125 RID: 37157
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009126 RID: 37158
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B30 RID: 2864
		[ObfuscatedName("ScheduleOne.UI.NewCustomerPopup+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D806 RID: 55302 RVA: 0x00335364 File Offset: 0x00333564
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NewCustomerPopup.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewCustomerPopup>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewCustomerPopup.__c>.NativeClassPtr);
				NewCustomerPopup.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCustomerPopup.__c>.NativeClassPtr, "<>9");
				NewCustomerPopup.__c.NativeFieldInfoPtr___9__13_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewCustomerPopup.__c>.NativeClassPtr, "<>9__13_1");
				NewCustomerPopup.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewCustomerPopup.__c>.NativeClassPtr, 100681030);
				NewCustomerPopup.__c.NativeMethodInfoPtr__PlayPopup_b__13_1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewCustomerPopup.__c>.NativeClassPtr, 100681031);
			}

			// Token: 0x0600D807 RID: 55303 RVA: 0x003353E0 File Offset: 0x003335E0
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewCustomerPopup.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewCustomerPopup.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D808 RID: 55304 RVA: 0x0033541C File Offset: 0x0033361C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 259400, XrefRangeEnd = 259404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PlayPopup_b__13_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewCustomerPopup.__c.NativeMethodInfoPtr__PlayPopup_b__13_1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D809 RID: 55305 RVA: 0x00069311 File Offset: 0x00067511
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042F6 RID: 17142
			// (get) Token: 0x0600D80A RID: 55306 RVA: 0x00335458 File Offset: 0x00333658
			// (set) Token: 0x0600D80B RID: 55307 RVA: 0x0006931A File Offset: 0x0006751A
			public unsafe static NewCustomerPopup.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NewCustomerPopup.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NewCustomerPopup.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NewCustomerPopup.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042F7 RID: 17143
			// (get) Token: 0x0600D80C RID: 55308 RVA: 0x00335480 File Offset: 0x00333680
			// (set) Token: 0x0600D80D RID: 55309 RVA: 0x0006932C File Offset: 0x0006752C
			public unsafe static Func<bool> __9__13_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NewCustomerPopup.__c.NativeFieldInfoPtr___9__13_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NewCustomerPopup.__c.NativeFieldInfoPtr___9__13_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009127 RID: 37159
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009128 RID: 37160
			private static readonly IntPtr NativeFieldInfoPtr___9__13_1;

			// Token: 0x04009129 RID: 37161
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400912A RID: 37162
			private static readonly IntPtr NativeMethodInfoPtr__PlayPopup_b__13_1_Internal_Boolean_0;
		}
	}
}
