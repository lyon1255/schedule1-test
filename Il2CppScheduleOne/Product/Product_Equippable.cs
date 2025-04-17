using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Packaging;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005AB RID: 1451
	public class Product_Equippable : Equippable_Viewmodel
	{
		// Token: 0x06007F9D RID: 32669 RVA: 0x00222DAC File Offset: 0x00220FAC
		// Note: this type is marked as 'beforefieldinit'.
		static Product_Equippable()
		{
			Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "Product_Equippable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr);
			Product_Equippable.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "Visuals");
			Product_Equippable.NativeFieldInfoPtr_ModelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "ModelContainer");
			Product_Equippable.NativeFieldInfoPtr_Consumable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "Consumable");
			Product_Equippable.NativeFieldInfoPtr_ConsumeDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "ConsumeDescription");
			Product_Equippable.NativeFieldInfoPtr_ConsumeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "ConsumeTime");
			Product_Equippable.NativeFieldInfoPtr_EffectsApplyDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "EffectsApplyDelay");
			Product_Equippable.NativeFieldInfoPtr_ConsumeAnimationBool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "ConsumeAnimationBool");
			Product_Equippable.NativeFieldInfoPtr_ConsumeAnimationTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "ConsumeAnimationTrigger");
			Product_Equippable.NativeFieldInfoPtr_ConsumeEquippableAssetPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "ConsumeEquippableAssetPath");
			Product_Equippable.NativeFieldInfoPtr_onConsumeInputStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "onConsumeInputStart");
			Product_Equippable.NativeFieldInfoPtr_onConsumeInputComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "onConsumeInputComplete");
			Product_Equippable.NativeFieldInfoPtr_onConsumeInputCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "onConsumeInputCancel");
			Product_Equippable.NativeFieldInfoPtr_consumeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "consumeTime");
			Product_Equippable.NativeFieldInfoPtr_consumingInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "consumingInProgress");
			Product_Equippable.NativeFieldInfoPtr_defaultModelPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "defaultModelPosition");
			Product_Equippable.NativeFieldInfoPtr_productAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "productAmount");
			Product_Equippable.NativeFieldInfoPtr_consumeRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "consumeRoutine");
			Product_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679325);
			Product_Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679326);
			Product_Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679327);
			Product_Equippable.NativeMethodInfoPtr_Consume_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679328);
			Product_Equippable.NativeMethodInfoPtr_ApplyEffects_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679329);
			Product_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679330);
			Product_Equippable.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, 100679331);
		}

		// Token: 0x06007F9E RID: 32670 RVA: 0x00222FBC File Offset: 0x002211BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243005, XrefRangeEnd = 243067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Product_Equippable.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007F9F RID: 32671 RVA: 0x0022300C File Offset: 0x0022120C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243067, XrefRangeEnd = 243093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Product_Equippable.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FA0 RID: 32672 RVA: 0x00223048 File Offset: 0x00221248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243093, XrefRangeEnd = 243139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Product_Equippable.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FA1 RID: 32673 RVA: 0x00223084 File Offset: 0x00221284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243139, XrefRangeEnd = 243172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Consume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Product_Equippable.NativeMethodInfoPtr_Consume_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FA2 RID: 32674 RVA: 0x002230C0 File Offset: 0x002212C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243172, XrefRangeEnd = 243182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyEffects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Product_Equippable.NativeMethodInfoPtr_ApplyEffects_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FA3 RID: 32675 RVA: 0x002230FC File Offset: 0x002212FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243182, XrefRangeEnd = 243196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Product_Equippable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007FA4 RID: 32676 RVA: 0x00223138 File Offset: 0x00221338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 243196, XrefRangeEnd = 243201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06007FA5 RID: 32677 RVA: 0x0003C71A File Offset: 0x0003A91A
		public Product_Equippable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700268B RID: 9867
		// (get) Token: 0x06007FA6 RID: 32678 RVA: 0x00223178 File Offset: 0x00221378
		// (set) Token: 0x06007FA7 RID: 32679 RVA: 0x0003C723 File Offset: 0x0003A923
		public unsafe FilledPackagingVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilledPackagingVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700268C RID: 9868
		// (get) Token: 0x06007FA8 RID: 32680 RVA: 0x002231A8 File Offset: 0x002213A8
		// (set) Token: 0x06007FA9 RID: 32681 RVA: 0x0003C742 File Offset: 0x0003A942
		public unsafe Transform ModelContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ModelContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ModelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700268D RID: 9869
		// (get) Token: 0x06007FAA RID: 32682 RVA: 0x002231D8 File Offset: 0x002213D8
		// (set) Token: 0x06007FAB RID: 32683 RVA: 0x0003C761 File Offset: 0x0003A961
		public unsafe bool Consumable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_Consumable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_Consumable)) = value;
			}
		}

		// Token: 0x1700268E RID: 9870
		// (get) Token: 0x06007FAC RID: 32684 RVA: 0x00223200 File Offset: 0x00221400
		// (set) Token: 0x06007FAD RID: 32685 RVA: 0x0003C77C File Offset: 0x0003A97C
		public unsafe string ConsumeDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ConsumeDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ConsumeDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700268F RID: 9871
		// (get) Token: 0x06007FAE RID: 32686 RVA: 0x00223228 File Offset: 0x00221428
		// (set) Token: 0x06007FAF RID: 32687 RVA: 0x0003C79B File Offset: 0x0003A99B
		public unsafe float ConsumeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ConsumeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ConsumeTime)) = value;
			}
		}

		// Token: 0x17002690 RID: 9872
		// (get) Token: 0x06007FB0 RID: 32688 RVA: 0x00223250 File Offset: 0x00221450
		// (set) Token: 0x06007FB1 RID: 32689 RVA: 0x0003C7B6 File Offset: 0x0003A9B6
		public unsafe float EffectsApplyDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_EffectsApplyDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_EffectsApplyDelay)) = value;
			}
		}

		// Token: 0x17002691 RID: 9873
		// (get) Token: 0x06007FB2 RID: 32690 RVA: 0x00223278 File Offset: 0x00221478
		// (set) Token: 0x06007FB3 RID: 32691 RVA: 0x0003C7D1 File Offset: 0x0003A9D1
		public unsafe string ConsumeAnimationBool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ConsumeAnimationBool);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ConsumeAnimationBool), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002692 RID: 9874
		// (get) Token: 0x06007FB4 RID: 32692 RVA: 0x002232A0 File Offset: 0x002214A0
		// (set) Token: 0x06007FB5 RID: 32693 RVA: 0x0003C7F0 File Offset: 0x0003A9F0
		public unsafe string ConsumeAnimationTrigger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ConsumeAnimationTrigger);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ConsumeAnimationTrigger), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002693 RID: 9875
		// (get) Token: 0x06007FB6 RID: 32694 RVA: 0x002232C8 File Offset: 0x002214C8
		// (set) Token: 0x06007FB7 RID: 32695 RVA: 0x0003C80F File Offset: 0x0003AA0F
		public unsafe string ConsumeEquippableAssetPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ConsumeEquippableAssetPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_ConsumeEquippableAssetPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002694 RID: 9876
		// (get) Token: 0x06007FB8 RID: 32696 RVA: 0x002232F0 File Offset: 0x002214F0
		// (set) Token: 0x06007FB9 RID: 32697 RVA: 0x0003C82E File Offset: 0x0003AA2E
		public unsafe UnityEvent onConsumeInputStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_onConsumeInputStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_onConsumeInputStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002695 RID: 9877
		// (get) Token: 0x06007FBA RID: 32698 RVA: 0x00223320 File Offset: 0x00221520
		// (set) Token: 0x06007FBB RID: 32699 RVA: 0x0003C84D File Offset: 0x0003AA4D
		public unsafe UnityEvent onConsumeInputComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_onConsumeInputComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_onConsumeInputComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002696 RID: 9878
		// (get) Token: 0x06007FBC RID: 32700 RVA: 0x00223350 File Offset: 0x00221550
		// (set) Token: 0x06007FBD RID: 32701 RVA: 0x0003C86C File Offset: 0x0003AA6C
		public unsafe UnityEvent onConsumeInputCancel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_onConsumeInputCancel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_onConsumeInputCancel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002697 RID: 9879
		// (get) Token: 0x06007FBE RID: 32702 RVA: 0x00223380 File Offset: 0x00221580
		// (set) Token: 0x06007FBF RID: 32703 RVA: 0x0003C88B File Offset: 0x0003AA8B
		public unsafe float consumeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_consumeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_consumeTime)) = value;
			}
		}

		// Token: 0x17002698 RID: 9880
		// (get) Token: 0x06007FC0 RID: 32704 RVA: 0x002233A8 File Offset: 0x002215A8
		// (set) Token: 0x06007FC1 RID: 32705 RVA: 0x0003C8A6 File Offset: 0x0003AAA6
		public unsafe bool consumingInProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_consumingInProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_consumingInProgress)) = value;
			}
		}

		// Token: 0x17002699 RID: 9881
		// (get) Token: 0x06007FC2 RID: 32706 RVA: 0x002233D0 File Offset: 0x002215D0
		// (set) Token: 0x06007FC3 RID: 32707 RVA: 0x0003C8C1 File Offset: 0x0003AAC1
		public unsafe Vector3 defaultModelPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_defaultModelPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_defaultModelPosition)) = value;
			}
		}

		// Token: 0x1700269A RID: 9882
		// (get) Token: 0x06007FC4 RID: 32708 RVA: 0x002233F8 File Offset: 0x002215F8
		// (set) Token: 0x06007FC5 RID: 32709 RVA: 0x0003C8DC File Offset: 0x0003AADC
		public unsafe int productAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_productAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_productAmount)) = value;
			}
		}

		// Token: 0x1700269B RID: 9883
		// (get) Token: 0x06007FC6 RID: 32710 RVA: 0x00223420 File Offset: 0x00221620
		// (set) Token: 0x06007FC7 RID: 32711 RVA: 0x0003C8F7 File Offset: 0x0003AAF7
		public unsafe Coroutine consumeRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_consumeRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.NativeFieldInfoPtr_consumeRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040056FC RID: 22268
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x040056FD RID: 22269
		private static readonly IntPtr NativeFieldInfoPtr_ModelContainer;

		// Token: 0x040056FE RID: 22270
		private static readonly IntPtr NativeFieldInfoPtr_Consumable;

		// Token: 0x040056FF RID: 22271
		private static readonly IntPtr NativeFieldInfoPtr_ConsumeDescription;

		// Token: 0x04005700 RID: 22272
		private static readonly IntPtr NativeFieldInfoPtr_ConsumeTime;

		// Token: 0x04005701 RID: 22273
		private static readonly IntPtr NativeFieldInfoPtr_EffectsApplyDelay;

		// Token: 0x04005702 RID: 22274
		private static readonly IntPtr NativeFieldInfoPtr_ConsumeAnimationBool;

		// Token: 0x04005703 RID: 22275
		private static readonly IntPtr NativeFieldInfoPtr_ConsumeAnimationTrigger;

		// Token: 0x04005704 RID: 22276
		private static readonly IntPtr NativeFieldInfoPtr_ConsumeEquippableAssetPath;

		// Token: 0x04005705 RID: 22277
		private static readonly IntPtr NativeFieldInfoPtr_onConsumeInputStart;

		// Token: 0x04005706 RID: 22278
		private static readonly IntPtr NativeFieldInfoPtr_onConsumeInputComplete;

		// Token: 0x04005707 RID: 22279
		private static readonly IntPtr NativeFieldInfoPtr_onConsumeInputCancel;

		// Token: 0x04005708 RID: 22280
		private static readonly IntPtr NativeFieldInfoPtr_consumeTime;

		// Token: 0x04005709 RID: 22281
		private static readonly IntPtr NativeFieldInfoPtr_consumingInProgress;

		// Token: 0x0400570A RID: 22282
		private static readonly IntPtr NativeFieldInfoPtr_defaultModelPosition;

		// Token: 0x0400570B RID: 22283
		private static readonly IntPtr NativeFieldInfoPtr_productAmount;

		// Token: 0x0400570C RID: 22284
		private static readonly IntPtr NativeFieldInfoPtr_consumeRoutine;

		// Token: 0x0400570D RID: 22285
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x0400570E RID: 22286
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x0400570F RID: 22287
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04005710 RID: 22288
		private static readonly IntPtr NativeMethodInfoPtr_Consume_Protected_Virtual_New_Void_0;

		// Token: 0x04005711 RID: 22289
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEffects_Protected_Virtual_New_Void_0;

		// Token: 0x04005712 RID: 22290
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005713 RID: 22291
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000AD3 RID: 2771
		[ObfuscatedName("ScheduleOne.Product.Product_Equippable+<<Consume>g__ConsumeRoutine|20_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D494 RID: 54420 RVA: 0x0032B6CC File Offset: 0x003298CC
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique()
			{
				Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "<<Consume>g__ConsumeRoutine|20_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr);
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>1__state");
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>2__current");
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, "<>4__this");
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100679332);
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100679333);
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100679334);
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100679335);
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100679336);
				Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr, 100679337);
			}

			// Token: 0x0600D495 RID: 54421 RVA: 0x0032B7AC File Offset: 0x003299AC
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D496 RID: 54422 RVA: 0x0032B7F4 File Offset: 0x003299F4
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D497 RID: 54423 RVA: 0x0032B828 File Offset: 0x00329A28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242989, XrefRangeEnd = 242994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170041E4 RID: 16868
			// (get) Token: 0x0600D498 RID: 54424 RVA: 0x0032B864 File Offset: 0x00329A64
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D499 RID: 54425 RVA: 0x0032B8A4 File Offset: 0x00329AA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242994, XrefRangeEnd = 242999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170041E5 RID: 16869
			// (get) Token: 0x0600D49A RID: 54426 RVA: 0x0032B8D8 File Offset: 0x00329AD8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D49B RID: 54427 RVA: 0x00067733 File Offset: 0x00065933
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041E1 RID: 16865
			// (get) Token: 0x0600D49C RID: 54428 RVA: 0x0032B918 File Offset: 0x00329B18
			// (set) Token: 0x0600D49D RID: 54429 RVA: 0x0006773C File Offset: 0x0006593C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170041E2 RID: 16866
			// (get) Token: 0x0600D49E RID: 54430 RVA: 0x0032B940 File Offset: 0x00329B40
			// (set) Token: 0x0600D49F RID: 54431 RVA: 0x00067757 File Offset: 0x00065957
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041E3 RID: 16867
			// (get) Token: 0x0600D4A0 RID: 54432 RVA: 0x0032B970 File Offset: 0x00329B70
			// (set) Token: 0x0600D4A1 RID: 54433 RVA: 0x00067776 File Offset: 0x00065976
			public unsafe Product_Equippable __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Product_Equippable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Product_Equippable.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPrObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F12 RID: 36626
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008F13 RID: 36627
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008F14 RID: 36628
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F15 RID: 36629
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008F16 RID: 36630
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F17 RID: 36631
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008F18 RID: 36632
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008F19 RID: 36633
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F1A RID: 36634
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000AD4 RID: 2772
		[ObfuscatedName("ScheduleOne.Product.Product_Equippable+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D4A2 RID: 54434 RVA: 0x0032B9A0 File Offset: 0x00329BA0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Product_Equippable.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Product_Equippable>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Product_Equippable.__c>.NativeClassPtr);
				Product_Equippable.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable.__c>.NativeClassPtr, "<>9");
				Product_Equippable.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Product_Equippable.__c>.NativeClassPtr, "<>9__17_0");
				Product_Equippable.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable.__c>.NativeClassPtr, 100679339);
				Product_Equippable.__c.NativeMethodInfoPtr__Equip_b__17_0_Internal_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Product_Equippable.__c>.NativeClassPtr, 100679340);
			}

			// Token: 0x0600D4A3 RID: 54435 RVA: 0x0032BA1C File Offset: 0x00329C1C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Product_Equippable.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4A4 RID: 54436 RVA: 0x0032BA58 File Offset: 0x00329C58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 242999, XrefRangeEnd = 243005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Equip_b__17_0(Transform c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Product_Equippable.__c.NativeMethodInfoPtr__Equip_b__17_0_Internal_Boolean_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D4A5 RID: 54437 RVA: 0x00067795 File Offset: 0x00065995
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041E6 RID: 16870
			// (get) Token: 0x0600D4A6 RID: 54438 RVA: 0x0032BAA8 File Offset: 0x00329CA8
			// (set) Token: 0x0600D4A7 RID: 54439 RVA: 0x0006779E File Offset: 0x0006599E
			public unsafe static Product_Equippable.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Product_Equippable.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Product_Equippable.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Product_Equippable.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041E7 RID: 16871
			// (get) Token: 0x0600D4A8 RID: 54440 RVA: 0x0032BAD0 File Offset: 0x00329CD0
			// (set) Token: 0x0600D4A9 RID: 54441 RVA: 0x000677B0 File Offset: 0x000659B0
			public unsafe static Func<Transform, bool> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Product_Equippable.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Transform, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Product_Equippable.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F1B RID: 36635
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008F1C RID: 36636
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x04008F1D RID: 36637
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F1E RID: 36638
			private static readonly IntPtr NativeMethodInfoPtr__Equip_b__17_0_Internal_Boolean_Transform_0;
		}
	}
}
