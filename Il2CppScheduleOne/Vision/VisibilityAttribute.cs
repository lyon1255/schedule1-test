using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Vision
{
	// Token: 0x02000175 RID: 373
	[Serializable]
	public class VisibilityAttribute : Object
	{
		// Token: 0x06001DDC RID: 7644 RVA: 0x000CD2E4 File Offset: 0x000CB4E4
		// Note: this type is marked as 'beforefieldinit'.
		static VisibilityAttribute()
		{
			Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vision", "VisibilityAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr);
			VisibilityAttribute.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr, "name");
			VisibilityAttribute.NativeFieldInfoPtr_pointsChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr, "pointsChange");
			VisibilityAttribute.NativeFieldInfoPtr_multiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr, "multiplier");
			VisibilityAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr, 100666684);
			VisibilityAttribute.NativeMethodInfoPtr_Delete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr, 100666685);
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x000CD378 File Offset: 0x000CB578
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 106383, RefRangeEnd = 106387, XrefRangeStart = 106369, XrefRangeEnd = 106383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisibilityAttribute(string _name, float _pointsChange, float _multiplier = 1f, int attributeIndex = -1) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisibilityAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _pointsChange;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _multiplier;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref attributeIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x000CD3F0 File Offset: 0x000CB5F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 106395, RefRangeEnd = 106397, XrefRangeStart = 106387, XrefRangeEnd = 106395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Delete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisibilityAttribute.NativeMethodInfoPtr_Delete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x00010DC3 File Offset: 0x0000EFC3
		public VisibilityAttribute(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06001DE0 RID: 7648 RVA: 0x000CD424 File Offset: 0x000CB624
		// (set) Token: 0x06001DE1 RID: 7649 RVA: 0x00010DCC File Offset: 0x0000EFCC
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityAttribute.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityAttribute.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06001DE2 RID: 7650 RVA: 0x000CD44C File Offset: 0x000CB64C
		// (set) Token: 0x06001DE3 RID: 7651 RVA: 0x00010DEB File Offset: 0x0000EFEB
		public unsafe float pointsChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityAttribute.NativeFieldInfoPtr_pointsChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityAttribute.NativeFieldInfoPtr_pointsChange)) = value;
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x000CD474 File Offset: 0x000CB674
		// (set) Token: 0x06001DE5 RID: 7653 RVA: 0x00010E06 File Offset: 0x0000F006
		public unsafe float multiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityAttribute.NativeFieldInfoPtr_multiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisibilityAttribute.NativeFieldInfoPtr_multiplier)) = value;
			}
		}

		// Token: 0x040013DA RID: 5082
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040013DB RID: 5083
		private static readonly IntPtr NativeFieldInfoPtr_pointsChange;

		// Token: 0x040013DC RID: 5084
		private static readonly IntPtr NativeFieldInfoPtr_multiplier;

		// Token: 0x040013DD RID: 5085
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Int32_0;

		// Token: 0x040013DE RID: 5086
		private static readonly IntPtr NativeMethodInfoPtr_Delete_Public_Void_0;
	}
}
