using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Storage
{
	// Token: 0x02000576 RID: 1398
	public class StorageEntityVisualizer : StorageVisualizer
	{
		// Token: 0x06007B23 RID: 31523 RVA: 0x00212730 File Offset: 0x00210930
		// Note: this type is marked as 'beforefieldinit'.
		static StorageEntityVisualizer()
		{
			Il2CppClassPointerStore<StorageEntityVisualizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Storage", "StorageEntityVisualizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StorageEntityVisualizer>.NativeClassPtr);
			StorageEntityVisualizer.NativeFieldInfoPtr_storageEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StorageEntityVisualizer>.NativeClassPtr, "storageEntity");
			StorageEntityVisualizer.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageEntityVisualizer>.NativeClassPtr, 100678740);
			StorageEntityVisualizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StorageEntityVisualizer>.NativeClassPtr, 100678741);
		}

		// Token: 0x06007B24 RID: 31524 RVA: 0x0021279C File Offset: 0x0021099C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235827, XrefRangeEnd = 235845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StorageEntityVisualizer.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B25 RID: 31525 RVA: 0x002127D8 File Offset: 0x002109D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235845, XrefRangeEnd = 235860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StorageEntityVisualizer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StorageEntityVisualizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StorageEntityVisualizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B26 RID: 31526 RVA: 0x0003A6F5 File Offset: 0x000388F5
		public StorageEntityVisualizer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700252E RID: 9518
		// (get) Token: 0x06007B27 RID: 31527 RVA: 0x00212814 File Offset: 0x00210A14
		// (set) Token: 0x06007B28 RID: 31528 RVA: 0x0003A6FE File Offset: 0x000388FE
		public unsafe StorageEntity storageEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageEntityVisualizer.NativeFieldInfoPtr_storageEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StorageEntityVisualizer.NativeFieldInfoPtr_storageEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040053DD RID: 21469
		private static readonly IntPtr NativeFieldInfoPtr_storageEntity;

		// Token: 0x040053DE RID: 21470
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040053DF RID: 21471
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
