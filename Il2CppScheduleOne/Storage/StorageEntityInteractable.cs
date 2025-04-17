using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000575 RID: 1397
	public class StorageEntityInteractable : InteractableObject
	{
		// Token: 0x06007B1B RID: 31515 RVA: 0x00212584 File Offset: 0x00210784
		// Note: this type is marked as 'beforefieldinit'.
		static StorageEntityInteractable()
		{
			Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StorageEntityInteractable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr);
			StorageEntityInteractable.NativeFieldInfoPtr_StorageEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr, "StorageEntity");
			StorageEntityInteractable.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr, 100678736);
			StorageEntityInteractable.NativeMethodInfoPtr_Hovered_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr, 100678737);
			StorageEntityInteractable.NativeMethodInfoPtr_StartInteract_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr, 100678738);
			StorageEntityInteractable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr, 100678739);
		}

		// Token: 0x06007B1C RID: 31516 RVA: 0x00212618 File Offset: 0x00210818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235804, XrefRangeEnd = 235808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageEntityInteractable.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B1D RID: 31517 RVA: 0x0021264C File Offset: 0x0021084C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235808, XrefRangeEnd = 235809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageEntityInteractable.NativeMethodInfoPtr_Hovered_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B1E RID: 31518 RVA: 0x00212688 File Offset: 0x00210888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235809, XrefRangeEnd = 235826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageEntityInteractable.NativeMethodInfoPtr_StartInteract_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B1F RID: 31519 RVA: 0x002126C4 File Offset: 0x002108C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235826, XrefRangeEnd = 235827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageEntityInteractable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageEntityInteractable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageEntityInteractable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B20 RID: 31520 RVA: 0x0003A6CD File Offset: 0x000388CD
		public StorageEntityInteractable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700252D RID: 9517
		// (get) Token: 0x06007B21 RID: 31521 RVA: 0x00212700 File Offset: 0x00210900
		// (set) Token: 0x06007B22 RID: 31522 RVA: 0x0003A6D6 File Offset: 0x000388D6
		public unsafe StorageEntity StorageEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageEntityInteractable.NativeFieldInfoPtr_StorageEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageEntityInteractable.NativeFieldInfoPtr_StorageEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040053D8 RID: 21464
		private static readonly IntPtr NativeFieldInfoPtr_StorageEntity;

		// Token: 0x040053D9 RID: 21465
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040053DA RID: 21466
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Virtual_Void_0;

		// Token: 0x040053DB RID: 21467
		private static readonly IntPtr NativeMethodInfoPtr_StartInteract_Public_Virtual_Void_0;

		// Token: 0x040053DC RID: 21468
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
