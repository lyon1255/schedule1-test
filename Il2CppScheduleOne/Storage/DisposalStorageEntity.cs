using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x0200056C RID: 1388
	public class DisposalStorageEntity : StorageEntity
	{
		// Token: 0x060079FF RID: 31231 RVA: 0x0020D558 File Offset: 0x0020B758
		// Note: this type is marked as 'beforefieldinit'.
		static DisposalStorageEntity()
		{
			Il2CppClassPointerStore<DisposalStorageEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "DisposalStorageEntity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisposalStorageEntity>.NativeClassPtr);
			DisposalStorageEntity.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisposalStorageEntity>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Storage.DisposalStorageEntityAssembly-CSharp.dll_Excuted");
			DisposalStorageEntity.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisposalStorageEntity>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Storage.DisposalStorageEntityAssembly-CSharp.dll_Excuted");
			DisposalStorageEntity.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisposalStorageEntity>.NativeClassPtr, 100678555);
			DisposalStorageEntity.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisposalStorageEntity>.NativeClassPtr, 100678556);
			DisposalStorageEntity.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisposalStorageEntity>.NativeClassPtr, 100678557);
			DisposalStorageEntity.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisposalStorageEntity>.NativeClassPtr, 100678558);
			DisposalStorageEntity.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisposalStorageEntity>.NativeClassPtr, 100678559);
		}

		// Token: 0x06007A00 RID: 31232 RVA: 0x0020D614 File Offset: 0x0020B814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233465, XrefRangeEnd = 233466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisposalStorageEntity() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisposalStorageEntity>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisposalStorageEntity.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A01 RID: 31233 RVA: 0x0020D650 File Offset: 0x0020B850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233466, XrefRangeEnd = 233467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DisposalStorageEntity.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A02 RID: 31234 RVA: 0x0020D68C File Offset: 0x0020B88C
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DisposalStorageEntity.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A03 RID: 31235 RVA: 0x0020D6C8 File Offset: 0x0020B8C8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DisposalStorageEntity.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A04 RID: 31236 RVA: 0x0020D704 File Offset: 0x0020B904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 233467, XrefRangeEnd = 233468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DisposalStorageEntity.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A05 RID: 31237 RVA: 0x0003A17E File Offset: 0x0003837E
		public DisposalStorageEntity(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024F1 RID: 9457
		// (get) Token: 0x06007A06 RID: 31238 RVA: 0x0020D740 File Offset: 0x0020B940
		// (set) Token: 0x06007A07 RID: 31239 RVA: 0x0003A187 File Offset: 0x00038387
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisposalStorageEntity.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisposalStorageEntity.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170024F2 RID: 9458
		// (get) Token: 0x06007A08 RID: 31240 RVA: 0x0020D768 File Offset: 0x0020B968
		// (set) Token: 0x06007A09 RID: 31241 RVA: 0x0003A1A2 File Offset: 0x000383A2
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisposalStorageEntity.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DisposalStorageEntity.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040052FC RID: 21244
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040052FD RID: 21245
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040052FE RID: 21246
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040052FF RID: 21247
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04005300 RID: 21248
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04005301 RID: 21249
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04005302 RID: 21250
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
