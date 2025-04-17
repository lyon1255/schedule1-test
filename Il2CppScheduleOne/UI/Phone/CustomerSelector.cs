using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Economy;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x0200069A RID: 1690
	public class CustomerSelector : MonoBehaviour
	{
		// Token: 0x0600966A RID: 38506 RVA: 0x00268550 File Offset: 0x00266750
		// Note: this type is marked as 'beforefieldinit'.
		static CustomerSelector()
		{
			Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "CustomerSelector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr);
			CustomerSelector.NativeFieldInfoPtr_ButtonPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, "ButtonPrefab");
			CustomerSelector.NativeFieldInfoPtr_EntriesContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, "EntriesContainer");
			CustomerSelector.NativeFieldInfoPtr_onCustomerSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, "onCustomerSelected");
			CustomerSelector.NativeFieldInfoPtr_customerEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, "customerEntries");
			CustomerSelector.NativeFieldInfoPtr_entryToCustomer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, "entryToCustomer");
			CustomerSelector.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100681889);
			CustomerSelector.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100681890);
			CustomerSelector.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100681891);
			CustomerSelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100681892);
			CustomerSelector.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100681893);
			CustomerSelector.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100681894);
			CustomerSelector.NativeMethodInfoPtr_CreateEntry_Private_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100681895);
			CustomerSelector.NativeMethodInfoPtr_CustomerSelected_Private_Void_Customer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100681896);
			CustomerSelector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, 100681897);
		}

		// Token: 0x0600966B RID: 38507 RVA: 0x00268698 File Offset: 0x00266898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269548, XrefRangeEnd = 269583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600966C RID: 38508 RVA: 0x002686CC File Offset: 0x002668CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269583, XrefRangeEnd = 269593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600966D RID: 38509 RVA: 0x00268700 File Offset: 0x00266900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269593, XrefRangeEnd = 269615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600966E RID: 38510 RVA: 0x00268734 File Offset: 0x00266934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269615, XrefRangeEnd = 269627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600966F RID: 38511 RVA: 0x00268778 File Offset: 0x00266978
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269650, RefRangeEnd = 269651, XrefRangeStart = 269627, XrefRangeEnd = 269650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009670 RID: 38512 RVA: 0x002687AC File Offset: 0x002669AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 194676, RefRangeEnd = 194677, XrefRangeStart = 194676, XrefRangeEnd = 194677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009671 RID: 38513 RVA: 0x002687E0 File Offset: 0x002669E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269700, RefRangeEnd = 269701, XrefRangeStart = 269651, XrefRangeEnd = 269700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateEntry(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_CreateEntry_Private_Void_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009672 RID: 38514 RVA: 0x00268824 File Offset: 0x00266A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269701, XrefRangeEnd = 269711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CustomerSelected(Customer customer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr_CustomerSelected_Private_Void_Customer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009673 RID: 38515 RVA: 0x00268868 File Offset: 0x00266A68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269711, XrefRangeEnd = 269726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomerSelector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009674 RID: 38516 RVA: 0x00049008 File Offset: 0x00047208
		public CustomerSelector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E19 RID: 11801
		// (get) Token: 0x06009675 RID: 38517 RVA: 0x002688A4 File Offset: 0x00266AA4
		// (set) Token: 0x06009676 RID: 38518 RVA: 0x00049011 File Offset: 0x00047211
		public unsafe GameObject ButtonPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_ButtonPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_ButtonPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E1A RID: 11802
		// (get) Token: 0x06009677 RID: 38519 RVA: 0x002688D4 File Offset: 0x00266AD4
		// (set) Token: 0x06009678 RID: 38520 RVA: 0x00049030 File Offset: 0x00047230
		public unsafe RectTransform EntriesContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_EntriesContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_EntriesContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E1B RID: 11803
		// (get) Token: 0x06009679 RID: 38521 RVA: 0x00268904 File Offset: 0x00266B04
		// (set) Token: 0x0600967A RID: 38522 RVA: 0x0004904F File Offset: 0x0004724F
		public unsafe UnityEvent<Customer> onCustomerSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_onCustomerSelected);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Customer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_onCustomerSelected), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E1C RID: 11804
		// (get) Token: 0x0600967B RID: 38523 RVA: 0x00268934 File Offset: 0x00266B34
		// (set) Token: 0x0600967C RID: 38524 RVA: 0x0004906E File Offset: 0x0004726E
		public unsafe List<RectTransform> customerEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_customerEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_customerEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E1D RID: 11805
		// (get) Token: 0x0600967D RID: 38525 RVA: 0x00268964 File Offset: 0x00266B64
		// (set) Token: 0x0600967E RID: 38526 RVA: 0x0004908D File Offset: 0x0004728D
		public unsafe Dictionary<RectTransform, Customer> entryToCustomer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_entryToCustomer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<RectTransform, Customer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.NativeFieldInfoPtr_entryToCustomer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006565 RID: 25957
		private static readonly IntPtr NativeFieldInfoPtr_ButtonPrefab;

		// Token: 0x04006566 RID: 25958
		private static readonly IntPtr NativeFieldInfoPtr_EntriesContainer;

		// Token: 0x04006567 RID: 25959
		private static readonly IntPtr NativeFieldInfoPtr_onCustomerSelected;

		// Token: 0x04006568 RID: 25960
		private static readonly IntPtr NativeFieldInfoPtr_customerEntries;

		// Token: 0x04006569 RID: 25961
		private static readonly IntPtr NativeFieldInfoPtr_entryToCustomer;

		// Token: 0x0400656A RID: 25962
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x0400656B RID: 25963
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x0400656C RID: 25964
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400656D RID: 25965
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x0400656E RID: 25966
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x0400656F RID: 25967
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006570 RID: 25968
		private static readonly IntPtr NativeMethodInfoPtr_CreateEntry_Private_Void_Customer_0;

		// Token: 0x04006571 RID: 25969
		private static readonly IntPtr NativeMethodInfoPtr_CustomerSelected_Private_Void_Customer_0;

		// Token: 0x04006572 RID: 25970
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B5F RID: 2911
		[ObfuscatedName("ScheduleOne.UI.Phone.CustomerSelector+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DA43 RID: 55875 RVA: 0x0033BD9C File Offset: 0x00339F9C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<CustomerSelector.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomerSelector>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerSelector.__c__DisplayClass11_0>.NativeClassPtr);
				CustomerSelector.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
				CustomerSelector.__c__DisplayClass11_0.NativeFieldInfoPtr_customer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerSelector.__c__DisplayClass11_0>.NativeClassPtr, "customer");
				CustomerSelector.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector.__c__DisplayClass11_0>.NativeClassPtr, 100681898);
				CustomerSelector.__c__DisplayClass11_0.NativeMethodInfoPtr__CreateEntry_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerSelector.__c__DisplayClass11_0>.NativeClassPtr, 100681899);
			}

			// Token: 0x0600DA44 RID: 55876 RVA: 0x0033BE18 File Offset: 0x0033A018
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerSelector.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA45 RID: 55877 RVA: 0x0033BE54 File Offset: 0x0033A054
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269538, XrefRangeEnd = 269548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateEntry_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerSelector.__c__DisplayClass11_0.NativeMethodInfoPtr__CreateEntry_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA46 RID: 55878 RVA: 0x0006A467 File Offset: 0x00068667
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043B5 RID: 17333
			// (get) Token: 0x0600DA47 RID: 55879 RVA: 0x0033BE88 File Offset: 0x0033A088
			// (set) Token: 0x0600DA48 RID: 55880 RVA: 0x0006A470 File Offset: 0x00068670
			public unsafe CustomerSelector __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CustomerSelector>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043B6 RID: 17334
			// (get) Token: 0x0600DA49 RID: 55881 RVA: 0x0033BEB8 File Offset: 0x0033A0B8
			// (set) Token: 0x0600DA4A RID: 55882 RVA: 0x0006A48F File Offset: 0x0006868F
			public unsafe Customer customer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.__c__DisplayClass11_0.NativeFieldInfoPtr_customer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerSelector.__c__DisplayClass11_0.NativeFieldInfoPtr_customer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009288 RID: 37512
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009289 RID: 37513
			private static readonly IntPtr NativeFieldInfoPtr_customer;

			// Token: 0x0400928A RID: 37514
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400928B RID: 37515
			private static readonly IntPtr NativeMethodInfoPtr__CreateEntry_b__0_Internal_Void_0;
		}
	}
}
