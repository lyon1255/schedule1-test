using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.Packaging;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.PlayerTasks
{
	// Token: 0x0200020F RID: 527
	public class UseBrickPress : Task
	{
		// Token: 0x06002BC2 RID: 11202 RVA: 0x000FB034 File Offset: 0x000F9234
		// Note: this type is marked as 'beforefieldinit'.
		static UseBrickPress()
		{
			Il2CppClassPointerStore<UseBrickPress>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks", "UseBrickPress");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UseBrickPress>.NativeClassPtr);
			UseBrickPress.NativeFieldInfoPtr_PRODUCT_SCALE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseBrickPress>.NativeClassPtr, "PRODUCT_SCALE");
			UseBrickPress.NativeFieldInfoPtr__TaskName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseBrickPress>.NativeClassPtr, "<TaskName>k__BackingField");
			UseBrickPress.NativeFieldInfoPtr_currentStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseBrickPress>.NativeClassPtr, "currentStep");
			UseBrickPress.NativeFieldInfoPtr_press = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseBrickPress>.NativeClassPtr, "press");
			UseBrickPress.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseBrickPress>.NativeClassPtr, "product");
			UseBrickPress.NativeFieldInfoPtr_products = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseBrickPress>.NativeClassPtr, "products");
			UseBrickPress.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseBrickPress>.NativeClassPtr, "container");
			UseBrickPress.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseBrickPress>.NativeClassPtr, 100668210);
			UseBrickPress.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseBrickPress>.NativeClassPtr, 100668211);
			UseBrickPress.NativeMethodInfoPtr__ctor_Public_Void_BrickPress_ProductItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseBrickPress>.NativeClassPtr, 100668212);
			UseBrickPress.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseBrickPress>.NativeClassPtr, 100668213);
			UseBrickPress.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseBrickPress>.NativeClassPtr, 100668214);
			UseBrickPress.NativeMethodInfoPtr_CheckMould_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseBrickPress>.NativeClassPtr, 100668215);
			UseBrickPress.NativeMethodInfoPtr_BeginPress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseBrickPress>.NativeClassPtr, 100668216);
			UseBrickPress.NativeMethodInfoPtr_FinishPress_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseBrickPress>.NativeClassPtr, 100668217);
			UseBrickPress.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseBrickPress>.NativeClassPtr, 100668218);
			UseBrickPress.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseBrickPress>.NativeClassPtr, 100668219);
		}

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x06002BC3 RID: 11203 RVA: 0x000FB1B8 File Offset: 0x000F93B8
		// (set) Token: 0x06002BC4 RID: 11204 RVA: 0x000FB1FC File Offset: 0x000F93FC
		public unsafe override string TaskName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseBrickPress.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseBrickPress.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002BC5 RID: 11205 RVA: 0x000FB24C File Offset: 0x000F944C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 122735, RefRangeEnd = 122737, XrefRangeStart = 122681, XrefRangeEnd = 122735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UseBrickPress(BrickPress _press, ProductItemInstance _product) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UseBrickPress>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_press);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_product);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseBrickPress.NativeMethodInfoPtr__ctor_Public_Void_BrickPress_ProductItemInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BC6 RID: 11206 RVA: 0x000FB2AC File Offset: 0x000F94AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122737, XrefRangeEnd = 122739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseBrickPress.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BC7 RID: 11207 RVA: 0x000FB2E8 File Offset: 0x000F94E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122739, XrefRangeEnd = 122782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UseBrickPress.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BC8 RID: 11208 RVA: 0x000FB324 File Offset: 0x000F9524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122782, XrefRangeEnd = 122792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckMould()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseBrickPress.NativeMethodInfoPtr_CheckMould_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BC9 RID: 11209 RVA: 0x000FB358 File Offset: 0x000F9558
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 122812, RefRangeEnd = 122814, XrefRangeStart = 122792, XrefRangeEnd = 122812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginPress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseBrickPress.NativeMethodInfoPtr_BeginPress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BCA RID: 11210 RVA: 0x000FB38C File Offset: 0x000F958C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 122831, RefRangeEnd = 122832, XrefRangeStart = 122814, XrefRangeEnd = 122831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishPress()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseBrickPress.NativeMethodInfoPtr_FinishPress_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BCB RID: 11211 RVA: 0x000FB3C0 File Offset: 0x000F95C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122832, XrefRangeEnd = 122837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseBrickPress.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002BCC RID: 11212 RVA: 0x000FB400 File Offset: 0x000F9600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122837, XrefRangeEnd = 122842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseBrickPress.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002BCD RID: 11213 RVA: 0x00017AD3 File Offset: 0x00015CD3
		public UseBrickPress(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06002BCE RID: 11214 RVA: 0x000FB440 File Offset: 0x000F9640
		// (set) Token: 0x06002BCF RID: 11215 RVA: 0x00017ADC File Offset: 0x00015CDC
		public unsafe static float PRODUCT_SCALE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UseBrickPress.NativeFieldInfoPtr_PRODUCT_SCALE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UseBrickPress.NativeFieldInfoPtr_PRODUCT_SCALE, (void*)(&value));
			}
		}

		// Token: 0x17000E8F RID: 3727
		// (get) Token: 0x06002BD0 RID: 11216 RVA: 0x000FB45C File Offset: 0x000F965C
		// (set) Token: 0x06002BD1 RID: 11217 RVA: 0x00017AEA File Offset: 0x00015CEA
		public new unsafe string _TaskName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseBrickPress.NativeFieldInfoPtr__TaskName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseBrickPress.NativeFieldInfoPtr__TaskName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06002BD2 RID: 11218 RVA: 0x000FB484 File Offset: 0x000F9684
		// (set) Token: 0x06002BD3 RID: 11219 RVA: 0x00017B09 File Offset: 0x00015D09
		public unsafe UseBrickPress.EStep currentStep
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseBrickPress.NativeFieldInfoPtr_currentStep);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseBrickPress.NativeFieldInfoPtr_currentStep)) = value;
			}
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x06002BD4 RID: 11220 RVA: 0x000FB4AC File Offset: 0x000F96AC
		// (set) Token: 0x06002BD5 RID: 11221 RVA: 0x00017B24 File Offset: 0x00015D24
		public unsafe BrickPress press
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseBrickPress.NativeFieldInfoPtr_press);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BrickPress>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseBrickPress.NativeFieldInfoPtr_press), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x06002BD6 RID: 11222 RVA: 0x000FB4DC File Offset: 0x000F96DC
		// (set) Token: 0x06002BD7 RID: 11223 RVA: 0x00017B43 File Offset: 0x00015D43
		public unsafe ProductItemInstance product
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseBrickPress.NativeFieldInfoPtr_product);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseBrickPress.NativeFieldInfoPtr_product), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x06002BD8 RID: 11224 RVA: 0x000FB50C File Offset: 0x000F970C
		// (set) Token: 0x06002BD9 RID: 11225 RVA: 0x00017B62 File Offset: 0x00015D62
		public unsafe List<FunctionalProduct> products
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseBrickPress.NativeFieldInfoPtr_products);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<FunctionalProduct>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseBrickPress.NativeFieldInfoPtr_products), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x06002BDA RID: 11226 RVA: 0x000FB53C File Offset: 0x000F973C
		// (set) Token: 0x06002BDB RID: 11227 RVA: 0x00017B81 File Offset: 0x00015D81
		public unsafe Draggable container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseBrickPress.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Draggable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseBrickPress.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001D05 RID: 7429
		private static readonly IntPtr NativeFieldInfoPtr_PRODUCT_SCALE;

		// Token: 0x04001D06 RID: 7430
		private static readonly IntPtr NativeFieldInfoPtr__TaskName_k__BackingField;

		// Token: 0x04001D07 RID: 7431
		private static readonly IntPtr NativeFieldInfoPtr_currentStep;

		// Token: 0x04001D08 RID: 7432
		private static readonly IntPtr NativeFieldInfoPtr_press;

		// Token: 0x04001D09 RID: 7433
		private static readonly IntPtr NativeFieldInfoPtr_product;

		// Token: 0x04001D0A RID: 7434
		private static readonly IntPtr NativeFieldInfoPtr_products;

		// Token: 0x04001D0B RID: 7435
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x04001D0C RID: 7436
		private static readonly IntPtr NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0;

		// Token: 0x04001D0D RID: 7437
		private static readonly IntPtr NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0;

		// Token: 0x04001D0E RID: 7438
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BrickPress_ProductItemInstance_0;

		// Token: 0x04001D0F RID: 7439
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001D10 RID: 7440
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001D11 RID: 7441
		private static readonly IntPtr NativeMethodInfoPtr_CheckMould_Private_Void_0;

		// Token: 0x04001D12 RID: 7442
		private static readonly IntPtr NativeMethodInfoPtr_BeginPress_Private_Void_0;

		// Token: 0x04001D13 RID: 7443
		private static readonly IntPtr NativeMethodInfoPtr_FinishPress_Private_Void_0;

		// Token: 0x04001D14 RID: 7444
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04001D15 RID: 7445
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_1;

		// Token: 0x020008E5 RID: 2277
		[OriginalName("Assembly-CSharp.dll", "", "EStep")]
		public enum EStep
		{
			// Token: 0x04008548 RID: 34120
			Pouring,
			// Token: 0x04008549 RID: 34121
			Pressing,
			// Token: 0x0400854A RID: 34122
			Complete
		}

		// Token: 0x020008E6 RID: 2278
		[ObfuscatedName("ScheduleOne.PlayerTasks.UseBrickPress+<<-ctor>g__CheckMould|11_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0 : Object
		{
			// Token: 0x0600C494 RID: 50324 RVA: 0x002FDFA8 File Offset: 0x002FC1A8
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0()
			{
				Il2CppClassPointerStore<UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UseBrickPress>.NativeClassPtr, "<<-ctor>g__CheckMould|11_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0>.NativeClassPtr);
				UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0>.NativeClassPtr, "<>1__state");
				UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0>.NativeClassPtr, "<>2__current");
				UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0>.NativeClassPtr, "<>4__this");
				UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0>.NativeClassPtr, 100668220);
				UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0>.NativeClassPtr, 100668221);
				UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0>.NativeClassPtr, 100668222);
				UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0>.NativeClassPtr, 100668223);
				UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0>.NativeClassPtr, 100668224);
				UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0>.NativeClassPtr, 100668225);
			}

			// Token: 0x0600C495 RID: 50325 RVA: 0x002FE088 File Offset: 0x002FC288
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C496 RID: 50326 RVA: 0x002FE0D0 File Offset: 0x002FC2D0
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C497 RID: 50327 RVA: 0x002FE104 File Offset: 0x002FC304
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122651, XrefRangeEnd = 122666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003D5F RID: 15711
			// (get) Token: 0x0600C498 RID: 50328 RVA: 0x002FE140 File Offset: 0x002FC340
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C499 RID: 50329 RVA: 0x002FE180 File Offset: 0x002FC380
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122666, XrefRangeEnd = 122671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003D60 RID: 15712
			// (get) Token: 0x0600C49A RID: 50330 RVA: 0x002FE1B4 File Offset: 0x002FC3B4
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C49B RID: 50331 RVA: 0x0005FAA4 File Offset: 0x0005DCA4
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D5C RID: 15708
			// (get) Token: 0x0600C49C RID: 50332 RVA: 0x002FE1F4 File Offset: 0x002FC3F4
			// (set) Token: 0x0600C49D RID: 50333 RVA: 0x0005FAAD File Offset: 0x0005DCAD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003D5D RID: 15709
			// (get) Token: 0x0600C49E RID: 50334 RVA: 0x002FE21C File Offset: 0x002FC41C
			// (set) Token: 0x0600C49F RID: 50335 RVA: 0x0005FAC8 File Offset: 0x0005DCC8
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D5E RID: 15710
			// (get) Token: 0x0600C4A0 RID: 50336 RVA: 0x002FE24C File Offset: 0x002FC44C
			// (set) Token: 0x0600C4A1 RID: 50337 RVA: 0x0005FAE7 File Offset: 0x0005DCE7
			public unsafe UseBrickPress __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UseBrickPress>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400854B RID: 34123
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400854C RID: 34124
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400854D RID: 34125
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400854E RID: 34126
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400854F RID: 34127
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008550 RID: 34128
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008551 RID: 34129
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008552 RID: 34130
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008553 RID: 34131
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020008E7 RID: 2279
		[ObfuscatedName("ScheduleOne.PlayerTasks.UseBrickPress+<<FinishPress>g__Wait|16_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1 : Object
		{
			// Token: 0x0600C4A2 RID: 50338 RVA: 0x002FE27C File Offset: 0x002FC47C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1()
			{
				Il2CppClassPointerStore<UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UseBrickPress>.NativeClassPtr, "<<FinishPress>g__Wait|16_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1>.NativeClassPtr);
				UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1>.NativeClassPtr, "<>1__state");
				UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1>.NativeClassPtr, "<>2__current");
				UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1>.NativeClassPtr, "<>4__this");
				UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1>.NativeClassPtr, 100668226);
				UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1>.NativeClassPtr, 100668227);
				UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1>.NativeClassPtr, 100668228);
				UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1>.NativeClassPtr, 100668229);
				UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1>.NativeClassPtr, 100668230);
				UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1>.NativeClassPtr, 100668231);
			}

			// Token: 0x0600C4A3 RID: 50339 RVA: 0x002FE35C File Offset: 0x002FC55C
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C4A4 RID: 50340 RVA: 0x002FE3A4 File Offset: 0x002FC5A4
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C4A5 RID: 50341 RVA: 0x002FE3D8 File Offset: 0x002FC5D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122671, XrefRangeEnd = 122676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003D64 RID: 15716
			// (get) Token: 0x0600C4A6 RID: 50342 RVA: 0x002FE414 File Offset: 0x002FC614
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C4A7 RID: 50343 RVA: 0x002FE454 File Offset: 0x002FC654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 122676, XrefRangeEnd = 122681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003D65 RID: 15717
			// (get) Token: 0x0600C4A8 RID: 50344 RVA: 0x002FE488 File Offset: 0x002FC688
			public unsafe Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C4A9 RID: 50345 RVA: 0x0005FB06 File Offset: 0x0005DD06
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D61 RID: 15713
			// (get) Token: 0x0600C4AA RID: 50346 RVA: 0x002FE4C8 File Offset: 0x002FC6C8
			// (set) Token: 0x0600C4AB RID: 50347 RVA: 0x0005FB0F File Offset: 0x0005DD0F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003D62 RID: 15714
			// (get) Token: 0x0600C4AC RID: 50348 RVA: 0x002FE4F0 File Offset: 0x002FC6F0
			// (set) Token: 0x0600C4AD RID: 50349 RVA: 0x0005FB2A File Offset: 0x0005DD2A
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D63 RID: 15715
			// (get) Token: 0x0600C4AE RID: 50350 RVA: 0x002FE520 File Offset: 0x002FC720
			// (set) Token: 0x0600C4AF RID: 50351 RVA: 0x0005FB49 File Offset: 0x0005DD49
			public unsafe UseBrickPress __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UseBrickPress>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UseBrickPress.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUsVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008554 RID: 34132
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008555 RID: 34133
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008556 RID: 34134
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008557 RID: 34135
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008558 RID: 34136
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008559 RID: 34137
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400855A RID: 34138
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400855B RID: 34139
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400855C RID: 34140
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
