using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.ItemFramework
{
	// Token: 0x020005EC RID: 1516
	[Serializable]
	public class QualityItemDefinition : StorableItemDefinition
	{
		// Token: 0x06008479 RID: 33913 RVA: 0x00232CE4 File Offset: 0x00230EE4
		// Note: this type is marked as 'beforefieldinit'.
		static QualityItemDefinition()
		{
			Il2CppClassPointerStore<QualityItemDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ItemFramework", "QualityItemDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QualityItemDefinition>.NativeClassPtr);
			QualityItemDefinition.NativeFieldInfoPtr_DefaultQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QualityItemDefinition>.NativeClassPtr, "DefaultQuality");
			QualityItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemDefinition>.NativeClassPtr, 100679882);
			QualityItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QualityItemDefinition>.NativeClassPtr, 100679883);
		}

		// Token: 0x0600847A RID: 33914 RVA: 0x00232D50 File Offset: 0x00230F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248765, XrefRangeEnd = 248771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), QualityItemDefinition.NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600847B RID: 33915 RVA: 0x00232DA8 File Offset: 0x00230FA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248779, RefRangeEnd = 248780, XrefRangeStart = 248771, XrefRangeEnd = 248779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QualityItemDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QualityItemDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QualityItemDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600847C RID: 33916 RVA: 0x0003ECBC File Offset: 0x0003CEBC
		public QualityItemDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700280A RID: 10250
		// (get) Token: 0x0600847D RID: 33917 RVA: 0x00232DE4 File Offset: 0x00230FE4
		// (set) Token: 0x0600847E RID: 33918 RVA: 0x0003ECC5 File Offset: 0x0003CEC5
		public unsafe EQuality DefaultQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemDefinition.NativeFieldInfoPtr_DefaultQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(QualityItemDefinition.NativeFieldInfoPtr_DefaultQuality)) = value;
			}
		}

		// Token: 0x04005A3B RID: 23099
		private static readonly IntPtr NativeFieldInfoPtr_DefaultQuality;

		// Token: 0x04005A3C RID: 23100
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultInstance_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005A3D RID: 23101
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
