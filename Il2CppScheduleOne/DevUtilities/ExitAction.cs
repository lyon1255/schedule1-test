using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000476 RID: 1142
	public class ExitAction : Object
	{
		// Token: 0x060062A7 RID: 25255 RVA: 0x001C040C File Offset: 0x001BE60C
		// Note: this type is marked as 'beforefieldinit'.
		static ExitAction()
		{
			Il2CppClassPointerStore<ExitAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "ExitAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExitAction>.NativeClassPtr);
			ExitAction.NativeFieldInfoPtr_exitType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExitAction>.NativeClassPtr, "exitType");
			ExitAction.NativeFieldInfoPtr_used = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExitAction>.NativeClassPtr, "used");
			ExitAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitAction>.NativeClassPtr, 100675809);
		}

		// Token: 0x060062A8 RID: 25256 RVA: 0x001C0478 File Offset: 0x001BE678
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExitAction() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExitAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060062A9 RID: 25257 RVA: 0x0002EA38 File Offset: 0x0002CC38
		public ExitAction(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DB3 RID: 7603
		// (get) Token: 0x060062AA RID: 25258 RVA: 0x001C04B4 File Offset: 0x001BE6B4
		// (set) Token: 0x060062AB RID: 25259 RVA: 0x0002EA41 File Offset: 0x0002CC41
		public unsafe ExitType exitType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitAction.NativeFieldInfoPtr_exitType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitAction.NativeFieldInfoPtr_exitType)) = value;
			}
		}

		// Token: 0x17001DB4 RID: 7604
		// (get) Token: 0x060062AC RID: 25260 RVA: 0x001C04DC File Offset: 0x001BE6DC
		// (set) Token: 0x060062AD RID: 25261 RVA: 0x0002EA5C File Offset: 0x0002CC5C
		public unsafe bool used
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitAction.NativeFieldInfoPtr_used);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExitAction.NativeFieldInfoPtr_used)) = value;
			}
		}

		// Token: 0x0400434C RID: 17228
		private static readonly IntPtr NativeFieldInfoPtr_exitType;

		// Token: 0x0400434D RID: 17229
		private static readonly IntPtr NativeFieldInfoPtr_used;

		// Token: 0x0400434E RID: 17230
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
